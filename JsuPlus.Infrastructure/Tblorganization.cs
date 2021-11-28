using System;
using System.Collections.Generic;

#nullable disable

namespace JsuPlus.Infrastructure
{
    public partial class Tblorganization
    {
        public Tblorganization()
        {
            TblorganizationHasTblparticipants = new HashSet<TblorganizationHasTblparticipant>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Status { get; set; }
        public string SubscriptionNumber { get; set; }
        public string Tblorganizationcol { get; set; }

        public virtual ICollection<TblorganizationHasTblparticipant> TblorganizationHasTblparticipants { get; set; }
    }
}
