using Lenguajes3_ProyectoFinalv3.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Web;

namespace Lenguajes3_ProyectoFinalv3.Servicios
{
    public class GMailProvider
    {
        public async static void mandarInfoTurno(Turno turno, Usuario paciente)
        {
            MailMessage mensaje = new MailMessage();
            mensaje.From = new MailAddress("goropeza8@gmail.com", Consultorio.nombre);
            mensaje.To.Add(paciente.correo);
            mensaje.Subject = "Información de tu Turno Reservado";

            mensaje.IsBodyHtml = false;
            Usuario profesional = await Consultorio.database.getProfesional(turno.profesionalDNI);
            mensaje.Body = "Tu turno en " + Consultorio.nombre + " fue reservado correctamente.\n"
                         + "  Detalles del turno: \n"
                         + "   - Dia: " + turno.fecha.ToString("dd/MM/yyyy") + "\n"
                         + "   - Hora: " + Consultorio.hourFromSlot(turno.slot) + "\n"
                         + "   - Profesional: " + profesional.nombre + " " + profesional.apellido;

            List<string> toUsers = new List<string>();
            toUsers.Add(paciente.correo);
            toUsers.Add(profesional.correo);

            string invitacion = ICSmanager.createReminder(turno, profesional, paciente);
            //string invitacion = MeetingRequestString(
            //    Consultorio.nombre,
            //    toUsers,
            //    "Tu turno en " + Consultorio.nombre,
            //    "Consulta psicológica con " + profesional.profesional_titulo + ", " + profesional.nombre + " " + profesional.apellido,
            //    Consultorio.direccion,
            //    Consultorio.dateTimeFromSlot(turno.slot, turno.fecha),
            //    Consultorio.dateTimeFromSlot(turno.slot, turno.fecha).AddMinutes(30)
            //);


            mensaje.Attachments.Add(
                new Attachment(GenerateStreamFromString(invitacion), "Agregar turno a tu calendario.ics")
            );


            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp.gmail.com";
            System.Net.NetworkCredential credenciales = new System.Net.NetworkCredential();

            credenciales.UserName = "goropeza8@gmail.com";
            credenciales.Password = "yekszxwkgckbyokv";

            smtp.UseDefaultCredentials = true;
            smtp.Credentials = credenciales;
            smtp.Port = 587;
            smtp.EnableSsl = true;
            await smtp.SendMailAsync(mensaje);
        }

        public async static void mandarInfoTurnoCancelado(Turno turno, Usuario paciente)
        {
            MailMessage mensaje = new MailMessage();
            mensaje.From = new MailAddress("goropeza8@gmail.com", Consultorio.nombre);
            mensaje.To.Add(paciente.correo);
            mensaje.Subject = "Cancelaste un turno en " + Consultorio.nombre;

            mensaje.IsBodyHtml = false;
            Usuario profesional = await Consultorio.database.getProfesional(turno.profesionalDNI);
            mensaje.Body = "Tu turno en " + Consultorio.nombre + " fue cancelado correctamente.\n"
                         + "  Detalles del turno: \n"
                         + "   - Dia: " + turno.fecha.ToString("dd/MM/yyyy") + "\n"
                         + "   - Hora: " + Consultorio.hourFromSlot(turno.slot) + "\n"
                         + "   - Profesional: " + profesional.nombre + " " + profesional.apellido;

            List<string> toUsers = new List<string>();
            toUsers.Add(paciente.correo);
            toUsers.Add(profesional.correo);

            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp.gmail.com";
            System.Net.NetworkCredential credenciales = new System.Net.NetworkCredential();

            credenciales.UserName = "goropeza8@gmail.com";
            credenciales.Password = "yekszxwkgckbyokv";

            smtp.UseDefaultCredentials = true;
            smtp.Credentials = credenciales;
            smtp.Port = 587;
            smtp.EnableSsl = true;
            await smtp.SendMailAsync(mensaje);
        }

        public async static void mandarInfoCuentaCreada(Usuario nuevo, string password)
        {
            MailMessage mensaje = new MailMessage();
            mensaje.From = new MailAddress("goropeza8@gmail.com", Consultorio.nombre);
            mensaje.To.Add(nuevo.correo);
            mensaje.Subject = "Información de tu cuenta en " + Consultorio.nombre;

            mensaje.IsBodyHtml = false;
            mensaje.Body = "Tu cuenta en " + Consultorio.nombre + " fue creada correctamente.\n"
                         + "  Para ingresar, utilizá tu DNI y la siguiente contraseña: \n" +
                           "    " + password + "\n" +
                           "  No te olvides de cambiar la contraseña en la pestaña \"Mi cuenta\" cuando inicies sesión en el Sistema.";

            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp.gmail.com";
            System.Net.NetworkCredential credenciales = new System.Net.NetworkCredential();

            credenciales.UserName = "goropeza8@gmail.com";
            credenciales.Password = "yekszxwkgckbyokv";

            smtp.UseDefaultCredentials = true;
            smtp.Credentials = credenciales;
            smtp.Port = 587;
            smtp.EnableSsl = true;
            await smtp.SendMailAsync(mensaje);
        }
        private static string MeetingRequestString(string from, List<string> toUsers, string subject, string desc, string location, DateTime startTime, DateTime endTime, int? eventID = null, bool isCancel = false)
        {
            StringBuilder str = new StringBuilder();

            str.AppendLine("BEGIN:VCALENDAR");
            str.AppendLine("PRODID:-//Microsoft Corporation//Outlook 12.0 MIMEDIR//EN");
            str.AppendLine("VERSION:2.0");
            str.AppendLine(string.Format("METHOD:{0}", (isCancel ? "CANCEL" : "REQUEST")));
            str.AppendLine("BEGIN:VEVENT");

            str.AppendLine(string.Format("DTSTART:{0:yyyyMMddTHHmmssZ}", startTime.ToUniversalTime()));
            str.AppendLine(string.Format("DTSTAMP:{0:yyyyMMddTHHmmss}", DateTime.Now));
            str.AppendLine(string.Format("DTEND:{0:yyyyMMddTHHmmssZ}", endTime.ToUniversalTime()));
            str.AppendLine(string.Format("LOCATION: {0}", location));
            str.AppendLine(string.Format("UID:{0}", (eventID.HasValue ? "blablabla" + eventID : Guid.NewGuid().ToString())));
            str.AppendLine(string.Format("DESCRIPTION:{0}", desc.Replace("\n", "<br>")));
            str.AppendLine(string.Format("X-ALT-DESC;FMTTYPE=text/html:{0}", desc.Replace("\n", "<br>")));
            str.AppendLine(string.Format("SUMMARY:{0}", subject));

            str.AppendLine(string.Format("ORGANIZER;CN=\"{0}\":MAILTO:{1}", from, from));
            foreach (var user in toUsers)
            {
                str.AppendLine(string.Format("ATTENDEE;CN=\"{0}\";RSVP=TRUE:mailto:{1}", user, user));
            }
            

            str.AppendLine("BEGIN:VALARM");
            str.AppendLine("TRIGGER:-PT30M");
            str.AppendLine("ACTION:DISPLAY");
            str.AppendLine("DESCRIPTION:Reminder");
            str.AppendLine("END:VALARM");
            str.AppendLine("END:VEVENT");
            str.AppendLine("END:VCALENDAR");

            return str.ToString();
        }

        


        public static Stream GenerateStreamFromString(string s)
        {
            var stream = new MemoryStream();
            var writer = new StreamWriter(stream);
            writer.Write(s);
            writer.Flush();
            stream.Position = 0;
            return stream;
        }

    }


}

