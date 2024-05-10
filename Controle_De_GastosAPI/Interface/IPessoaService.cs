using Controle_De_GastosAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace Controle_De_GastosAPI.Interface
{
    public interface IPessoaService
    {
        public Pessoa ProcurarID(int ID);
        public void AdicionaPessoa(Pessoa pessoa);
        public void AtualizaPessoa(Pessoa pessoa);
        public void DeletaPessoa(int id);
        public Task<IEnumerable<Pessoa>> Lista();
    }
}
