﻿using System;
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

        //Destructor 
        ~Aluno()
        {
            Console.WriteLine("Aluno Destruct");
        }
    }
}
