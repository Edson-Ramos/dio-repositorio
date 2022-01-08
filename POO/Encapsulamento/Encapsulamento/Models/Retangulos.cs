using System;


namespace Encapsulamento.Models
{   //Classe Retangulos
    public class Retangulos
    {
        // Criando propriedades encapsuladas que so pode ser alteradas dentro da propria classe
        private double comprimento;
        private double largura;
        private bool validacao;

        // criando um método para alterar as propriedades encapsuladas(privadas)
        public void DefinirMedidas(double comprimento, double largura)
        {
            //criando uma validação para poder alterar as propriedades somentes se os valores forem validos
            if (comprimento > 0 && largura > 0)
            {
                this.comprimento = comprimento;
                this.largura = largura;
                validacao = true;
            }
            else
            {
                Console.WriteLine("Valores Não São Válidos!");
            }
        }

        // metodo de retorno de calculo de area apos obter valores válidos
        public double ObterArea()
        {
            //outra validação
            if (validacao)
            {
                return comprimento * largura;
            }
            else
            {
                Console.WriteLine("Digite Valores Válidos");
                return 0;
            }
        }
    }
}
