using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Usuario
    {
        [Key]
        public int IdTipoDocumento { get; set; }       
        public string NumeroIdentificacion { get; set; }
        public string Barrio { get; set; }
        public string Direcccion { get; set; }
        public string Telefono { get; set; }

        public virtual TipoDocumento TipoDocumento { get; set; }
    }
}
