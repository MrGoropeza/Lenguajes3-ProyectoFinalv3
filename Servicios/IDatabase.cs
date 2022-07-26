using Lenguajes3_ProyectoFinalv3.Models;
using Lenguajes3_ProyectoFinalv3.Models.FirebaseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lenguajes3_ProyectoFinalv3.Servicios
{
    public interface IDatabase
    {
        #region selects-read
        List<string> getDatosConsultorio();
        Task<List<Usuario>> getProfesionales();
        Task<List<Usuario>> getPacientes();
        Task<Usuario> getProfesional(int dni);
        Task<Usuario> getUsuario(int dni);
        Task<List<Usuario>> getUsuarios();
        Turno getTurno(DateTime fecha);
        List<Turno> getTurnosProfesional(int dni);
        Task<List<Turno>> getAgendaProfesional(int dni, DateTime fecha);

        Task<List<Turno>> getTurnosPaciente(int dni);
        #endregion

        #region insert-create
        void addUser(Usuario user);
        void addTurno(Turno turno);
        #endregion

        #region updates
        void updateUser(Usuario usuario);

        void updateDatosConsultorio(DatosConsul consultorio);
        void turnAdmin(int dni);
        void removeAdmin(int dni);
        void turnProfesional(int dni);
        void removeProfesional(int dni);
        #endregion

        #region delete
        void removeUser(Usuario user);
        void removeTurno(Turno turno);
        #endregion
    }
}
