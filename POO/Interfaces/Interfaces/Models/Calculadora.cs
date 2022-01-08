using Interfaces.Interfaces;
using System;


namespace Interfaces.Models
{
    public class Calculadora : ICalculadora
    {
        public int Div(int x, int y)
        {
            return x / y;
        }

        public int Mult(int x, int y)
        {
            return x * y;
        }

        public int Somar(int x, int y)
        {
            return x + y;
        }

        public int Sub(int x, int y)
        {
            return x - y;
        }
    }
}
