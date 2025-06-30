using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.JSInterop;
using System.Text.Json;

namespace H125Q2BlazorApp.Services
{
    public class FavoriteService
    {
        private readonly IJSRuntime _jsRuntime;
        private const string StorageKey = "favorite_products";
        private List<int> _favoriteIds = new();
        
        // Event til at notificere om ændringer i favorit-listen
        public event Action? OnFavoritesChanged;
        
        public FavoriteService(IJSRuntime jsRuntime)
        {
            _jsRuntime = jsRuntime;
        }
        
        // Indlæs favoritter fra localStorage
        public async Task LoadFavoritesAsync()
        {
            try
            {
                var favoritesJson = await _jsRuntime.InvokeAsync<string>("localStorage.getItem", StorageKey);
                
                if (!string.IsNullOrEmpty(favoritesJson))
                {
                    _favoriteIds = JsonSerializer.Deserialize<List<int>>(favoritesJson) ?? new List<int>();
                }
            }
            catch (Exception)
            {
                // Fejlhåndtering - hvis localStorage ikke er tilgængelig, starter vi bare med en tom liste
                _favoriteIds = new List<int>();
            }
        }
        
        // Gem favoritter til localStorage
        private async Task SaveFavoritesAsync()
        {
            var favoritesJson = JsonSerializer.Serialize(_favoriteIds);
            await _jsRuntime.InvokeVoidAsync("localStorage.setItem", StorageKey, favoritesJson);
            OnFavoritesChanged?.Invoke(); // Notificer om ændring
        }
        
        // Tilføj eller fjern et produkt fra favoritter
        public async Task ToggleFavoriteAsync(int productId)
        {
            if (_favoriteIds.Contains(productId))
            {
                _favoriteIds.Remove(productId);
            }
            else
            {
                _favoriteIds.Add(productId);
            }
            
            await SaveFavoritesAsync();
        }
        
        // Tjek om et produkt er i favoritter
        public bool IsFavorite(int productId)
        {
            return _favoriteIds.Contains(productId);
        }
        
        // Få antal favoritter
        public int FavoriteCount => _favoriteIds.Count;
        
        // Få liste af alle favoritprodukt IDs
        public List<int> GetFavoriteIds()
        {
            return new List<int>(_favoriteIds);
        }
    }
} 