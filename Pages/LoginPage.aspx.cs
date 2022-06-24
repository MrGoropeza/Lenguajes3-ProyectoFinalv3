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
                    Response.Redirect("DashboardPage.aspx");
                }
                else
                {
                    Response.Write("No estás registrado.");
                }

                

                
            }
            catch (Exception exp)
            {
                Response.Write(exp.Message);
                Consultorio.usuario_logeado = null;
                Consultorio.token = null;
            }
        }
    }
}