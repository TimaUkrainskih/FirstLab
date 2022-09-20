using lab1;
using System;
namespace exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Первое задание");
            Console.WriteLine($"byte\nmax: {byte.MaxValue} min: {byte.MinValue}" +
                $"\nsbyte\nmax: {sbyte.MaxValue} min: {sbyte.MinValue}" +
                $"\nshort\nmax: {short.MaxValue} min: {short.MinValue}" +
                $"\nushort\nmax: {ushort.MaxValue} min: {ushort.MinValue}" +
                $"\nint\nmax: {int.MaxValue} min: {int.MinValue}" +
                $"\nuint\nmax: {uint.MaxValue} min: {uint.MinValue}" +
                $"\nlong\nmax: {long.MaxValue} min: {long.MinValue}" +
                $"\nulong\nmax: {ulong.MaxValue} min: {ulong.MinValue}" +
                $"\nfloat\nmax: {float.MaxValue} min: {float.MinValue}" +
                $"\ndoable\nmax: {double.MaxValue} min: {double.MinValue}" );

            Console.WriteLine("\n\nВторое задание");
            Console.Write("введите длины сторон\nдлина первой стороны: ");
            double side1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("длина второй стороны: ");
            double side2 = Convert.ToDouble(Console.ReadLine());
            Rectangle tom = new Rectangle(side1, side2);
            Console.WriteLine($"Площадь: {tom.Area}");

            Console.WriteLine("\n\nТретье задание");
            Point point1 = new Point(4, 3);
            Point point2 = new Point(1, 1);
            Point point3 = new Point(2, 5);
            Point point4 = new Point(3, 1);
            
            Figure figur = new Figure(point1, point2, point3,point4);
            
            figur.Print();
           

        }





    }





}






