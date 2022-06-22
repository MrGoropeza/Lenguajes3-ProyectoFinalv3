using Lenguajes3_ProyectoFinalv3.Models;
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
        List<String> getDatosConsultorio();
        Profesional getProfesional(int dni);
        List<Profesional> getProfesionales();
        Paciente getPaciente(int dni);
        List<Paciente> getPacientes();
        Admin getAdmin(int dni);
        List<Admin> getAdmins(int dni);
        Turno getTurno(DateTime fecha);
        List<Turno> getTurnosProfesional(int dni);
        Consulta getConsultaPaciente(int dni);
        Consulta getConsultaProfesional(int dni);
        List<Turno> getAgendaProfesional(int dni);
        #endregion

        #region insert-create
        void addUser(Usuario user);
        void addTurno(Turno turno);
        void addConsulta(Consulta consulta);
        #endregion

        #region updates
        void cambiarNombre(int dni);
        void cambiarApellido(int dni);
        void cambiarGenero(int dni);
        void cambiarTelefono1(int dni);
        void cambiarTelefono2(int dni);
        void cambiarAvatarLink(int dni);
        void turnAdmin(int dni);
        void turnProfesional(int dni);
        #endregion

        #region delete

        #endregion
    }
}
