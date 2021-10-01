using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProAgro.Models
{
    public class Georeferencias
    {
        public int idGeoreferencia { get; set; }
        public int idEstado { get; set; }
        public double latitud { get; set; }
        public double longitud { get; set; }
    }
}