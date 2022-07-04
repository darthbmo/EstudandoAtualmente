using EstudosGerais.Facade_Pattern.Interfaces;

namespace EstudosGerais.Facade_Pattern
{
    public class FornecedorPizza : IPizza
    {
        void IPizza.BuscarPizzaNormal()
        {
            ObterRecheioNaoVegano();
        }

        void IPizza.BuscarPizzaVegana()
        {
            Console.WriteLine("Vegana...");
        }

        private void ObterRecheioNaoVegano()
        {
            Console.WriteLine("Obtendo...");
        }
    }
}
