using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstruturasCSharp
{
    public class PosicaoClass{

        public int x;
        public int y;

        public override string ToString()
        {
            return "X = " + x.ToString() + ", " + "Y = " + y.ToString();
        }

    }

    public struct PosicaoStruct
    {
        public int x;
        public int y;
        public override string ToString()
        {
            return "X = " + x.ToString() + ", " + "Y = " + y.ToString();
        }

      
    }

    public enum Roles
    {
        Developer, Arquiteto, Tester
    }

    public enum Colors
    {
        Red = 0, Green = 1, Blue = 2
    }

    public enum FormasPagto
    {
        Boleto, Cartao, Cheque
    }

    class Program
    {
        static void Main(string[] args)
        {

            PosicaoStruct pos1 = new PosicaoStruct();
            pos1.x = 10;
            pos1.y = 20;

            PosicaoStruct pos2 = new PosicaoStruct();
            pos2.x = 30;
            pos2.y = 40;

            PosicaoStruct pos3 = pos2;
            pos3.x = 50;

            Console.WriteLine(pos1);
            Console.WriteLine(pos2);
            Console.WriteLine(pos3);

            FormasPagto formaPagto = FormasPagto.Boleto;
            Roles role = Roles.Arquiteto;
            Colors cor;
            cor = 0;

            Console.WriteLine(formaPagto);
            Console.WriteLine(role);
            Console.WriteLine(cor);

            Console.ReadLine();

        }
    }
}
