using Firebase.Database;
using Firebase.Database.Query;
using Lenguajes3_ProyectoFinalv3.Models;
using Lenguajes3_ProyectoFinalv3.Models.FirebaseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace Lenguajes3_ProyectoFinalv3.Servicios
{
    public class FirebaseDatabase : IDatabase
    {
        private static string RTDBkey = "https://lenguajes3-proyectofinal-default-rtdb.firebaseio.com/";

        private static FirebaseClient rtdb;
        public FirebaseDatabase (){
            rtdb = new FirebaseClient(RTDBkey);
        }

        public void addConsulta(Consulta consulta)
        {
            throw new NotImplementedException();
        }

        public async void addUser(Usuario usuario)
        {
            try
            {
                await rtdb.Child("Usuarios")
                    .Child(usuario.dni.ToString)
                    .PutAsync(usuario);
            }
            catch (Exception)
            {
            }
        }

        public void addTurno(Turno turno)
        {
            throw new NotImplementedException();
        }

        public void cambiarApellido(int dni)
        {
            throw new NotImplementedException();
        }

        public void cambiarAvatarLink(int dni)
        {
            throw new NotImplementedException();
        }

        public void cambiarGenero(int dni)
        {
            throw new NotImplementedException();
        }

        public void cambiarNombre(int dni)
        {
            throw new NotImplementedException();
        }

        public void cambiarTelefono1(int dni)
        {
            throw new NotImplementedException();
        }

        public void cambiarTelefono2(int dni)
        {
            throw new NotImplementedException();
        }
        List<Turno> IDatabase.getAgendaProfesional(int dni)
        {
            throw new NotImplementedException();
        }

        Consulta IDatabase.getConsultaPaciente(int dni)
        {
            throw new NotImplementedException();
        }

        Consulta IDatabase.getConsultaProfesional(int dni)
        {
            throw new NotImplementedException();
        }

        public List<string> getDatosConsultorio()
        {
            return getDatosConsultorioFirebase().Result;
        }

        private async Task<List<string>> getDatosConsultorioFirebase()
        {
            List<string> list = new List<string>();
            var query = await rtdb.Child("datos_consultorio")
                .OnceAsync<string>();
            foreach (var item in query)
            {
                list.Add(item.Object);
            }
            return list;
        }

        Turno IDatabase.getTurno(DateTime fecha)
        {
            throw new NotImplementedException();
        }

        List<Turno> IDatabase.getTurnosProfesional(int dni)
        {
            throw new NotImplementedException();
        }

        public void turnAdmin(int dni)
        {
            throw new NotImplementedException();
        }

        public void turnProfesional(int dni)
        {
            throw new NotImplementedException();
        }

        public async void removeUser(Usuario user)
        {
            await rtdb.Child("Usuarios")
                .Child(user.dni.ToString)
                .DeleteAsync();
        }

        public List<Usuario> getProfesionales()
        {
            throw new NotImplementedException();
        }

        public async Task<Usuario> getUsuario(int dni)
        {
            return await rtdb.Child("Usuarios")
                .Child(dni.ToString())
                .OnceSingleAsync<Usuario>();
        }

        public List<Usuario> getPacientes()
        {
            throw new NotImplementedException();
        }

        public List<Usuario> getAdmins()
        {
            throw new NotImplementedException();
        }
    }
}