using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.TsarevDT.Sprint1.Task7.V18.Lib
{
    public class DataService : ISprint1Task7V18
    {
        public double Calculate(double x, double y)
        {
            double a, b;
            a = 1 + Math.Pow(Math.Sin(x + y), 2);
            b = 2 + Math.Abs(x - ((2 * x) / (1 + Math.Pow(x * y, 2))));
            return Math.Round((a / b)+x, 3);
        }
    }
}
