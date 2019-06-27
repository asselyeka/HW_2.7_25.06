using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//7.	Даны радиус круга и сторона квадрата. У какой фигуры площадь больше?

namespace HW_2._7_25._06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите радиус круга r:");
            var rCircle = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите сторонy квадрата x:");
            var xFoursquare = Convert.ToDouble(Console.ReadLine());

            var circleSquare = Math.PI * rCircle * rCircle;
            var foursquareSquare = xFoursquare*xFoursquare;
            Console.Write("Площадь круга: ");
            Console.WriteLine(circleSquare);
            Console.Write("Площадь квадрата: ");
            Console.WriteLine(foursquareSquare);

            if (circleSquare>foursquareSquare) Console.WriteLine("Площадь круга больше, чем площадь квадрата.");
            else Console.WriteLine("Площадь квадрата больше, чем площадь круга.");
            Console.ReadKey();
        }
    }
}
