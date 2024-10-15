using Tyuiu.KovyazinAA.Sprint2.Task5.V6.Lib;
namespace Tyuiu.KovyazinAA.Sprint2.Task5.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int x = 3; int y = 9;
            Assert.AreEqual("девятка бубны", ds.FindCardNameAndValue(x, y));

        }
    }
}