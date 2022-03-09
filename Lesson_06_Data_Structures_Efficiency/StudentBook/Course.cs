using System;

namespace Lesson_06_Data_Structures_Efficiency.StudentBook
{
    public class Course : IComparable<Course>, IEquatable<Course>
    {
        public Course(string name)
        {
            Name = name;
        }

        public string Name { get; set; }

        public int CompareTo(Course other)
        {
            return string.Compare(Name, other.Name, true);
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as Course);
        }

        public bool Equals(Course other)
        {
            if (other is null)
            {
                return false;
            }

            if (ReferenceEquals(this, other))
            {
                return true;
            }

            return string.Compare(Name, other.Name, true) == 0;
        }

        public override int GetHashCode()
        {
            return !string.IsNullOrEmpty(Name) ? Name.GetHashCode() : 0;
        }

        public override string ToString()
        {
            return string.Format($"{Name}");
        }
    }
}