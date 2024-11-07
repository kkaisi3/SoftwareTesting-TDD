using cs_arrays_strings_lists;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrays_strings_lists.nUnitTests
{
    [TestFixture]
   
    public class _4_ReturnWordsBetweenParenthesesTests
    {
        [Test]
        public void ReturnWordsBetweenParentheses_OneWord()
        {
            var input = "(found)";
            var expected = "found";
            var result = Task4.ReturnWordsBetweenParentheses(input);
            Assert.That(result, Is.EqualTo(expected));
        }
        [Test]
        public void ReturnWordsBetweenParentheses_Multiple_Words()
        {
            var input = "Problem solving is (in my opinion) a very useful skill to have!";
            var expected = "in my opinion";
            var result = Task4.ReturnWordsBetweenParentheses(input);
            Assert.That(result, Is.EqualTo(expected));
        }

    }
}
