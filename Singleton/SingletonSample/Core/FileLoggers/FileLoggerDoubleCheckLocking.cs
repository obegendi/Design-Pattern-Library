namespace SingletonSample.Core.FileLoggers
{
    /// <summary>
    ///     A double-check locking implementation of FileLogger
    ///     Note: Dangerous code - easy to get wrong
    /// </summary>
    public class FileLoggerDoubleCheckLocking : BaseFileLogger
    {
        private static FileLoggerDoubleCheckLocking _instance;
        private static readonly object _lock = new object();


        private FileLoggerDoubleCheckLocking()
        {
        }

        public static FileLoggerDoubleCheckLocking Instance
        {
            get
            {
                if (_instance == null)
                    lock (_lock)
                    {
                        if (_instance == null)
                            _instance = new FileLoggerDoubleCheckLocking();
                    }
                return _instance;
            }
        }
    }
}