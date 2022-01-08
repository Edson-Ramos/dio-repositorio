using System;


namespace ProjetoSeries.Classes
{
    public class Serie : EntidadeBase
    {
        //Atributos
        private Genero Genero { get; set; }
        private string Titulo { get; set; }
        private string Descrição { get; set; }
        private int Ano { get; set; }

        private bool Excluido { get; set; }

        //Método
        public Serie(int id, Genero genero, string titulo, string descricao, int ano)
        {
            this.Id = id;
            this.Genero = genero;
            this.Titulo = titulo;
            this.Descrição = descricao;
            this.Ano = ano;
            this.Excluido = false;
        }
        
        public override string ToString()
        {
            //Environment.NewLine(https://docs.microsoft.com/en-us/dotnet/api/system.environment.newline?view-netcore-3.1)
            string retorno = "";
            retorno += "Genero: " + this.Genero + Environment.NewLine;
            retorno += "Titulo: " + this.Titulo + Environment.NewLine;
            retorno += "Descrição: " + this.Descrição + Environment.NewLine;
            retorno += "Ano de Inicio: " + this.Ano + Environment.NewLine;
            retorno += "Excluido: " + this.Excluido + Environment.NewLine;
            return retorno;
           
        }

        public string rotornaTitulo()
        {
            return this.Titulo;
        }

        public int retornaId()
        {
            return this.Id;
        }

        public bool retornaExcluido()
        {
            return this.Excluido;
        }

        public void Exclui()
        {
            this.Excluido = true;
        }
    }
}
