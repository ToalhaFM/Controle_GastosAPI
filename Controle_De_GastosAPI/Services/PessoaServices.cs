using Controle_De_GastosAPI.Interface;
using Controle_De_GastosAPI.Models;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Controle_De_GastosAPI.Services
{
    public class PessoaServices : IPessoaService
    {

        private readonly RepositoryPatternContext _Context;
        private DbSet<Pessoa> _PessoaSet;


        public PessoaServices(RepositoryPatternContext context)
        {
            _Context = context;
            
        }

        public async Task<IActionResult> AdicionaPessoa(Pessoa pessoa)
        {
            await _Context.Pessoa.AddAsync(pessoa);
            await _Context.SaveChangesAsync();
            return new CreatedAtActionResult(nameof(Pessoa), "Pessoa", new
            {
                id = pessoa.Id
            }, pessoa);
        }

        public void AtualizaPessoa(Pessoa pessoa)
        {
            _Context.Pessoa.Update(pessoa);
            _Context.SaveChanges();
        }

        public void DeletaPessoa(int id)
        {
            var primario =  _Context.Pessoa.FirstOrDefault(p => p.Id == id);
            _Context.Remove<Pessoa>(primario);
            _Context.SaveChanges(true);

            
        }

        public async Task<IEnumerable<Pessoa>> Lista()
        {
            var ip = await _Context.Pessoa.ToListAsync();
            return ip;
        }

        public Pessoa ProcurarID(int ID)
        {
            var person =  _Context.Pessoa.FirstOrDefault(c => c.Id == ID);
            return person;
        }

        void IPessoaService.AdicionaPessoa(Pessoa pessoa)
        {
            _Context.Pessoa.Add(pessoa);
            _Context.SaveChanges();
        }
    }
}
