using System;

namespace MutationTesting.Example
{
    public class Student
    {
        public int Age { get; private set; }

        public bool HasPaid { get; private set; }

        public Student(int age, bool hasPaid)
        {
            this.Age = age;
            this.HasPaid = hasPaid;
        }
    }
}
