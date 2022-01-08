using System;
using System.Collections.Generic;

namespace ColeçõesEspecificas
{
    public class ColeçõesEspecificas
    {
        static void Main()
        {

            Stack<string> pilha = new Stack<string>();

            pilha.Push("Python");
            pilha.Push(".Net");
            pilha.Push("Codigo Limpo");

            Console.WriteLine($"Quantidade de Livro na Pilha {pilha.Count}");


            while (pilha.Count > 0)
            {
                Console.WriteLine($"Proximo Livro Para Leitura é: {pilha.Peek()}");
                Console.WriteLine($"{pilha.Pop()} Lido Com Sucesso!");
                Console.WriteLine($"Livros Para Leitura: {pilha.Count}");
            }

            //Queue<string> fila = new Queue<string>();

            //fila.Enqueue("Edson");
            //fila.Enqueue("Leonardo");
            //fila.Enqueue("José");


            //Console.WriteLine($"Pessoa Na Fila: {fila.Count}");
            //while (fila.Count > 0)
            //{
            //    Console.WriteLine($"Vez de: {fila.Peek()}");
            //    Console.WriteLine($"{fila.Dequeue()} Atendido");
            //    Console.WriteLine($"Pessoa Na Fila: {fila.Count}");
            //}
        }
    }
}