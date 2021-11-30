using System;
using System.Collections.Generic;


#nullable disable

namespace JsuPlus.Infrastructure
{
    public partial class Tblparticipant
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Email { get; set; }
        public int AddressId { get; set; }
        public string Password { get; set; }

    }
}
