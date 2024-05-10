using Controle_De_GastosAPI.Models;

namespace Controle_De_GastosAPI.Interface
{
    public interface IBancoServices
    {
        public void AdicionaBanco(Banco banco);
        public void AtualizaBanco(Banco banco);
        public void DeletaBanco(int id);
        public Task<Banco> ProcuraIdBanco(int id);
        public Task<IEnumerable<Banco>> ListaBanco();
    }
}
