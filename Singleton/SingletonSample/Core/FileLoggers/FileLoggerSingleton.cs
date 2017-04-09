namespace SingletonSample.Core.FileLoggers
{
    /// <summary>
    ///     A non-thread-safe FileLogger Singleton implementation
    /// </summary>
    public sealed class FileLoggerSingleton : BaseFileLogger
    {
        private static FileLoggerSingleton _instance;

        private FileLoggerSingleton()
        {
        }

        public static FileLoggerSingleton Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new FileLoggerSingleton();
                return _instance;
            }
        }
    }
}