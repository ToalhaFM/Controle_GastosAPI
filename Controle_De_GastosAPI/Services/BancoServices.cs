using Controle_De_GastosAPI.Interface;
using Controle_De_GastosAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace Controle_De_GastosAPI.Services
{
    public class BancoServices : IBancoServices
    {
        private readonly RepositoryPatternContext _Context;
        private DbSet<Banco> _bancoSet;

        public BancoServices(RepositoryPatternContext context)
        {
            _Context = context;
        }

        public void AdicionaBanco(Banco banco)
        {
            _Context.Banco.Add(banco);
            _Context.SaveChanges();
        }

        public void AtualizaBanco(Banco banco)
        {
            _Context.Banco.Update(banco);
            _Context.SaveChanges();
        }

        public void DeletaBanco(int id)
        {
            var Del = _Context.Banco.FirstOrDefault(x => x.Id == id);
            if (Del != null) 
            {
                _Context.Banco.Remove(Del);
                _Context.SaveChanges();
            }
        }

        public async Task<IEnumerable<Banco>> ListaBanco()
        {
            var Ban = await _Context.Banco.ToListAsync();
            return Ban;
        }

        public async Task<Banco> ProcuraIdBanco(int id)
        {
            var Mostra = await _Context.Banco.FirstOrDefaultAsync(x => x.Id == id);
            return Mostra;
        }
    }
}
