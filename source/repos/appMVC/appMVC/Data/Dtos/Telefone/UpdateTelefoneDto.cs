using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace appMVC.Data.Dtos
{
    public class UpdateTelefoneDto
    {
        [Required(ErrorMessage = "o campo numero é obrigatório")]
        public int Numero { get; set; }
        [Required(ErrorMessage = "o campo numero é obrigatório")]
        public int Ddd { get; set; }
        [Required(ErrorMessage = "o campo tipo telefone é obrigatório")]
        public int TipoTelefone { get; set; }
    }
}
