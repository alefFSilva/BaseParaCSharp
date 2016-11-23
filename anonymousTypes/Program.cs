using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace anonymousTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //nullable
            int? i = null;
            string a = null;

            var valores = new[] {
                                new { idade = 18, nome = "Alef" },
                                new { idade = 20, nome = "João"}
            };

            foreach (var item in valores)
            {
                Console.WriteLine("Nome: " + item.nome);
                Console.WriteLine("Idade: " + item.idade.ToString());
                Console.WriteLine("--------------------------------------");

                Console.ReadKey();
            }
        }
    }
}
