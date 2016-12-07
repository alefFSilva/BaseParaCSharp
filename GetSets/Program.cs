using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetSets
{

    public class Conta
    {

        private string _Cliente;
        private double _Valor;


        public Conta(string nome)
        {
            this._Cliente = nome;
        }

        public string getCliente()
        {
            return this._Cliente;
        }

        public void setCliente(string value)
        {
            this._Cliente = value;
        }

        public void Sacar(Double valor)
        {

            this._Valor = this._Valor - valor;

        }

        public void Deposita(int valor)
        {

            this._Valor = this._Valor + valor;

        }


        public double getSaldo()
        {
            return this._Valor;
        }
    
    }


    class Program
    {
        static void Main(string[] args)
        {

            Conta c = new Conta("Alef");
            c.Deposita(500);
            c.Sacar(250);

            Console.WriteLine("Cliente: " + c.getCliente());
            Console.WriteLine("Saldo: " + c.getSaldo());
            Console.ReadLine();


        }
    }
}
