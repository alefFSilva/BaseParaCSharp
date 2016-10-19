using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysAndArraysLists
{
    class Program
    {
        static void Main(string[] args)
        {
                            //ArrayPadrao
            int[]   a1 = new int[3];
            a1[0] = 10;
            a1[1] = 20;
            a1[2] = 30;

                            //ArrayMultiDimnsional
            int[,] ma1 = new int[5, 10];
            ma1[0, 0]  = 10;

                            //ArrayBooleano Com Valores PreDefinidos
            bool[] a3 = new bool[] { true, false, true };

            String[] a2 = { "one", "two" };

            Console.WriteLine(a2.Length);
            Console.ReadKey();

            ArrayList al1 = new ArrayList();
            al1.Add(10);
            al1.Add("OK");
            al1.Add(true);


            //Generics List<T>
            List<int> li = new List<int>();
            li.Add(20);
            li.Add(10);
            
            
        }
    }
}
