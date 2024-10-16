using Tyuiu.KovyazinAA.Sprint2.Task6.V11.Lib;
namespace Tyuiu.KovyazinAA.Sprint2.Task6.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int g = 29;
            int m = 12;
            int n = 31;
            string s = "1.1.30";
            Assert.AreEqual(s, ds.FindDateOfNextDay(g, m, n));
        }
    }
}