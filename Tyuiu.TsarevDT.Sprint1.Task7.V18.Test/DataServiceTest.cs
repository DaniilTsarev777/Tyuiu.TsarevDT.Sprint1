using Tyuiu.TsarevDT.Sprint1.Task7.V18.Lib;
namespace Tyuiu.TsarevDT.Sprint1.Task7.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x, y;
            x = 0.5;
            y = 0.5;

            Assert.AreEqual(1.2, ds.Calculate(x, y));
        }
    }
}