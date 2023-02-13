using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleCreater
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длины сторон треугольника:");
            Console.WriteLine("Сторона A = ");
            double edgeA = double.Parse(Console.ReadLine());
            Console.WriteLine("Сторона B = ");
            double edgeB = double.Parse(Console.ReadLine());
            Console.WriteLine("Сторона C = ");
            double edgeC = double.Parse(Console.ReadLine());
            TriangleCalculator Triangle = new TriangleCalculator();
            Triangle.CheckTriangleType(edgeA, edgeB, edgeC);
            Console.ReadKey();
        }
    }
}
