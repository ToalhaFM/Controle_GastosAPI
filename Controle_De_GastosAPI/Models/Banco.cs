using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Controle_De_GastosAPI.Models
{
    [Table("Banco")]
    public class Banco
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public Decimal Saldo { get; set; }
        [Required]
        public int pessoa {  get; set; }
        [JsonIgnore]
        public Pessoa? Dono { get; set; }
    }
}
