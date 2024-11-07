using cs_arrays_strings_lists;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace arrays_strings_lists.nUnitTests
{
    [TestFixture]
   
    public class _3_SlowDownSentenceTests
    {
        [Test]
        public void SlowDownSentence_OneWord()
        {
            string input = "hello";
            string expected = "hello... ";
            string result = Task3.SlowDownSentence(input);
            Assert.That(result, Is.EqualTo(expected));
        }
        [Test]
        public void SlowDownSentence_MultipleWords()
        {
            string input = "Hello everyone at Northcoders";
            string expected = "Hello... everyone... at... Northcoders... ";
            string result = Task3.SlowDownSentence(input);
            Assert.That(result, Is.EqualTo(expected));
        }
    }
}
