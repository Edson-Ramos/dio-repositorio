using System;


namespace Interfaces.Interfaces
{
    public interface ICalculadora
    {
        int Somar(int x, int y);
        int Sub (int x, int y);
        int Mult (int x, int y);
        int Div  (int x, int y)
        {
            return x / y;
        }
    }
}
