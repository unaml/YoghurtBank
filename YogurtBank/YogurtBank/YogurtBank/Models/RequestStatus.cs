using System;

namespace YogurtBank.Models {

    public enum RequestStatus 
    {
        Waiting,
        ApprovedBySUpervisor,
        ApprovedByStudent,
        Declined,
    }

}