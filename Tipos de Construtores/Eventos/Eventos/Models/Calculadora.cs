
using System;


namespace Eventos.Models
{
    public class Calculadora
    {
        // Delegate
        public delegate void DelegateCalculadora();

        //Evente
        public static event DelegateCalculadora EventoCalculadora; 

        public static void Somar(int x, int y)
        {
            if  (EventoCalculadora != null)
            {
                Console.WriteLine($"Adição: {x + y}");
                EventoCalculadora();
            }
            else
            {
                Console.WriteLine("Nenhum Inscrito");
            }
            
        }
        public static void Subitrair(int x, int y)
        {
            if (EventoCalculadora != null)
            {
                Console.WriteLine($"Subitrair: {x - y}");
                EventoCalculadora();
            }
            
        }
    }
}
