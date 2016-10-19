using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionsStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;

            #region if 
            if (a == 5)
            {
                Console.WriteLine("a = 5");

            }
            else {
                Console.WriteLine("a <> 5");
            }
            Console.ReadKey();

            #endregion

            #region switch

            //if Anilhado
            if (a == 5)
            {
                Console.WriteLine("a = 5");

            }
            else if (a == 10)
            {
                Console.WriteLine("a <> 5");
            }
            else if (a == 250)
            {
                Console.ReadKey();
            }
            int g = 10;

            switch(g)
            {
                case 10:
                    Console.WriteLine("g = 10");
                    break;
                case 5:
                    Console.WriteLine("g = 5");
                    break;
                default:
                    Console.WriteLine("nothing");
                    break;
            }

            Console.ReadKey();
            #endregion

        }
    }
}
