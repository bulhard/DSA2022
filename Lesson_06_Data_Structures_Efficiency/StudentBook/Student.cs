using System;
using System.Diagnostics.CodeAnalysis;

namespace Lesson_06_Data_Structures_Efficiency.StudentBook
{
    public class Student : IComparable<Student>
    {
        public Student(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int CompareTo(Student other)
        {
            var compare = LastName.CompareTo(other.LastName);

            if (compare == 0)
            {
                compare = FirstName.CompareTo(other.FirstName);
            }

            return compare;
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }
    }
}