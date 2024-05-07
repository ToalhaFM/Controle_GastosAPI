using Controle_De_GastosAPI.Interface;
using Controle_De_GastosAPI.Models;

namespace Controle_De_GastosAPI.Services
{
    public class BancoServices
    {
        private readonly IRepository<Banco> _bancoRepository;

        public BancoServices(IRepository<Banco> bancoRepository)
        {
            _bancoRepository = bancoRepository;
        }

        public void AdicionarBanco(Banco banco)
        {
            _bancoRepository.Add(banco);
        }

        public void AtualizarBanco(Banco banco)
        {
            _bancoRepository.Update(banco);
        }

        public void ExcluirBanco(Banco banco)
        {
            _bancoRepository.Delete(banco); 
        }

        public Banco ProcuraBanco(int BancoId)
        {
            return _bancoRepository.GetById(BancoId);
        }

        public IEnumerable<Banco> GetBancoList()
        {
            return _bancoRepository.GetAll();
        }
    }
}
