using System.Collections.Generic;


namespace YogurtBank.Models

    public record IdeaDTO(string Id, Supervisor Creator, DateTime Posted, string Subject, string Description, int AmountOfCollaborators, bool Open, TimeSpan TimeToComplete, DateTime StartDate, IdeaType Type);

    public record IdeaCreateDTO 
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

    public record IIdeaDetailsDTO();


    IdeaUpdateDTO

IdeaDetailDTO


eneric; 
