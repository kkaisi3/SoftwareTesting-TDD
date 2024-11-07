using cs_arrays_strings_lists;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrays_strings_lists.nUnitTests
{
    [TestFixture]
   
    public class _10_FrequencyCounting
    {
        [Test]
        public void FrequencyCounting_SingleElement()
        {
            int[] input = { 20 };
            Dictionary<int, int> expected = new Dictionary<int, int>()
            {
                { 20, 1 },
            };
            var result = Task10.FrequencyCounting(input);
            Assert.That(result, Is.EqualTo(expected));
        }
        [Test]
        public void FrequencyCounting_MultipleInstance()
        {
            int[] input = { 20, 20 };
            Dictionary<int, int> expected = new Dictionary<int, int>()
            {
                { 20, 2 },
            };
            var result = Task10.FrequencyCounting(input);
            Assert.That(result, Is.EqualTo(expected));
        }
        [Test]
        public void FrequencyCounting_MultipleElements()
        {
            int[] input = { 20, 30, 45, 100, 24, 80, 100, 20 };
            Dictionary<int, int> expected = new Dictionary<int, int>()
            {
                { 20, 2 }, {30, 1}, {45, 1}, {100, 2}, {24, 1}, {80, 1}
            };
            var result = Task10.FrequencyCounting(input);
            Assert.That(result, Is.EqualTo(expected));
        }
    }
}
