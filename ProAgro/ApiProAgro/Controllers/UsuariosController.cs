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

        // POST: api/Usuarios/Login
        [Route("api/Usuarios/Login")]
        public Models.Respuesta Login(Usuarios usuario)
        {
            Models.Respuesta respuesta = new Models.Respuesta();
            List<Usuarios> listausuarios =accessData.Consultar().ToList();
            foreach ( var elemen in listausuarios)
            {

                if (usuario.rfc == elemen.rfc && usuario.contraseña == elemen.contraseña)
                {
                    respuesta.status = true;
                    respuesta.idUsuario = elemen.idUsuario;
                    return respuesta;
                }
                else
                {
                    respuesta.status = false;
                    respuesta.mensaje = "Usuario o contraseña invalidos";
                }
            }

            return respuesta;
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
