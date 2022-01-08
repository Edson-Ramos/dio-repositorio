using System;
using System.Collections.Generic;

namespace Dicionario
{
    public class Dicionario
    {
        static void Main()
        {
            Dictionary<string, string> estados = new Dictionary<string, string>();

            estados.Add("PE", "Pernambuco");
            estados.Add("SP", "São Paulo");
            estados.Add("BA", "Bahia");
            estados.Add("Pe", "Pernambuco");

            foreach (KeyValuePair<string, string> item in estados)
            {
                Console.WriteLine($"Chave: {item.Key}, Valor {item.Value}");
            }

            string valorProcurado = "SC";

            // var teste = estados["SC"];
            //Console.WriteLine($"{estados[valorProcurado]}");
            //estados["BA"] = "BA - TesteAtt";
            //Console.WriteLine($"{estados[valorProcurado]}");
            //estados.Remove(valorProcurado);

            //foreach (KeyValuePair<string, string> item in estados)
            //{
            //    Console.WriteLine($"Chave: {item.Key}, Valor {item.Value}");

            //}

            // Tratando Excessão de Procurar Um Valor que Não existe no dicionário
            if (estados.TryGetValue(valorProcurado, out string estadoEncotrado))
            {
                Console.WriteLine(estadoEncotrado);
            }
            else
            {
                Console.WriteLine($"Chave {valorProcurado} Não Existe No Dicionario");
            }
            

        }
    }
}