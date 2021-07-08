using NUnit.Framework;
using System.Threading;

namespace TesteSingleton
{
    public class UnitTestSingleton
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void SimpleSingletonTest()
        {
            var obj1 = CurrentSingleton.Instance;
            obj1.Count = 1;
            Assert.AreEqual(1, obj1.Count);

            var obj2 = CurrentSingleton.Instance;
            Assert.AreEqual(1, obj2.Count);

            var obj3 = InstancePerThread.Instance;
            obj3.Count = 1;
            Assert.AreEqual(1, obj3.Count);

            var obj4 = InstancePerThread.Instance;
            Assert.AreEqual(1, obj4.Count);
        }

        [Test]
        public void UniqueThreadTest()
        {
            var t1 = new Thread(() =>
            {
                var singleton1 = CurrentSingleton.Instance;
                singleton1.Count = 1;
                Assert.AreEqual(1, singleton1.Count);
            });

            var t2 = new Thread(() =>
            {
                var singleton2 = CurrentSingleton.Instance;
                Assert.AreEqual(1, singleton2.Count);
            });

            t1.Start();
            t2.Start();
        }

        [Test]
        public void MultiThreadTest()
        {
            var t1 = new Thread(() =>
            {
                var singleton1 = InstancePerThread.Instance;
                singleton1.Count = 1;
                Assert.AreEqual(1, singleton1.Count);
            });

            var t2 = new Thread(() =>
            {
                var singleton2 = InstancePerThread.Instance;
                Assert.AreNotEqual(1, singleton2.Count);

                singleton2.Count = 2;
                Assert.AreEqual(2, singleton2.Count);

                var singleton3 = InstancePerThread.Instance;
                Assert.AreEqual(2, singleton3.Count);
            });

            t1.Start();
            t2.Start();
        }
    }
}