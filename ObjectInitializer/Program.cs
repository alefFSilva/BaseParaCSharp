using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectInitializer
{
    public class Filme
    {
        public string Nome;
        public int ano;

    }

    public class Autor
    {
        public int Codigo;
        public string Nome;
        public List<Filme> Filmes ;

        //public Autor(int codigo, string nome, string filme)
        //{
        //    this.Codigo = codigo;
        //    this.Nome = nome;
        //    this.Filme = filme;

        //}
    }

    class Program
    {
        static void Main(string[] args)
        {

            Autor a = new Autor()
            {
                Codigo = 2,
                Nome = "Wolverine",
                Filmes = new List<Filme>()
                {
                    new Filme()
                    {
                        Nome = "X-Man",
                        ano = 2010
                    },


            new Filme()
            {
                Nome = "Wolverin Origins",
                ano = 2013
            }
                }
            
            };

        }
    }
}
