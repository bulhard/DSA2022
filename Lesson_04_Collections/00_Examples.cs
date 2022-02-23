using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lesson_04_Collections
{
    public static class _00_Examples
    {
        public static void Run()
        {
            Dictionary<string, int> studentsMarks = new Dictionary<string, int>();

            studentsMarks.Add("Ivan", 4);
            studentsMarks.Add("Peter", 6);
            studentsMarks.Add("Maria", 6);
            studentsMarks.Add("George", 5);

            int peterMark = studentsMarks["Peter"];

            Console.WriteLine("Peter's mark: {0}", peterMark);
            Console.WriteLine("Is Peter in the hash table: {0}", studentsMarks.ContainsKey("Peter"));
            Console.WriteLine("Students and grades:");

            foreach (var pair in studentsMarks)
            {
                Console.WriteLine("{0} --> {1}", pair.Key, pair.Value);
            }

            string studentName = "Ivan";
            if (studentsMarks.TryGetValue(studentName, out int studentMark))
            {
                Console.WriteLine($"{studentName}'s mark: {studentMark}");
            }
            else
            {
                Console.WriteLine($"Student {studentName} not found.");
            }


            if (studentsMarks.ContainsKey(studentName))
            {
                Console.WriteLine($"{studentName}'s mark: {studentsMarks[studentName]}");
            }
            else
            {
                Console.WriteLine($"Student {studentName} not found.");
            }
        }

        public static void CountingWords()
        {
            string text = "a text, some text, just some text";

            IDictionary<string, int> wordsCount = new Dictionary<string, int>();

            string[] words = text.Split(' ', ',', '.');

            foreach (string word in words)
            {
                if (wordsCount.ContainsKey(word))
                {
                    wordsCount[word] = wordsCount[word] + 1;
                }
                else
                {
                    wordsCount[word] = 1;
                }
            }

            Console.WriteLine("--- CountingWords ---");

            foreach (var pair in wordsCount)
            {
                Console.WriteLine("{0} -> {1}", pair.Key, pair.Value);
            }

        }


        public static Dictionary<string, List<Score>> studentGrades = new Dictionary<string, List<Score>>();

        public static void NestedDemo()
        {

            AddGrade("Ivan", "DSA", 1);
            AddGrade("Ivan", "Math", 2);
            AddGrade("Ivan", "Programming", 3);
            AddGrade("Ivan", "Software", 4);

            AddGrade("Maria", "DSA", 1);
            AddGrade("Maria", "Math", 3);

            AddGrade("Peter", "DSA", 2);
            AddGrade("Peter", "Math", 3);

            foreach (var student in studentGrades)
            {
                Console.WriteLine($"Student {student.Key} has scores:");
                foreach (var score in student.Value)
                {
                    Console.WriteLine($"{score.Subject} ==> {score.Grade}");
                }
            }

        }

        private static void AddGrade(string studentName, string subjectName, int grade)
        {
            if (!studentGrades.ContainsKey(studentName))
            {
                studentGrades[studentName] = new List<Score>();
            }

            Score score = new Score { Subject = subjectName, Grade = grade };

            studentGrades[studentName].Add(score);
        }


        public static void CountingWordsSorted()
        {
            string text = "a text, some text, just some text";

            IDictionary<string, int> wordsCount = new SortedDictionary<string, int>();

            string[] words = text.Split(' ', ',', '.');

            foreach (string word in words)
            {
                if (wordsCount.ContainsKey(word))
                {
                    wordsCount[word] = wordsCount[word] + 1;
                }
                else
                {
                    wordsCount[word] = 1;
                }
            }

            Console.WriteLine("--- CountingWordsSorted ---");

            foreach (var pair in wordsCount)
            {
                Console.WriteLine("{0} -> {1}", pair.Key, pair.Value);
            }

        }

        public static void PointsPlayground()
        {
            SortedDictionary<Point, string> planets = new SortedDictionary<Point, string>();

            Point point1 = new Point { X = 1, Y = 12 };

            Point point2 = new Point { X = 1, Y = 2 };

            planets.Add(point1, "Earth");
            planets.Add(point2, "Mars");

            foreach (var pair in planets)
            {
                Console.WriteLine("{0} {1} -> {2}", pair.Key.X, pair.Key.Y, pair.Value);
            }
        }


        public static void HasSets1()
        {
            ISet<string> firstSet = new HashSet<string>(
                new string[] { "SQL", "Java", "C#", "PHP" });

            ISet<string> secondSet = new HashSet<string>(
               new string[] { "Oracle", "SQL", "MySQL" });

            ISet<string> union = new HashSet<string>(firstSet);

            union.UnionWith(secondSet);

            List<int> strings = new List<int> { 1, 1, 1, 2, 2, 2, 3, 3, 3 };
            var stringSet = strings.ToHashSet();

            foreach (var element in union)
            {
                Console.Write("{0} ", element);
            }
            Console.WriteLine();

        }
    }
}
