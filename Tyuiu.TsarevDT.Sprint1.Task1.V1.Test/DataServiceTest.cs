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
            double x = 1.0;
            double y = 2.0;
            double a = 3.0;
            var res = ds.Calculate(x, y, a);
            Assert.AreEqual(18, res);




        }
    }
}