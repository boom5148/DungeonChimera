using NUnit.Framework;
using DungeonChimera.util;

namespace UnitTests.UtilTests
{
    [TestFixture]
    class AddterTest
    {
        private Adder _Adder;
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void CanAddTwoNumbers()
        {
            int result = _Adder.Add(1, 1);
            Assert.Pass();
        }
    }
}
