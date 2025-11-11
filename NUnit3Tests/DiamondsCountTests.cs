using NUnit3Tests;
using NUnit.Framework;
using CSharpCodeExamples.Codility.Exercises;


namespace NUnit3Tests
{
    public class DiamondsCountTests
    {

        [Test]
        public void Example_Test_One()
        {
            // Arrange
            int[] X = [1, 1, 2, 2, 2, 3, 3];
            int[] Y = [3, 4, 1, 3, 5, 3, 4];

            TestContext.WriteLine(X.ToString());
            TestContext.WriteLine(Y);

            // Act
            int result = Exercise3_2017Contest.DiamondsCount(X, Y);

            // Assert
            Assert.That(result, Is.EqualTo(2));
        }
    }
}