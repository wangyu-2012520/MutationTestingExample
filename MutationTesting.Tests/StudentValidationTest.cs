using System;
using MutationTesting.Example;
using Xunit;

namespace MutationTesting.Tests
{
    public class StudentValidationTest
    {
        [Fact]
        public void IsAdultAndHasPaid_IsValid()
        {
            var student = new Student(18, true);

            var isValid = StudentValidator.IsValid(student);

            Assert.True(isValid);
        }

        [Fact]
        public void IsUnderageAndHasNotPaid_IsNotValid()
        {
            var student = new Student(12, false);

            var isValid = StudentValidator.IsValid(student);

            Assert.False(isValid);
        }
    }
}