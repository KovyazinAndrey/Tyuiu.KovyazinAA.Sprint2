using Tyuiu.KovyazinAA.Sprint2.Task1.V19.Lib;
namespace Tyuiu.KovyazinAA.Sprint2.Task1.V19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #2 | Выполнил: Ковязин А. А. | ПКТб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Логические операции                                               *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #19                                                             *");
            Console.WriteLine("* Выполнил: Ковязин Андрей Александрович | ПКТб-24-1                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу из операций сравнений и логических операций, а также *");
            Console.WriteLine("* арифметических выражений, которая вернет логическую последовательность  *");
            Console.WriteLine("* (массив): (True, False, True, False, True, False)                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* A = 696                                                                 *");
            int a = 696;
            Console.WriteLine("* B = 354                                                                 *");
            int b = 354;
            Console.WriteLine("* C = 423                                                                 *");
            int c = 423;
            Console.WriteLine("* D = 957                                                                 *");
            int d = 957;
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(ds.GetLogicOperations(a, b, c, d));
            
        }
    }
}
