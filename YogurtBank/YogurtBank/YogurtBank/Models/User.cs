using System;
using System.Collections.Generic;

namespace YogurtBank.Models
{
    public abstract class User {
        public int Id { get; set; } 
        public string Username { get; set; }
        public int Age {get; set; }
        public Gender Gender { get; set; } 
        public ICollection<CollaborationRequest> CollaborationRequests { get; set; }

        public void LogIn() {}
        public void UpdateProfile() {}
        public void RespondToCollaborationRequest() 
        {

        }
        
    }
}

public enum Gender {
    Male,
    Female,
    Other,
}