using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiciosWeb.Dominio
{
    public class Usuario
    {
        public int IdUsuario { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Correo { get; set; }
        public int idRol { get; set; }
        public Nullable<short> Cedula { get; set; }
        public Nullable<short> Telefono { get; set; }

        public virtual Roles Roles { get; set; }
        public virtual ICollection<Solicitud> Solicitud { get; set; }
    }
}
