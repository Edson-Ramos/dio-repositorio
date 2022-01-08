using System;

namespace PolimorfismoTempoDeComplilação.Models
{
    public class Calculadora
    {
        public int Somar(int Num1, int Num2)
        {
            return Num1 + Num2;
        }


        public int Somar(int Num1, int Num2, int Num3)
        {
            return Num1 + Num2 + Num3;
        }
    }
}
