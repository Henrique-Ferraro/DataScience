using appMVC.Models;
using System.ComponentModel.DataAnnotations;

namespace appMVC.models
{
    public class mdlTelefone
    {
        internal object TelefoneId;

        [Key]
        [Required]
        public int Id { get; set; }
        [Required(ErrorMessage = "o campo numero é obrigatório")]
        public int Numero { get; set; }
        [Required(ErrorMessage = "o campo numero é obrigatório")]
        public int Ddd { get; set; }
        [Required(ErrorMessage = "o campo tipo telefone é obrigatório")]
        public int TipoTelefone { get; set; }
        public virtual mdlPessoa Pessoas { get; set; }

    }
}
