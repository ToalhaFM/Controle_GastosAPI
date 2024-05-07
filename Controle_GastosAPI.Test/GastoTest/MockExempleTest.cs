using Controle_De_GastosAPI.Interface;
using Controle_De_GastosAPI.Models;
using Controle_De_GastosAPI.Repository;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controle_GastosAPI.Test.GastoTest
{
    public class MockExempleTest
    {

        [Fact]
        public void Test() 
        {
            Mock<Repository<Dinheiro_Gasto>> gasto = new Mock<Repository<Dinheiro_Gasto>>();
            gasto.Setup(a =>  a.GetAll()).Returns(Compra);
        }

        private Dinheiro_Gasto Compra()
        {
            return new Dinheiro_Gasto()
            {
                Descricao = "Pizza 8 pedaços sabor frango com catupiry",
                Id = 3,
                Gasto = 58,
                DateUso = DateTime.Now,
            };
        }
    }
}
