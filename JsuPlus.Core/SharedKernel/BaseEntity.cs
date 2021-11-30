using System;
using System.Collections.Generic;

namespace JsuPlus.Core.SharedKernel
{
    //will house properties that can be found in ALL entities
    public abstract class BaseEntity
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public List<BaseDomainEvent> Events = new List<BaseDomainEvent>();

    }
}
