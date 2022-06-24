using Lenguajes3_ProyectoFinalv3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lenguajes3_ProyectoFinalv3.Pages
{
    public partial class ForgotPasswordPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                advertencia.Visible = false;
            }
        }

        protected async void btn_login_Click(object sender, EventArgs e)
        {
            try
            {
                Usuario user = await Consultorio.database.getUsuario(int.Parse(tb_dni.Text));
                try
                {
                    Consultorio.auth.recuperarContra(user.correo);
                    advertencia.InnerText = "Email de Reseteo enviado a " + user.correo + ". Ya podés volver a inicio de sesión.";
                    advertencia.Visible = true;
                }
                catch (Exception)
                {
                    advertencia.InnerText = "Error al mandar correo de recuperación, intente de nuevo.";
                    advertencia.Visible = true;
                    throw;
                }
                
            }
            catch (Exception)
            {
                advertencia.InnerText = "No estas registrado.";
                advertencia.Visible = true;
                throw;
            }
        }
    }
}