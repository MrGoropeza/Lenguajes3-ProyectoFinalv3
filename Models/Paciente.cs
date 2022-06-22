using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lenguajes3_ProyectoFinalv3.Models
{
    public class Paciente : Usuario
    {
        public List<Turno> turnos = new List<Turno>();
        public List<Consulta> consultas = new List<Consulta>();
    }
}