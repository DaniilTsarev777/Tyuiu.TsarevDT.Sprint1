using Tyuiu.TsarevDT.Sprint1.Task6.V14.Lib;
namespace Tyuiu.TsarevDT.Sprint1.Task6.V14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Царёв Д. И. | СМАРТб-24-1";
            Console.WriteLine("*************************************************************************");
            Console.WriteLine("* Спринт #1                                                             *");
            Console.WriteLine("* Тема: Работа со строками класс String                                 *");
            Console.WriteLine("* Задание #6                                                            *");
            Console.WriteLine("* Варинат #14                                                           *");
            Console.WriteLine("* Выполнил: Царёв Даниил Ильич | СМАРТб-24-1                            *");
            Console.WriteLine("*************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                              *");
            Console.WriteLine("* пользователь вводит текст. Проверить, что строка составлена только из *");
            Console.WriteLine("* строчных русских букв.                                                *");
            Console.WriteLine("*************************************************************************");
            Console.WriteLine("* ИССХОДНЫЕ ДАННЫЕ:                                                     *");
            Console.WriteLine("*************************************************************************");
            string x;
            Console.WriteLine("Введите текст");
            x = Console.ReadLine();

            Console.WriteLine("*************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                            *");
            Console.WriteLine("*************************************************************************");

            Console.WriteLine(ds.CheckLowerCaseRusLetters(x));
            Console.ReadKey();
        }
    }
}
