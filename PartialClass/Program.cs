using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClass
{
    class Program
    {
        static void Main(string[] args)
        {
            var user = new Usuario(213, "Alesf", "fela");

            if (user.Autenticar())
            {
                Console.WriteLine("Usuário autenticado com sucesso.");
            }
            else
            {
                Console.WriteLine("Credenciais incorretas.");
            }

            Console.ReadKey();
        }
    }
}
