using Firebase.Auth;
using Lenguajes3_ProyectoFinalv3.Models;
using Lenguajes3_ProyectoFinalv3.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lenguajes3_ProyectoFinalv3.Pages
{
    public partial class RegisterPage1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                logo.InnerText = Consultorio.nombre;
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
            usuario.telefono2 = tb_telefono2.Text;
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
                FirebaseAuthLink token = await Consultorio.auth.registrarUsuario(usuario.correo, tb_password.Text);
                bool isUserUploaded = await Consultorio.database.addUser(usuario);
                if (!isUserUploaded)
                {
                    await Consultorio.auth.eliminarCuenta(token.FirebaseToken);
                }
                bool isPacienteUploaded = await Consultorio.database.addPaciente(usuario);
                if (!isPacienteUploaded)
                {
                    await Consultorio.auth.eliminarCuenta(token.FirebaseToken);
                }
                Response.Redirect("LoginPage.aspx");

            }
            catch (Exception exp)
            {
                Response.Write("<script>alert('" + exp.Message + "')</script>");
                throw;
            }
            if (file_up.HasFile)
            {
                //file_up.PostedFile.InputStream;
            }
        }
    }
}