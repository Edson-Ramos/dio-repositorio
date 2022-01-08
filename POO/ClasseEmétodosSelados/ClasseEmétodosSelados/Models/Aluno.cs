using System;


namespace ClasseEmétodosSelados.Models
{
    internal class Aluno : Pessoa
    {
        public double Nota { get; set; }

        public override void Apresentar()
        {
            Console.WriteLine($"Olá, Meu Nome é {Nome}, Minha Idade év{Idade} e sou Aluno de Nota {Nota}");
        }
    }
}
