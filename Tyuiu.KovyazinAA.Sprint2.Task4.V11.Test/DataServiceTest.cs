using Tyuiu.KovyazinAA.Sprint2.Task4.V11.Lib;
namespace Tyuiu.KovyazinAA.Sprint2.Task4.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int x = 1;
            int y = 2;
            Assert.AreEqual(ds.Calculate(x, y),121);
        }
    }
}