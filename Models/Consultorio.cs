using Lenguajes3_ProyectoFinalv3.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

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

    }
}