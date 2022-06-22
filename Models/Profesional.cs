using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lenguajes3_ProyectoFinalv3.Models
{
    public class Profesional : Usuario
    {
        public string especialidad { get; set; }
        public string descripcion { get; set; }

        List<Consulta> portafolio;
        List<Turno> agenda;
    }
}