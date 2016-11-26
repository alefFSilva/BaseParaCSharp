using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSample
{
    class Aluno
    {
        //Constructor
        public Aluno()
        {
            Console.WriteLine("Constructor constructor.");
        }

        public Aluno(string _nome, int _idade)
        {
            this.nome   = _nome;
            this.idade = _idade; 
        }

        //Fields
        private string nome;
        private int idade;

        //Properties
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

        public int Idade
        {
            get
            {
                return idade;
            }
            set
            {
                idade = value;
            }
        }

        public int GetTwiceIdade()
        {
            int twice = this.idade * 2;
            return twice;
        }

        public bool verifyMajor(int _idade)
        {
            /*    bool verify = false;

                if (_idade > 18)

                    verify = true;
                else
                    verify = false;
             */

            /*Declara a variavel verify e aplica TRUE ou FALSE
                Se _idade > 18
                ? => THEN\Então
                : => ELSE
            */
                            
            bool verify = (_idade > 18 ? true : false);

                return verify;
        }

        public void Limpar()
        {
            this.nome   =   string.Empty;
            this.idade = 0;

        }

        private void GoAge()
        {
            this.idade = 20;
        }
        //Destructor 
        ~Aluno()
        {
            Console.WriteLine("Aluno Destruct");
        }
    }
}
