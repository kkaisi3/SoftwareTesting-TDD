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
        [TestCase(new int[] { 2, 4, 6, 7, 1}, 12)]
        [TestCase(new int[] { 1 }, 0)]
        [TestCase(new int[] { 1 , 2 }, 0)]
        [TestCase(new int[] { 1 ,2, 3 }, 2)]
        public void SumNumbersTest(int[] input, int expected)
        {

            SumOfNumbers testNumbers = new SumOfNumbers();
            int sumOfNumbers = testNumbers.AddNumbers(input);
             sumOfNumbers.Should().Be(expected);
        }

        [Test]
        [TestCase(new double[] {1,2,3}, 2)]
        [TestCase(new double[] {40,16,5,8}, 17.25)]
        [TestCase(new double[] {2,0}, 1)]
        [TestCase(new double[] {1}, 1)]
        [TestCase(new double[] {0}, 0)]
        
        public void MeanNumberTest(double[] input, double expected)
        {
            SumOfNumbers meanTest = new SumOfNumbers();
            
            double meanNums = meanTest.MeanNumber(input);

            meanNums.Should().Be(expected);


        }

    }
}