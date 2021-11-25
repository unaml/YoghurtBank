using System;

namespace YogurtBank.Models
{
    public class Idea
    {
        public string Id { get; set; }
        public Supervisor Creator { get; set; }
        public DateTime Posted { get; set; }
        public string Subject { get; set; } 
        public string Description { get; set; }
        public int AmountOfCollaborators { get; set; }
        public bool Open { get; set; }
        public TimeSpan TimeToComplete { get; set; }
        public DateTime StartDate { get; set; }
        public IdeaType Type { get; set }
    }
}