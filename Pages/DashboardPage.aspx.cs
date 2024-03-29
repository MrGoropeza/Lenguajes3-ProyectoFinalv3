﻿using Lenguajes3_ProyectoFinalv3.Models;
using Lenguajes3_ProyectoFinalv3.Pages.Widgets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lenguajes3_ProyectoFinalv3
{
    public partial class DashboardPage : System.Web.UI.Page
    {
        protected async void Page_Load(object sender, EventArgs e)
        {
            correo.InnerText = Consultorio.correo;
            telefono.InnerText = Consultorio.numero;
            direccion.InnerText = Consultorio.direccion;
            if(Consultorio.usuario_logeado == null)
            {
                Response.Redirect("HomePage.aspx",true);
            }
            else
            {
                var master = (Dashboard)this.Master;
                master.setActivePage("dashboard");

                if (!IsPostBack)
                {
                    Consultorio.turnos_logeado =
                        await Consultorio.database
                        .getTurnosPaciente(Consultorio.usuario_logeado.dni);
                }
                else
                {
                    ph_turnos.Controls.Clear();
                }
                
                cargar_turnos();
            }
        }

        public async void cargar_turnos()
        {
            ph_turnos.Controls.Clear();
            if (Consultorio.turnos_logeado != null)
            {
                if(Consultorio.turnos_logeado.Count == 0)
                {
                    advertencia.InnerText = "No tenés turnos reservados.";
                    advertencia.Visible = true;
                        return;
                }
                foreach (var turno in Consultorio.turnos_logeado)
                {
                    TurnoReservado turno_widget = (TurnoReservado)LoadControl("Widgets/TurnoReservado.ascx");
                    turno_widget.Turno = turno;
                    turno_widget.Profesional = await Consultorio.database.getProfesional(turno.profesionalDNI);
                    turno_widget.pagina = this;
                    System.Diagnostics.Debug.WriteLine("Turno puesto en vista:\n" +
                        "Slot: " + turno.slot + "\n" +
                        "Fecha: " + turno.fecha.ToString() + "\n" +
                        "ProfesionalDNI: " + turno.profesionalDNI);
                    ph_turnos.Controls.Add(turno_widget);
                }
            }
        }


        protected async void btn_load_more_Click(object sender, EventArgs e)
        {
            if(Consultorio.turnos_logeado.Count == 0)
            {
                advertencia.InnerText = "No tenés ningún turno registrado.";
                advertencia.Visible = true;
                return;
            }
            int index = 0;
            if(Consultorio.turnos_logeado.Count + 5 > Consultorio.turnos_logeado.Count)
            {
                Consultorio.turnos_cargados = Consultorio.turnos_logeado.Count;
                if (IsPostBack)
                {
                    advertencia.InnerText = "No tenés más turnos.";
                    advertencia.Visible = true;
                }
            }
            else
            {
                Consultorio.turnos_cargados += 5;
            }
            while (index < Consultorio.turnos_cargados)
            {
                TurnoReservado turno_widget = (TurnoReservado)LoadControl("Widgets/TurnoReservado.ascx");
                turno_widget.Turno = Consultorio.turnos_logeado[index];
                turno_widget.Profesional = await Consultorio.database.getProfesional(Consultorio.turnos_logeado[index].profesionalDNI);
                ph_turnos.Controls.Add(turno_widget);
                index++;
            }
        }
    }
}