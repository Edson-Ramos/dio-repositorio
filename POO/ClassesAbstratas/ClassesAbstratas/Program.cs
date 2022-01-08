using System;

namespace ClassesAbstratas.Models
{
    public class Program
    {
        static void Main()
        {
            Corrente c = new Corrente();
            c.Creditar(100);

            c.ExibirSaldo();
        }
    }
}