using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProAgro.Models
{
    public class Usuarios
    {
        public int idUsuario { get; set; }
        public string contraseña { get; set; }
        public string nombre { get; set; }
        public System.DateTime fechaCreacion { get; set; }
        public string rfc { get; set; }
    }
}