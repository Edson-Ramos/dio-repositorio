using System;

namespace PolimorfismoTempoDeComplilação.Models
{
    public class Program
    {

        static void Main()
        {
            Calculadora calc = new Calculadora();
            Console.WriteLine("A Soma do Primeiro Método é " + calc.Somar(10, 10));
            Console.WriteLine("A Soma Do Segundo Método é " + calc.Somar(10, 10, 10));
        }

    }
}