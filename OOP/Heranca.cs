namespace EstudosGerais.OOP
{
    //Superclasse - Classe Pai;
    public class Heranca
    {
        //public Heranca(string _nome)
        //{
        //    Nome = _nome;
        //}

        public string? Nome { get; set; }

        //virtual permite que o método seja sobreposto;
        public virtual void MetodoClassePai()
        {
            Console.WriteLine("Classe Pai.");
        }
    }

    //Subclasse - Classe filha - Herda da Superclasse;
    public class SubClasse : Heranca
    {
        public SubClasse()
        {

        }

        //override sobrepoem o método;
        public override void MetodoClassePai()
        {
            Console.WriteLine("Método Sobreposto - Classe Filha.");
        }
    }
}
