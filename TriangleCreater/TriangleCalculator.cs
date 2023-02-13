using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace TriangleCreater
{
    public class TriangleCalculator
    { 
        public TriangleType CheckTriangleType(double edgeA, double edgeB, double edgeC)
        {
            if(edgeA + edgeB > edgeC && edgeA + edgeC > edgeB && edgeB + edgeC > edgeA)
            {
                if(edgeA == edgeB && edgeA == edgeC && edgeB == edgeC)
                {
                    Console.WriteLine("Тип треугольника: Равносторонний");
                    
                    return TriangleType.Equilateral;
                }
                else if(edgeA == edgeB || edgeA == edgeC || edgeB == edgeC)
                {
                    Console.WriteLine("Тип треугольника: Равнобедренный");
                    
                    return TriangleType.Isosceles;
                }
                else if (edgeA != edgeB && edgeA != edgeC && edgeB != edgeC)
                {
                    Console.WriteLine("Тип треугольника: Разносторонний");
                    
                    return TriangleType.Versatile;
                }
            }
            Console.WriteLine(" Такой треугольник невозможен!");
            return TriangleType.Impossible;
        }
    }
}
