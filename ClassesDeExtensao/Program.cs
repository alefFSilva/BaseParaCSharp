using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ClassesDeExtensao
{
    public static class DataSetExtension
    {

        //Não há a necessidade acessar o sourceCode para criar um novo método e aplicar Herança, por exemplo.
        //A palavra reservada THIS é quem garante que a classe seja do tipo extensão.
        public static void WriteJson(this DataSet ds, string filename)
        {
            //Rotina de Data => JSON
        }

        public static string ToUrl(this string str)
        {

            return str = "http://" + str;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {

            //var ds = new DataSet();
            //ds.WriteXml("XML");

            ////Basta chamar o método como qualquer outro método da classe extendida.
            //ds.WriteJson("");

            string url = "aleffsilvablog.wordpress.com";
            Console.WriteLine(url.ToUrl());
            Console.ReadKey();

        }
    }
}
