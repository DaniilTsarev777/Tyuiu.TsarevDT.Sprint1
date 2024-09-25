using Tyuiu.TsarevDT.Sprint1.Task2.V27.Lib;
namespace Tyuiu.TsarevDT.Sprint1.Task2.V27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Царёв Д. И. | СМАРТб-24-1";
            Console.WriteLine("*************************************************************************");
            Console.WriteLine("* Спринт #1                                                             *");
            Console.WriteLine("* Тема: Арифметические операторы в C#                                   *");
            Console.WriteLine("* Задание #2                                                            *");
            Console.WriteLine("* Варинат #27                                                           *");
            Console.WriteLine("* Выполнил: Царёв Даниил Ильич | СМАРТб-24-1                            *");
            Console.WriteLine("*************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                              *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные       *");
            Console.WriteLine("* данные, выполняет указанные расчёты и печатает результат на экране.   *");
            Console.WriteLine("*                                                                       *");
            Console.WriteLine("*************************************************************************");
            Console.WriteLine("* ИССХОДНЫЕ ДАННЫЕ:                                                     *");
            Console.WriteLine("*************************************************************************");
            
            int x;
            Console.WriteLine("Введите значение x");
            x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("*************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                            *");
            Console.WriteLine("*************************************************************************");

            Console.WriteLine("Периметр квадрата = " + ds.Calculate(x));
            Console.ReadLine();
        }
    }
}
