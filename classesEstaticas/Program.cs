using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classesEstaticas
{
    public static class Conversor
    {

        public static double CelsiusToFah(double temperatura)
        {
            return (temperatura * 9 / 5) + 32;
        }

        public static double FahToCelsius(double temperatura)
        {
            return (temperatura - 32) * 5 / 9;
        }


    }

    class Program
    {
        static void Main(string[] args)
        {
            var temperatura = 30.0;
            temperatura =   Conversor.CelsiusToFah(temperatura);
            Console.WriteLine(temperatura);
            Console.ReadKey();

        }
    }
}
