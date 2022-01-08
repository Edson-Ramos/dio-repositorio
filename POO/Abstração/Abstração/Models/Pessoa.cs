using System;


namespace Abstração.Models
{   // criando uma classe chamada pessoa
    public class Pessoa
    {   // criando as propriedades da classe pessoa
        public string Nome { get; set; }
        public int Idade { get; set; }

        // criando método de apresentação da classe pessoa
        public void Apresentação()
        {
            Console.WriteLine($"Ola, Meu Nome é {Nome} e Minha Idade é {Idade}");
        }
    }
}
