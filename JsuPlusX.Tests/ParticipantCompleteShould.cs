using Xunit;
using JsuPlus.Core.Events;
using System.Linq;

namespace JsuPlus.Tests.Core.Entities
{
    public class ParticipantCompleteShould
    {
        [Fact]
        public void SetIsDoneToTrue()
        {
            var item = new ParticipantBuilder().Build();

            item.MarkComplete();

            Assert.True(item.IsDone);
        }
    }
}
