using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.KovyazinAA.Sprint2.Task0.V1.Lib
{
    public class DataService : ISprint2Task0V1
    {
        public bool[] GetCompareOperations(int x, int y)
        {
            bool[] res = new bool[6];
            res[0] = x == y + 111;
            res[1] = x != y + 111;
            res[2] = x < y + 1000;
            res[3] = x > y + 1000;
            res[4] = x <= y + 1000;
            res[5] = x >= y + 1000;
            return res;
        }
    }
}
