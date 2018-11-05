using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryApp
{
        public struct Point
        {
            public int X;
            public int Y;

            public Point(int x, int y)
            {
                X = x;
                Y = y;
            }

            public void Move(bool isX, int value)
            {
                if (isX)
                {
                    X += value;
                }
                else
                {
                    Y += value;
                }
            }
        }
        public struct Line
        {
            public Point StartPoint;
            public Point EndPoint;

            public Line(Point startPoint, Point endPoint)
            {
                StartPoint = startPoint;
                EndPoint = endPoint;
            }
            public double GetLength()
            {
                return Math.Sqrt(Math.Pow(EndPoint.X - StartPoint.X, 2) + Math.Pow(EndPoint.Y - StartPoint.Y, 2));
            }
        }
        class Program
        {
            public static int AdvancedParse(string label)
            {
                int a;
                while (true)
                {
                    Console.WriteLine($"Введите {label}");
                    if (int.TryParse(Console.ReadLine(), out a))
                    {
                        return a;
                    }
                    Console.WriteLine("Некоректный ввод");
                }


            }
            static void Main(string[] args)
            {
                int x1 = AdvancedParse("x1");
                int y1 = AdvancedParse("y1");
                int x2 = AdvancedParse("x2");
                int y2 = AdvancedParse("y2");

                Point startPoint = new Point(x1, y1);
                Point endPoint = new Point(x2, y2);
                Line line = new Line(startPoint, endPoint);

                while (true)
                {
                    Console.WriteLine("\nВыбирете действие:\n 1. Узнать длину отрезка \n 2. Изменить координаты точек \n Для завершения работы нажмите Ecs");
                    var Button = Console.ReadKey().Key;
                    switch (Button)
                    {
                        case ConsoleKey.D1:
                            Console.WriteLine($"\n Длина отрезка = {line.GetLength()}");
                            break;
                        case ConsoleKey.D2:
                            break;
                        case ConsoleKey.Escape:
                            System.Environment.Exit(0);
                            break;
                        default:
                            Console.WriteLine("Некоректный ввод");
                            continue;
                    }
                }
            }
        }
}
