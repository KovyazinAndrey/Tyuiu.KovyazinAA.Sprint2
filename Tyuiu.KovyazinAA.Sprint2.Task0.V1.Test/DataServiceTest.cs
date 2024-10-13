using Tyuiu.KovyazinAA.Sprint2.Task0.V1.Lib;
namespace Tyuiu.KovyazinAA.Sprint2.Task0.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int x = 233;
            int y = 122;
            bool[] res = new bool[6];
            res = ds.GetCompareOperations(x, y);
            bool[] wait = new bool[6] {true, false, true, false, true, false };
            CollectionAssert.AreEqual(wait, res);
        }
    }
}