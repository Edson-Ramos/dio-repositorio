using System;

namespace ModificadoresReadOnly.Models
{
    public class Pessoa
    {
        // valor da variavél que recebe readonly do pode ser alterado aqui na inicialização
        private readonly string Nome = "Edson";
        private readonly string SobreNome;

        // Ou aqui nos Construtores, não é possivél alterar em nenhum outro lugar
        public Pessoa()
        {
            this.Nome = string.Empty;
            this.SobreNome = string.Empty;
        }

        public Pessoa(string Nome, string SobreNome)
        {
            this.Nome = Nome;
            this.SobreNome = SobreNome;
        }

        public void Apresentar()
        {
            Console.WriteLine($"Olá, Meu Nome é {Nome}, e Meu Sobre Nome é {SobreNome}");
        }
    }
}
