using System;

namespace ArrayMultidimencional
{
    public class ArrayMultidimencional
    {
        static void Main()
        {
            int[,] matriz = new int[4, 2];
            matriz[0, 0] = 10;
            matriz[1, 0] = 20;
            matriz[2, 0] = 30;
            matriz[3, 0] = 40;
            matriz[0, 1] = 50;
            matriz[1, 1] = 60;
            matriz[2, 1] = 70;
            matriz[3, 1] = 80;


            Console.WriteLine($"{matriz[0,0]} | {matriz[0,1]}");
            Console.WriteLine($"{matriz[1,0]} | {matriz[1,1]}");
            Console.WriteLine($"{matriz[2,0]} | {matriz[2,1]}");
            Console.WriteLine($"{matriz[3,0]} | {matriz[3,1]}");

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++) 
                {
                    Console.WriteLine(matriz[i,j]);
                }
            }
        }
    }
}