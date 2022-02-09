﻿using System;

namespace Lesson_01_Data_Structures_Algorithms_and_Complexity
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Student[] students = new Student[10];

            students[0] = new Student { StudentNumber = 1, Name="Ivan" };
            students[1] = new Student { StudentNumber = 2, Name = "John" };
            students[2] = new Student { StudentNumber = 3, Name = "Jane" };
            students[3] = new Student { StudentNumber = 4, Name = "Maria" };
            students[4] = new Student { StudentNumber = 5, Name = "Erman" };
            students[5] = new Student { StudentNumber = 6, Name = "Islam" };


            var s1 = Search(students, 1);

            var s5 = Search(students, 15);
        }

        private static Student Search(Student[] students, int studentNumber)
        {
            foreach (var student in students)
            {
                if (student.StudentNumber == studentNumber)
                {
                    return student;
                }
            }
            return null;
        }

        private static Student SearchByIndex(Student[] students, int index)
        {
            if (students.Length < index && index >= 0)
            {
                return students[index];
            }
            return null;
        }
    }
}