using Servicio.Modelos.Modelos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Servicio.Negocio.InterfacesNegocio
{
    public interface INegocioUsuario
    {
        long CrearUsuario(Usuario usuario);

        Usuario ValidarUsuario(Usuario usuario);
    }
}
