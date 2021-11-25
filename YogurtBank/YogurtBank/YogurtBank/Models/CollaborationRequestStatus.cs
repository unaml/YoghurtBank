using System;

namespace YogurtBank.Models 
{
    public enum CollaborationRequestStatus 
    {
        Waiting,
        ApprovedBySupervisor,
        ApprovedByStudent,
        Declined,
    }
}