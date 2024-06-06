using appMVC.models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace appMVC.Models
{
    public class mdlPessoa
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required(ErrorMessage ="O campo nome é obrigatório")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "O campo cpf é obrigatório")]
        public int Cpf { get; set; }
        public virtual mdlEndereco Endereco { get; set; }
        public int  EnderecoId { get; set; }
        public virtual List<mdlEndereco> Enderecos { get; set; }
        public int TelefoneId { get; set; }
        public mdlTelefone telefone { get; set; }
        //public virtual List<mdlTelefone> Telefones { get; set; }

    }
}
