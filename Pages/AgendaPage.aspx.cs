using Lenguajes3_ProyectoFinalv3.Models;
using Lenguajes3_ProyectoFinalv3.Pages.Widgets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lenguajes3_ProyectoFinalv3.Pages
{
    public partial class AgendaPage : System.Web.UI.Page
    {

        AgendaWidget agenda;
        protected void Page_Load(object sender, EventArgs e)
        {
                if (Consultorio.usuario_logeado == null)
                {
                    Response.Redirect("HomePage.aspx");
                }
                else
                {
                    var master = (Dashboard)this.Master;
                    master.setActivePage("agenda");

                    agenda = (AgendaWidget)LoadControl("Widgets/AgendaWidget.ascx");
                    agenda.Profesional = Consultorio.usuario_logeado;

                    ph_agenda.Controls.Add(agenda);
                }
        }

        protected void btn_anterior_Click(object sender, EventArgs e)
        {
            Consultorio.semanaActualAgenda -= 1;
            agenda.Lunes = DateTime.Today
                .AddDays(-(int)DateTime.Today.DayOfWeek + (int)DayOfWeek.Monday)
                .AddDays(7 * Consultorio.semanaActualAgenda);
        }

        protected void btn_siguiente_Click(object sender, EventArgs e)
        {
            Consultorio.semanaActualAgenda += 1;
            agenda.Lunes = DateTime.Today
                .AddDays(-(int)DateTime.Today.DayOfWeek + (int)DayOfWeek.Monday)
                .AddDays(7 * Consultorio.semanaActualAgenda);
        }

        protected void btn_hoy_Click(object sender, EventArgs e)
        {
            Consultorio.semanaActualAgenda = 0;
            agenda.Lunes = DateTime.Today
                .AddDays(-(int)DateTime.Today.DayOfWeek + (int)DayOfWeek.Monday)
                .AddDays(7 * Consultorio.semanaActualAgenda);
        }

        protected void btn_refresh_Click(object sender, EventArgs e)
        {
            agenda.Lunes = DateTime.Today
                .AddDays(-(int)DateTime.Today.DayOfWeek + (int)DayOfWeek.Monday)
                .AddDays(7 * Consultorio.semanaActualAgenda);
        }

        protected void btn_print_Click(object sender, EventArgs e)
        {

        }
    }
}