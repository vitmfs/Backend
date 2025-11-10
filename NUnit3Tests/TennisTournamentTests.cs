using NUnit3Tests;
using NUnit.Framework;
using CSharpCodeExamples.Codility.Exercises;
{
    
}

namespace NUnit3Tests
{
    public class TennisTournamentTests
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
            int players = 8;
            int courts = 4;

            // Act
            int result = Exercise3_2017Contest.TennisTournament(players, courts);

            // Assert
            Assert.That(result, Is.EqualTo(4));
        }

        [Test]
        public void WhenNotEnoughCourts_ReturnsZero()
        {
            // Arrange
            int players = 8;
            int courts = 3;

            // Act
            int result = Exercise3_2017Contest.TennisTournament(players, courts);

            // Assert
            Assert.Equals(0, result);
        }

        [Test]
        public void WhenOddNumberOfPlayers_IgnoresLastPlayer()
        {
            // Arrange
            int players = 7;
            int courts = 3;

            // Act
            int result = Exercise3_2017Contest.TennisTournament(players, courts);

            // Assert
            // 7 / 2 = 3 possible games, but only 3 courts — enough
            Assert.Equals(3, result);
        }

        [Test]
        public void WhenOddNumberOfPlayersButNotEnoughCourts_ReturnsZero()
        {
            // Arrange
            int players = 7;
            int courts = 2;

            // Act
            int result = Exercise3_2017Contest.TennisTournament(players, courts);

            // Assert
            Assert.Equals(0, result);
        }

        [Test]
        public void WhenZeroPlayers_ReturnsZero()
        {
            // Arrange
            int players = 0;
            int courts = 10;

            // Act
            int result = Exercise3_2017Contest.TennisTournament(players, courts);

            // Assert
            Assert.Equals(0, result);
        }

        [Test]
        public void WhenOnlyOnePlayer_ReturnsZero()
        {
            // Arrange
            int players = 1;
            int courts = 5;

            // Act
            int result = Exercise3_2017Contest.TennisTournament(players, courts);

            // Assert
            Assert.Equals(0, result);
        }

        [Test]
        public void WhenCourtsExactlyMatchNumberOfGames_ReturnsNumberOfGames()
        {
            // Arrange
            int players = 10;
            int courts = 5;

            // Act
            int result = Exercise3_2017Contest.TennisTournament(players, courts);

            // Assert
            Assert.Equals(5, result);
        }
    }
}