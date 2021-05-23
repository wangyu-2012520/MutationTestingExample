using MutationTesting.Example;
using Xunit;

namespace MutationTesting.Tests
{
    public class StudentScoringTest
    {
        [Fact]
        public void TwoScores_AreAddedUp()
        {
            var student = new Student(18, true);
            var firstScore = 5;
            var secondScore = 8;
            var expectedScore = 13;
            var scoreboard = new Scoreboard();
            
            scoreboard.AddScore(student, firstScore);
            scoreboard.AddScore(student, secondScore);
            var finalScore = scoreboard.GetScore(student);

            Assert.Equal(expectedScore, finalScore);
        }

        [Fact]
        public void NoScores_Zero()
        {
            var student = new Student(18, true);
            var expectedScore = 0;
            var scoreboard = new Scoreboard();
            
            var finalScore = scoreboard.GetScore(student);

            Assert.Equal(expectedScore, finalScore);
        }
    }
}