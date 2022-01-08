using System;

namespace ClassesAbstratas.Models
{
    public abstract class Conta
    {
        protected double Saldo { get; set; }

        public abstract void Creditar(double valor);

        public void ExibirSaldo()
        {
            Console.WriteLine($"Seu Saldo é: {Saldo}");
        }
    }
}
