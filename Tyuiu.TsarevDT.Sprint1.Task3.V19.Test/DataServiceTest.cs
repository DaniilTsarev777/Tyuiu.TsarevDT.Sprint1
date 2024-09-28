using Tyuiu.TsarevDT.Sprint1.Task3.V19.Lib;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace Tyuiu.TsarevDT.Sprint1.Task3.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpresion()
        {
            DataService ds = new DataService();
            double x1 = 5;
            double y1 = 4;
            double x2 = 4;
            double y2 = 5;
            bool tf = true;

            var res = ds.ElephCanMove(x1, x2, y1, y2);
            Assert.AreEqual(tf, res);

        }
    }
}