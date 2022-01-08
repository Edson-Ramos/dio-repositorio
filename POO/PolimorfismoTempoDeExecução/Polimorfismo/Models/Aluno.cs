using System;


namespace Polimorfismo.Models
{
    public class Aluno : Pessoa
    {
        public double Nota { get; set; }

        public override void Apresentar()
        {
            Console.WriteLine($"Olá, Meu Nome é {Nome} e Sou Aluno de Nota {Nota}");
        }
    }
}
