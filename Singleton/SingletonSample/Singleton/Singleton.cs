namespace SingletonSample.Singleton
{
    public class Singleton
    {
        private static Singleton _instance;

        private Singleton()
        {
        }

        public static Singleton Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Singleton();
                return _instance;
            }
        }

        public void DoStuff()
        {
        }
    }

    public class SampleUsage
    {
        public void SomeMethod()
        {
            // Call Singleton's DoStuff() method
            Singleton.Instance.DoStuff();

            // Assign to another variable
            var myObject = Singleton.Instance;
            myObject.DoStuff();

            // Pass as parameter
            SomeOtherMethod(Singleton.Instance);
        }

        private void SomeOtherMethod(Singleton singleton)
        {
            singleton.DoStuff();
        }
    }
}