using System;
using System.Collections.Generic;
using System.Text;

namespace Servicio.Modelos.Modelos
{
    public class Persona
    {
        public long Identificador { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Identificacion { get; set; }
        public string Email { get; set; }
        public string TipoIdentificacion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string NombreCompleto { get; set; }


    }
}
