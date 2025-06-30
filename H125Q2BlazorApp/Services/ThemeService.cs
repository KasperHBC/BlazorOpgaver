using System;
using System.Threading.Tasks;
using Microsoft.JSInterop;

namespace H125Q2BlazorApp.Services
{
    public class ThemeService : IDisposable
    {
        private readonly IJSRuntime _jsRuntime;
        private bool _mørktTema = false;
        private bool _disposed = false;

        public bool MørktTema
        {
            get => _mørktTema;
            set
            {
                if (_mørktTema != value)
                {
                    _mørktTema = value;
                    OnThemeChanged?.Invoke();
                }
            }
        }

        public event Action OnThemeChanged = null!;

        public ThemeService(IJSRuntime jsRuntime)
        {
            _jsRuntime = jsRuntime;
        }

        public string GetCurrentThemeClass()
        {
            return MørktTema ? "dark" : "light";
        }

        public async Task ApplyThemeAsync()
        {
            if (_disposed) return;
            
            var theme = GetCurrentThemeClass();
            await _jsRuntime.InvokeVoidAsync("document.body.setAttribute", "data-bs-theme", theme);
        }

        public async Task SkiftTemaAsync()
        {
            MørktTema = !MørktTema;
            await ApplyThemeAsync();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    // Frigør eventuelle ressourcer her
                    OnThemeChanged = null!;
                }

                _disposed = true;
            }
        }
    }
} 