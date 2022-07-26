using Lenguajes3_ProyectoFinalv3.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Firebase.Auth;
using Lenguajes3_ProyectoFinalv3.Pages.Widgets;

namespace Lenguajes3_ProyectoFinalv3.Models
{
    public class Consultorio
    {
        public static string nombre { get; set; }
        public static string correo { get; set; }
        public static string numero { get; set; }
        public static string direccion { get; set; }

        public static IDatabase database;
        public static IStorage storage;
        public static IAuth auth;

        public static Usuario usuario_logeado;
        public static FirebaseAuthLink token;

        public static List<Usuario> profesionales { get; set; }

        public static List<Turno> turnos_logeado { get; set; }

        public static int turnos_cargados { get; set; }

        public static int semanaActualAgenda = 0;

        public static int semanaActualPro = 0;

        public static AgendaWidget agendaActual;

        public static void initFirebase()
        {
            database = new FirebaseDatabase();
            storage = new FirebaseFiles();
            auth = new FirebaseAuthenticator();
        }
        public static void setDatos()
        {
            List<string> datos = database.getDatosConsultorio();
            correo = datos[0];
            direccion = datos[1];
            nombre = datos[2];
            numero = datos[3];
        }

        public static string monthFromInt(int month)
        {
            string respuesta = "";
            switch (month)
            {
                case 1:
                    respuesta = "Enero";
                    break;
                case 2:
                    respuesta = "Febrero";
                    break;
                case 3:
                    respuesta = "Marzo";
                    break;
                case 4:
                    respuesta = "Abril";
                    break;
                case 5:
                    respuesta = "Mayo";
                    break;
                case 6:
                    respuesta = "Junio";
                    break;
                case 7:
                    respuesta = "Julio";
                    break;
                case 8:
                    respuesta = "Agosto";
                    break;
                case 9:
                    respuesta = "Septiembre";
                    break;
                case 10:
                    respuesta = "Octubre";
                    break;
                case 11:
                    respuesta = "Noviembre";
                    break;
                case 12:
                    respuesta = "Diciembre";
                    break;
            }
            return respuesta;
        }

        public static DateTime dateTimeFromSlot(int slot, DateTime dia)
        {
            
            DateTime hora = new DateTime(dia.Year
                , dia.Month
                , dia.Day
                , 10, 0, 0);

            DateTime respuesta = hora;

            if (slot >= 0 && slot <= 3)
            {
                respuesta = hora.AddMinutes(30 * slot);
            }
            else if (slot >= 4 && slot <= 15)
            {
                respuesta = hora.AddHours(4).AddMinutes(30 * (slot - 4));
            }
            return respuesta;
        }

        public static string hourFromSlot(int slot)
        {
            string respuesta = "";
            DateTime hora = new DateTime(DateTime.Today.Year
                ,DateTime.Today.Month
                ,DateTime.Today.Day
                ,10,0,0);

            if(slot >= 0 && slot <= 3)
            {
                respuesta = hora.AddMinutes(30 * slot).ToString("HH:mm")
                        + " - "
                        + hora.AddMinutes(30 * slot).AddMinutes(30).ToString("HH:mm");
            }else if (slot >= 4 && slot <= 15)
            {
                respuesta = hora.AddHours(4).AddMinutes(30 * (slot - 4)).ToString("HH:mm")
                        + " - "
                        + hora.AddHours(4).AddMinutes(30 * (slot - 4)).AddMinutes(30).ToString("HH:mm");
            }
            return respuesta;
        }
    }
}


enum slots
{
    slot1, slot2, slot3, slot4, slot5, slot6, slot7, slot8, slot9, slot10, slot11, slot12, slot13, slot14, slot15, slot16
}