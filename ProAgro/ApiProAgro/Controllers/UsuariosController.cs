using ProAgro.Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ApiProAgro.Controllers
{
    public class UsuariosController : ApiController
    {
        protected HelperData accessData;

        public UsuariosController()
        {
            accessData = new HelperData();
        }
        // GET: api/Usuarios
        public IEnumerable<Usuarios> Get()
        {
            return accessData.Consultar(true); 
        }

        // GET: api/Usuarios/5
        public Usuarios Get(int id)
        {
            return accessData.Consultar(id, true);
        }

        // POST: api/Usuarios
        public void Post([FromBody]Usuarios usuario)
        {
            accessData.Agregar(usuario);
        }

        // PUT: api/Usuarios/5
        public void Put(int id, [FromBody]Usuarios usuario)
        {
            usuario.idUsuario = id;
            accessData.Actualizar(usuario);
        }

        // DELETE: api/Usuarios/5
        public void Delete(int id)
        {
            accessData.Eliminar(accessData.Consultar(id));

        }
    }
}
