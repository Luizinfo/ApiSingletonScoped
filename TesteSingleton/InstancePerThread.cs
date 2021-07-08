using System.Threading;

namespace TesteSingleton
{
    public sealed class InstancePerThread
    {
        private static ThreadLocal<InstancePerThread> instances = new ThreadLocal<InstancePerThread>(() => new InstancePerThread());

        private InstancePerThread()
        {
        }

        public static InstancePerThread Instance
        {
            get { return instances.Value; }
        }

        public int Count { get; set; }
    }
}