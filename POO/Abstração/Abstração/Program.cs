using System;

namespace Abstração.Models
{
    public class Program
    {
        
        static void Main()
        { //Criando um Objeto "p1" para classe pessoa
           Pessoa p1 = new Pessoa();
            p1.Nome = "Edson";
            p1.Idade = 35;

            //Chamando o método apresentação da classe pessoa
            p1.Apresentação();
        }
    }
}