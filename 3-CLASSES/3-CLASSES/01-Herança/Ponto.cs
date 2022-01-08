using System;

namespace Classes.Herança
{
    public class Ponto
    {
        //variaveis do tipo publicas temos acesso a qualquer lugar do meu codigo que eu instanciar o objeto "Ponto"
        public int x, y;

        // variavel do tipo privata só é acessado aqui dentro da classe
        private int distancia;

         // Construtor do tipo publico onde ja referência a variavél x e y
        public Ponto(int x, int y)
        {
            this.x = x;
            this.y = y; 
        }

        // esse Método protected, quem herda essa classe terá acesso a este método
        protected void CalcularDistancia()
        {
            //Faz Alguma Coisa...
        }

        // esse método só é ultilizado aqui dentro da classe
        private void CalcularDistancia2()
        {
            //Faz Alguma Coisa...
        }

        // Este Método Permite que uma classe filha sobescreva a atuação dele.
        public virtual void CalcularDistancia3()
        {
            //Faz Alguma Coisa...
        }
    }
}