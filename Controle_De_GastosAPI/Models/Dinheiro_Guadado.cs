using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Controle_De_GastosAPI.Models
{
    [Table("DepositoD")]
    public class Dinheiro_Guadado
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(200)]
        public string Descricao { get; set; }
        public Decimal Depositar { get; set; }
        [Required]
        public DateTime DateUso { get; set; }

        public Dinheiro_Guadado(string descrever, DateTime dateUso)
        {
            Descricao = descrever;
            DateUso = dateUso;
        }

        public void Gastar(Decimal deposito)
        {
            Banco dinheiro = new Banco();
            dinheiro.Saldo -= deposito;
            Depositar = dinheiro.Saldo;
        }
    }
}
