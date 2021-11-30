using JsuPlus.Core.Entities;
using JsuPlus.Core.Interfaces;
using System;

namespace JsuPlus.Tests
{
    public class ParticipantBuilder
    {
        private readonly Participant _participant = new Participant();

        public ParticipantBuilder Id(Guid id)
        {
            _participant.Id = id;
            return this;
        }
       
        public Participant Build() => _participant;

    }
}
