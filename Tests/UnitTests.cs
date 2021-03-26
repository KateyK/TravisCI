using System;
using NUnit.Framework;

namespace TravisCILab
{
    [TestFixture]
    public class Math
    {
    //ADD
        [Test]
        public void Add_Valid_KRULL()
        {
            Assert.AreEqual(3, Program.Add("1", "2"));
            Assert.AreEqual(5, Program.Add("3", "2"));
            Assert.AreEqual(12, Program.Add("5", "7"));
        }

        [Test]
        public void Add_Invalid_KRULL()
        {
            Assert.Throws<FormatException>(() => Program.Add("1", "a"));
            Assert.Throws<FormatException>(() => Program.Add("a", "1"));
            Assert.Throws<FormatException>(() => Program.Add("a", "a"));
        }

        [Test]
        public void Add_Null_KRULL()
        {
            Assert.Throws<ArgumentNullException>(() => Program.Add("1", null));
            Assert.Throws<ArgumentNullException>(() => Program.Add(null, "1"));
            Assert.Throws<ArgumentNullException>(() => Program.Add(null, null));
        }

        // Implement 3 tests per operation, following a similar pattern as above

    //SUB
        [Test]
        public void Subtract_Valid_KRULL()
        {
            Assert.AreEqual(4, Program.Subtract("6", "2"));
            Assert.AreEqual(-2, Program.Subtract("4", "6"));
            Assert.AreEqual(1, Program.Subtract("4", "3"));
        }

        [Test]
        public void Subtract_Invalid_KRULL()
        {
            Assert.Throws<FormatException>(() => Program.Subtract("1", "a"));
            Assert.Throws<FormatException>(() => Program.Subtract("a", "1"));
            Assert.Throws<FormatException>(() => Program.Subtract("a", "a"));
        }

        [Test]
        public void Subtract_Null_KRULL()
        {
            Assert.Throws<ArgumentNullException>(() => Program.Subtract("1", null));
            Assert.Throws<ArgumentNullException>(() => Program.Subtract(null, "1"));
            Assert.Throws<ArgumentNullException>(() => Program.Subtract(null, null));
        }

    //MULT
        [Test]
        public void Multiply_Valid_KRULL()
        {
            Assert.AreEqual(12, Program.Multiply("3", "4"));
            Assert.AreEqual(-2, Program.Multiply("-1", "2"));
            Assert.AreEqual(3, Program.Multiply("3", "1"));
        }

        [Test]
        public void Multiply_Invalid_KRULL()
        {
            Assert.Throws<FormatException>(() => Program.Multiply("1", "a"));
            Assert.Throws<FormatException>(() => Program.Multiply("a", "1"));
            Assert.Throws<FormatException>(() => Program.Multiply("a", "a"));
        }

        [Test]
        public void Multiply_Null_KRULL()
        {
            Assert.Throws<ArgumentNullException>(() => Program.Multiply("1", null));
            Assert.Throws<ArgumentNullException>(() => Program.Multiply(null, "1"));
            Assert.Throws<ArgumentNullException>(() => Program.Multiply(null, null));
        }

    //DIV
        [Test]
        public void Divide_Valid_KRULL()
        {
            Assert.AreEqual(4, Program.Divide("12", "3"));
            Assert.AreEqual(5, Program.Divide("20", "4"));
            Assert.AreEqual(-3, Program.Divide("-12", "4"));
        }

        [Test]
        public void Divide_Invalid_KRULL()
        {
            Assert.Throws<FormatException>(() => Program.Divide("1", "a"));
            Assert.Throws<FormatException>(() => Program.Divide("a", "1"));
            Assert.Throws<FormatException>(() => Program.Divide("a", "a"));
        }

        [Test]
        public void Divide_Null_KRULL()
        {
            Assert.Throws<ArgumentNullException>(() => Program.Divide("1", null));
            Assert.Throws<ArgumentNullException>(() => Program.Divide(null, "1"));
            Assert.Throws<ArgumentNullException>(() => Program.Divide(null, null));
        }

    //POW
        [Test]
        public void Power_Valid_KRULL()
        {
            Assert.AreEqual(9, Program.Power("3", "2"));
            Assert.AreEqual(4, Program.Power("2", "2"));
            Assert.AreEqual(25, Program.Power("5", "2"));
        }

        [Test]
        public void Power_Invalid_KRULL()
        {
            Assert.Throws<FormatException>(() => Program.Power("1", "a"));
            Assert.Throws<FormatException>(() => Program.Power("a", "1"));
            Assert.Throws<FormatException>(() => Program.Power("a", "a"));
        }

        [Test]
        public void Power_Null_KRULL()
        {
            Assert.Throws<ArgumentNullException>(() => Program.Power("1", null));
            Assert.Throws<ArgumentNullException>(() => Program.Power(null, "1"));
            Assert.Throws<ArgumentNullException>(() => Program.Power(null, null));
        }
    }
}
