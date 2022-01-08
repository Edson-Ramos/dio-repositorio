using System;


namespace Construtores.Models
{
    internal class Aluno : Pessoa
    {
        public Aluno(string Nome, String SobreNome, string Disciplina) : base(Nome, SobreNome)
        {
            Console.WriteLine("Classe Aluno");
        }
        
    }
}
