namespace MutationTesting.Example
{
    public class StudentValidator
    {
        public static bool IsValid(Student student)
        {
            return student.Age >= 18 && student.HasPaid;
        }
    }
}