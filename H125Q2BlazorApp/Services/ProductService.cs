using H125Q2BlazorApp.Models;

namespace H125Q2BlazorApp.Services
{
    /// <summary>
    /// Service til at dele produktdata på tværs af forskellige komponenter.
    /// </summary>
    public class ProductService
    {
        private readonly List<Product> _products = new();
        private int _nextId = 1;
        
        // Liste af tilgængelige kategorier
        public List<string> Categories { get; } = new List<string>
        {
            "Elektronik",
            "Bolig",
            "Tøj",
            "Sport",
            "Have",
            "Bøger",
            "Legetøj",
            "Andet"
        };
        
        /// <summary>
        /// Henter alle produkter i servicen
        /// </summary>
        public List<Product> GetAllProducts()
        {
            return _products;
        }
        
        /// <summary>
        /// Tilføjer et nyt produkt til listen og tilskriver et ID
        /// </summary>
        public void AddProduct(Product product)
        {
            product.Id = _nextId++;
            _products.Add(product);
        }
        
        /// <summary>
        /// Henter et specifikt produkt baseret på ID
        /// </summary>
        public Product? GetProductById(int id)
        {
            return _products.FirstOrDefault(p => p.Id == id);
        }
        
        /// <summary>
        /// Fjerner et produkt baseret på ID
        /// </summary>
        public bool RemoveProduct(int id)
        {
            var product = GetProductById(id);
            if (product != null)
            {
                return _products.Remove(product);
            }
            return false;
        }
    }
} 