using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiciosWeb.Dominio
{
    public class Roles
    {
        public int IDRol { get; set; }
        public string Tipo { get; set; }
        public virtual ICollection<Usuario> Usuario { get; set; }
    }
}
