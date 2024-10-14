using Tyuiu.KovyazinAA.Sprint2.Task3.V4.Lib;
namespace Tyuiu.KovyazinAA.Sprint2.Task3.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int x = 4;
            double res = ds.Calculate(x);
            Assert.AreEqual(11.716, res);
        }
    }
}