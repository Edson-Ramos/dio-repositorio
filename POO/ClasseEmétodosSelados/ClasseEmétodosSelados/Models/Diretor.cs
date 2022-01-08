using System;


namespace ClasseEmétodosSelados.Models
{
    internal class Diretor : Professor
    {
        public override void Apresentar()
        {
            Console.WriteLine($"Olá, Meu Nome é {Nome}, Minha Idade é {Idade}, e Sou Diretor");
        }

    }
}
