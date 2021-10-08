using System;
using System.Collections.Generic;
using System.Text;

namespace Servicio.Modelos.Modelos
{
    public class Usuario
    {
        public long Identificador { get; set; }
        public string UsuarioPersona { get; set; }
        public string Contraseña { get; set; }
        public DateTime FechaCreacion { get; set; }
        public long IdentificadorPerosna { get; set; }

    }
}
