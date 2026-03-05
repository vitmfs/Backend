using CSharpCodeExamples.Codility.Exercises;
using NUnit.Framework;
using NUnit3Tests;
using static CSharpCodeExamples.FundamentalsOfComputerProgrammingWithCSharp.Exercises;

//https://docs.nunit.org/articles/nunit/writing-tests/assertions/assertions.html

namespace zNUnit3Tests
{
    public class BookExercisesTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            string str = "This is the TEXT. Text, text, text – THIS TEXT! Is this the text?";
            Dictionary<string, int> summary = CountEachWord(str);
            int n = 4;
            Assert.That(summary["is"], Is.EqualTo(2));
            Assert.That(summary["the"], Is.EqualTo(2));
            Assert.That(summary["this"], Is.EqualTo(3));
            Assert.That(summary["text"], Is.EqualTo(6));
        }



    }





}

