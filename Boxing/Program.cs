using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boxing
{
    class Program
    {
        static void Main(string[] args)
        {

            int a = 10;
            object o = (object)a;
            //System.Object

            Console.Write(o.GetType().ToString());
            Console.ReadKey();

            int b = (int)o;
           // int b = ((int)o).GetType();

            System.Type t = b.GetType();

            Console.WriteLine(b);
            Console.ReadKey();
        }
    }
}
