using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class mdlEndereco
    {
        public static object Items { get; set; }
        public int id { get; set; }
        public string logradouro { get; set; }
        public int numero { get; set; }
        public int cep { get; set; }
        public string bairro { get; set; }
        public string cidade { get; set; }
        public string estado { get; set; }

        public override bool Equals(object obj)
        {
            bool exit = false;

            if (typeof(mdlEndereco) == obj.GetType())
            {
                mdlEndereco _mdlEndereco = (mdlEndereco)obj;

                if (this.id.Equals(_mdlEndereco.id) && this.logradouro == _mdlEndereco.logradouro && 
                    this.numero == _mdlEndereco.numero && this.cep == _mdlEndereco.cep && 
                    this.bairro == _mdlEndereco.bairro && this.cidade == _mdlEndereco.cidade && 
                    this.estado == _mdlEndereco.estado)
                {
                    exit = true;
                }
            }
            return exit;
        }
        public override string ToString()
        {
            return id + "-" + logradouro + "-" + numero + "-" + cep + "-" + bairro + "-" + cidade + "-" + estado;
        }

    }
}

