using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Controle_De_GastosAPI.Models
{
    [Table("Pessoa")]
    public class Pessoa
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(70)]
        public string? Nome { get; set; }
        [Required]
        public DateTime Created { get; set; }
    }
}
