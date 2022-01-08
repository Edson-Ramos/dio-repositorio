using System;

class Program
{
    static void Main(string[] args)
    {
        string str;
        while ((str = Console.ReadLine()) != null)
        {
            int v = int.Parse(str);
            if ( v < 0  )
            {
                Console.WriteLine("Digite Um Número Válido");
            }
            else          //Escreva o seu código nos espaços em branco
            {
                int x = int.Parse(str);
                if ( x > 0)
                {
                    Console.WriteLine("vai ter duas!");
                }
                else
                {
                    Console.WriteLine("vai ter copa!");
                }
            }
        }

    }

}