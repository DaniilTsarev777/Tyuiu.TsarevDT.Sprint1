using Tyuiu.TsarevDT.Sprint1.Task6.V14.Lib;
namespace Tyuiu.TsarevDT.Sprint1.Task6.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidString()
        {
            DataService ds = new DataService();
            string test = "привет";
            Assert.AreEqual(true, ds.CheckLowerCaseRusLetters(test));
            

        }
    }
}