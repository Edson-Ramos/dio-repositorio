using System;

namespace Classes.Herança
{
    //":" Significa que "Ponto3d" Herda da Classe "Ponto" que seja publico, protected ou
    //interno(porque a classe Ponto3D esta dentro do mesmo projeto)
    public class Ponto3D : Ponto
    {
        public int z;
        public Ponto3D(int x, int y, int z) : base(x, y)
        {
            this.z = z;
            CalcularDistancia();
        }
        // declaração de um membro statico que para acessa esse método não e necessário instanciar
        public static void Calcular()
        {
            //Faz Alguma Coisa...
        }
        //sobrescreve a classe pai onde tem o "Vitural".
        public override void CalcularDistancia3()
        {
            //Faz Alguma Coisa...
        }
    }
}