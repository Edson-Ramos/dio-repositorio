using System;

namespace Getters_and_Setters.Models
{
    public class Program
    {
        static void Main()
        {
            Data d1 = new Data();
            //d1.SetMes(10);

            d1.Mes = 2;
            d1.ApresentarMes(); 
        }
    }
}