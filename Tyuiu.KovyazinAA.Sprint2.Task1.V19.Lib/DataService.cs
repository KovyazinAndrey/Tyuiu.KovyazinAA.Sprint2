using System.Reflection.Metadata.Ecma335;
using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.KovyazinAA.Sprint2.Task1.V19.Lib
{
    public class DataService : ISprint2Task1V19
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] res = new bool[6];
            res[0] = (a > b) | (b == c);
            res[1] = (a != d) & (d == a);
            res[2] = (c < d) || (d != a);
            res[3] = (b != c) && (c == a);
            res[4] = !(res[3]);
            res[5] = (a != b) ^ (b != c);
            return res;
        }
    }
}
