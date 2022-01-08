using System;

namespace Encapsulamento.Models
{
    public class Program
    {
        static void Main()
        {
            Retangulos r = new Retangulos();

            r.DefinirMedidas(30, 30);
            Console.WriteLine($"Área {r.ObterArea()}");
        }
    }
}