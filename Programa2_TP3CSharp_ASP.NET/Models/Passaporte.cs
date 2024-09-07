using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Programa2_TP3CShpar_ASP.NET.Models
{
    public class Passaporte
    {
        [Key]
        [ForeignKey("Pessoa")]
        public int PassaportId { get; set; }

        [Required(ErrorMessage = "Nome do Passaporte obrigatório")]
        public string PassaportType { get; set; }
        public string PaisDeOrigem { get; set; }

        // Relacionamento um-pra-um
        public Pessoa? Pessoa { get; set; }
    }
}
