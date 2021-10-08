using Servicio.Modelos.Modelos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Servicio.AccesoDatos.InterfacesDatos
{
    public interface IDatosUsuario
    {
        long CrearUsuario (Usuario usuario);

        Usuario ValidarUsuario(Usuario usuario);
    }
}
