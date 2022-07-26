using Lenguajes3_ProyectoFinalv3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lenguajes3_ProyectoFinalv3.Pages
{
    public partial class LoginPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                advertencia.Visible = false;
                try
                {
                    var query_dni = Request.QueryString["dni"];
                    if (query_dni != null)
                    {
                        if (query_dni.Length > 0)
                        {
                            tb_dni.Text = Request.QueryString["dni"];
                        }
                    }
                }
                catch (Exception)
                {
                }
            }
        }

        protected async void btn_login_Click(object sender, EventArgs e)
        {
            try
            {
                Usuario usuario = await Consultorio.database.getUsuario(int.Parse(tb_dni.Text));
                if (usuario!=null)
                {
                    Consultorio.token = await Consultorio.auth.iniciarSesion(usuario.correo, tb_password.Text);
                    Consultorio.usuario_logeado = usuario;
                    if (usuario.isProfesional)
                    {
                        Response.Redirect("AgendaPage.aspx", false);
                    }
                    else
                    {
                        Response.Redirect("DashboardPage.aspx", false);
                    }
                    
                }
                else
                {
                    advertencia.InnerText = "No estás registrado.";
                    advertencia.Visible = true;
                }

                

                
            }
            catch (Exception exp)
            {
                string error = exp.Message;
                advertencia.InnerText = 
                    error.Contains("WrongPassword") ? 
                        "Contraseña incorrecta." :
                        "Hubo un error al intentar iniciar sesión, por favor intenta de nuevo.";
                advertencia.Visible = true;
                Consultorio.usuario_logeado = null;
                Consultorio.token = null;
            }
        }
    }
}