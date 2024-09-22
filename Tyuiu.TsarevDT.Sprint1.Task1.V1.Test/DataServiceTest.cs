using Tyuiu.TsarevDT.Sprint1.Task1.V1.Lib;
namespace Tyuiu.TsarevDT.Sprint1.Task1.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 3.0;
            double y = 2.0;
            double a = 4.0;
            var res = ds.Calculate(a, x, y);
            Assert.AreEqual(24.5, res);




        }
    }
}