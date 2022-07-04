using EstudosGerais.Facade_Pattern.Interfaces;

namespace EstudosGerais.Facade_Pattern
{
    public class FacadeRestaurant
    {
        private IPizza _Fornecedor;

        public FacadeRestaurant()
        {
            _Fornecedor = new FornecedorPizza();
        }

        public void BuscarPizzaNormal()
        {
            _Fornecedor.BuscarPizzaNormal();
        }

        public void BuscarPizzaVegana()
        {
            _Fornecedor.BuscarPizzaVegana();
        }
    }
}
