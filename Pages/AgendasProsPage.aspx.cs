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
    public partial class AgendasProsPage : System.Web.UI.Page
    {

        protected async void Page_Load(object sender, EventArgs e)
        {
            

            
            if (Consultorio.usuario_logeado == null)
            {
                Response.Redirect("HomePage.aspx", false);
            }
            else
            {
                var master = (Dashboard)this.Master;
                master.setActivePage("agendas_pros");

                if (!IsPostBack)
                {
                    Consultorio.profesionales = await Consultorio.database.getProfesionales();
                    foreach (var pro in Consultorio.profesionales)
                    {
                        if (pro.dni != Consultorio.usuario_logeado.dni)
                        {
                            dpls_pros.Items.Add(new ListItem(pro.nombre + " " + pro.apellido, pro.dni.ToString()));
                        }
                    }
                    Consultorio.agendaActual = null;
                }
                
            }
            if(Consultorio.agendaActual != null)
            {
                ph_agenda.Controls.Add(Consultorio.agendaActual);
                btn_anterior.Visible = true;
                btn_siguiente.Visible = true;
                btn_hoy.Visible = true;
                btn_refresh.Visible = true;
            }
            else{
                btn_anterior.Visible = false;
                btn_siguiente.Visible = false;
                btn_hoy.Visible = false;
                btn_refresh.Visible = false;
            }
                
            
        }

        protected void dpls_pros_SelectedIndexChanged(object sender, EventArgs e)
        {
            ph_agenda.Controls.Clear();
            if(dpls_pros.SelectedValue != "0")
            {
                Consultorio.agendaActual = (AgendaWidget)LoadControl("Widgets/AgendaWidget.ascx");
                Consultorio.agendaActual.Profesional = Consultorio.profesionales.Find(usuario => usuario.dni == int.Parse(dpls_pros.SelectedValue));

                Consultorio.agendaActual.EnableViewState = true;
                ph_agenda.Controls.Add(Consultorio.agendaActual);
                btn_anterior.Visible = true;
                btn_siguiente.Visible = true;
                btn_hoy.Visible = true;
                btn_refresh.Visible = true;
            }
            
        }

        protected void btn_anterior_Click(object sender, EventArgs e)
        {
            Consultorio.semanaActualAgenda -= 1;
            Consultorio.agendaActual.Lunes = DateTime.Today
                .AddDays(-(int)DateTime.Today.DayOfWeek + (int)DayOfWeek.Monday)
                .AddDays(7 * Consultorio.semanaActualAgenda);
            
        }

        protected void btn_siguiente_Click(object sender, EventArgs e)
        {
            Consultorio.semanaActualAgenda += 1;
            Consultorio.agendaActual.Lunes = DateTime.Today
                .AddDays(-(int)DateTime.Today.DayOfWeek + (int)DayOfWeek.Monday)
                .AddDays(7 * Consultorio.semanaActualAgenda);
        }

        protected void btn_hoy_Click(object sender, EventArgs e)
        {
            Consultorio.semanaActualAgenda = 0;
            Consultorio.agendaActual.Lunes = DateTime.Today
                .AddDays(-(int)DateTime.Today.DayOfWeek + (int)DayOfWeek.Monday)
                .AddDays(7 * Consultorio.semanaActualAgenda);
        }

        protected void btn_refresh_Click(object sender, EventArgs e)
        {
            Consultorio.agendaActual.Lunes = DateTime.Today
                .AddDays(-(int)DateTime.Today.DayOfWeek + (int)DayOfWeek.Monday)
                .AddDays(7 * Consultorio.semanaActualAgenda);
        }
    }
}