using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeInference_Dynamic
{
    public class Connection
    {
        public string Banco;

        public void Conectar()
        {
            Console.WriteLine("Conectando");
        }

        public void CloseConnction()
        {
            Console.WriteLine("Fechando conexão.");
        } 
    }

    public static class Fabrica
    {
        public static Connection CriarConnection()
        {
            return new Connection();
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            //Inferência - Resolvido em tempo de compilação
            var con = Fabrica.CriarConnection();
            con.Conectar();

            //Dynamic - Resolvido em tempo de execução, quando ainda não se conhece o objeto to handle
            dynamic con1  = Fabrica.CriarConnection();


        }
    }
}
