using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lenguajes3_ProyectoFinalv3.Models
{
    public class Consulta
    {
        Usuario paciente { get; set; }
        Usuario Profesional { get; set; }
        DateTime fecha { get; set; }
    }
}