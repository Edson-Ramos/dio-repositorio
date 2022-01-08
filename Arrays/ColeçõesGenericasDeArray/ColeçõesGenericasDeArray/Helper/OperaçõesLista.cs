using System;
using System.Collections.Generic;


namespace ColeçõesGenericasDeArray.Helper
{
    public class OperaçõesLista
    {
        public void ExibirLista(List<string> lista)
        {
            for (int i = 0; i < lista.Count; i++)
            {
                Console.WriteLine($"Pocição {i}, Valor {lista[i]}");
            }
        }

    }
}
