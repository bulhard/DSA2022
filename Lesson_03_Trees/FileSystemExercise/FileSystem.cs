using Lesson_03_Trees.FileSystemExercise.FileSystemMan;
using System;
using System.Diagnostics;

namespace Lesson_03_Trees.FileSystemExercise
{
    public class FileSystem
    {
        public static readonly Stopwatch Stopwatch = new Stopwatch();

        public const string DirectoryPath = @"C:\Program Files";

        public static void Run()
        {
            Stopwatch.Start();
            {
                Console.Write("Loading...");

                var fileSystem = new FileSystemManager();
                fileSystem.BuildDirectoryTree(DirectoryPath);

                Console.WriteLine("\rTotal folders: {0}\n", fileSystem.Paths.Count);

                var baseFolder = fileSystem[DirectoryPath];
                PrintFolderInformation(baseFolder, fileSystem, prefix: "Base ");

                foreach (var childFolder in baseFolder.ChildFolders)
                {
                    PrintFolderInformation(childFolder, fileSystem, prefix: "    ");
                }
            }
            Stopwatch.Stop();

            Console.WriteLine("\nElapsed time: {0}\n", Stopwatch.Elapsed);
        }

        private static void PrintFolderInformation(Folder folder, FileSystemManager fileSystem, string prefix = null)
        {
            var folderSize = fileSystem.CalculateSumOfFilesSizeInSubtree(folder);
            Console.WriteLine("{2}{0} | Size: {1} bytes", folder, folderSize, prefix);
        }
    }
}