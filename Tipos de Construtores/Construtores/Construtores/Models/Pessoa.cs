using System;


namespace Construtores.Models
{
    public class Pessoa
    {
        private string Nome;
        private string SobreNome;

        // COnstrutor padrão é definido desse jeito se não for inserido nenhum construtor.
        //public Pessoa()
        //{
        //    Nome = string.Empty;
        //    SobreNome = string.Empty;
        //}
        // Construtos está exigindo que tenha dois paramentos do tipo strings
        public Pessoa(string nome, string sobrenome)
        {
            this.Nome = nome;
            this.SobreNome = sobrenome;
            Console.WriteLine("Classe Pessoa");
        }

        public void Apresentar()
        {
            Console.WriteLine($"Ola, Meu Nome è {Nome} {SobreNome}");
        }
    }
}
