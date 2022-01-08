﻿using System;


namespace OrdenandoArray.Helper
{
    public class OperaçõesArray
    {
        public void OrdenarBubbleSort(ref int[] array)
        {
            int temp = 0;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length -1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        temp = array[j + 1];
                        array[j + 1] = array[j];
                        array[j] = temp;
                    }            
                }
            }
        }

        public void ImprimirArray(int[] array)
        {
            var linha = string.Join(", ", array);            
            
              Console.WriteLine(linha);
        }

        public void ImprimiArrayString(string[] array)
        {
            var linha = string.Join(", ", array);
            Console.WriteLine(linha);
        }

        public void Ordenar(ref int[] array)
        {
            Array.Sort(array);
        }

        public void Copiar(ref int[] array, ref int[] arrayDeDestino)
        {
            Array.Copy(array, arrayDeDestino, array.Length);
        }
        public bool Existe(int[] array, int valor)
        {
            return Array.Exists(array, elemento => elemento == valor);
        }

        public bool TodoMaiorQue(int[] array, int valor)
        {
            return Array.TrueForAll(array, elemento => elemento > valor);
        }

        public int ObterValor(int[] array, int valor)
        {
            return Array.Find(array, elemento => elemento == valor);
        }

        public int ObterIndece(int[] array, int valor)
        {
            return Array.IndexOf(array, valor);
        }

        public void RedimencionarArray(ref int[] array, int novoTamanho)
        {
            Array.Resize(ref array, novoTamanho);
        }

        public string[] AlteraTipo(int[] array)
        {
            return Array.ConvertAll(array, elemento => elemento.ToString());
        }

    }
}
