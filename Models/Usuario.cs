using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lenguajes3_ProyectoFinalv3.Models
{
    public class Usuario
    {
        public int dni { get; set; }
        public string correo { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string telefono1 { get; set; }
        public string telefono2 { get; set; }
        public string genero { get; set; }
        public string avatar_link { get; set; }
    }
}