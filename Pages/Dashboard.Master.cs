using Lenguajes3_ProyectoFinalv3.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lenguajes3_ProyectoFinalv3
{
    public partial class Dashboard : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("es-ES");
            Thread.CurrentThread.CurrentCulture = new CultureInfo("es-ES");
            if (!IsPostBack)
            {
                correo_consul.InnerText = Consultorio.correo;
                numero_consul.InnerText = Consultorio.numero;
                if (Consultorio.usuario_logeado != null)
                {
                    if (Consultorio.usuario_logeado.isAdmin)
                    {
                        users.Visible = true;
                        agenda.Visible = true;
                        agendas_pros.Visible = true;
                        datos_consultorio.Visible = true;
                    }
                    else if(Consultorio.usuario_logeado.isProfesional)
                    {
                        agenda.Visible = true;
                        users.Visible = false;
                        dashboard.Visible = false;
                        reservar.Visible = false;
                        agendas_pros.Visible = false;
                        datos_consultorio.Visible = false;
                    }
                    else
                    {
                        agendas_pros.Visible = false;
                        users.Visible = false;
                        agenda.Visible = false;
                        datos_consultorio.Visible = false;
                    }
                    username.InnerText = Consultorio.usuario_logeado.nombre + " " + Consultorio.usuario_logeado.apellido;
                    if(Consultorio.usuario_logeado.avatar_link != "" && Consultorio.usuario_logeado.avatar_link != null)
                    {
                        user_avatar.ImageUrl = Consultorio.usuario_logeado.avatar_link;
                    }
                    else
                    {
                        user_avatar.ImageUrl = "../images/avatar-default.png";
                    }
                    
                }
                else
                {
                    Response.Redirect("HomePage.aspx");
                }
            }
        }

        public void setActivePage(string id_page)
        {
            switch (id_page)
            {
                case "dashboard":
                    setInactiveAll();
                    dashboard.Attributes["class"] = "active";
                    break;
                case "reservar":
                    setInactiveAll();
                    reservar.Attributes["class"] = "active";
                    break;
                case "cuenta":
                    setInactiveAll();
                    cuenta.Attributes["class"] = "active";
                    break;
                case "users":
                    setInactiveAll();
                    users.Attributes["class"] = "active";
                    break;
                case "agenda":
                    setInactiveAll();
                    agenda.Attributes["class"] = "active";
                    break;
                case "agendas_pros":
                    setInactiveAll();
                    agendas_pros.Attributes["class"] = "active";
                    break;
                case "datos_consultorio":
                    setInactiveAll();
                    datos_consultorio.Attributes["class"] = "active";
                    break;
            }
        }

        private void setInactiveAll()
        {
            dashboard.Attributes["class"] = "";
            reservar.Attributes["class"] = "";
            cuenta.Attributes["class"] = "";
            users.Attributes["class"] = "";
            agenda.Attributes["class"] = "";
            agendas_pros.Attributes["class"] = "";
            datos_consultorio.Attributes["class"] = "";
        }

        protected void btn_logout_Click(object sender, EventArgs e)
        {
            Consultorio.usuario_logeado = null;
            Consultorio.token = null;
            Consultorio.turnos_cargados = 0;
            Consultorio.turnos_logeado = null;
            Response.Redirect("HomePage.aspx", false);
        }
    }
}