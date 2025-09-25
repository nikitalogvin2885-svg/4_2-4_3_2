//16
using System;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длины трех сторон треугольника:");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            bool isTrianglePossible = IsTrianglePossible(a, b, c);
            Console.WriteLine(isTrianglePossible ? "Треугольник можно построить." : "Треугольник нельзя построить.");
        }

        static bool IsTrianglePossible(int a, int b, int c)
        {
            return a + b > c && a + c > b && b + c > a;
        }
    }
}
