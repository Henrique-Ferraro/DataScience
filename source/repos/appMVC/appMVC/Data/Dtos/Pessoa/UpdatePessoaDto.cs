using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace appMVC.Data.Dtos
{
    public class UpdatePessoaDto
    {
        [Required(ErrorMessage = "O campo nome é obrigatório")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "O campo cpf é obrigatório")]
        public int Cpf { get; set; }
        public string Endereco { get; set; }
        public string Telefone { get; set; }
    }
}
