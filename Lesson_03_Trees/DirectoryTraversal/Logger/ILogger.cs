namespace Lesson_03_Trees.DirectoryTraversal.Logger
{
    public interface ILogger
    {
        void Log(string format, params object[] parameters);

        string GetAllText();
    }
}