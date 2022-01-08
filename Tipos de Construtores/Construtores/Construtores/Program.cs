using System;

namespace Construtores.Models
{
    public class Program
    {
        static void Main()
        {
            Aluno a1 = new Aluno("Edson", "Ramos", "Teste");

            a1.Apresentar();

            //Pessoa p1 = new Pessoa();
            //Pessoa p2 = new Pessoa("Edson", "Ramos");

            //p1.Apresentar();
            //p2.Apresentar();
        }
    }
}