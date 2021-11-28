using System.Collections.Generic;
using System.Collections.ObjectModel;
using JsuPlus.Core.SharedKernel;
using JsuPlus.Core.Events;
using System;

namespace JsuPlus.Core.Entities
{
    public class Participant : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public bool IsDone { get; private set; } = false;

        public void MarkComplete()
        {
            IsDone = true;
            Events.Add(new ParticipantCompletedEvent(this));
        }
       
    }
}
