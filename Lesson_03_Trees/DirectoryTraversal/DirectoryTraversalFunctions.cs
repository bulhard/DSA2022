using Lesson_03_Trees.DirectoryTraversal.Logger;
using System;
using System.IO;

namespace Lesson_03_Trees.DirectoryTraversal
{
    public class DirectoryTraversalFunctions
    {
        private const string FileExtensionToMatch = "*.exe";

        private readonly ILogger logger;

        /// <summary>
        /// Initializes a new instance of the DirectoryTraversalDfs class with specified ILogger.
        /// </summary>
        /// <param name="logger">Logger class implements ILogger interface.</param>
        public DirectoryTraversalFunctions(ILogger logger)
        {
            this.logger = logger;
        }

        /// <summary>
        /// Traverse directory by given path and prints all files matched *.exe file extension.
        /// The traverse strategy is performed via Recursively Depth-First Search algorithm.
        /// </summary>
        /// <param name="directoryPath">The directory path to traverse.</param>
        public void TraverseDirectory(string directoryPath)
        {
            if (string.IsNullOrEmpty(directoryPath))
            {
                throw new ArgumentException("Directory path cannot be null or empty.");
            }

            if (!Directory.Exists(directoryPath))
            {
                throw new ArgumentException("Could not find a path: " + directoryPath);
            }

            var directoryInfo = new DirectoryInfo(directoryPath);
            TraverseDirectory(directoryInfo);
        }

        private void TraverseDirectory(DirectoryInfo dirInfo, string separator = " ")
        {
            foreach (var dir in dirInfo.GetDirectories())
            {
                try
                {
                    foreach (var file in dir.GetFiles(FileExtensionToMatch))
                    {
                        logger.Log("{0}{1}", separator, file.FullName);
                    }

                    TraverseDirectory(dir, separator + " ");
                }
                catch (Exception)
                {
                    continue;
                }
            }
        }
    }
}