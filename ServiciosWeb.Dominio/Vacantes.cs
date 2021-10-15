using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiciosWeb.Dominio
{
    public class Vacantes
    {
        public int IdVacante { get; set; }
        public int idcategoria { get; set; }
        public string Empresa { get; set; }
        public string Posicion { get; set; }
        public string Descripcion { get; set; }
        public string Horario { get; set; }
        public string Ubicacion { get; set; }

        public virtual Categoria Categoria { get; set; }
        public virtual ICollection<Solicitud> Solicitud { get; set; }
    }
}
