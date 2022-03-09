using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Utility;

namespace Lesson_06_Data_Structures_Efficiency.StudentBook
{
    public class StudentBookTest
    {
        SortedDictionary<Course, SortedSet<Student>> studentsBook = new SortedDictionary<Course, SortedSet<Student>>();

        public void Run()
        {
            LoadStudents();

            DisplayStudents();
        }

        private void DisplayStudents()
        {
            foreach (var record in studentsBook)
            {
                Console.Write($"{record.Key}: ");

                Console.Write($"{string.Join(", ", record.Value)}");

                Console.WriteLine();
            }
        }

        private void LoadStudents()
        {
            string fileContent = ConsoleUtility.GetFileTextContent("../../../StudentBook/students.txt");

            string[] fileArray = fileContent.Split(Environment.NewLine.ToCharArray());

            foreach (var line in fileArray)
            {
                if (!string.IsNullOrEmpty(line))
                {
                    string[] lineArray = line.Split("|");

                    string firstName = lineArray[0].Trim();
                    string lastName = lineArray[1].Trim();
                    string courseName = lineArray[2].Trim();

                    Student student = new Student(firstName, lastName);
                    Course course = new Course(courseName);

                    if (!studentsBook.ContainsKey(course))
                    {
                        studentsBook.Add(course, new SortedSet<Student>());
                    }
                    studentsBook[course].Add(student);
                }
            }
        }

        //public void Hints()
        //{
        //    SortedDictionary<Course, SortedSet<Student>> studentsBook = new SortedDictionary<Course, SortedSet<Student>>();

        //    var course = new Course("C#");
        //    var student = new Student("Ivan", "Petrov");

        //    if (!studentsBook.ContainsKey(course))
        //    {
        //        studentsBook.Add(course, new SortedSet<Student>());
        //    }
        //    studentsBook[course].Add(student);

        //    course = new Course("C#");
        //    student = new Student("Ivana", "Petrova");

        //    if (!studentsBook.ContainsKey(course))
        //    {
        //        studentsBook.Add(course, new SortedSet<Student>());
        //    }
        //    studentsBook[course].Add(student);

        //    course = new Course("C#");
        //    student = new Student("Stamat", "Ivanov");

        //    if (!studentsBook.ContainsKey(course))
        //    {
        //        studentsBook.Add(course, new SortedSet<Student>());
        //    }
        //    studentsBook[course].Add(student);

        //    foreach (var record in studentsBook)
        //    {
        //        Console.Write($"{record.Key}: ");

        //        Console.Write($"{string.Join(", ", record.Value)}");

        //        Console.WriteLine();
        //    }
        //}
    }
}