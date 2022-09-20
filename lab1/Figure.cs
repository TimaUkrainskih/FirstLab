using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lab1;

namespace lab1
{
    public class Figure
    {
        public Point point_one_;
        public Point point_two_;
        public Point point_three_;
        public Point point_four_;
        public Point point_five_;
        public string key;

        public Figure(Point point_one,Point point_two)
        {
            point_one_ = point_one;
            point_two_ = point_two;
        }
        public Figure(Point point_one, Point point_two, Point point_three)
        {
            this.point_one_ = point_one;
            this.point_two_ = point_two;
            this.point_three_ = point_three;
            this.key = "Triangle";

        }

        public Figure(Point point_one, Point point_two, Point point_three, Point point_four)
        {
            this.point_one_ = point_one;
            this.point_two_ = point_two;
            this.point_three_ = point_three;
            this.point_four_ = point_four;
            this.key = "Square";
        }
        public Figure(Point point_one, Point point_two, Point point_three, Point point_four, Point point_five)
        {
            this.point_one_ = point_one;
            this.point_two_ = point_two;
            this.point_three_ = point_three;
            this.point_four_ = point_four;
            this.point_five_ = point_five;
            this.key = "Pentagon";
        }

        public double LengthSide(Point A, Point B)
        {
            return Math.Sqrt(Math.Pow((B.x_ - A.x_), 2) + Math.Pow((B.y_ - A.y_), 2));
        }

        public double PerimeterCalculator()
        {
            double result = LengthSide(point_one_, point_two_);
            if (this.key == "Triangle") result += LengthSide(point_two_, point_three_) + LengthSide(point_three_, point_one_);

            if (this.key == "Square") result += LengthSide(point_two_, point_three_) + LengthSide(point_three_, point_four_) +
                    LengthSide(point_four_, point_one_);

            if (this.key == "Pentagon") result += LengthSide(point_two_, point_three_) + LengthSide(point_three_, point_four_) +
                    LengthSide(point_four_, point_five_) + LengthSide(point_five_, point_one_);


            return result;

        }

        public void Print()
        {

            if (this.key == "Triangle")
            {
                Console.WriteLine($"Фигура: {this.key}\nПериметр = {this.PerimeterCalculator()}");
            }
            if (this.key == "Square")
            {
                Console.WriteLine($"Фигура: {this.key}\nПериметр = {this.PerimeterCalculator()}");
            }
            if (this.key == "Pentagon")
            {
                Console.WriteLine($"Фигура: {this.key}\nПериметр = {this.PerimeterCalculator()}");
            }
        }
    }
}
