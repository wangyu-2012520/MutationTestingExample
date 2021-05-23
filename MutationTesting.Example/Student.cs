using System;

namespace MutationTesting.Example
{
    public class Student
    {
        public int Age { get; }

        public bool HasPaid { get; }

        public Student(int age, bool hasPaid)
        {
            this.Age = age;
            this.HasPaid = hasPaid;
        }
    }
}
