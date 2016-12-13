using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca
{
    class Funcionario : Pessoa
    {

        public string Departamento;
        public void Trabalhar()
        {
            Console.WriteLine(Nome + " " + " Trabanalhando.");
        }

    }
}
