using Firebase.Auth;
using Lenguajes3_ProyectoFinalv3.Models;
using Lenguajes3_ProyectoFinalv3.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Globalization;

namespace Lenguajes3_ProyectoFinalv3.Pages
{
    public partial class RegisterPage1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("es-ES");
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

                    var query_name = Request.QueryString["name"];
                    if (query_name != null)
                    {
                        if (query_name.Length > 0)
                        {
                            tb_nombre.Text = Request.QueryString["name"];
                        }
                    }

                }
                catch (Exception)
                {
                }

            }
        }

        protected void validarTelefono(object sender, ServerValidateEventArgs e)
        {
            string numero = tb_telefono1.Text;
            e.IsValid = PhoneValidator.isValid(numero);

        }

        protected async void btn_register_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            usuario.dni = int.Parse(tb_dni.Text);
            usuario.nombre = tb_nombre.Text;
            usuario.apellido = tb_apellido.Text;
            usuario.telefono1 = tb_telefono1.Text;
            usuario.correo = tb_mail.Text;
            usuario.fecha_nac = tb_fecha_nac.Text;
            usuario.isProfesional = false;
            usuario.isAdmin = false;
            switch (rdbtnls_genero.SelectedItem.Value)
            {
                case "Masculino":
                    usuario.genero = "M";
                    break;
                case "Femenino":
                    usuario.genero = "F";
                    break;
                case "Otro":
                    usuario.genero = "O";
                    break;
            }
            try
            {
                if (file_up.HasFile)
                {
                    usuario.avatar_link = await Consultorio.storage.setAvatarLink(file_up.PostedFile.InputStream, usuario.dni);
                }
                Consultorio.token = await Consultorio.auth.registrarUsuario(usuario.correo, tb_password.Text);
                Consultorio.database.addUser(usuario);
                Response.Redirect("LoginPage.aspx");

            }
            catch (Exception exp)
            {
                Response.Write("<script>alert('" + exp.Message + "')</script>");
                if (Consultorio.token != null)
                {
                    await Consultorio.auth.eliminarCuenta(Consultorio.token.FirebaseToken);
                    Consultorio.database.removeUser(usuario);
                }
                throw;
            }
            
        }
    }
}