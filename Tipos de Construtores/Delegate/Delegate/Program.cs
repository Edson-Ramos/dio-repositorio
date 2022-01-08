using System;

namespace Delegate.Models
{
    public class Program
    {
        public delegate void Operação(int x, int y);
        static void Main()
        {
            // Operação op = Calculadora.Somar;
            Operação op = new Operação(Calculadora.Somar);
            // Delegate com Mult Cast juntou a primeira operação somar e logo apos são o subitrair.
            op += Calculadora.Subtrair;

            op.Invoke(10, 10);
            // op(10, 10);

        }
    }
}