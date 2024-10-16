using Tyuiu.KovyazinAA.Sprint2.Task7.V11.Lib;
namespace Tyuiu.KovyazinAA.Sprint2.Task7.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = -0.4;
            double y = -0.8;
            bool wait = true;
            Assert.AreEqual(wait, ds.CheckDotInShadedArea(x, y));
        }
    }
}