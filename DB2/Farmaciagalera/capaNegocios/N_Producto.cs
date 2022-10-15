using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using capaDatos;
using capaEntidad;
using System.Data;

namespace capaNegocios
{
    public class N_Producto
    {
        D_Producto objdato = new D_Producto();        
       
        public DataTable N_listado()
        {
            return objdato.D_listado();
        }

    }
}
