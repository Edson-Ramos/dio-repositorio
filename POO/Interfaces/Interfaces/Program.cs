using Interfaces.Interfaces;
using System;

namespace Interfaces.Models
{
    public class Program
    {
        static void Main()
        {
            int x = 10;
            int y = 20;

            ICalculadora calc = new Calculadora();
            Console.WriteLine($"Soma de {x} e {y} é " + calc.Somar(x, y));
            Console.WriteLine($"Subitração de {y} e {x} é " + calc.Sub(y, x));
            Console.WriteLine($"Multiplicação de {x} e {y} é " + calc.Mult(x, y));
            Console.WriteLine($"Divisão de {y} e {x} é " + calc.Div(y, x));
        }
    }
}
