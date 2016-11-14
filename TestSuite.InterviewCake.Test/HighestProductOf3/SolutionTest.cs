using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Should;
using TestSuite.InterviewCake.HighestProductOf3;

namespace TestSuite.InterviewCake.Test.HighestProductOf3
{
    [TestClass]
    public class SolutionTest
    {
        [TestMethod]
        public void HighestProductOf3_TestInput()
        {
            // Arrange
            var input = new int[] { 1, 10, -5, 1, -100 };

            // Act
            var result = Solution.GetHighestProductOf3(input);

            // Assert
            result.ShouldEqual(5000);
        }

        [TestMethod]
        [ExpectedException(typeof(OverflowException))]
        public void HighestProductOf3_TestOverflow()
        {
            // Arrange
            var input = new int[] { 1, 10, -5, 1, -100, int.MaxValue };

            // Act
            var result = Solution.GetHighestProductOf3(input);

            // Assert
        }

        [TestMethod]
        public void HighestProductOfK_TestInput()
        {
            // Arrange
            var input = new int[] { 1, 10, -5, 1, -100 };

            // Act
            var result = Solution.GetHighestProductOfK(3, input);

            // Assert
            result.ShouldEqual(5000);
        }

        [TestMethod]
        public void HighestProductOfK4_TestInput()
        {
            // Arrange
            var input = new int[] { 1, 10, -5, 1, -100, -10, -100 };

            // Act
            var result = Solution.GetHighestProductOfK(4, input);

            // Assert
            result.ShouldEqual(500000);
        }

        [TestMethod]
        [ExpectedException(typeof(OverflowException))]
        public void HighestProductOfK_TestOverflow()
        {
            // Arrange
            var input = new int[] { 1, 10, -5, 1, -100, int.MaxValue };

            // Act
            var result = Solution.GetHighestProductOfK(3, input);

            // Assert
        }
    }
}
