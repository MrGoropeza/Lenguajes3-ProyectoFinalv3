using Lenguajes3_ProyectoFinalv3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lenguajes3_ProyectoFinalv3.Pages.Widgets
{
    public partial class AgendaWidget : System.Web.UI.UserControl
    {
        private Usuario profesional;

        public Usuario Profesional
        {
            get
            {
                return profesional;
            }
            set
            {
                profesional = value;
                turnos();
            }
        }

        private DateTime lunes_semana = DateTime.Today.AddDays(-(int)DateTime.Today.DayOfWeek + (int)DayOfWeek.Monday);

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        async void turnos()
        {
            var lunes = lunes_semana;
            List<Turno> turnos = new List<Turno>();

            for (int j = 0; j < 5; j++)
            {
                turnos = await Consultorio.database.getAgendaProfesional(profesional.dni, lunes);

                Table agenda = tabla;

                tabla.Rows[1].Cells[j+1].Text = diaFromWeekDay(lunes.DayOfWeek) + " " + lunes.Day;

                for (int i = 0; i < 16; i++)
                {
                    try
                    {
                        Turno t = turnos.Find(turno => turno.slot == i);
                        TableCell celda = new TableCell();
                        if (t != null)
                        {
                            Usuario paciente = await Consultorio.database.getUsuario(t.pacienteDNI);

                            celda.Text = "<p>" + paciente.nombre + " " + paciente.apellido + "</p>"
                                + "\nDNI: " + paciente.dni;
                            tabla.Rows[i + 2].Cells.Add(celda);
                        }
                        else
                        {
                            if (lunes < DateTime.Now)
                            {
                                celda.Text = "Pasado";
                            }
                            else
                            {
                                celda.Text = "Libre";
                            }
                            celda.Attributes["class"] = "passdate";
                            tabla.Rows[i + 2].Cells.Add(celda);
                        }
                    }
                    catch (Exception)
                    {
                    }

                }

                lunes = lunes.AddDays(1);
            }
        }

        string diaFromWeekDay(DayOfWeek dia)
        {
            string resultado = "";
            switch (dia)
            {
                case DayOfWeek.Sunday:
                    resultado = "Domingo";
                    break;
                case DayOfWeek.Monday:
                    resultado = "Lunes";
                    break;
                case DayOfWeek.Tuesday:
                    resultado = "Martes";
                    break;
                case DayOfWeek.Wednesday:
                    resultado = "Miércoles";
                    break;
                case DayOfWeek.Thursday:
                    resultado = "Jueves";
                    break;
                case DayOfWeek.Friday:
                    resultado = "Viernes";
                    break;
                case DayOfWeek.Saturday:
                    resultado = "Sábado";
                    break;
                default:
                    break;
            }
            return resultado;
        }

        protected void btn_anterior_Click(object sender, EventArgs e)
        {
            if(lunes_semana.Day < DateTime.Today.Day)
            {
                lunes_semana = lunes_semana.AddDays(-7);
            }
            vaciar_tabla();
            turnos();
        }

        protected void btn_siguiente_Click(object sender, EventArgs e)
        {
            //if (lunes_semana.Day >= DateTime.Today.Day)
            //{
                lunes_semana = lunes_semana.AddDays(7);
            //}
            vaciar_tabla();
            turnos();
        }

        void vaciar_tabla()
        {
            for (int i = 0; i < 16; i++)
            {
                TableCell celdaHorario = tabla.Rows[i+2].Cells[0];
                tabla.Rows[i + 2].Cells.Clear();
                tabla.Rows[i + 2].Cells.Add(celdaHorario);
            }
        }

    }
}