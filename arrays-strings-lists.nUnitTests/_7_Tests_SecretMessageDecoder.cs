using cs_arrays_strings_lists;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrays_strings_lists.nUnitTests
{
    [TestFixture]
   
    //HINT: If you get stuck, focus on passing one test at a time. Follow the bullet point in the instructions, or look at the description attribute of each test. 
    public class _7_SecretMessageDecoder
    {
        [Test, Description("Only includes words if word is present in both arrays")] //Description attribute describes what behaviour the test is checking for
        public static void SecretMessageDecoder_1()
        {
            string[] secretWords1 = { "bye", "C#" };
            string[] secretWords2 = { "hi", "C#" };
            string expected = "C#";
            var result = Task7.SecretMessageDecoder(secretWords1, secretWords2);
            Assert.That(result, Is.EqualTo(expected));
        }
        [Test, Description("Only includes words if word is present at the same index of both arrays")]
        public static void SecretMessageDecoder_2()
        {
            string[] secretWords1 = { "tangerine", "lemon", "kiwi" };
            string[] secretWords2 = { "kiwi", "lemon", "tangerine" };
            string expected = "lemon";
            var result = Task7.SecretMessageDecoder(secretWords1, secretWords2);
            Assert.That(result, Is.EqualTo(expected));
        }
        [Test, Description("Does not include words 7 or more in length")]
        public static void SecretMessageDecoder_3()
        {
            string[] secretWords1 = { "lime", "lemon", "tangerine", "orange" };
            string[] secretWords2 = { "kiwi", "lemon", "tangerine", "lime" };
            string expected = "lemon";
            var result = Task7.SecretMessageDecoder(secretWords1, secretWords2);
            Assert.That(result, Is.EqualTo(expected));
        }
        [Test, Description("Returns words reversed and seperated with a space")]
        public static void SecretMessageDecoder_4()
        {
            string[] secretWords1 = { "bye", "rocks", "C#", "hi" };
            string[] secretWords2 = { "hi", "rocks", "C#", "bye" };
            string expected = "C# rocks";
            var result = Task7.SecretMessageDecoder(secretWords1, secretWords2);
            Assert.That(result, Is.EqualTo(expected));
        }
        [Test, Description("Ignores and removes whitespace at beginning and end of a word")]
        public static void SecretMessageDecoder_5()
        {
            string[] secretWords1 = { " me ", "Northcoders", "found", "the", "you" };
            string[] secretWords2 = { "me", "Northcoders", " found", "th e", "you" };
            string expected = "you found me";
            var result = Task7.SecretMessageDecoder(secretWords1, secretWords2);
            Assert.That(result, Is.EqualTo(expected));
        }
    }
}
