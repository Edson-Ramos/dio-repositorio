using System;

namespace Polimorfismo.Models
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }

        public virtual void Apresentar()
        {
            Console.WriteLine($"Olá, Meu Nome é {Nome}, e Minha Idade é {Idade} Anos");
        }
    }
}
