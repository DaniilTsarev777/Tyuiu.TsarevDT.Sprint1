using Newtonsoft.Json.Linq;
using Tyuiu.TsarevDT.Sprint1.Task2.V27.Lib;
namespace Tyuiu.TsarevDT.Sprint1.Task2.V27.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int x = 2;
            var res = ds.CalculateSquarePerimetr(x);
            Assert.AreEqual(8, res);
        }
    }
}