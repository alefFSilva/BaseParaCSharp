using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropriedadesAutomáticas
{

    class Funcionario
    {
        public string   Nome    { get; set; }
        public int      Codigo  { get; set; }
        public double   Salario   { get; set; }

        public Funcionario(string nome)
        {
            this.Nome = Nome;

        }
        public Funcionario(string nome, int codigo, double salario)
        {
            this.Nome = nome;
            this.Codigo = codigo;
            this.Salario = salario;
        }

        public override string ToString()
        {
            return "Nome: " + this.Nome + ", Codigo: " + this.Codigo + ", Salario: " + this.Salario;
        }

    }
    

    class Program
    {
        static void Main(string[] args)
        {

            Funcionario f = new Funcionario("Alef", 123456,1.200);

            Console.WriteLine(f);
            Console.ReadKey();

        }
    }
}
