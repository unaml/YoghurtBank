using System;

namespace YogurtBank.Models
{
    public class Student : User
    {
        public void RequestCollaboration(Supervisor supervisor)
        {
            //needs to go find the supervisor in the database and add a collabrequest to their list of requests? 
        }
        public void RequestCollaboration(Idea idea) 
        {
            //needs to go find the idea in the database, then the supervisor belonging to the idea and then add a collabrequest to their list of requests?}
        }
    }