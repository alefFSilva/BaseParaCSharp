using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operator
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Sintaxe
            int a = 10;
            int b = 2;

            int soma = a + b;
            int subt = a - b;
            int mult = a * b;
            int rest = a % b; //Módulo

            //Incremento  - x++
            //Decremento  - x--

            //Comparativos

            if (a > b)
                // Console.WriteLine("a > b");

                if (b < a)
                    // Console.WriteLine("b < a");

                    // => - Lambda
                    if (a >= b)
                        //    Console.WriteLine("a >= b");

                        if (b <= a)
                            //   Console.WriteLine("b <= a");

                            //Equals
                            if (a == b)
                                //  Console.WriteLine("a == b");

                                //Not
                                if (a != b)
                                    // Console.WriteLine("a != b");

                                    //Lógicos
                                    //XOR  - Lógico Exclusivo  - Um ou outro
                                    if (true ^ false)
                                        //Console.WriteLine("true");

                                        //Condicionais

                                        //AND
                                        if (true && true)
                                            //    Console.WriteLine("true");

                                            //OR 
                                            //   if (true || false)
                                            // Console.WriteLine("true");

                                            #endregion


            Console.WriteLine("Valor 1: ");
            int v1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Valor 2: ");
            int v2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Soma: ");
            Console.WriteLine("Subtração: ");
            Console.WriteLine("Multiplicação: ");
            Console.WriteLine("Divisão: ");
        }
    }
}
