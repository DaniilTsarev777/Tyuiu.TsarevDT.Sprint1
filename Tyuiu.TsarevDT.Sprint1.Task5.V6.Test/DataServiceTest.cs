using Tyuiu.TsarevDT.Sprint1.Task5.V6.Lib;
namespace Tyuiu.TsarevDT.Sprint1.Task5.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExperssion()
        {
            double x = 21;
            DataService ds = new DataService();
            double n = 7;


            var res = ds.Calculate(Convert.ToInt32(x));
            Assert.AreEqual(n, res);

        }
    }
}