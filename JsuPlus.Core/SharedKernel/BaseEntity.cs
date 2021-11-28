using System.Collections.Generic;

namespace JsuPlus.Core.SharedKernel
{
    //will house properties that can be found in ALL entities
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        public List<BaseDomainEvent> Events = new List<BaseDomainEvent>();

    }
}
