using Servicio.AccesoDatos.InterfacesDatos;
using Servicio.Modelos.Modelos;
using Servicio.Negocio.InterfacesNegocio;
using System;
using System.Collections.Generic;
using System.Text;

namespace Servicio.Negocio.AdminNegocio
{
    public class NegocioPersona: INegocioPersona
    {
        internal IDatosPersona idatosPerosna; 

        public NegocioPersona(IDatosPersona _idatosPerosna) 
        {
            idatosPerosna = _idatosPerosna;
        }
        public long CrearPersona(Persona persona) 
        {                       
            return idatosPerosna.CrearPersona(persona);        
        }

        public List<Persona> ObtenerPerosnas() 
        {
            return idatosPerosna.ObtenerPerosnas();        
        }
    }
}
