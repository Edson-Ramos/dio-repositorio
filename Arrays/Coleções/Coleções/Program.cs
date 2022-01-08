using System;

namespace Coleções
{
    public class Coleções
    {
        static void Main()
        {
            int[] arrayInteiros = new int[5];

            arrayInteiros[0] = 10;
            arrayInteiros[1] = 20;
            arrayInteiros[2] = 30;
            arrayInteiros[3] = 40;
            arrayInteiros[4] = 50; 

            foreach ( int i in arrayInteiros )
            {
                Console.WriteLine(i);
            }
            
        }
    }
}