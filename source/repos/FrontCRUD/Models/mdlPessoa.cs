using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class MdlPessoa
    {
        public int id { get; set; }
        public string nome { get; set; }
        public long cpf { get; set; }
        public string endereco { get; set; }
        public string telefone { get; set; }

        public override bool Equals(object obj)
        {
            bool exit = false;
            if (typeof(MdlPessoa) == obj.GetType())
            {
                MdlPessoa _mdlPessoa = (MdlPessoa)obj;

                if (this.id.Equals(_mdlPessoa.id) && this.nome == _mdlPessoa.nome && this.cpf == _mdlPessoa.cpf && 
                    this.endereco == _mdlPessoa.endereco && this.telefone == _mdlPessoa.telefone)
                {
                    exit = true;
                }
                        
            }

            return exit;
        }
        public override string ToString()
        {
            return id + "-" + nome + "-" + cpf + "-" + endereco + "-" + telefone;
        }
    }
}
