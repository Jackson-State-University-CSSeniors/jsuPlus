using JsuPlus.Core.Entities;
using JsuPlus.Core.SharedKernel;


namespace JsuPlus.Core.Events
{
    public class ParticipantCompletedEvent : BaseDomainEvent
    {
        public Participant CompletedItem { get; set; }
        public ParticipantCompletedEvent(Participant completeditem)
        {
            CompletedItem = completeditem;
        }
    }
}
