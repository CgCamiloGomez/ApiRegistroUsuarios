using Servicio.Modelos.Modelos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Servicio.Negocio.InterfacesNegocio
{
    public interface INegocioPersona
    {
        long CrearPersona(Persona persona);

        List<Persona> ObtenerPerosnas();
    }
}
