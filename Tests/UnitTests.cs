using System;
using NUnit.Framework;

namespace TravisCILab
{
    [TestFixture]
    public class Math
    {
        [Test]
        public void Add_Valid()
        {
            Assert.AreEqual(3, Program.Add("1", "2"));
            Assert.AreEqual(5, Program.Add("3", "2"));
            Assert.AreEqual(12, Program.Add("5", "7"));
        }

        [Test]
        public void Add_Invalid()
        {
            Assert.Throws<FormatException>(() => Program.Add("1", "a"));
            Assert.Throws<FormatException>(() => Program.Add("a", "1"));
            Assert.Throws<FormatException>(() => Program.Add("a", "a"));
        }

        [Test]
        public void Add_Null()
        {
            Assert.Throws<ArgumentNullException>(() => Program.Add("1", null));
            Assert.Throws<ArgumentNullException>(() => Program.Add(null, "1"));
            Assert.Throws<ArgumentNullException>(() => Program.Add(null, null));
        }

        // Implement 3 tests per operation, following a similar pattern as above
        [Test]
        public void Subtract1()
        {
            Assert.IsTrue(true);
        }

        [Test]
        public void Subtract2()
        {
            Assert.IsTrue(true);
        }

        [Test]
        public void Subtract3()
        {
            Assert.IsTrue(true);
        }

        [Test]
        public void Multiply1()
        {
            Assert.IsTrue(true);
        }

        [Test]
        public void Multiply2()
        {
            Assert.IsTrue(true);
        }

        [Test]
        public void Multiply3()
        {
            Assert.IsTrue(true);
        }

        [Test]
        public void Divide1()
        {
            Assert.IsTrue(true);
        }

        [Test]
        public void Divide2()
        {
            Assert.IsTrue(true);
        }

        [Test]
        public void Divide3()
        {
            Assert.IsTrue(true);
        }

        [Test]
        public void Power1()
        {
            Assert.IsTrue(true);
        }

        [Test]
        public void Power2()
        {
            Assert.IsTrue(true);
        }

        [Test]
        public void Power3()
        {
            Assert.IsTrue(true);
        }
    }
}
