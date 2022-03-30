using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication19
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> List1 = new List<int> { 1, 3, 5 };
            List<int> List2 = new List<int> { 2, 4, 6, 8 };
            List<int> List3 = new List<int>();
            List3 = MergedList(List1, List2);
            for (int i = 0; i < List3.Count;i++ )
            {
                Console.WriteLine(List3[i]);
            }
            Console.ReadKey();
        }
        //static رايحة باية      -     اسمها اية - راجعة باية
        static List<int> MergedList(List<int> List1, List<int> List2)
        {

            List<int> List3 = new List<int>();
            for (int i = 0; i < List1.Count; i++)
            {
                List3.Add(List1[i]);
            }
            for (int i = 0; i < List2.Count; i++)
            {
                List3.Add(List2[i]);
            }
            int tmp = 0;
            for (int i = 0; i < List3.Count; i++)
            {
                for (int j = i + 1; j < List3.Count; j++)
                {
                    if (List3[i] > List3[j])
                    {
                        tmp      = List3[j];
                        List3[j] = List3[i];
                        List3[i] = tmp;
                    }
                }
            }
            return List3;

        }
    }
}
