using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AgenciaBoaViagem.Models
{
    [Table("Contato")]
    public class Contato
    {

        [Key]
        public int IdContato { get; set; }

        [Required(ErrorMessage = "Informe seu Nome.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Informe seu Email.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Informe o Assunto.")]
        public string Assunto { get; set; }

        [Required(ErrorMessage = "Informe a Mensagem.")]
        public string Mensagem { get; set; }

    }
}
