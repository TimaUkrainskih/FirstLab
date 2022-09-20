using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    public class Rectangle
    {
        public double side1_;
        public double side2_;
        double area_;
        double perimeter_;
        public double Perimeter { get { return perimeter_; } }

        public double Area { get { return area_; } }
        public Rectangle()
        {
            this.side1_ = 0;
            this.side2_ = 0;
        }
        public Rectangle(double sideA, double sideB)
        {
            this.side1_ = sideA;
            this.side2_ = sideB;
            this.perimeter_ = PerimeterCalculator();
            this.area_ = AreaCalculator();
        }
        public double AreaCalculator()
        {
            return side1_ * side2_;
        }

        public double PerimeterCalculator()
        {
            return side1_ * 2 + side2_ * 2;
        }



    }
}
