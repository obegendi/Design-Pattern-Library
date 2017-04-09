using System;
using System.Threading.Tasks;
using SingletonSample.Interfaces;

namespace SingletonSample.Core
{
    public class NumbersToTextFileAsync : INumbersToTextFile
    {
        private readonly IFileLoggerFactory _fileLoggerFactory;

        private int _maxIntegerToWrite = 100;

        public NumbersToTextFileAsync(IFileLoggerFactory fileLoggerFactory)
        {
            _fileLoggerFactory = fileLoggerFactory;
        }

        public int MaxIntegerToWrite
        {
            set { _maxIntegerToWrite = value; }
        }

        public void WriteNumbersToFile()
        {
            Console.WriteLine("Begin Logging to File");
            var generator = new NumberGenerator();
            IFileLogger myLogger = null;

            Action<int> logToFile = i =>
            {
                Console.Write(".");
                myLogger = _fileLoggerFactory.Create();
                myLogger.WriteLineToFile("Getting next number...");
                myLogger.WriteLineToFile("Logged Number: " + i);
            };
            Parallel.For(0, _maxIntegerToWrite, logToFile);

            myLogger.CloseFile();
            Console.WriteLine();
        }
    }
}