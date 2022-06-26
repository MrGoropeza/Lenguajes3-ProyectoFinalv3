using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lenguajes3_ProyectoFinalv3.Models
{
    public class Turno
    {
        public int pacienteDNI { get; set; }
        public int profesionalDNI { get; set; }
        public DateTime fecha { get; set; }
        public int slot { get; set; } 
    }
}