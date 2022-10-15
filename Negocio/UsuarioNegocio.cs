using entidades;
using Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class UsuarioNegocio
    {
        IUsiarioRepositorio usuarioRepositorio;

        public UsuarioNegocio(IUsiarioRepositorio usiarioRepositorio)
        {
            this.usuarioRepositorio = usiarioRepositorio;
        }

        public void IngresarUsuario(Usuario usuario)
        {
            //Aplicar reglas de negocio

            //Guardamos en el repositorio
            usuarioRepositorio.IngresarUsuario(usuario);
        }
    }
}
