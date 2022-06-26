using Lenguajes3_ProyectoFinalv3.Models;
using Lenguajes3_ProyectoFinalv3.Pages.Widgets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lenguajes3_ProyectoFinalv3
{
    public partial class HomePage : System.Web.UI.Page
    {
        protected async void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Consultorio.turnos_cargados = 0;
                if(Consultorio.usuario_logeado == null)
                {
                    Response.Redirect("HomePage.aspx");
                }
                else
                {
                    var master = (Dashboard)this.Master;
                    master.setActivePage("dashboard");


                    if(Consultorio.turnos_logeado == null)
                    {
                        Consultorio.turnos_logeado =
                            await Consultorio.database
                            .getTurnosPaciente(Consultorio.usuario_logeado.dni);
                    }
                    

                    if(Consultorio.turnos_logeado != null)
                    {
                        btn_load_more_Click(sender,e);
                    }
                }
            }
            else
            {
                //if (Consultorio.usuario_logeado == null)
                //{
                //    Response.Redirect("HomePage.aspx");
                //}
                //else
                //{
                //    if (Consultorio.turnos_logeado != null)
                //    {
                //        btn_load_more_Click(sender, e);
                //    }
                //}
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