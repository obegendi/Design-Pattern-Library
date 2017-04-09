using System;
using SingletonSample.Core.Factories;
using SingletonSample.Interfaces;

namespace SingletonSample.Core
{
    public class NumbersToTextFile : INumbersToTextFile
    {
        private readonly IFileLoggerFactory _fileLoggerFactory;

        private int _maxIntegerToWrite = 100;

        public NumbersToTextFile(IFileLoggerFactory fileLoggerFactory)
        {
            _fileLoggerFactory = fileLoggerFactory;
        }

        public void WriteNumbersToFile()
        {
            Console.WriteLine("Begin Logging to File");
            var generator = new NumberGenerator();
            IFileLogger myLogger = null;
            foreach (long integer in generator.Integers())
            {
                Console.Write(".");
                myLogger = _fileLoggerFactory.Create();
                myLogger.WriteLineToFile("Getting next number...");
                myLogger.WriteLineToFile("Logged Number: " + integer);

                // this is inefficient...
                if (_fileLoggerFactory is InstanceFileLoggerFactory)
                    myLogger.CloseFile();

                if (integer >= _maxIntegerToWrite)
                    break;
            }
            myLogger.CloseFile();
            Console.WriteLine();
        }

        public int MaxIntegerToWrite
        {
            set { _maxIntegerToWrite = value; }
        }
    }
}