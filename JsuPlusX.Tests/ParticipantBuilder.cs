using JsuPlus.Core.Entities;

namespace JsuPlus.Tests
{
    public class ParticipantBuilder
    {
        private readonly Participant _participant = new Participant();

        public ParticipantBuilder Id(int id)
        {
            _participant.Id = id;
            return this;
        }
        public ParticipantBuilder FirstName(string firstname)
        {
            _participant.FirstName = firstname;
            return this;
        }
        public ParticipantBuilder LastName(string lastname)
        {
            _participant.LastName = lastname;
            return this;
        }
        public Participant Build() => _participant;

    }
}
