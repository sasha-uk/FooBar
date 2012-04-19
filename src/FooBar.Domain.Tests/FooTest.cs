using NUnit.Framework;

namespace FooBar.Domain.Tests
{
    [TestFixture]
    public class FooTest
    {
        [Test]
        public void Test()
        {
            var actual = new Foo();
            Assert.That(actual, Is.Not.Null);
        }
    }
}