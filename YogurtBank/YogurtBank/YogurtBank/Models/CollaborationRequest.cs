using System;
using System.ComponentModel.DataAnnotations;

namespace YogurtBank.Models
{
    public class CollaborationRequest
    {
        public Student requester { get; }
        public Supervisor requestee { get; }
        public string application { get; set; } 
        public Status status { get; set; }
    }

    public enum Status {
        Waiting, 
        AprovedBySupervisor,
        ApprovedByStudent, 
        Declined,
    }
}