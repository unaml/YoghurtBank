﻿using System;
using System.ComponentModel.DataAnnotations;

namespace YogurtBank.Models
{
    public class CollaborationRequest
    {
        public Student Requester { get; init; }
        public Supervisor Requestee { get; init; }
        public Idea? Idea { get; init; }
        public string Application { get; set; } 
        public CollaborationRequestStatus Status { get; set; } = CollaborationRequestStatus.Waiting;

        public bool UpdateStatus(bool Approved, User Updater) 
        {
            //check if the user updating can make the update that is being attempted
            //check if the attempted update is allowed

            throw new NotImplementedException();
        }
    }
}
