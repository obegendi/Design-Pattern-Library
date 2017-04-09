using SimpleInjector;

namespace SingletonSample
{
    public static class IoC
    {
        private static Container _container;

        public static void Initialize(Container container)
        {
            _container = container;
        }

        public static TBase Resolve<TBase>() where TBase : class
        {
            return _container.GetInstance<TBase>();
        }
    }
}