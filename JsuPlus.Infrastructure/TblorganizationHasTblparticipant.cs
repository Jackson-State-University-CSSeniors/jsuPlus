using System;
using System.Collections.Generic;

#nullable disable

namespace JsuPlus.Infrastructure
{
    public partial class TblorganizationHasTblparticipant
    {
        public int TblorganizationId { get; set; }
        public int TblparticipantId { get; set; }

        public virtual Tblorganization Tblorganization { get; set; }
        public virtual Tblparticipant Tblparticipant { get; set; }
    }
}
