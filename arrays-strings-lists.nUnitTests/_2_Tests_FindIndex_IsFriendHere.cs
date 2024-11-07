using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using cs_arrays_strings_lists;

namespace arrays_strings_lists.nUnitTests
{
    [TestFixture]
  
    public class _2_Section2_Tests
    {
        [Test]
        public void FindIndex()
        {
            int result = Task2.FindIndex("o", "fox");
            Assert.That(result, Is.EqualTo(1));
        }
        [Test]
        public void IsFriendHere()
        {
            List<string> inputFriends = new List<string> { "Lee", "Rowan", "Ari", "Kai" };
            bool resultRobin = Task2.IsFriendHere(inputFriends, "Robin");
            bool resultKai = Task2.IsFriendHere(inputFriends, "Kai");
            Assert.That(resultRobin, Is.EqualTo(false));
            Assert.That(resultKai, Is.EqualTo(true));
        }
    }
}
