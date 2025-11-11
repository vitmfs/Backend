using NUnit3Tests;
using NUnit.Framework;
using CSharpCodeExamples.Codility.Exercises;


namespace NUnit3Tests
{
    public class ArrayRecoveryTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }

        [Test]
        public void WhenCourtsAreEnough_ReturnsHalfThePlayers()
        {
            // Arrange
            int[] A = [2, 5, 3, 7, 9, 6];
            TestContext.WriteLine($"Value of tests is something");

            // Act
            int result = Exercise3_2017Contest.ArrayRecovery([], 0);

            // Assert
            Assert.That(result, Is.EqualTo(4));
        }
    }
}