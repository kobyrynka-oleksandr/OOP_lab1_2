using OOP_lab1_2;
namespace TestTCircle
{
    public class Tests
    {
        [Test]
        public void GetArea_5_returned78()
        {
            double r = 5;
            double expected = 78.53981633974483;

            TCircle circle = new TCircle(r);
            double actual = circle.GetArea;

            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void GetArea_8_returned201()
        {
            double r = 8;
            double expected = 201.06192982974676;

            TCircle circle = new TCircle(r);
            double actual = circle.GetArea;

            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void GetCircuit_5_returned31()
        {
            double r = 5;
            double expected = 31.41592653589793;

            TCircle circle = new TCircle(r);
            double actual = circle.GetCircuit;

            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void GetCircuit_8_returned50()
        {
            double r = 8;
            double expected = 50.26548245743669;

            TCircle circle = new TCircle(r);
            double actual = circle.GetCircuit;

            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void GetVolume_5_5_returned392()
        {
            double r = 5;
            double h = 5;
            double expected = 392.69908169872417;

            TCylinder cylinder = new TCylinder(r, h);
            double actual = cylinder.GetVolume;

            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void GetVolume_8_8_returned392()
        {
            double r = 8;
            double h = 8;
            double expected = 1608.495438637974;

            TCylinder cylinder = new TCylinder(r, h);
            double actual = cylinder.GetVolume;

            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void plus_8_5_returned13()
        {
            double r1 = 8;
            double r2 = 5;
            double expected = 13;

            TCircle circle1 = new TCircle(r1);
            TCircle circle2 = new TCircle(r2);

            TCircle sumOfTriangle = circle1 + circle2;
            double actual = sumOfTriangle.GetRadius;

            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void minus_8_5_returned3()
        {
            double r1 = 8;
            double r2 = 5;
            double expected = 3;

            TCircle circle1 = new TCircle(r1);
            TCircle circle2 = new TCircle(r2);

            TCircle sumOfTriangle = circle1 - circle2;
            double actual = sumOfTriangle.GetRadius;

            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void multiply_8_5_returned40()
        {
            double r = 8;
            double expected = 40;
            double multiplier = 5;

            TCircle circle1 = new TCircle(r);

            TCircle sumOfTriangle = circle1 * multiplier;
            double actual = sumOfTriangle.GetRadius;

            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void multiply_5_10_returned50()
        {
            double r = 5;
            double expected = 50;
            double multiplier = 10;

            TCircle circle1 = new TCircle(r);

            TCircle sumOfTriangle = multiplier * circle1;
            double actual = sumOfTriangle.GetRadius;

            Assert.AreEqual(expected, actual);
        }
    }
}