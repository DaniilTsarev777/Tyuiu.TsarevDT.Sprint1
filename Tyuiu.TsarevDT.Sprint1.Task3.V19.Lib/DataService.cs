using System;
using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.TsarevDT.Sprint1.Task3.V19.Lib
{
    public class DataService : ISprint1Task3V19
    {
        public bool Calculate(double x1, double y1, double x2, double y2)
        {
            return Math.Abs(x1 - x2) == Math.Abs(y1 - y2);
        }

        public void Calculate()
        {
            throw new NotImplementedException();
        }
    }
}
