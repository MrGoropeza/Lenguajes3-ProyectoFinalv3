using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lenguajes3_ProyectoFinalv3.Models
{
    public class Turno
    {
        Paciente paciente { get; set; }
        Profesional profesional { get; set; }
        DateTime fecha { get; set; }
        int DuracionMinutos { get; set; } 
    }
}