using Controle_De_GastosAPI.Models;

namespace Controle_De_GastosAPI.Interface
{
    public interface IGastosServices
    {
        public String Compra(Dinheiro_Gasto val);
        public void AtualizaGasto(Dinheiro_Gasto val);
        public Task<IEnumerable<Dinheiro_Gasto>> ListarCompra();
        public Task<Dinheiro_Gasto> ProcurarIdCompra(int id);

    }
}
