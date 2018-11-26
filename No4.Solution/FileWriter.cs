using System.IO;

namespace No4.Solution
{
    // Выделить базвый класс для общей реализации

    public class FileWriter
    {
        public virtual string WorkingDirectory => "Files with random chars";

        public virtual string FileExtension => ".txt";

        protected virtual void WriteBytesToFile(string fileName, byte[] content)
        {
            if (!Directory.Exists(WorkingDirectory))
            {
                Directory.CreateDirectory(WorkingDirectory);
            }

            File.WriteAllBytes($"{WorkingDirectory}//{fileName}", content);
        }
    }
}
