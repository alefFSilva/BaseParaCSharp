using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {

            string s1 = "one,two,three";

            string s2  = "one";
            s2 += ",two";
            s2 += ",three";

            System.Text.StringBuilder sb = new StringBuilder();
            sb.Append("one");
            sb.Append(",two");
            sb.Append(",three");

            //s2.EndsWith("ree");
            //Verifica se a String termina com a String dada e retorna um Booleano

            //s2.Equals("one");
            //Faz  comparações de objetos Strings

            //s2.IndexOf("two");
            //Retorna a posição de onde ocorre a Sring dada como parâmetro

            //s2.Insert(4, "OK");
            //Insere na posição passada como parâmetro 1 a String passada no parâmetro 2

            //s2.Remove(4, 2);
            //Remove a partir da posição dada como parâmetro 1 o número x de caracteres, onde x é igual
            //o parâmetro 2

            //s2.Replace(" one ", "two");
            //Substitui a String dada como parâmetro 1 pela a String dada como parâmetro 2

            //s2.Split(',');
            //Retorna um ARRAY
            //Separa uma String pelo separador CHAR dado como parâmetro 1 e armazena nos Index de um ARRAY

            Console.WriteLine(s1);
            Console.WriteLine(s2);
            Console.WriteLine(sb);

            Console.ReadKey();

        }
    }
}
