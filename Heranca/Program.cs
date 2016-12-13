using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca
{
    class Program
    {
        static void Main(string[] args)
        {

            Aluno a = new Aluno();
            a.Matricula = 123;
            a.Nome = "Alef";
            a.Estudar();            
            a.Dormir();


            Funcionario f = new Funcionario();
            f.Nome = "João";
            f.Departamento = "Portaria";
            f.Trabalhar();
            f.Dormir();

            Console.ReadLine();

        }
    }
}
