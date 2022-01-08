using System;
 
namespace SequênciaS
{

    public class Program
    {
        static void Main()
        {           
            double a, c, s = 0;
            for  (a = 1; a <= 100; a++)
            {
                c = 1 / a;
                s = s + c;         
            }
            var x = Math.Round(s, 2);
            Console.WriteLine(x);
        }
    }
}   