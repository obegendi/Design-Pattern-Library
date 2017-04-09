using SimpleInjector;
using SingletonSample.Core;
using SingletonSample.Core.Factories;
using SingletonSample.Interfaces;

namespace SingletonSample
{
    public class DependencyResolver
    {
        private static readonly Container _container;

        static DependencyResolver()
        {
            _container = new Container();
            IoC.Initialize(_container);
        }

        public Container Container => _container;

        public void EnsureDependenciesRegistered()
        {
            _container.Register<IFileLoggerFactory, LazySingletonFileLoggerFactory>();
            _container.Register<IDelayConfig, DefaultDelayConfig>();
        }
    }
}