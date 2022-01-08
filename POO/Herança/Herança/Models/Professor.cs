using System;

namespace Herança.Models
{
    // criando uma classe aluno que herda atributos, métodos e comportamentos da classe Pai
    public class Professor : Pessoa
    {
        // atributos exclusivo da classe aluno
        public double Salario { get; set; }
    }
}
