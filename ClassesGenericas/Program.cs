using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesGenericas
{
    class Pilha<T>
    {
        string nome;
        int codigo;

        int pos = 0;

        T[] itens = new T[110];

        public void Push(T item)
        {
            itens[pos] = item;
            pos++;
        }

        public T Pop()
        {
            pos--;
            return itens[pos];
        }

    }

    class Program
    {
        static void Main(string[] args)
        {

            var c = new Pilha<string>();
            c.Push("Alef");

         




        }
    }
}
