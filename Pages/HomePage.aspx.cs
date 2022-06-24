using Lenguajes3_ProyectoFinalv3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lenguajes3_ProyectoFinalv3.Pages
{
    public partial class HomePage : System.Web.UI.Page
    {
        Inicio masterPage;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                masterPage = (Inicio)this.Master;
                nombre_consul.InnerText = Consultorio.nombre;
                contacto_correo.InnerText = Consultorio.correo;
                contacto_telefono.InnerText = Consultorio.numero;
            }
        }

        protected async void Login_Click(object sender, EventArgs e)
        {
            if(tb_login_dni.Text.Length > 0 && tb_login_pass.Text.Length > 0)
            {
                try
                {
                    Usuario usuario = await Consultorio.database.getUsuario(int.Parse(tb_login_dni.Text));

                    Consultorio.token = await Consultorio.auth.iniciarSesion(usuario.correo, tb_login_pass.Text);

                    Consultorio.usuario_logeado = usuario;

                    Response.Redirect("DashboardPage.aspx");
                }
                catch (Exception exp)
                {
                    Response.Write(exp.Message);
                    Consultorio.usuario_logeado = null;
                    Consultorio.token = null;
                    Response.Redirect("LoginPage.aspx");
                    throw;
                }
            } else if (tb_login_dni.Text.Length > 0)
            {
                string link = "LoginPage.aspx?dni=" + tb_login_dni.Text; 
                Response.Redirect(link, false);
            }
            else
            {
                Response.Redirect("LoginPage.aspx",false);
            }
        }

        protected void Register_Click(object sender, EventArgs e)
        {
            List<string> redirect_link = new List<string>();
            redirect_link.Add("RegisterPage.aspx");
            if (tb_register_dni.Text.Length > 0)
            {
                redirect_link.Add("dni=" + tb_register_dni.Text);
            }
            if (tb_register_name.Text.Length > 0)
            {
                redirect_link.Add("name=" + tb_register_name.Text);
            }
            string link = redirect_link[0];
            for (int i = 1; i < redirect_link.Count; i++)
            {
                if (i == 1)
                {
                    link += "?" + redirect_link[i];
                }
                else
                {
                    link += "&" + redirect_link[i];
                }
                
            }
            Response.Redirect(link);
        }

        protected void btn_reserve_now_Click(object sender, EventArgs e)
        {
            if(Consultorio.usuario_logeado == null)
            {
                Response.Redirect("LoginPage.aspx");
            }
            else
            {
                Response.Redirect("DashboardPage.aspx");
            }
        }
    }
}