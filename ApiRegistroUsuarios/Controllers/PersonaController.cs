using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Servicio.Modelos.Modelos;
using Servicio.Negocio.InterfacesNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiRegistroUsuarios.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonaController : ControllerBase
    {
        internal INegocioPersona negocioPersona;
        public PersonaController(INegocioPersona _negocioPersona)
        {
            negocioPersona = _negocioPersona;
        }


        [HttpPost]
        [Route("AgregarPersona")]
        public ActionResult<long> CrearPersona(Persona persona)
        {
            return Ok(negocioPersona.CrearPersona(persona));
        }

        [HttpGet]
        [Route("ObtenerPersonas")]
        public ActionResult<Persona> ObtenerPerosnas()
        {
            return Ok(negocioPersona.ObtenerPerosnas());
        }
    }
}
