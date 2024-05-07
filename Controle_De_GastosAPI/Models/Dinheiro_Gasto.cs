using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Controle_De_GastosAPI.Models
{
    [Table("Dinheiro_Gasto")]
    public class Dinheiro_Gasto
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(200)]
        public string Descricao { get; set; }
        public Decimal Gasto { get; set; }
        [Required]
        public DateTime DateUso { get; set; }

        public void Gastar(Decimal gasto)
        {
            Banco dinheiro = new Banco();
            dinheiro.Saldo -= gasto;
            Gasto = gasto;
        }
    }
}
