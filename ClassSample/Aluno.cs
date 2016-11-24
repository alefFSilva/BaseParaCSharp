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

        ~Aluno()
        {
            Console.WriteLine("Aluno Destruct");
        }
    }
}
