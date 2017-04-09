using SingletonSample.Core.FileLoggers;
using SingletonSample.Interfaces;

namespace SingletonSample.Core.Factories
{
    public class LazySingletonFileLoggerFactory : IFileLoggerFactory
    {
        public IFileLogger Create()
        {
            return FileLoggerLazySingleton.Instance;
        }
    }
}