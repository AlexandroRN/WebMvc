using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiciosWeb.Dominio
{
    public class Categoria
    {
        public int IdCategoria { get; set; }
        public string NombreCategoria { get; set; }

        public virtual ICollection<Vacantes> Vacantes { get; set; }

    }
}
