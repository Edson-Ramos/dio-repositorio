
using System;


namespace Getters_and_Setters.Models
{
    public class Data
    {
        private int mes;
        private bool mesValido;

        //public int GetMes()
        //{
        //    return this.mes;
        //}

        //public void SetMes(int mes)
        //{
        //    if (mes > 0 && mes <= 12)
        //    {
        //        this.mes = mes;
        //        this.mesValido = true;
        //    }            
        //}

        public int Mes
        {
            get
            {
                return this.Mes;
            }
            set
            {
                if (value > 0 && value <= 12)
                {
                    this.mes = value;
                    mesValido = true;
                }
            }
        }

        public void ApresentarMes()
        {
            if (this.mesValido)
            {
                switch (this.mes)
                {
                    case 1:
                        Console.WriteLine("Mês de Janeiro");
                        break;
                    case 2:
                        Console.WriteLine("Mês de Fevereiro");
                        break;
                    case 3:
                        Console.WriteLine("Mês de Março");
                        break;
                    case 4:
                        Console.WriteLine("Mês de Abril");
                        break;
                    case 5:
                        Console.WriteLine("Mês de Maio");
                        break;
                    case 6:
                        Console.WriteLine("Mês de Junho");
                        break;
                    case 7:
                        Console.WriteLine("Mês de Julho");
                        break;
                    case 8:
                        Console.WriteLine("Mês de Agosto");
                        break;
                    case 9:
                        Console.WriteLine("Mês de Setembro");
                        break;
                    case 10:
                        Console.WriteLine("Mês de Outubro");
                        break;
                    case 11:
                        Console.WriteLine("Mês de Novembro");
                        break;
                    default:
                        Console.WriteLine("Mês de Dezembro");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Mês Invalido!");
            }
        }




       
    }

}
