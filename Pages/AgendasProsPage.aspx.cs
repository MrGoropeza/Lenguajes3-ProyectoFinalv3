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
            if (!IsPostBack)
            {
                if (Consultorio.usuario_logeado == null)
                {
                    Response.Redirect("HomePage.aspx", false);
                }
                else
                {
                    var master = (Dashboard)this.Master;
                    master.setActivePage("agendas_pros");

                    Consultorio.profesionales = await Consultorio.database.getProfesionales();
                    foreach (var pro in Consultorio.profesionales)
                    {
                        if (pro.dni != Consultorio.usuario_logeado.dni)
                        {
                            dpls_pros.Items.Add(new ListItem(pro.nombre + " " + pro.apellido, pro.dni.ToString()));
                        }
                    }
                }
            }
            
        }

        protected void dpls_pros_SelectedIndexChanged(object sender, EventArgs e)
        {
            AgendaWidget agenda = (AgendaWidget)LoadControl("Widgets/AgendaWidget.ascx");
            agenda.Profesional = Consultorio.profesionales.Find(usuario => usuario.dni == int.Parse(dpls_pros.SelectedValue));

            ph_agenda.Controls.Add(agenda);
        }
    }
}