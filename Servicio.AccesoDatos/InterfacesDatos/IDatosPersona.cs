using Servicio.Modelos.Modelos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Servicio.AccesoDatos.InterfacesDatos
{
    public interface IDatosPersona
    {
        long CrearPersona(Persona persona);

        List<Persona> ObtenerPerosnas();
    }
}
