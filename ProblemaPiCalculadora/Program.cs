using ProblemaPiCalculadora;
using System;
using System.Globalization;
namespace Programa
{
    class Program
    {
        static void Main(string[] args)
        {
            {

             CultureInfo CI = CultureInfo.InvariantCulture;

             Calculadora calc = new Calculadora();

            Console.Write("Entre o valor raio: ");
            double raio = double.Parse(Console.ReadLine(), CI);

            double circ = calc.circunferencia(raio);
            double volume = calc.Volume(raio);

            Console.WriteLine("Circuferencia: " + circ.ToString("F2", CI));
            Console.WriteLine("Volume: " + volume.ToString("F2", CI));
            Console.WriteLine("Valor de PI: " + calc.Pi.ToString("F2", CI));

            }
        }
  
    }
}
