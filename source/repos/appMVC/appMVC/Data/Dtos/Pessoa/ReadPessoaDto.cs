using appMVC.models;
using appMVC.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace appMVC.Data.Dtos
{
    public class ReadPessoaDto
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required(ErrorMessage = "O campo nome é obrigatório")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "O campo cpf é obrigatório")]
        public int Cpf { get; set; }
        [JsonIgnore]
        public virtual mdlEndereco Endereco { get; set; }
        [JsonIgnore]
        public virtual mdlTelefone Telefone { get; set; }
    }
}
