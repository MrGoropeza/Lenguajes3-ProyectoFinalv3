using Ical.Net;
using Ical.Net.CalendarComponents;
using Ical.Net.DataTypes;
using Ical.Net.Serialization;
using Lenguajes3_ProyectoFinalv3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lenguajes3_ProyectoFinalv3.Servicios
{
    public class ICSmanager
    {
        public static string createReminder(Turno turno, Usuario profesional, Usuario paciente)
        {
            var e = new CalendarEvent
            {
                Start = new CalDateTime(Consultorio.dateTimeFromSlot(turno.slot, turno.fecha), ""),
                End = new CalDateTime(Consultorio.dateTimeFromSlot(turno.slot, turno.fecha).AddMinutes(30)),
                Location = Consultorio.direccion,
                Summary = "Consulta en " + Consultorio.nombre,
                Description = "Consulta psicológica con " + profesional.profesional_titulo + ", " + profesional.nombre + " " + profesional.apellido,
                Uid = Guid.NewGuid().ToString(),
            };

            System.Diagnostics.Debug.WriteLine("Fecha puesta en el correo:");
            System.Diagnostics.Debug.WriteLine("\t" + Consultorio.dateTimeFromSlot(turno.slot, turno.fecha).ToString());

            var alarma = new Alarm
            {
                Trigger = new Trigger("-PT30M")
            };
            e.Alarms.Add(alarma);

            var organizer = new Organizer {
                CommonName = Consultorio.nombre
            };
            e.Organizer = organizer;

            var datosProfesional = new Attendee
            {
                CommonName = "\"" + profesional.nombre + " " + profesional.apellido + "\"",
                Rsvp = true,
                Value = new Uri("mailto:" + profesional.correo)
            };

            var datosPaciente = new Attendee
            {
                CommonName = "\"" + paciente.nombre + " " + paciente.apellido + "\"",
                Rsvp = true,
                Value = new Uri("mailto:" + paciente.correo)
            };

            e.Attendees = new List<Attendee> { datosProfesional, datosPaciente };


            var calendar = new Calendar();
            calendar.AddTimeZone(new VTimeZone("Argentina Standard Time"));
            calendar.Events.Add(e);

            var serializer = new CalendarSerializer();
            return serializer.SerializeToString(calendar);
            
        }
    }
}