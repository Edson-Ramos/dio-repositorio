
using System;

class Program
{
	static void Main(string[] args)
	{
		int c = 0;
		int n = 0;
		int i;
		int max;
		int atual;

		string tempVar = Console.ReadLine();
		if (tempVar != null)
		{
			c = int.Parse(tempVar);
		}
		while ((c--) != 0)
		{
			string tempVar2 = Console.ReadLine();
			if (tempVar2 != null)
			{
				n = int.Parse(tempVar2);
			}

			if (n == 2 || n == 3)
			{
				Console.WriteLine("{0:D}\n", n - 1);
			}
			else
			{
				max = 5;
				atual = 2;
				for (i = 4; i <= n;)
				{
					if (i + max > n)
					{
						break;
					}
					else
					{
						i += max;
						max += 2;
						atual++;
					}
				}
				Console.Write("{0:D}\n", n - atual);
			}
		}


	}
}


////using System;
////using System.Collections.Generic;
////using System.Text;

////namespace Dio
////{
////    class Xenlongao
////    {
////        static void Main(string[] args)
////        {
////            double c = 1 , n = 7;



////            while (n-- > c)
////            {
////                var resto = c % n;

////                Console.WriteLine(Math.Round(resto, 2));

////                //if (resto == 0)
////                //{
////                //    int valor = 1;
////                //    int novoValor = 0;
////                //    novoValor = novoValor + valor;
////                //    Console.WriteLine(novoValor);
////                //}
////            }            

////            //int C = Convert.ToInt32(Console.ReadLine());
////            //int N = Convert.ToInt32(Console.ReadLine());
////            //while (N-- > C)
////            //{
////            //    int val = N %                               ;
////            //    int newval =                         ;        //complete com a sua lógica
////            //    int resposta =                      ;
////            //    Console.WriteLine(resposta);
////            //}
////        }
////    }
////}





//using System;

//namespace Xenlongão
//{
//    public class program
//    { 
//        static void Main(string[] args)
//        {
//            int C = Convert.ToInt32(Console.ReadLine());
//            int N = Convert.ToInt32(Console.ReadLine());
//            int novoValor = 0;

//            while (N-- > 0)
//            {       
//                    int div = C % N;

//                Console.WriteLine(div);
//                //if (div == 0)
//                //{
//                //    int valor = 1;
//                //    novoValor += valor;
//                //}
//            }

//        }
//    }
//}



