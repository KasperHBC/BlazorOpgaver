namespace H125Q2BlazorApp.Models
{
    public enum TaskDifficulty
    {
        Easy,
        Medium,
        Hard
    }

    public class Task
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string WhatYouLearn { get; set; } = string.Empty;
        public string Hints { get; set; } = string.Empty;
        public TaskDifficulty Difficulty { get; set; }
    }
}
