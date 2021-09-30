using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProAgro.Datos
{
    public class HelperData
    {
        protected ProagroEntities myContext;
        public HelperData()
        {
            myContext = new ProagroEntities();

        }

        public List<Usuarios> Consultar(bool cargaCompleta=false)
        {
            myContext.Configuration.LazyLoadingEnabled = cargaCompleta;
            return myContext.Usuarios.ToList();
        }

        public Usuarios Consultar(int id,bool cargaCompleta=false)
        {
            myContext.Configuration.LazyLoadingEnabled = cargaCompleta;
            return myContext.Usuarios.Where(us=> us.idUsuario==id).FirstOrDefault();
        }

        public void Agregar(Usuarios usuario)
        {
            myContext.Set<Usuarios>().Add(usuario);
            //myContext.Entry<Usuarios>(usuario).State = System.Data.Entity.EntityState.Added; //La entrada es un usuario y se pone en estado de modificado
            myContext.SaveChanges();
        }

        public void Actualizar(Usuarios usuario)
        {
            myContext.Entry<Usuarios>(usuario).State= System.Data.Entity.EntityState.Modified; //La entrada es un usuario y se pone en estado de modificado
            myContext.SaveChanges();
        }

        public void Eliminar(Usuarios usuario)
        {
            myContext.Entry<Usuarios>(usuario).State = System.Data.Entity.EntityState.Deleted; //La entrada es un usuario y se pone en estado de modificado
            myContext.SaveChanges();
        }

    }
}
