using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using cs_arrays_strings_lists;

namespace arrays_strings_lists.nUnitTests
{
    [TestFixture]
    
    public class _8_LetterCounter
    {
        [Test]
        public void LetterCounter_SingleChar()
        {
            var input = "a";
            int[] expected = { 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            var result = Task8.LetterCounter(input);
            Assert.That(result, Is.EqualTo(expected));
        }
        [Test]
        public void LetterCounter_UpperCaseChar()
        {
            var input = "A";
            int[] expected = { 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            var result = Task8.LetterCounter(input);
            Assert.That(result, Is.EqualTo(expected));
        }
        [Test]
        public void LetterCounter_MultipleChar()
        {
            string input = "AbcYz";
            int[] expected = { 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1 };
            int[] result = Task8.LetterCounter(input);
            Assert.That(result, Is.EqualTo(expected));
        }
        [Test]
        public void LetterCounter_MultipleInstances()
        {
            string input = "Aardvark";
            int[] expected = { 3, 0, 0, 1, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 2, 0, 0, 0, 1, 0, 0, 0, 0 };
            int[] result = Task8.LetterCounter(input);
            Assert.That(result, Is.EqualTo(expected));
        }
    }
}
