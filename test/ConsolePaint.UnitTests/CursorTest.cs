using NUnit.Framework;

namespace ConsolePaint.UnitTests
{
    public class Tests
    {
        [Test]
        public void ToString_SomePosition_ShouldBeDescriptive()
        {
            var cursor = new Cursor(ln: 17, col: 23);
            var actual = cursor.ToString();
            Assert.AreEqual("Ln: 17, Col: 23", actual);
        }

        [Test]
        public void CarriageReturn_SameLineCol0()
        {
            var cursor = new Cursor(ln: 17, col: 23);
            var actual = cursor.CarriageReturn();
            var expected = new Cursor(ln: 17, col: 0);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void NewLine_NextLineCol0()
        {
            var cursor = new Cursor(ln: 17, col: 23);
            var actual = cursor.NewLine();
            var expected = new Cursor(ln: 18, col: 0);
            Assert.AreEqual(expected, actual);
        }
    }
}
