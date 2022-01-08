using System;


namespace Herança.Models
{
    // criando uma classe aluno que herda atributos, métodos e comportamentos da classe Pai
    public class Aluno : Pessoa
    {
        // atributos exclusivo da classe aluno
        public double Nota { get; set; }
    }
}
