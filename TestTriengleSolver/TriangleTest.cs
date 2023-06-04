using NUnit.Framework;
using TriangleSolver;

namespace TestTriengleSolver
{
    [TestFixture]
    public class TriangleTest
    {

        [Test]
        public void ValidEquilateral_Input60and60and60_OutputValidTriangle()
        {
            // Test Data Preparation
            int firstSide = 60;
            int secondSide = 60;
            int thirdSide = 60;
            string expectedResponse = "An EQUILATERAL triangle is formed";

            // Test execution
            string executionResponse = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            // Assert
            Assert.AreEqual(expectedResponse, executionResponse);
        }

    }
}
