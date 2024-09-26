using Tyuiu.TsarevDT.Sprint1.Task3.V19.Lib;
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

            var res = ds.Calculate(x1, y1, x2, y2);
            Assert.AreEqual(tf, res);

        }
    }
}