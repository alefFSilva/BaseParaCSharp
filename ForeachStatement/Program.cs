using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForeachStatement
{
    class Program
    {

        public struct Livro
        {
            public string nome;
            public string autor;
            public int codigo;

        }
        static void Main(string[] args)
        {
            Livro l1 = new Livro();

            l1.autor = "Alef";
            l1.nome = "Aleph";
            l1.codigo = 1;

            Livro l2 = new Livro();
            l2.autor = "Eduardo Spohr";
            l2.nome = "Batalha do Apocalipse";
            l2.codigo = 2;

            List<Livro> livros = new List<Livro>();
            livros.Add(l1);
            livros.Add(l2);

            foreach (Livro item in livros)
            {
                Console.WriteLine("Código do livro: " + item.codigo.ToString());
                Console.WriteLine("Código do NOME: " + item.nome);
                Console.WriteLine("Código do AUTOR: " + item.autor);
                Console.WriteLine("---------------------------------------------");
                
            }
            for (int i = 0; i < livros.Count; i++)
            {

                Livro l = livros.ElementAt(i);
                Console.WriteLine(l.autor);
            }

            Console.ReadKey();

        }
    }
}
