﻿using Tyuiu.TsarevDT.Sprint1.Task7.V18.Lib;
namespace Tyuiu.TsarevDT.Sprint1.Task7.V18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Царёв Д. И. | СМАРТб-24-1";
            Console.WriteLine("*************************************************************************");
            Console.WriteLine("* Спринт #1                                                             *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту               *");
            Console.WriteLine("* Задание #7                                                            *");
            Console.WriteLine("* Варинат #18                                                           *");
            Console.WriteLine("* Выполнил: Царёв Даниил Ильич | СМАРТб-24-1                            *");
            Console.WriteLine("*************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                              *");
            Console.WriteLine("* Написать  программу, которая вычисляет выражение                      *");
            Console.WriteLine("* ((1+sin^2(x+y)) / (2+|x-(2x)/(1+x^2*y^2))|) + x                       *");
            Console.WriteLine("* и печатает результат на экране.                                       *");
            Console.WriteLine("*                                                                       *");
            Console.WriteLine("*************************************************************************");
            Console.WriteLine("* ИССХОДНЫЕ ДАННЫЕ:                                                     *");

            double x, y;
            Console.WriteLine("Введите значение X");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение Y");
            y = Convert.ToDouble(Console.ReadLine());

           
            Console.WriteLine("*************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                            *");
            Console.WriteLine("*************************************************************************");

            Console.WriteLine(ds.Calculate(x, y));
            Console.ReadKey(); 
        }
    }
}