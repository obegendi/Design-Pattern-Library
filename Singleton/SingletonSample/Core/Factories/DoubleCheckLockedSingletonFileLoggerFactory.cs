using SingletonSample.Core.FileLoggers;
using SingletonSample.Interfaces;

namespace SingletonSample.Core.Factories
{
    public class DoubleCheckLockedSingletonFileLoggerFactory : IFileLoggerFactory
    {
        public IFileLogger Create()
        {
            return FileLoggerDoubleCheckLocking.Instance;
        }
    }
}