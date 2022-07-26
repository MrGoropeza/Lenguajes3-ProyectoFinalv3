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

        protected void validarTelefono()
        {
            string numero = tb_telefono1.Text;
            tb_tel_validator.IsValid = PhoneValidator.isValid(numero);

        }

        protected async void btn_register_Click(object sender, EventArgs e)
        {
            validarTelefono();
            correo_ServerValidate();
            dni_ServerValidate();

            List<Usuario> registrados = await Consultorio.database.getUsuarios();
            bool encontrado_dni = false;
            bool encontrado_correo = false;
            foreach (Usuario usuario in registrados)
            {
                if (usuario.dni.Equals(int.Parse(tb_dni.Text)))
                {
                    dni_custom_validator.IsValid = false;
                    dni_custom_validator.ErrorMessage = "DNI ya registrado. ";
                    encontrado_dni = true;
                }
                if(usuario.correo == tb_mail.Text)
                {
                    encontrado_correo = true;
                    mail_custom_validator.IsValid = false;
                }
            }

            if(tb_dni.Text.Length != 8)
            {
                dni_custom_validator.IsValid = false;
                dni_custom_validator.ErrorMessage += "DNI no válido.";
            }

            DateTime fecha_selected = DateTime.Parse(tb_fecha_nac.Text);
            bool fecha_valida = true;
            System.Diagnostics.Debug.WriteLine(fecha_selected.Year + " - " + DateTime.Today.Year);
            if(DateTime.Today.Year - fecha_selected.Year < 17)
            {
                fecha_valida = false;
                rfv_fecha.ErrorMessage = "Fecha no válida";
                rfv_fecha.IsValid = false;
            }
            else
            {
                fecha_valida = true;
                rfv_fecha.IsValid = true;
            }

            if (!encontrado_correo && !encontrado_dni && fecha_valida)
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

        protected async void dni_ServerValidate(object source, ServerValidateEventArgs args)
        {
            List<Usuario> registrados = await Consultorio.database.getUsuarios();
            bool encontrado = false;
            foreach (Usuario usuario in registrados)
            {
                System.Diagnostics.Debug.WriteLine(usuario.dni +" "+ int.Parse(tb_dni.Text));
                if(usuario.dni.Equals(int.Parse(tb_dni.Text)))
                {
                    encontrado = true;
                    dni_custom_validator.ErrorMessage = "DNI ya registrado. ";
                }
            }
            if (encontrado && tb_dni.Text.Length == 8)
            {
                args.IsValid = false;
            }
            else
            {
                args.IsValid = true;
            }
            
            //if (registrados.Contains(registrados.Find(user => user.dni == int.Parse(tb_dni.Text))))
            //{
            //    args.IsValid = false;
            //    dni_custom_validator.ErrorMessage = "DNI ya registrado";
            //}
            //else
            //{
            //    args.IsValid = true;
            //}
        }

        protected async void dni_ServerValidate()
        {
            List<Usuario> registrados = await Consultorio.database.getUsuarios();
            bool encontrado = false;
            foreach (Usuario usuario in registrados)
            {
                if (usuario.dni.Equals(int.Parse(tb_dni.Text)))
                {
                    dni_custom_validator.IsValid = false;
                    dni_custom_validator.ErrorMessage = "DNI ya registrado";
                    return;
                }
            }
            if (encontrado)
            {
                dni_custom_validator.IsValid = false;
                dni_custom_validator.ErrorMessage = "DNI ya registrado";
            }
            else
            {
                dni_custom_validator.IsValid = true;
            }
            
        }


        protected async void correo_ServerValidate(object source, ServerValidateEventArgs args)
        {
            List<Usuario> registrados = await Consultorio.database.getUsuarios();
            if (registrados.Contains(registrados.Find(user => user.correo == tb_mail.Text)))
            {
                args.IsValid = false;
                mail_custom_validator.ErrorMessage = "Correo ya registrado";
            }
            else
            {
                args.IsValid = true;
            }
        }

        protected async void correo_ServerValidate()
        {
            List<Usuario> registrados = await Consultorio.database.getUsuarios();
            if (registrados.Contains(registrados.Find(user => user.correo == tb_mail.Text)))
            {
                mail_custom_validator.IsValid = false;
                mail_custom_validator.ErrorMessage = "Correo ya registrado";
            }
            else
            {
                mail_custom_validator.IsValid = true;
            }
        }

    }
}