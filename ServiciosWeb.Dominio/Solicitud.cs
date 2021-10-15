using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiciosWeb.Dominio
{
    public class Solicitud
    {
        public int IdSolicitud { get; set; }
        public int idusuario { get; set; }
        public int idvacante { get; set; }

        public virtual Usuario Usuario { get; set; }
        public virtual Vacantes Vacantes { get; set; }
    }
}
