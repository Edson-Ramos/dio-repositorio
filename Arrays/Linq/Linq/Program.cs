using System;

namespace Linq
{
    public class Linq
    {
        static void Main()
        {
            int[] arrayNumeros = new int[10] { 1, 2, 3, 4, 5, 6, 6, 100,100,3 };

            var minimo = arrayNumeros.Min();
            var maximo = arrayNumeros.Max();
            var medio = arrayNumeros.Average();
            var soma = arrayNumeros.Sum();
            var distinto = arrayNumeros.Distinct().ToArray();  

            Console.WriteLine($"Minimo : {minimo}, Maximo: {maximo}, Médio: {medio}");
            Console.WriteLine($"Soma : {soma}, Valores Distintos {string.Join(", ", distinto)}");



            //Querys e Method para fazer uma operação em uma array
            //var numerosParesQuerys =
            //    from num in arrayNumeros
            //    where num % 2 == 0
            //    orderby num
            //    select num;

            //var numerosParesMetodo = arrayNumeros.Where(x => x % 2 == 0).OrderBy(x => x).ToList();


            //Console.WriteLine($"Numeros Pares Querys: " + string.Join(", ", numerosParesQuerys));
            //Console.WriteLine($"Numeros Pares Metodo: " + string.Join(", ", numerosParesMetodo));
        }
    }
}