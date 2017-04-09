using System;
using System.IO;
using System.Linq;
using SimpleInjector;
using SingletonSample.Core;
using SingletonSample.Interfaces;
using Xunit;
using Xunit.Sdk;

namespace SingletonSample.Test
{
    public class MultipleThreadsFileLogger : IDisposable
    {
        private Container _container;
        private INumbersToTextFile _numbersToTextFile;

        [Fact]
        [InlineData()]
        public void Setup()
        {
            File.Delete(@"c:\dev\scratch\logs\logfile.txt");
            _container = new SimpleInjector.Container();
            _container.Register<INumbersToTextFile, NumbersToTextFileAsync>();
            
            IoC.Initialize(_container);

        }
        [Fact]
        public void TestMethod1()
        {
        }

        public void Dispose()
        {
            File.Delete(@"c:\logfile.txt");
            _container?.Dispose();
        }
    }
}
