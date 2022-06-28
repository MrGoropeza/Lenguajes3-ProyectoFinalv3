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

        


    }
}