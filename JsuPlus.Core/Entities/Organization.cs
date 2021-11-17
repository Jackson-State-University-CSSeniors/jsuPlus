using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JsuPlus.Core.SharedKernel;


namespace JsuPlus.Core.Entities
{
    public class Organization : BaseEntity
    {
        public string Name { get; set; }
        public string Status { get; set; }
        public string SubscriptionNumber { get; set; }
    }
}
