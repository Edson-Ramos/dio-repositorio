using System;

namespace Polimorfismo.Models
{
    public class Program
    {
        static void Main()
        {
            Aluno a = new Aluno();
            a.Nome = "Edson Ramos";
            a.Idade = 35;
            a.Nota = 10;

            a.Apresentar();

            Professor p = new Professor();
            p.Nome = "Felipe Melo";
            p.Idade = 40;
            p.Salario = 3000;

            p.Apresentar();
        }
        
    }
}