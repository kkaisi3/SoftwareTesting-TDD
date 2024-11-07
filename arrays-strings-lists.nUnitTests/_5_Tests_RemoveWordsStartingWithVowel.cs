using cs_arrays_strings_lists;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrays_strings_lists.nUnitTests
{
    [TestFixture]
    public class _5_RemoveWordStartingWithVowel
    {
        [Test]
        public void RemoveWordStartingWithVowel_lowercase()
        {
            var input = new List<string> { "olive", "jade" };
            var expected = new List<string> { "jade" };
            var result = Task5.RemoveWordStartingWithVowel(input);
            Assert.That(result, Is.EqualTo(expected));
        }
        [Test]
        public void RemoveWordStartingWithVowel_uppercase()
        {
            var input = new List<string> { "amber", "Cerise", "Indigo", "Ochre", "Chartreuse", "lavender" };
            var expected = new List<string> { "Cerise", "Chartreuse", "lavender" };
            var result = Task5.RemoveWordStartingWithVowel(input);
            Assert.That(result, Is.EqualTo(expected));
        }
    }
}
