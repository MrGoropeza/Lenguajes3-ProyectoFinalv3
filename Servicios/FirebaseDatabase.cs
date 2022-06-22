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

        public Task<bool> addAdmin(Usuario admin)
        {
            throw new NotImplementedException();
        }

        public Task<bool> addConsulta(Consulta consulta)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> addPaciente(Usuario paciente)
        {

            try
            {
                await rtdb.Child("Pacientes")
                    .Child(paciente.dni.ToString)
                    .PutAsync("none");
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<bool> addUser(Usuario usuario)
        {
            try
            {
                await rtdb.Child("Usuarios")
                    .Child(usuario.dni.ToString)
                    .PutAsync(usuario);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public Task<bool> addProfesional(Usuario profesional)
        {
            throw new NotImplementedException();
        }

        public Task<bool> addTurno(Turno turno)
        {
            throw new NotImplementedException();
        }

        public bool cambiarApellido(int dni)
        {
            throw new NotImplementedException();
        }

        public bool cambiarAvatarLink(int dni)
        {
            throw new NotImplementedException();
        }

        public bool cambiarGenero(int dni)
        {
            throw new NotImplementedException();
        }

        public bool cambiarNombre(int dni)
        {
            throw new NotImplementedException();
        }

        public bool cambiarTelefono1(int dni)
        {
            throw new NotImplementedException();
        }

        public bool cambiarTelefono2(int dni)
        {
            throw new NotImplementedException();
        }

        

        Admin IDatabase.getAdmin(int dni)
        {
            throw new NotImplementedException();
        }

        List<Admin> IDatabase.getAdmins(int dni)
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

        Paciente IDatabase.getPaciente(int dni)
        {
            throw new NotImplementedException();
        }

        List<Paciente> IDatabase.getPacientes()
        {
            throw new NotImplementedException();
        }

        Profesional IDatabase.getProfesional(int dni)
        {
            throw new NotImplementedException();
        }

        List<Profesional> IDatabase.getProfesionales()
        {
            throw new NotImplementedException();
        }

        Turno IDatabase.getTurno(DateTime fecha)
        {
            throw new NotImplementedException();
        }

        List<Turno> IDatabase.getTurnosProfesional(int dni)
        {
            throw new NotImplementedException();
        }
    }
}