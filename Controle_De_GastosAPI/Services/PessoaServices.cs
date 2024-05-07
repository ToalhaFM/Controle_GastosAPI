using Controle_De_GastosAPI.Interface;
using Controle_De_GastosAPI.Models;

namespace Controle_De_GastosAPI.Services
{
    public class PessoaServices
    {
        private readonly IRepository<Pessoa> _pessoaRepository;

        public PessoaServices(IRepository<Pessoa> pessoaRepository)
        {
            _pessoaRepository = pessoaRepository;
        }

        public void AdionarPessoa(Pessoa pessoa)
        {
            _pessoaRepository.Add(pessoa);
        }

        public void AtualizandoPessoa(Pessoa pessoa)
        {
            _pessoaRepository.Update(pessoa);
        }

        public void ExcluindoPessoa(Pessoa pessoa)
        {
            _pessoaRepository.Delete(pessoa);
        }

        public Pessoa ProcuraId(int procuraId)
        {
            return _pessoaRepository.GetById(procuraId);
        }

        public IEnumerable<Pessoa> ListarPessoa()
        {
            return _pessoaRepository.GetAll(); 
        }
    }
}
