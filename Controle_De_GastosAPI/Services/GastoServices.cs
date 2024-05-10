using Controle_De_GastosAPI.Interface;
using Controle_De_GastosAPI.Models;

namespace Controle_De_GastosAPI.Services
{
    public class GastoServices : IGastosServices
    {
        private readonly RepositoryPatternContext _Context;

        public GastoServices(RepositoryPatternContext context)
        {
            _Context = context;
        }

        public void AtualizaGasto(Dinheiro_Gasto val)
        {
            throw new NotImplementedException();
        }

        public string Compra(Dinheiro_Gasto val)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Dinheiro_Gasto>> ListarCompra()
        {
            throw new NotImplementedException();
        }

        public Task<Dinheiro_Gasto> ProcurarIdCompra(int id)
        {
            throw new NotImplementedException();
        }
    }
}
