using System;
using System.Collections.Generic;

namespace YogurtBank.Models
{
    public abstract class User {
        public int Id { get; init; } 
        public string Username { get; init; }
        public ICollection<CollaborationRequest> CollaborationRequests { get; set; }

        public void LogIn() 
        {
            //Link to the login form - we are not making it 
            throw new NotImplementedException();
        }

        public bool RespondToCollaborationRequest(CollaborationRequest collabrequest, bool Approve) 
        {
            //this method simply calls the wanted collabrequest. 
            //the request checks if it is possible to do it at this time
            return collabrequest.UpdateStatus(Approve, this);
        }
        
    }
}