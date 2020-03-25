using System;

namespace WorkWithClass
{
    class Program
    {
        static void Main(string[] args)
        {
            EqTriangle firstTriangle = new EqTriangle();
            EqTriangle secondTriangle = new EqTriangle(5.5, 3.4, 4.5);
            EqTriangle thirdTriangle = new EqTriangle(3.6, 3.6, 3.6);
            EqTriangle fourthTriangle = new EqTriangle(thirdTriangle);

            Console.WriteLine("Является ли треугольник равносторонним:");
            Console.WriteLine("Первый треугольник: " + firstTriangle.DoesThisTriangleExist().ToString());
            Console.WriteLine("Второй треугольник: " + secondTriangle.DoesThisTriangleExist().ToString());
            Console.WriteLine("Третий треугольник: " + thirdTriangle.DoesThisTriangleExist().ToString());
            Console.WriteLine("Четвертый треугольник: " + fourthTriangle.DoesThisTriangleExist().ToString());
            Console.WriteLine("\n-------------------------------------------\n");

            Console.WriteLine("Вычисление периметра:");
            Console.WriteLine("Первый треугольник: " + firstTriangle.Perimeter().ToString());
            Console.WriteLine("Второй треугольник: " + secondTriangle.Perimeter().ToString());
            Console.WriteLine("Третий треугольник: " + thirdTriangle.Perimeter().ToString());
            Console.WriteLine("Четвертый треугольник: " + fourthTriangle.Perimeter().ToString());
            Console.WriteLine("\n-------------------------------------------\n");

            Console.WriteLine("Вычисление площади:");
            Console.WriteLine("Первый треугольник: " + firstTriangle.Square().ToString());
            Console.WriteLine("Второй треугольник: " + secondTriangle.Square().ToString());
            Console.WriteLine("Третий треугольник: " + thirdTriangle.Square().ToString());
            Console.WriteLine("Четвертый треугольник: " + fourthTriangle.Square().ToString());
            Console.WriteLine("\n-------------------------------------------\n");

            Console.ReadLine();
        }
    }
}
