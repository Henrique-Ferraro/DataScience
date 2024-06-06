using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace appMVC.Data.Dtos
{
    public class CreateEnderecoDto
    {

        [Required(ErrorMessage = "O campo logradouro é obrigatório")]
        public string Logradouro { get; set; }
        [Required(ErrorMessage = "O campo numero é obrigatório")]
        public int Numero { get; set; }
        [Required(ErrorMessage = "O campo cep é obrigatório")]
        public int cep { get; set; }
        [Required(ErrorMessage = "O campo bairro é obrigatório")]
        public string Bairro { get; set; }
        [Required(ErrorMessage = "O campo cidade é obrigatório")]
        public string Cidade { get; set; }
        [Required(ErrorMessage = "O campo estado é obrigatório")]
        public string Estado { get; set; }
    }
}
