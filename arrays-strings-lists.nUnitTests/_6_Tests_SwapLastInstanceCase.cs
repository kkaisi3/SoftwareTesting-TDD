using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using cs_arrays_strings_lists;

namespace arrays_strings_lists.nUnitTests
{
    [TestFixture]
    public class _6_SwapLastInstanceCase
    {
        [Test]
        public static void SwapLastInstanceCase_OneInstance()
        {
            string[] input = { "These", "yellow", "cars", "are", "great", "yellow", "cars" };
            string searchTerm = "yellow";
            string expected = "These yellow cars are great YELLOW cars";
            var result = Task6.SwapLastInstanceCase(input, searchTerm);
            Assert.That(result, Is.EqualTo(expected));
        }
        [Test]
        public static void SwapLastInstanceCase_MultipleInstances()
        {
            string[] input = { "I", "LOVE", "CROWS", "BECAUSE", "CROWS", "ARE", "GREAT" };
            string searchTerm = "crows";
            string expected = "I LOVE CROWS BECAUSE crows ARE GREAT";
            var result = Task6.SwapLastInstanceCase(input,searchTerm);
            Assert.That(result, Is.EqualTo(expected));
        }
    }
}
