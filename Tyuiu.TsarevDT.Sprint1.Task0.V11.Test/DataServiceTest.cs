using Tyuiu.TsarevDT.Sprint1.Task0.V11.Lib;
namespace Tyuiu.TsarevDT.Sprint1.Task0.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            var res = ds.Calculate();
            Assert.AreEqual(7, res);
        }
    }
}