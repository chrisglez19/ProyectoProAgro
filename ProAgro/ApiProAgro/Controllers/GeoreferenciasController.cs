 using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ProAgro.Datos;

namespace ApiProAgro.Controllers
{
    public class GeoreferenciasController : ApiController
    {
        protected GeoreferenciasHelper accessData;

        public GeoreferenciasController()
        {
            accessData = new GeoreferenciasHelper();
        }
        // GET: api/Georeferencias
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Georeferencias/5
        public List<Georeferencias> Get(int id)
        {
            return accessData.Consultar(id);
        }

        // POST: api/Georeferencias
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Georeferencias/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Georeferencias/5
        public void Delete(int id)
        {
        }
    }
}
