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
        public async void addTurno(Turno turno)
        {
            System.Diagnostics.Debug.WriteLine("Agregando turno a firebase: \n" +
                "Slot: " + turno.slot + "\n" +
                "Fecha: " + turno.fecha.ToString("dd-MM-yyyy"));
            await rtdb.Child("Turnos")
                .Child(turno.fecha.ToString("dd-MM-yyyy"))
                .Child(turno.profesionalDNI.ToString())
                .Child("slot-" + turno.slot.ToString())
                .PutAsync(turno);
        }
        public async Task<List<Turno>> getAgendaProfesional(int dni, DateTime fecha)
        {
            List<Turno> resultado = new List<Turno>();
            var query = await rtdb.Child("Turnos")
                .Child(fecha.ToString("dd-MM-yyyy"))
                .Child(dni.ToString())
                .OnceAsync<Turno>();
            foreach (var turno in query)
            {
                resultado.Add(turno.Object);
            }
            resultado = resultado.OrderBy(turno => turno.slot).ToList();
            return resultado;
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
        public async void turnAdmin(int dni)
        {
            Usuario user = await rtdb.Child("Usuarios")
                .Child(dni.ToString()).OnceSingleAsync<Usuario>();
            user.isAdmin = true;
            await rtdb.Child("Usuarios")
                .Child(dni.ToString())
                .PatchAsync<Usuario>(user);
        }
        public async void turnProfesional(int dni)
        {
            Usuario user = await rtdb.Child("Usuarios")
                .Child(dni.ToString()).OnceSingleAsync<Usuario>();
            user.isProfesional = true;
            await rtdb.Child("Usuarios")
                .Child(dni.ToString())
                .PatchAsync<Usuario>(user);
        }
        public async void removeUser(Usuario user)
        {
            await rtdb.Child("Usuarios")
                .Child(user.dni.ToString)
                .DeleteAsync();
        }
        public async Task<List<Usuario>> getProfesionales()
        {
            List<Usuario> pros = new List<Usuario>();
            var query = await rtdb.Child("Usuarios")
                .OnceAsync<Usuario>();
            var queryWhere = query.Where(user => user.Object.isProfesional);
            foreach (var item in queryWhere)
            {
                pros.Add(item.Object);
            }
            return pros;
        }
        public async Task<Usuario> getUsuario(int dni)
        {
            return await rtdb.Child("Usuarios")
                .Child(dni.ToString())
                .OnceSingleAsync<Usuario>();
        }
        public async Task<List<Usuario>> getUsuarios()
        {
            List<Usuario> respuesta = new List<Usuario>();
            var request = await rtdb.Child("Usuarios").OnceAsync<Usuario>();
            foreach (var user in request)
            {
                respuesta.Add(user.Object);
            }
            return respuesta;
        }
        public async void updateUser(Usuario usuario)
        {
            try
            {
                await rtdb.Child("Usuarios")
                    .Child(usuario.dni.ToString)
                    .PatchAsync(usuario);
            }
            catch (Exception)
            {
            }
        }
        public async Task<List<Turno>> getTurnosPaciente(int dni)
        {
            List<Turno> turnos = new List<Turno>();
            var todos = await rtdb.Child("Turnos").OnceAsync<object>();
            foreach (var fecha in todos)
            {
                var profesionales = await rtdb.Child("Turnos")
                    .Child(fecha.Key).OnceAsync<object>();
                foreach (var pro in profesionales)
                {
                    var turnosQuery = await rtdb.Child("Turnos")
                        .Child(fecha.Key).Child(pro.Key)
                        .OnceAsync<Turno>();
                    foreach (var turno in turnosQuery)
                    {
                        if(turno.Object.pacienteDNI == dni
                            && turno.Object.fecha >= DateTime.Today)
                        {
                            turnos.Add(turno.Object);
                        }
                    }
                }
                turnos = turnos.OrderBy(turno => turno.slot).ToList();
            }
            turnos = turnos.OrderBy(turno => turno.fecha).ToList();
            return turnos;
        }
        public async Task<Usuario> getProfesional(int dni)
        {
            return await rtdb.Child("Usuarios")
                .Child(dni.ToString())
                .OnceSingleAsync<Usuario>();
        }
        public async void removeTurno(Turno turno)
        {
            await rtdb.Child("Turnos")
                .Child(turno.fecha.ToString("dd-MM-yyyy"))
                .Child(turno.profesionalDNI.ToString())
                .Child("slot-"+turno.slot.ToString())
                .DeleteAsync();
        }
        public async void removeAdmin(int dni)
        {
            Usuario user = await rtdb.Child("Usuarios")
                .Child(dni.ToString()).OnceSingleAsync<Usuario>();
            user.isAdmin = false;
            await rtdb.Child("Usuarios")
                .Child(dni.ToString())
                .PatchAsync<Usuario>(user);
        }
        public async void removeProfesional(int dni)
        {
            Usuario user = await rtdb.Child("Usuarios")
                .Child(dni.ToString()).OnceSingleAsync<Usuario>();
            user.isProfesional = false;
            await rtdb.Child("Usuarios")
                .Child(dni.ToString())
                .PatchAsync<Usuario>(user);
        }
        public async void updateDatosConsultorio(DatosConsul consultorio)
        {
            await rtdb.Child("datos_consultorio")
                .PatchAsync(consultorio);
        }
    }
}