using SingletonSample.Core.FileLoggers;
using SingletonSample.Interfaces;

namespace SingletonSample.Core.Factories
{
    public class InstanceFileLoggerFactory : IFileLoggerFactory
    {
        public IFileLogger Create()
        {
            return new FileLogger();
        }
    }
}