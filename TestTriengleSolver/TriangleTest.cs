using NUnit.Framework;
using TriangleSolver;

namespace TestTriengleSolver
{
    [TestFixture]
    public class TriangleTest
    {
        private static string VALID_EQUIRATERAL_RESPONSE = "An EQUILATERAL triangle is formed";

        private static string VALID_ISOSCELES_RESPONSE = "An ISOSCELES triangle is formed";


        [Test]
        public void ValidEquilateral_Input60and60and60_OutputValidTriangle()
        {
            // Test Data Preparation
            int firstSide = 60;
            int secondSide = 60;
            int thirdSide = 60;
            string expectedResponse = VALID_EQUIRATERAL_RESPONSE;

            // Test execution
            string executionResponse = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            // Assert
            Assert.AreEqual(expectedResponse, executionResponse);
        }

        [Test]
        public void ValidIsosceles_Input60and60and40_OutputValidTriangle()
        {
            // Test Data Preparation
            int firstSide = 60;
            int secondSide = 60;
            int thirdSide = 40;
            string expectedResponse = VALID_ISOSCELES_RESPONSE;

            // Test execution
            string executionResponse = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            // Assert
            Assert.AreEqual(expectedResponse, executionResponse);
        }

        [Test]
        public void ValidIsosceles_Input40and60and40_OutputValidTriangle()
        {
            // Test Data Preparation
            int firstSide = 40;
            int secondSide = 60;
            int thirdSide = 40;
            string expectedResponse = VALID_ISOSCELES_RESPONSE;

            // Test execution
            string executionResponse = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            // Assert
            Assert.AreEqual(expectedResponse, executionResponse);
        }

        [Test]
        public void ValidIsosceles_Input70and40and40_OutputValidTriangle()
        {
            // Test Data Preparation
            int firstSide = 70;
            int secondSide = 40;
            int thirdSide = 40;
            string expectedResponse = VALID_ISOSCELES_RESPONSE;

            // Test execution
            string executionResponse = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            // Assert
            Assert.AreEqual(expectedResponse, executionResponse);
        }

    }
}
