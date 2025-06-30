using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace H125Q2BlazorApp.Models
{
    public class Product
    {
        public int Id { get; set; }
        
        [Required(ErrorMessage = "Titel er påkrævet")]
        [StringLength(100, ErrorMessage = "Titlen må ikke være længere end 100 tegn")]
        public string Title { get; set; } = string.Empty;
        
        [Required(ErrorMessage = "Pris er påkrævet")]
        [Range(0.01, 1000000, ErrorMessage = "Pris skal være mellem 0,01 og 1.000.000")]
        public decimal Price { get; set; }
        
        [StringLength(1000, ErrorMessage = "Beskrivelsen må ikke være længere end 1000 tegn")]
        public string Description { get; set; } = string.Empty;
        
        [Required(ErrorMessage = "Kategori er påkrævet")]
        public string Category { get; set; } = string.Empty;
        
        public string ImageUrl { get; set; } = string.Empty;
        
        // Liste af beskeder til dette produkt
        public List<Message> Messages { get; set; } = new List<Message>();
    }
} 