using Servicio.AccesoDatos.InterfacesDatos;
using Servicio.Modelos.Modelos;
using Servicio.Negocio.InterfacesNegocio;
using System;
using System.Collections.Generic;
using System.Text;

namespace Servicio.Negocio.AdminNegocio
{
    public class NegocioUsuario : INegocioUsuario
    {

        internal IDatosUsuario idatosUsuario;

        public NegocioUsuario(IDatosUsuario _idatosUsuario)
        {
            idatosUsuario = _idatosUsuario;
        }
        public long CrearUsuario(Usuario usuario) 
        {
            
            return idatosUsuario.CrearUsuario(usuario);
        }

        public Usuario ValidarUsuario(Usuario usuario) 
        {
            return idatosUsuario.ValidarUsuario(usuario);        
        }


    }
}
