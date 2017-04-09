namespace SingletonSample.Core.FileLoggers
{
    /// <summary>
    ///     A non-singleton implementation of a file logger
    /// </summary>
    public class FileLoggerLazySingleton : BaseFileLogger
    {
        private FileLoggerLazySingleton()
        {
        }

        #region Lazy Singleton Implementation

        public static FileLoggerLazySingleton Instance
        {
            get { return Nested.instance; }
        }

        private class Nested
        {
            internal static readonly FileLoggerLazySingleton instance = new FileLoggerLazySingleton();
            // Explicit static constructor to tell C# compiler not to mark as beforefieldinit
            // http://csharpindepth.com/Articles/General/Singleton.aspx
            static Nested()
            {
            }
        }

        #endregion
    }
}