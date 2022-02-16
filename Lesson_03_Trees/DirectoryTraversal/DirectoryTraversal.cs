using Lesson_03_Trees.DirectoryTraversal.Logger;
using System;
using System.Diagnostics;

namespace Lesson_03_Trees.DirectoryTraversal
{
    public static class DirectoryTraversal
    {
        /*
         * 2. Write a program to traverse the directory C:\WINDOWS and all its
         * subdirectories recursively and to display all files matching the mask *.exe.
         * Use the class System.IO.Directory.
         */

        public static readonly Stopwatch Stopwatch = new Stopwatch();

        public const string DirectoryPath = @"C:\Program Files\";

        public static void Run()
        {
            Console.Write("Click [ENTER] to start directory traversion...");
            Console.ReadKey(false);

            Stopwatch.Start();
            {
                var logger = new StringBuilderLogger();

                TraverseDirectory(DirectoryPath, new DirectoryTraversalFunctions(logger));

                Console.WriteLine(logger.GetAllText());
            }
            Stopwatch.Stop();

            Console.WriteLine("Elapsed time: {0}\n", Stopwatch.Elapsed);
        }

        public static void TraverseDirectory(string directoryPath, DirectoryTraversalFunctions directoryTraversalFunctions)
        {
            directoryTraversalFunctions.TraverseDirectory(directoryPath);
        }
    }
}