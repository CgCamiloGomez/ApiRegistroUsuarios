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
    public class UsuarioController : ControllerBase
    {
        internal INegocioUsuario negocioUsuario;
        public UsuarioController(INegocioUsuario _negocioUsuario)
        {
            negocioUsuario = _negocioUsuario;
        }

        [HttpPost]
        [Route("AgregarUsuario")]
        public ActionResult<Usuario> CrearUsuario (Usuario usuario)
        {
            return Ok(negocioUsuario.CrearUsuario(usuario));
        }

        [HttpPost]
        [Route("ValidarUsuario")]
        public ActionResult<Usuario>ValidarUsuario(Usuario usuario)
        {
            return Ok(negocioUsuario.ValidarUsuario(usuario));
        }
    }
}
