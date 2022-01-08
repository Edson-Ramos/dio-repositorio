using System;

namespace Sucessor_Par
{
    public class program
    {
        static void Main(string[] args)
        {          
                 int x = int.Parse(Console.ReadLine());      

                if (x % 2 == 0)
                {
                    int par = x + 2;
                    Console.WriteLine(par);
                }
                else
                {
                    int impar = x + 1;
                    Console.WriteLine(impar);
                }
        }   
    }

}