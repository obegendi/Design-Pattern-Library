namespace SingletonSample.Core.FileLoggers
{
    /// <summary>
    ///     A thread-safe FileLogger Singleton implementation
    ///     Note that performance may suffer due to locking implementation
    /// </summary>
    public sealed class FileLoggerThreadSafeSingleton : BaseFileLogger
    {
        private static readonly object _lock = new object();
        private static FileLoggerThreadSafeSingleton _instance;

        private FileLoggerThreadSafeSingleton()
        {
        }

        public static FileLoggerThreadSafeSingleton Instance
        {
            get
            {
                // lock occurs on every request for the instance
                lock (_lock)
                {
                    if (_instance == null)
                        _instance = new FileLoggerThreadSafeSingleton();
                    return _instance;
                }
            }
        }
    }
}