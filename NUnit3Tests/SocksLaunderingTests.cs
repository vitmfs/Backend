using NUnit3Tests;
using NUnit.Framework;
using CSharpCodeExamples.Codility.Exercises;


namespace NUnit3Tests
{
    public class SocksLaunderingTests
    {
        [SetUp]
        public void Setup()
        {
        }


        [Test]
        public void TestDescribedInTheProblem()
        {
            // Arrange arguments
            int K = 2;
            int[] C = { 1, 2, 1, 1 };
            int[] D = [1, 4, 3, 2, 4];

            // Call method under test with arranged arguments
            int result = Exercise3_2017Contest.SocksLaundering(K, C, D);

            // Assert
            Assert.That(result, Is.EqualTo(3));
        }

        [Test]
        public void No_Laundry_Test()
        {
            // Arrange arguments
            int K = 2;
            int[] C = {};
            int[] D = [];

            // Call method under test with arranged arguments
            int result = Exercise3_2017Contest.SocksLaundering(K, C, D);

            // Assert
            Assert.That(result, Is.EqualTo(0));
        }

        [Test]
        public void Odd_Clean_With_Odd_Dirty_Test()
        {
            // Arrange arguments
            int K = 2;
            int[] C = { 1, 2, 1, 1, 2, 2 }; 
            int[] D = [1, 2];

            // Call method under test with arranged arguments
            int result = Exercise3_2017Contest.SocksLaundering(K, C, D);

            // Assert
            Assert.That(result, Is.EqualTo(4));
        }
    }
}