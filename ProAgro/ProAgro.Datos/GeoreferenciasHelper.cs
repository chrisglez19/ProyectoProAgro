using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProAgro.Datos
{
    public class GeoreferenciasHelper
    {
        protected ProagroEntities myContext;
        public GeoreferenciasHelper()
        {
            myContext = new ProagroEntities();

        }

        //public List<Estados> Consultar(bool cargaCompleta = false)
        //{
        //    myContext.Configuration.LazyLoadingEnabled = cargaCompleta;
        //    return myContext.Permisos.ToList();
        //}

        public List<Georeferencias> Consultar(int id, bool cargaCompleta = false)
        {
            
            Permisos permiso = new Permisos();
            List<Permisos> listapermisos = new List<Permisos>();
            listapermisos = myContext.Permisos.ToList();
            myContext.Configuration.LazyLoadingEnabled = cargaCompleta;
            permiso = listapermisos.Where(us => us.idUsuario == id).FirstOrDefault();

            return myContext.Georeferencias.Where(edo => edo.idEstado == permiso.idEstado).ToList();
        }
    }
}
