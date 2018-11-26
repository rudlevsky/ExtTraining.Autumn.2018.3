namespace No4.Solution.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var randByte = new RandomBytesFileGenerator();

            randByte.GenerateFiles(1, 100);

            var randChar = new RandomCharsFileGenerator();

            randChar.GenerateFiles(1, 100);
        }
    }
}
