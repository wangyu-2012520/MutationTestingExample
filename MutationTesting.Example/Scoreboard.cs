using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace MutationTesting.Example
{
    public class Scoreboard
    {
        public readonly List<StudentScore> Scores = new List<StudentScore>();

        // inspired by AddItem method in https://github.com/dotnet-architecture/eShopOnWeb/blob/master/src/ApplicationCore/Entities/BasketAggregate/Basket.cs
        public void AddScore(Student student, int score)
        {
            if (!Scores.Any(_ => _.Student.Equals(student)))
            {
                Scores.Add(new StudentScore(student, score));
                return;
            }
            // We cannot kill the mutation FirstOrDefault, because it actually is not valid.
            // The previous if statement ensures that the score exists, thus we will never get null.
            var existingScore = Scores.First(_ => _.Student.Equals(student));
            existingScore.AddScore(score);
        }

        public int GetScore(Student student)
        {
            return Scores.Where(_ => _.Student.Equals(student))
                .Select(_ => _.Score)
                .FirstOrDefault();
        }
    }
}