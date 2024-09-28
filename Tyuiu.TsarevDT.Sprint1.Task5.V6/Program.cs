using Tyuiu.TsarevDT.Sprint1.Task5.V6.Lib;
namespace Tyuiu.TsarevDT.Sprint1.Task5.V6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Царёв Д. И. | СМАРТб-24-1";
            Console.WriteLine("*************************************************************************");
            Console.WriteLine("* Спринт #1                                                             *");
            Console.WriteLine("* Тема: Преобразование типов и класс Convert                            *");
            Console.WriteLine("* Задание #5                                                            *");
            Console.WriteLine("* Варинат #6                                                            *");
            Console.WriteLine("* Выполнил: Царёв Даниил Ильич | СМАРТб-24-1                            *");
            Console.WriteLine("*************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                              *");
            Console.WriteLine("* Написать программу, которая решает следующую задачу:                  *");
            Console.WriteLine("* Пусть k – целое от 1 до 365. Присвоить целой переменной n значение    *");
            Console.WriteLine("* 1,2,...,7 в зависимости от того, на какой день недели                 *");
            Console.WriteLine("* (понедельник, вторник,..., воскресенье) приходится k-й день           *");
            Console.WriteLine("* невисокосного года, в котором 1 января – понедельник.                 *");
            Console.WriteLine("*************************************************************************");
            Console.WriteLine("* ИССХОДНЫЕ ДАННЫЕ:                                                     *");
            Console.WriteLine("*************************************************************************");
            double k;
            Console.WriteLine("Введите число от 1 до 365 ");
            k = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("*************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                            *");
            Console.WriteLine("*************************************************************************");

            Console.WriteLine(ds.Calculate(Convert.ToInt32(k)));
            Console.ReadKey();
        }
    }
}
