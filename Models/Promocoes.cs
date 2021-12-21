using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AgenciaBoaViagem.Models
{
    [Table("Cliente")]
    public class Promocoes
    {
        [Key]
        public int IdPromocao { get; set; }

        [Required(ErrorMessage = "Informe seu Nome.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Informe seu Email.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Informe o Telefone.")]
        public string Telefone { get; set; }


    }
}
