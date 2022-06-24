using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lenguajes3_ProyectoFinalv3.Models
{
    public class Turno
    {
        Usuario paciente { get; set; }
        Usuario profesional { get; set; }
        DateTime fecha { get; set; }
        int DuracionMinutos { get; set; } 
    }
}