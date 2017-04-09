using SingletonSample.Interfaces;

namespace SingletonSample.Core
{
    public class DefaultDelayConfig : IDelayConfig
    {
        public int DelayMilliseconds { get; set; } = 50;
    }
}