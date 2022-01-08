using System;

namespace Herança.Models
{
    public class Program
    {
        static void Main()
        {
            Aluno a = new Aluno();
            a.Nota = 10;
            a.Nome = "Edson Ramos";
            a.Idade = 35;

            Professor p = new Professor();
            p.Salario = 2000;
            p.Nome = "Leonardo de Lima";
            p.Idade = 28;

            Console.WriteLine($"Olá, Meu Nome é {a.Nome}, Minha Idade é {a.Idade}, e Minha Nota é {a.Nota}");
            Console.WriteLine($"Olá, Meu Nome é {p.Nome}, Minha Idade é {p.Idade}, e Meu Sálario é {p.Salario}");

        }
    }

}
