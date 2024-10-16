using System.ComponentModel.Design;
using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.KovyazinAA.Sprint2.Task6.V11.Lib
{
    public class DataService : ISprint2Task6V11
    {
        public string FindDateOfNextDay(int g, int m, int n)
        {
            const int V = 1;
            if (n <= 29)
                switch (n)
                {
                    case V: n += V; break;
                    case 2: n += V; break;
                    case 3: n += V; break;
                    case 4: n += V; break;
                    case 5: n += V; break;
                    case 6: n += V; break;
                    case 7: n += V; break;
                    case 8: n += V; break;
                    case 9: n += V; break;
                    case 10: n += V; break;
                    case 11: n += V; break;
                    case 12: n += V; break;
                    case 13: n += V; break;
                    case 14: n += V; break;
                    case 15: n += V; break;
                    case 16: n += V; break;
                    case 17: n += V; break;
                    case 18: n += V; break;
                    case 19: n += V; break;
                    case 20: n += V; break;
                    case 21: n += V; break;
                    case 22: n += V; break;
                    case 23: n += V; break;
                    case 24: n += V; break;
                    case 25: n += V; break;
                    case 26: n += V; break;
                    case 27: n += V; break;
                    case 28: n += V; break;
                    case 29: n += V; break;

                }
            else if ((n == 29) & (m == 2))
            {
                m += 1;
                n = V;
            }
            else if (((m == V) || (m == 3) || (m == 5) || (m == 7) || (m == 8) || (m == 10) || (m == 12)) & (n == 31))
            {
                m += V; 
                n = V;
            }
            else if ((m==2)||(m==4)||(m==6)||(m==9)||(m==11)&(n==30))
            {
                m += V;
                n = V;
            }
            if (m==13)
            {
                m = V;
                g += V;
            }
            string num = "";
            if (n<=9)
            {
                num = "0" + n;
            }
            else
            {
                num = Convert.ToString(n);
            }
            string mon = "";
            if (m<=9)
            {
                mon = "0" + m;
            }
            else
            {
                mon = Convert.ToString(m);
            }
            string res = $"{num}.{mon}.{g}";
            return res;
        }
    }
}
