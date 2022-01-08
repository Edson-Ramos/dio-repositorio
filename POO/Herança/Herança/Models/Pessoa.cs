using System;


namespace Herança.Models
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }

        public void Apresentar()
        {
            Console.WriteLine($"Meu Nome é {Nome} e Minha Idade é {Idade} Anos");
        }
    }
}
