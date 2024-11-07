using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using cs_arrays_strings_lists;

namespace arrays_strings_lists.nUnitTests
{
    [TestFixture]
    public class _11_EncodeArray()
    {
        [Test]
        public void EncodeArray_SingleElement()
        {
            int[] input = { 1 };
            int[] expected = { 1, 1 };
            int[] result = AdvancedTasks.EncodeArray(input);
            Assert.That(result, Is.EqualTo(expected));
        }
        [Test]
        public void EncodeArray_MultipleElement()
        {
            int[] input = { 1, 1 };
            int[] expected = { 1, 2 };
            int[] result = AdvancedTasks.EncodeArray(input);
            Assert.That(result, Is.EqualTo(expected));
        }
        [Test]
        public void EncodeArray_MultipleInstance()
        {
            int[] input = { 1, 1, 1, 2, 2, 3, 3, 4, 4, 4, 5, 6, 6, 6, 6 };
            int[] expected = { 1, 3, 2, 2, 3, 2, 4, 3, 5, 1, 6, 4 };
            int[] result = AdvancedTasks.EncodeArray(input);
            Assert.That(result, Is.EqualTo(expected));
        }

    }
    [TestFixture]
    public class _12_IsRotation 
    {
        [Test]
        public void IsRotation()
        {
            Assert.That(AdvancedTasks.IsRotation("defabc", "abcdef"), Is.True);
            Assert.That(AdvancedTasks.IsRotation("bcdefa", "abcdef"), Is.True);
            Assert.That(AdvancedTasks.IsRotation("labradooble", "radooblelab"), Is.True);
            Assert.That(AdvancedTasks.IsRotation("dfeabc", "abcdef"), Is.False);
        }
    }
    [TestFixture]
    public class _13_IsMagicSquare
    {
        [Test]
        public void IsMagicSquare_True()
        {
            int[,] input = { { 8, 1, 6 }, { 3, 5, 7 }, { 4, 9, 2 } };
            Assert.That(AdvancedTasks.IsMagicSquare(input), Is.True);
        }
        public void IsMagicSquare_False()
        {
            int[,] input = { { 20, 300, 50 }, { 34, 42, 90 }, { 100, 80, 4 } };
            Assert.That(AdvancedTasks.IsMagicSquare(input), Is.False);
        }
    }
}
