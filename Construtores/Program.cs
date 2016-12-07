using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Construtores
{
    public class Contato
    {
        public string Tipo;
        public string Descricao;
    }

    public class Cliente
    {

        public int Codigo;
        public string Nome;
        public Contato Contato;

        //Construtor padrão
        public Cliente()
        {
            this.Codigo = 0;
            this.Nome = "Sem nome";
            this.Contato = new Contato();
        }

        //OVERLOADS
        public Cliente(int Codigo)
        {
            this.Codigo = Codigo;
            this.Nome = "Sem nome";
            this.Contato = new Contato();

        }

        public Cliente(int Codigo, string Nome)
        {
            this.Codigo = Codigo;
            this.Nome = Nome;
            this.Contato = new Contato();

        }


        public override string ToString()
        {
            return "Código: " + this.Codigo.ToString() + ", Nome: " + this.Nome;
        }

    }

    public class ClienteVIP : Cliente
    {
        int tempo;


        //O C# não é poliformico em relação aos contrutores, ele é estático.
        //Para usar construtores nas classes filhas, é necessário usar a palavra reservada base que reutiliza
        //os OVERLOADS da classe pai.

        public ClienteVIP(int Codigo, string Nome)
                :base(Codigo, Nome)
        {
            this.tempo = 10;
          
        }
    }


    class Program
    {
        static void Main(string[] args)
        {

            Cliente cli = new Cliente();
            Console.WriteLine(cli);

            Cliente cli1 = new Cliente(14);
            Console.WriteLine(cli1);

            Cliente cli2 = new Cliente(666, "Alef Again");
            Console.WriteLine(cli2);

            Cliente cli3 = new ClienteVIP(33, "Outro");
            Console.WriteLine(cli3);

            cli.Codigo = 123;
            cli.Nome = " Alef.";
            cli.Contato.Descricao = "Teste";

            Console.WriteLine(cli);
            Console.ReadLine();

        }
    }


}
