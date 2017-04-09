using System;
using System.Diagnostics;
using System.IO;
using SingletonSample.Core;
using SingletonSample.Interfaces;

namespace SingletonSample
{
    internal class Program
    {
        private const bool _useParallel = true;
        private static DependencyResolver _dependencyResolver;
        private static INumbersToTextFile _numbersToTextFile;

        private static void RegisterTypes()
        {
            _dependencyResolver = new DependencyResolver();
            _dependencyResolver.EnsureDependenciesRegistered();
            if (_useParallel)
            {
                _dependencyResolver.Container.Register<INumbersToTextFile, NumbersToTextFileAsync>();
            }
            else
            {
                _dependencyResolver.Container.Register(typeof(INumbersToTextFile), typeof(NumbersToTextFile));
            }
        }

        private static void Main(string[] args)
        {
            RegisterTypes();
            File.Delete(@"c:\dev\scratch\logs\logfile.txt");

            var stopwatch = new Stopwatch();
            stopwatch.Start();

            _numbersToTextFile = _dependencyResolver.Container.GetInstance<INumbersToTextFile>();
            _numbersToTextFile.MaxIntegerToWrite = 100;
            _numbersToTextFile.WriteNumbersToFile();

            stopwatch.Stop();
            Console.WriteLine("Time Elapsed: {0}", stopwatch.Elapsed);

            Console.ReadLine();
        }
    }
}
