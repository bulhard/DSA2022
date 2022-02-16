using System.Text;

namespace Lesson_03_Trees.DirectoryTraversal.Logger
{
    public class StringBuilderLogger : ILogger
    {
        private readonly StringBuilder log = new StringBuilder();

        public void Log(string format, params object[] parameters)
        {
            log.AppendLine(string.Format(format, parameters));
        }

        public string GetAllText()
        {
            return log.ToString();
        }
    }
}