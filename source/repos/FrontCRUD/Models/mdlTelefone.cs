using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Models
{
    public class mdlTelefone
    {
        public int id { get; set; }
        public int numero { get; set; }
        public int ddd { get; set; }
        public string tipo { get; set; }

        public override bool Equals(object obj)
        {
            bool exit = false;

            if(typeof(mdlTelefone) == obj.GetType())
            {
                mdlTelefone _mdlTelefone = (mdlTelefone)obj;

                if (this.id.Equals(_mdlTelefone.id) && this.numero == _mdlTelefone.numero && this.ddd == _mdlTelefone.ddd && this.tipo == _mdlTelefone.tipo)
                {
                    exit = true;
                }
            }
            return exit;
        }
        public override string ToString()
        {
            return id + "-" + numero + "-" + ddd + "-" + tipo;
        }

    }
}
