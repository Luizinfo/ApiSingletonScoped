using System;

namespace TesteSingleton
{
    public sealed class CurrentSingleton // Seal your singletons if possible
    {
        private static Lazy<CurrentSingleton> uniqueInstance = new Lazy<CurrentSingleton>(() => new CurrentSingleton());

        private CurrentSingleton()
        {
        }

        public static CurrentSingleton Instance  // use a property, since this is C#...
        {
            get { return uniqueInstance.Value; }
        }

        public int Count { get; set; }
    }
}