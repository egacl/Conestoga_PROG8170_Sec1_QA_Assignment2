using NUnit.Framework;
using TriangleSolver;

namespace TestTriengleSolver
{
    [TestFixture]
    public class TriangleTest
    {
        private static string VALID_EQUIRATERAL_RESPONSE = "An EQUILATERAL triangle is formed";

        private static string VALID_ISOSCELES_RESPONSE = "An ISOSCELES triangle is formed";

        private static string VALID_SCALENE_RESPONSE = "A SCALENE triangle is formed";

        private static string INVALID_ZERO_SIDE_RESPONSE = "Invalid Triangle - at least one side is zero";

        private static string INVALID_TRIANGLE = "INVALID Triangle detected!!";


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

        [Test]
        public void ValidScalene_Input70and60and50_OutputValidTriangle()
        {
            // Test Data Preparation
            int firstSide = 70;
            int secondSide = 60;
            int thirdSide = 50;
            string expectedResponse = VALID_SCALENE_RESPONSE;

            // Test execution
            string executionResponse = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            // Assert
            Assert.AreEqual(expectedResponse, executionResponse);
        }

        [Test]
        public void ValidScalene_Input60and70and50_OutputValidTriangle()
        {
            // Test Data Preparation
            int firstSide = 60;
            int secondSide = 70;
            int thirdSide = 50;
            string expectedResponse = VALID_SCALENE_RESPONSE;

            // Test execution
            string executionResponse = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            // Assert
            Assert.AreEqual(expectedResponse, executionResponse);
        }

        [Test]
        public void ValidScalene_Input60and50and70_OutputValidTriangle()
        {
            // Test Data Preparation
            int firstSide = 60;
            int secondSide = 50;
            int thirdSide = 70;
            string expectedResponse = VALID_SCALENE_RESPONSE;

            // Test execution
            string executionResponse = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            // Assert
            Assert.AreEqual(expectedResponse, executionResponse);
        }

        [Test]
        public void ValidScalene_Input2and3and4_OutputValidTriangle()
        {
            // Test Data Preparation
            int firstSide = 2;
            int secondSide = 3;
            int thirdSide = 4;
            string expectedResponse = VALID_SCALENE_RESPONSE;

            // Test execution
            string executionResponse = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            // Assert
            Assert.AreEqual(expectedResponse, executionResponse);
        }

        [Test]
        public void ValidScalene_Input4and3and5_OutputValidTriangle()
        {
            // Test Data Preparation
            int firstSide = 4;
            int secondSide = 3;
            int thirdSide = 5;
            string expectedResponse = VALID_SCALENE_RESPONSE;

            // Test execution
            string executionResponse = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            // Assert
            Assert.AreEqual(expectedResponse, executionResponse);
        }

        [Test]
        public void ZeroLengthOneSide_Input0and3and5_OutputInvalidTriangle()
        {
            // Test Data Preparation
            int firstSide = 0;
            int secondSide = 3;
            int thirdSide = 5;
            string expectedResponse = INVALID_ZERO_SIDE_RESPONSE;

            // Test execution
            string executionResponse = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            // Assert
            Assert.AreEqual(expectedResponse, executionResponse);
        }

        [Test]
        public void ZeroLengthOneSide_Input4and0and5_OutputInvalidTriangle()
        {
            // Test Data Preparation
            int firstSide = 4;
            int secondSide = 0;
            int thirdSide = 5;
            string expectedResponse = INVALID_ZERO_SIDE_RESPONSE;

            // Test execution
            string executionResponse = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            // Assert
            Assert.AreEqual(expectedResponse, executionResponse);
        }

        [Test]
        public void ZeroLengthOneSide_Input4and3and0_OutputInvalidTriangle()
        {
            // Test Data Preparation
            int firstSide = 4;
            int secondSide = 3;
            int thirdSide = 0;
            string expectedResponse = INVALID_ZERO_SIDE_RESPONSE;

            // Test execution
            string executionResponse = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            // Assert
            Assert.AreEqual(expectedResponse, executionResponse);
        }

    }
}
