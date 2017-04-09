using SingletonSample.Core.FileLoggers;
using SingletonSample.Interfaces;

namespace SingletonSample.Core.Factories
{
    public class LockedSingletonFileLoggerFactory : IFileLoggerFactory
    {
        public IFileLogger Create()
        {
            return FileLoggerThreadSafeSingleton.Instance;
        }
    }
}