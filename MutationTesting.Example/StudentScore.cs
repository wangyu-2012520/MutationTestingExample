namespace MutationTesting.Example
{
    public class StudentScore
    {
        public Student Student { get; }
        public int Score { get; private set; }

        public StudentScore(Student student, int score)
        {
            Student = student;
            Score = score;
        }

        public void AddScore(int score)
        {
            Score += score;
        }
    }
}