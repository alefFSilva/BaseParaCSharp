using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSample
{
    class Aluno
    {
        public Aluno()
        {
            Console.WriteLine("Constructor constructor.");
        
        }

        private string nome;

        public string Nome
        {
            get
            {
                return nome;
            }

            set
            {
                nome = value;
            }

        }

        ~Aluno()
        {
            Console.WriteLine("Aluno Destruct");
        }
    }
}
