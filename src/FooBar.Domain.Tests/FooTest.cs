using NUnit.Framework;

namespace FooBar.Domain.Tests
{
    [TestFixture]
    public class FooTest
    {
        [Test]
        public void ShouldSaySomething()
        {
            var foo = new Foo();
            Assert.That(foo.Hello(), Is.Not.Null);
        }

        [Test]
        public void ShouldSayHello()
        {
            var foo = new Foo();
            Assert.That(foo.Hello(), Is.EqualTo("Hello!"));
        }
    }
}