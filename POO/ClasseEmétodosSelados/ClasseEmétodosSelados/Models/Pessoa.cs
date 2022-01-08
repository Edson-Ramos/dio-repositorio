using System;


namespace ClasseEmétodosSelados.Models
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }

        public  virtual void Apresentar()
        {
            Console.WriteLine($"Olá, Meu Nome é {Nome}, e Minha Idade é {Idade}");
        }
    }

}
