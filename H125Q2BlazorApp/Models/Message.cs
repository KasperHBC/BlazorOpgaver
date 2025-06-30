using System;

namespace H125Q2BlazorApp.Models
{
    public class Message
    {
        public int Id { get; set; }
        
        public int ProductId { get; set; }
        
        public string Text { get; set; } = string.Empty;
        
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        
        public string SenderName { get; set; } = "Anonym"; // I en rigtig app ville dette være brugeren
    }
} 