using System;
using System.Collections.Generic;


#nullable disable

namespace JsuPlus.Infrastructure
{
    public partial class Tblparticipant
    {
        public Tblparticipant()
        {
            TblorganizationHasTblparticipants = new HashSet<TblorganizationHasTblparticipant>();
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Email { get; set; }
        public int AddressId { get; set; }

        public virtual ICollection<TblorganizationHasTblparticipant> TblorganizationHasTblparticipants { get; set; }
    }
}
