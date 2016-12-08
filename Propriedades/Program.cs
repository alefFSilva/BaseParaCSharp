using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Propriedades
{
    public class MensalidadeNegativaException: Exception
    {
        public MensalidadeNegativaException(string message)
            :base(message)
        {

        }

    }

    public enum tipoAluno
    {
        Regular, Especial
    }

    public class Aluno
    {
        //Fields
        private int         _matricula;
        private string      _nome;
        private double      _mensalidade;
        private tipoAluno   _tipo;

        public int Matricula
        {
            get
            {
                return this._matricula;
            }
            set
            {
                this._matricula = value;
            }

        }
        public string Nome
        {
            get
            {
                return _nome;
            }
            set
            {
                _nome = value;
            }
        }

        public double Mensalidade
        {
            get
            {
                return _mensalidade;
            }
            set
            {
                if (value < 0)
                    throw new MensalidadeNegativaException("Valor inválido");
                else
                    _mensalidade = value;
            }
        }

        public tipoAluno Tipo
        {
            get
            {
                return _tipo;
            }
            set
            {
                _tipo = value;
            }
        }

        }

        

    

    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Aluno a = new Aluno();
                a.Matricula = 123;
                a.Nome = "Alef.";
                a.Mensalidade = -500;
                a.Tipo = tipoAluno.Regular;

            }catch(MensalidadeNegativaException e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }
    }
}

