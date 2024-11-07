using cs_arrays_strings_lists;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrays_strings_lists.nUnitTests
{
    [TestFixture]
    public class _9_AnagramDetector
    {
        [Test]
        public void AnagramDetector_EqualStrings()
        {
            string input1 = "a";
            string input2 = "A";
            string input3 = "B";
            bool resultTrue = Task9.AnagramDetector(input1, input2);
            bool resultFalse = Task9.AnagramDetector(input1, input3);
            Assert.That(resultTrue, Is.EqualTo(true));
            Assert.That(resultFalse, Is.EqualTo(false));
        }
        public void AnagramDetector_MultipleCharacters()
        {
            string input1 = "silent";
            string input2 = "listen";
            string input3 = "listend";
            string input4 = "listenn";

            bool resultTrue = Task9.AnagramDetector(input1, input2);
            bool resultFalse1 = Task9.AnagramDetector(input1, input3);
            bool resultFalse2 = Task9.AnagramDetector(input1, input4);

            Assert.That(resultTrue, Is.EqualTo(true));
            Assert.That(resultFalse1, Is.EqualTo(false));
            Assert.That(resultFalse2, Is.EqualTo(false));
        }
    }
}
