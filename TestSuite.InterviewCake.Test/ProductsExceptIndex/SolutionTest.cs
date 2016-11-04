using Microsoft.VisualStudio.TestTools.UnitTesting;
using Should;
using TestSuite.InterviewCake.ProductExceptIndex;

namespace TestSuite.InterviewCake.Test.ProductsExceptIndex
{
    [TestClass]
    public class SolutionTest
    {
        [TestMethod]
        public void TestInput()
        {
            // Arrange
            var input = new int[] { 1, 7, 3, 4 };

            // Act
            var result = Solution.GetProductsExceptIndex(input);

            // Assert
            result[0].ShouldEqual(84);
            result[1].ShouldEqual(12);
            result[2].ShouldEqual(28);
            result[3].ShouldEqual(21);
        }

        [TestMethod]
        public void TestWithZeroes()
        {
            // Arrange
            var input = new int[] { 1, 7, 0, 3, 4 };

            // Act
            var result = Solution.GetProductsExceptIndex(input);

            // Assert
            result[0].ShouldEqual(0);
            result[1].ShouldEqual(0);
            result[2].ShouldEqual(84);
            result[3].ShouldEqual(0);
            result[4].ShouldEqual(0);
        }
    }
}
