using Controle_De_GastosAPI.Interface;
using Controle_De_GastosAPI.Models;

namespace Controle_De_GastosAPI.Services
{
    public class GastoServices
    {
        private readonly IRepository<Dinheiro_Gasto> _service;

        public GastoServices(IRepository<Dinheiro_Gasto> service)
        {
            _service = service;
        }

        public void AddGastos(Dinheiro_Gasto gastos)
        {
            _service.Add(gastos);
        }

        public void ExcluirGastos(Dinheiro_Gasto excluir)
        {
            _service.Delete(excluir);
        }

        public void AtualizaGastos(Dinheiro_Gasto Up) 
        {
            _service.Update(Up);
        }

        public IEnumerable<Dinheiro_Gasto> ListarGastos()
        {
            return _service.GetAll();
        }

        public Dinheiro_Gasto Get(int id)
        {
            return _service.GetById(id);
        }
    }
}
