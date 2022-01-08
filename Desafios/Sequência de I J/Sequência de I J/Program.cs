using System;

namespace Sequência_de_i_j
{
    public class Program
    {
        static void Main(string [] args)
        {
            
            for (int i = 1; i <= 9; i++)
            {
                if (i % 2 == 1)
                {
                    for (int j = 7; j >= 5 && j <= 7; j--)
                    {
                        int I = i;
                        int J = j;
                        Console.WriteLine($"I={I} J={J}");
                    }
                }
            }
        }
    }
}

