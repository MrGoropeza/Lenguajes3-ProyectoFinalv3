using Lenguajes3_ProyectoFinalv3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lenguajes3_ProyectoFinalv3.Pages.Widgets
{
    public partial class UserWidget : System.Web.UI.UserControl
    {
        private Usuario usuario;
        public Usuario Usuario
        {
            get
            {
                return usuario;
            }
            set
            {
                usuario = value;
                lb_name.Text = usuario.nombre + " " + usuario.apellido;
                user_title.InnerText = usuario.profesional_titulo;
                if(usuario.avatar_link != null)
                {
                    if(usuario.avatar_link != "")
                    {
                        user_avatar.Attributes["src"] = usuario.avatar_link;
                    }
                }
                user_correo.InnerText = usuario.correo;
                user_dni.InnerText = usuario.dni.ToString();
                user_fecha_nac.InnerText = usuario.fecha_nac;
                switch (usuario.genero)
                {
                    case "M":
                        user_gender.InnerText = "Masculino";
                        break;
                    case "F":
                        user_gender.InnerText = "Femenino";
                        break;
                    case "O":
                        user_gender.InnerText = "Otro";
                        break;
                }
                user_tel1.InnerText = usuario.telefono1;
                if (usuario.isAdmin)
                {
                    esAdmin.InnerText = "Es Admin: Si";
                }
                else
                {
                    esAdmin.InnerText = "Es Admin: No";
                }
                if (usuario.isProfesional)
                {
                    esProfesional.InnerText = "Es Profesional: Si";
                }
                else
                {
                    esProfesional.InnerText = "Es Profesional: No";
                }
                if(usuario.dni != Consultorio.usuario_logeado.dni && !usuario.isProfesional)
                {
                    lb_name.Enabled = false;
                }
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void lb_name_Click(object sender, EventArgs e)
        {
            user_title.InnerText = usuario.dni.ToString() + " vs " + Consultorio.usuario_logeado.dni.ToString();
            Page.Response.Redirect("AccountPage.aspx", false);
            if (usuario.dni == Consultorio.usuario_logeado.dni)
            {
                //lb_name.PostBackUrl = "AccountPage.aspx";
                //Server.Transfer("AccountPage.aspx");
                //HttpContext.Current.ApplicationInstance.CompleteRequest();
                Page.Response.Redirect("AccountPage.aspx",false);
            }
            else if (usuario.isProfesional)
            {
                //lb_name.PostBackUrl = "ProfessionalsPage.aspx";
                //Server.Transfer("ProfessionalsPage.aspx");
                //HttpContext.Current.ApplicationInstance.CompleteRequest();
                Page.Response.Redirect("ProfessionalsPage.aspx", false);
            }
        }

        protected void btn_admin_Click(object sender, EventArgs e)
        {
            if (usuario.isAdmin)
            {
                Consultorio.database.removeAdmin(usuario.dni);
                if (usuario.dni == Consultorio.usuario_logeado.dni)
                {
                    Consultorio.usuario_logeado.isAdmin = false;
                }
            }
            else
            {
                Consultorio.database.turnAdmin(usuario.dni);
            }
        }

        protected void btn_pro_Click(object sender, EventArgs e)
        {
            if (usuario.isProfesional)
            {
                Consultorio.database.removeProfesional(usuario.dni);
                if (usuario.dni == Consultorio.usuario_logeado.dni)
                {
                    Consultorio.usuario_logeado.isProfesional = false;
                }
            }
            else
            {
                Consultorio.database.turnProfesional(usuario.dni);
            }
        }
    }
}