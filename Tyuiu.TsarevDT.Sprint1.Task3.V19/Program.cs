using Tyuiu.TsarevDT.Sprint1.Task3.V19.Lib;
namespace Tyuiu.TsarevDT.Sprint1.Task3.V19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #1 | Выполнил: Царёв Д. И. | СМАРТб-24-1";
            Console.WriteLine("*************************************************************************");
            Console.WriteLine("* Спринт #1                                                             *");
            Console.WriteLine("* Тема: Операторы составного присваивания                               *");
            Console.WriteLine("* Задание #3                                                            *");
            Console.WriteLine("* Варинат #19                                                           *");
            Console.WriteLine("* Выполнил: Царёв Даниил Ильич | СМАРТб-24-1                            *");
            Console.WriteLine("*************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                              *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные       *");
            Console.WriteLine("* данные, выполняет указанные расчёты и печатает результат на экране.   *");
            Console.WriteLine("*                                                                       *");
            Console.WriteLine("*************************************************************************");

            double x1, y1, x2, y2;
            Console.WriteLine("Введите значение x1:");
            x1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение y1:");
            y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение x2:");
            x2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение y2:");
            y2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("*************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                            *");
            Console.WriteLine("*************************************************************************");

            Console.WriteLine(ds.ElephCanMove(x1, x2, y1, y2));
            Console.ReadLine();
        }
    }
}
