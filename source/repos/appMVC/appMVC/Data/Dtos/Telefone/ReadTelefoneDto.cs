using appMVC.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace appMVC.Data.Dtos
{
    public class ReadTelefoneDto
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required(ErrorMessage = "o campo numero é obrigatório")]
        public int Numero { get; set; }
        [Required(ErrorMessage = "o campo numero é obrigatório")]
        public int Ddd { get; set; }
        [Required(ErrorMessage = "o campo tipo telefone é obrigatório")]
        public int TipoTelefone { get; set; }
        [JsonIgnore]
        public virtual mdlPessoa Pessoa{ get; set; }
    }
}
