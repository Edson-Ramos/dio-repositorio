using System;


namespace ClasseEmétodosSelados.Models
{
    public sealed class Professor : Pessoa
    {
        public double Salario { get; set; }

        public sealed override void Apresentar()
        {
            Console.WriteLine($"Olá, Meu Nome é {Nome}, Minha Idade é {Idade}, e Meu Sálario é {Salario}");
        }
    }
}
