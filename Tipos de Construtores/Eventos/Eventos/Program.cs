using System;

namespace Eventos.Models
{
     class Program
    {
        public delegate void Operacao(int x, int y);

        static void Main()
        {
            Matematica m = new Matematica(10, 20);
            m.Somar();
        }
    }
}