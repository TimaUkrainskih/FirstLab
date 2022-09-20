using System;
using lab1;


namespace RectangleTest.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void AreaCalculator_Test()
        {
            double expected = 200;

            Rectangle test = new Rectangle(10, 20);
            double actual = test.AreaCalculator();

            Assert.Equal(expected, actual);

        }

        [Fact]
        public void PerimeterCalculator_Test_Rectangle()
        {
            double expected = 30;
            Rectangle test = new Rectangle(7, 8);
            double actual = test.PerimeterCalculator();

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void LengthSide_Test()
        {
            double expected = 5;
            Point point1 = new Point(3, 2);
            Point point2 = new Point(0, 6);
            Figure temp = new Figure(point1, point2);

            double actual = temp.LengthSide(point1, point2);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void PerimeterCalculator_Test_Figur()
        {
            double expected = 12;
            Point point1 = new Point(3, 2);
            Point point2 = new Point(0, 6);
            Point point3 = new Point(0, 2);
            Figure temp = new Figure(point1, point2, point3);

            double actual = temp.PerimeterCalculator();

            Assert.Equal(expected, actual);

        }
    }
}