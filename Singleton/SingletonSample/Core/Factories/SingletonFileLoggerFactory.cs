using SingletonSample.Core.FileLoggers;
using SingletonSample.Interfaces;

namespace SingletonSample.Core.Factories
{
    public class SingletonFileLoggerFactory : IFileLoggerFactory
    {
        public IFileLogger Create()
        {
            return FileLoggerSingleton.Instance;
        }
    }
}