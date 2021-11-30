using System.Collections.Generic;
using System.Collections.ObjectModel;
using JsuPlus.Core.SharedKernel;
using JsuPlus.Core.Events;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace JsuPlus.Core.Entities
{
    public class Participant : BaseEntity
    {
        public string FirstName { get;private set; }
        public string LastName { get; private set; }
        public DateTime DateOfBirth { get; private set; }
        public string Email { get; private set; }
        //public int AddressId { get; set; }
        public string Password { get; private set; }

        [NotMapped]
        public bool IsDone { get; private set; } = false;


        public void MarkComplete()
        {
            IsDone = true;
            Events.Add(new ParticipantCompletedEvent(this));
        }

        public void CreateParticipant(string firstName, string lastName, DateTime dateOfBirth, string email, string password)
        {
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
            Email = email;
            Password = password;
        }
       
    }
}
