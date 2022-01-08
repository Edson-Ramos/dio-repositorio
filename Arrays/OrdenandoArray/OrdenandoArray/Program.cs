using OrdenandoArray.Helper;
using System;

namespace OrdenandoArray
{
    public class OrdenandoArrays
    {
        static void Main()
        {

            OperaçõesArray op = new OperaçõesArray();
            int[] array = { 6, 3, 8, 1, 9 };
            int[] arraycopy = new int[10];
            int valorProcurado = 10;
            int novoTamanho = 20;

            //Converter uma Array do Tipo Inteiro Para o Tipo String
            //string[] arrayString = op.AlteraTipo(array);
            //op.ImprimiArrayString(arrayString);



            //Aumenta o Tamanho da array em tempo de execução
            //Console.WriteLine($"Capacidade Atual do Array {array.Length}");
            //op.ImprimirArray(array);

            //op.RedimencionarArray(ref array, novoTamanho);

            //Console.WriteLine($"Capacidade Atual do Array Após Redimencionar {array.Length}");
            //op.ImprimirArray(array);


            //Procurando o Indece do Valor procurado se ele estiver dentro da array
            //int indexProcurado = op.ObterIndece(array, valorProcurado);

            //if (indexProcurado > -1)
            //{
            //    Console.WriteLine($"O Indece do Elemento {valorProcurado} é: {indexProcurado}");
            //}
            //else
            //{
            //    Console.WriteLine("O Valor Não foi Encontrado!");
            //}

            //Procura um Valor dentro de uma Array
            //int valorAchado = op.ObterValor(array, valorProcurado);

            //if (valorAchado > 0)
            //{
            //    Console.WriteLine($"Encontrei o Valor {valorAchado}");
            //}
            //else
            //{
            //    Console.WriteLine($"Valor {valorProcurado} Não Achado");
            //}


            // Verifica dentro de uma array de existe valor maior do que o informado
            //bool todosMaiorQue = op.TodoMaiorQue(array, valorProcurado);

            //if (todosMaiorQue)
            //{
            //    Console.WriteLine($"Todos os Valores São Maior Que {valorProcurado}");
            //}
            //else
            //{
            //    Console.WriteLine($"Existe Valores Que Não São Maiores do que o Valor Procurado: {valorProcurado} ");
            //}


            // Procura um Valor especificado dentro do array
            //bool valor = op.Existe(array, valorProcurado);

            //if (valor)
            //{
            //    Console.WriteLine($"Encontrei o valor: {valorProcurado}");
            //}
            //else
            //{
            //    Console.WriteLine("Não Encontrei o Valor Procurado");
            //}

            // imprimi uma array
            //Console.WriteLine("Array Original:");
            //op.ImprimirArray(array);

            // Ordena uma array com o método bebbleSort
            // op.OrdenarBubbleSort(ref array);
            // op.Ordenar(ref array);
            //Console.WriteLine("Array Ordenada:");
            //op.ImprimirArray(array);

            //Copia uma array para outra array
            //Console.WriteLine("Array Copia Antes da Ação");
            //op.ImprimirArray(arraycopy);
            //op.Copiar(ref array, ref arraycopy);
            //Console.WriteLine("Array Copia Após Copiar");
            //op.ImprimirArray(arraycopy);



        }
    }
}