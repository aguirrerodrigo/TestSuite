using Microsoft.VisualStudio.TestTools.UnitTesting;
using Should;
using TestSuite.InterviewCake.AppleStocks;

namespace TestSuite.InterviewCake.Test.AppleStocks
{

    [TestClass]
    public class SolutionTest
    {
        [TestMethod]
        public void TestEmpty()
        {
            // Arrange
            var input = new int[0];

            // Act
            var result = Solution.GetMaxProfit(input);

            // Assert
            result.ShouldEqual(0);
        }

        [TestMethod]
        public void TestSingle()
        {
            // Arrange
            var input = new int[] { 99 };

            // Act
            var result = Solution.GetMaxProfit(input);

            // Assert
            result.ShouldEqual(0);
        }

        [TestMethod]
        public void TestLoss()
        {
            // Arrange
            var input = new int[] { 7, 5 };

            // Act
            var result = Solution.GetMaxProfit(input);

            // Asser
            result.ShouldEqual(-2);
        }

        [TestMethod]
        public void TestWin()
        {
            // Arrange
            var input = new int[] { 5, 7 };

            // Act
            var result = Solution.GetMaxProfit(input);

            // Assert
            result.ShouldEqual(2);
        }

        [TestMethod]
        public void TestMultiple()
        {
            // Arrange
            var input = new int[] { 10, 7, 5, 8, 11, 9 };

            // Act
            var result = Solution.GetMaxProfit(input);

            // Assert
            result.ShouldEqual(6);
        }

        [TestMethod]
        public void TestMultiple_WhenHighestComesBeforeLowest()
        {
            // Arrange
            var input = new int[] { 99, 10, 7, 5, 8, 11, 9 };

            // Act
            var result = Solution.GetMaxProfit(input);

            // Assert
            result.ShouldEqual(6);
        }

        [TestMethod]
        public void TestMultiple_WhenAllAreLosses()
        {
            // Arrange
            var input = new int[] { 99, 87, 54, 51, 20 };

            // Act
            var result = Solution.GetMaxProfit(input);

            // Assert
            result.ShouldEqual(-3);
        }
    }
}
