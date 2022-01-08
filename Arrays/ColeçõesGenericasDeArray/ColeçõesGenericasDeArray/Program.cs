using ColeçõesGenericasDeArray.Helper;
using System;
using System.Collections.Generic;

namespace ColeçõesGenericas
{
    public class Program
    {
        static void Main()
        {
            OperaçõesLista opLista = new OperaçõesLista();
            List<string> estados = new List<string>();
            string[] estadosArray = new string[2] { "CE", "RN" };

            estados.Add("SP");
            estados.Add("BA");
            estados.Add("PE");
            estados.Add("MG");

            Console.WriteLine($"Quantidade de Elementos na Lista:{estados.Count}");

            estados.Insert(1, "RJ");
            // estados.AddRange(estadosArray);

            opLista.ExibirLista(estados);

            //Console.WriteLine("Removendo Um Elemento");
            //estados.Remove("MG");
            //opLista.ExibirLista(estados);

        }
           
    }
}