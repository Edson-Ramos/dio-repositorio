using System;

namespace Instrucoes
{
    class Program
    {
        static void Declaracoes()
        {
            int a;
            int b = 2, c = 3;
            const int d = 4;
            a = 1;
            Console.WriteLine(a + b + c + d);
        }

        static void InstrucoesIF(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("Nenhum Argumento");
            }
            else if (args.Length == 1)
            {
                Console.WriteLine("Um Argumento");
            }
            else
            {
                Console.WriteLine($"{args.Length} argumentos");
            }
        }
        static void InstrucoesSwitch(string[] args)
        {
            int numeroDeArgumentos = args.Length;
            switch (numeroDeArgumentos)
            {
                case 0:
                    Console.WriteLine("Nenhum Argumento");
                    break;
                case 1:
                    Console.WriteLine("Um Argumento");
                    break ;
                default:
                    Console.WriteLine($"{args.Length} Argumentos");
                    break;
            }
        }
        static  void InstrucoesWhile(string[] args)
        {
            int i = 0;
            while (i < args.Length)
            {
                Console.WriteLine(args[i]);
                i++;
            }
        }
        static void InstrucoesDo(string[] args)
        {
            string texto;
            do
            {
                texto = Console.ReadLine();
                Console.WriteLine(texto);
            }while (string.IsNullOrEmpty(texto));
        }
        static void InstrucoesFor(string[] args)
        {
            for (int i = 0; i < args.Length; i++)
            {
                Console.WriteLine(args[i]);
            }
        }
        static void IntrucoesForeach(string[] args)
        {
            foreach(string s in args)
            {
                Console.WriteLine(s);            }
        }
        static void InstrucoesBreak(string[] args)
        {
            while (true)
            {
                string s = Console.ReadLine();
                if (string.IsNullOrEmpty(s))
                {
                    break;
                }
                else
                {
                    Console.WriteLine(s);
                }
            }
        }
        static void InstrucoesContinue(string[] args)
        {
            for(int i = 0; i < args.Length; i++)
            {
                if (args[i].StartsWith("/"))
                {
                    continue;
                }
                else
                {
                    Console.WriteLine(args[i]);
                }
            }

        }
        static void InstrucoesReturn()
        {
            int Somar(int a, int b)
            {
                return a + b;
            }

            Console.WriteLine(Somar(1,2));
            Console.WriteLine(Somar(3,4));
            Console.WriteLine(Somar(5,6));
            return;
        }
        static void InstrucoesTryCatchFinallyThrow(string[] args)
        {
            double Dividir(double x, double y)
            {
                if (y == 0)
                    throw new DivideByZeroException();

                return x / y;
                
            }
            try
            {
                if (args.Length != 2)
                {
                    throw new InvalidOperationException("Informe 2 Números");
                }   

                double x = double.Parse(args[0]);
                double y = double.Parse(args[1]);
                Console.WriteLine(Dividir(x, y));
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine($"Erro Genérico: {e.Message}");
            }
            finally
            {
                Console.WriteLine("Até Breve!");
            }
        }
        static void InstrucoesUsing(string[] args)
        {   
            //Cria um arquivo de texto e escreve algumas linhas
            using (System.IO.TextWriter w = System.IO.File.CreateText("teste.txt"))
            {
                w.WriteLine("Line 1");
                w.WriteLine("Line 2");
                w.WriteLine("Line 3");
            }
        }
    }
}