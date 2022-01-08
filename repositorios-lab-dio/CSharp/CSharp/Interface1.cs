
namespace Interface1

{
    interface IAnimal
    {
        void Nome(string nome);
        void Dono(string nomeDono);
        void especie(string especie);

     }

    class Animal: IAnimal
    {
        public string Nome { get; set; }
        public string NomeDono { get; set; }
        public string especie { get; set; }



        void IAnimal.Nome(string nome)
        {
            this.Nome = nome;
        }
        void IAnimal.Dono(string nomeDono)
        {
            this.NomeDono = nomeDono;
        }

    void IAnimal.especie(string especie)
        {
            this.especie = especie;
        }
    }
}
