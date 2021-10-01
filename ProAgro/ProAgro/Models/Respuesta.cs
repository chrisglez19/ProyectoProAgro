using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProAgro.Models
{
    public class Respuesta
    {
        public bool status { get; set; }
        public string mensaje { get; set; }
        public int idUsuario { get; set; }
    }
}