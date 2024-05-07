using Controle_De_GastosAPI.Interface;
using Controle_De_GastosAPI.Models;
using Controle_De_GastosAPI.Repository;
using Controle_De_GastosAPI.Services;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controle_GastosAPI.Test.GastoTest
{
    public class MockPessoaTest
    {
        [Fact(DisplayName = "Testando a lista de pessoas salvas")]
        public void testCadastroPessoa()
        {
            Mock<IRepository<Pessoa>> pessoa = new Mock<IRepository<Pessoa>>();
            pessoa.Setup(a => a.GetById(It.IsAny<int>())).Returns(2);
            PessoaServices services = new PessoaServices(pessoa.Object);

            var tesPessoa = new Pessoa() 
            {
                Created =  DateTime.Now ,
                Id = 2,
                Nome = "Admin"
            };

            //act

            var SaveMethod=()=> services.AdionarPessoa(tesPessoa);

            //assert
            var except = Assert.Throws<ArgumentException>(SaveMethod);
            Assert.Contains("Já existe essa pessoa", except.Message);

            Assert.Equal(2, tesPessoa.Id);
        }

        public void test2()
        {
            Mock<IRepository<Pessoa>> pessoa = new Mock<IRepository<Pessoa>>();
            pessoa.Setup(a => a.Add(It.IsAny<Pessoa>()));
            PessoaServices services = new PessoaServices(pessoa.Object);

            var tesPessoa = new Pessoa()
            {
                Created = DateTime.Now,
                Id = 2,
                Nome = "Admin"
            };

            //act

            var SaveMethod = () => services.AdionarPessoa(tesPessoa);

            //assert
            var except = Assert.Throws<ArgumentException>(SaveMethod);
            Assert.Contains("Já existe essa pessoa", except.Message);
        }
        private Pessoa person()
        {
            return new Pessoa()
            {
                Id = 4,
                Nome = "Henrique Soares",
                Created = DateTime.Now
            };
         }
    }
}
