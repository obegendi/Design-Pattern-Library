namespace SingletonSample.Singleton
{
    public class LazySingleton
    {
        private LazySingleton()
        {
        }

        public static LazySingleton Instance
        {
            get { return Nested.instance; }
        }

        private class Nested
        {
            internal static readonly LazySingleton instance = new LazySingleton();

            static Nested()
            {
            }
        }
    }
}