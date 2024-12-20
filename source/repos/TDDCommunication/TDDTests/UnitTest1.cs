using FluentAssertions;
using TDD_Communication;
namespace TDDTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCase(new int[] { 2, 4, 6, 7, 1 }, 12)]
        [TestCase(new int[] { 1 }, 0)]
        [TestCase(new int[] { 1, 2 }, 0)]
        [TestCase(new int[] { 1, 2, 3 }, 2)]
        public void SumNumbersTest(int[] input, int expected)
        {

            SumOfNumbers testNumbers = new SumOfNumbers();
            int sumOfNumbers = testNumbers.AddNumbers(input);
            sumOfNumbers.Should().Be(expected);
        }

        [Test]
        [TestCase(new double[] { 1, 2, 3 }, 2)]
        [TestCase(new double[] { 40, 16, 5, 8 }, 17.25)]
        [TestCase(new double[] { 2, 0 }, 1)]
        [TestCase(new double[] { 1 }, 1)]
        [TestCase(new double[] { 0 }, 0)]

        public void MeanNumberTest(double[] input, double expected)
        {
            SumOfNumbers meanTest = new SumOfNumbers();

            double meanNums = meanTest.MeanNumber(input);

            meanNums.Should().Be(expected);


        }
        [Test]
        [TestCase("Northcoders", 1163)]
        [TestCase("northcoders", 1195)]
        [TestCase("a", 97)]
        [TestCase("123", 150)]

        public void addAscii(string input, int expected)
        {
            AsciiNums addAsciiTest = new AsciiNums();

            int addedAscii = addAsciiTest.addAscii(input);

            addedAscii.Should().Be(expected);


        }

        [Test]
        [TestCase(new string[]{"LIKE"}, "LIKE")]
        [TestCase(new string[]{"DISLIKE"}, "DISLIKE")]
        [TestCase(new string[]{"LIKE", "LIKE"}, "NEUTRAL")]
        [TestCase(new string[]{"DISLIKE", "DISLIKE"}, "NEUTRAL")]

        [TestCase(new string[]{"LIKE", "DISLIKE"}, "NEUTRAL")]
        [TestCase(new string[]{"DISLIKE", "DISLIKE", "LIKE"}, "LIKE")]
        [TestCase(new string[]{"LIKE", "LIKE", "LIKE"}, "LIKE")]

        
        public void TestLikeDislike(string[] input, string exprected)
        {
            LIKEDISLIKE liketest = new LIKEDISLIKE();
          
            string testAnswer = liketest.buttonspressed(input);

            testAnswer.Should().Be(exprected);


        }
        [Test]
        [TestCase("northcoders", "abegupbqref")]
        [TestCase("abegupbqref", "northcoders")]
        [TestCase("a", "n")]

        public void CeasarTest(string input, string exprected)
        {
            CeasarCipher ceasartest = new CeasarCipher();
            string ceasarcipher = ceasartest.Ceasarstring(input);
            ceasarcipher.Should().Be(exprected);
        }

        [Test]
        [TestCase("---K-----M---C--",6,0,"no Cheese")]
        [TestCase("---K-----M---C--",0,6,"Cheese")]
        [TestCase("---K-----M---C--",1,1,"Cheese")]
        [TestCase("---K-----M---C--",3,1,"no Cheese")]
        [TestCase("---K---M---C--", 2,1,"Cheese Party")]
        [TestCase("---M-----K---C--", -1, 1, "no Cheese")]
        [TestCase("---M-----K---C--", 6, 6, "Cheese")]
      





        public void CheseTest(string raceinput, int catInput, int mouseInput, string expected)
        {
            CheeseHunt testCheese = new CheeseHunt();

            string cheeseAns = testCheese.Hunting(raceinput, catInput, mouseInput);

            cheeseAns.Should().Be(expected);

        }
        
    }
}