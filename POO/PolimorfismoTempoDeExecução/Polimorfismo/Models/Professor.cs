using System;


namespace Polimorfismo.Models
{
    internal class Professor : Pessoa
    {
        public double Salario { get; set; }

        public override void Apresentar()
        {
            Console.WriteLine($"Olá, Meu Nome é {Nome}, e Sou Professor e meu Sálario é {Salario}");
        }
    }
}
