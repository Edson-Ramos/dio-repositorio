using System;
using CSharp;
using Interface1;
using Enum;

namespace CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var pessoa = (Pessoas)0;
            Pessoas pessoa2 = Pessoas.João;
            Pessoas pessoa3 = (Pessoas)4;


            Pessoa person = new Pessoa();

            person.nome = "Edson Ramos";
            person.idade = 35;
            person.estado = "Pernambuco";

            var person2 = new Pessoa();

            person2.nome = "Marta Maria";
            person2.idade = 30;
            person2.estado = "São Paulo";


            Animal animal = new Animal();

            animal.Nome = "Au Au";
            animal.NomeDono = "Seu João";
            animal.especie = "Cachorro";



        }
    }
}
