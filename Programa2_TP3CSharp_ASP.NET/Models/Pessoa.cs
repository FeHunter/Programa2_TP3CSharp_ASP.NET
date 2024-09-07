using System.ComponentModel.DataAnnotations;

namespace Programa2_TP3CShpar_ASP.NET.Models
{
    public class Pessoa
    {
        [Key]
        public int PessoaId { get; set; }

        [Required(ErrorMessage = "Nome obrigatório")]
        [StringLength(100, ErrorMessage = "Nome muito longo")]
        public string Nome { get; set; }
        public string Nacionalidade { get; set; }
        public int Idade { get; set; }

        // Relacionamento um-pra-um
        public Passaporte Passaporte { get; set; }
    }
}
