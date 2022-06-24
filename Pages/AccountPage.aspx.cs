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
    public partial class AccountPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (!IsPostBack)
            {
                if (Consultorio.usuario_logeado == null)
                {
                    Response.Redirect("HomePage.aspx", false);
                }
                else
                {
                    if (Consultorio.usuario_logeado.isProfesional)
                    {
                        desc_pro.Visible = true;
                        tb_desc_pro.Text = Consultorio.usuario_logeado.profesional_bio;
                        tb_titulo_pro.Text = Consultorio.usuario_logeado.profesional_titulo;
                    }
                    else
                    {
                        desc_pro.Visible = false;
                    }
                    var master = (Dashboard)this.Master;
                    master.setActivePage("cuenta");
                    advertencia.Visible = false;
                    tb_nombre.Text = Consultorio.usuario_logeado.nombre;
                    tb_apellido.Text = Consultorio.usuario_logeado.apellido;
                    tb_dni.Text = Consultorio.usuario_logeado.dni.ToString();
                    tb_telefono1.Text = Consultorio.usuario_logeado.telefono1;
                    tb_fecha_nac.Text = Consultorio.usuario_logeado.fecha_nac;
                    switch (Consultorio.usuario_logeado.genero)
                    {
                        case "M":
                            rdbtnls_genero.SelectedValue = "Masculino";
                            break;
                        case "F":
                            rdbtnls_genero.SelectedValue = "Femenino";
                            break;
                        case "O":
                            rdbtnls_genero.SelectedValue = "Otro";
                            break;
                    }
                    tb_mail.Text = Consultorio.usuario_logeado.correo;
                }
                
            }
        }

        protected void validarTelefono(object source, ServerValidateEventArgs args)
        {
            string numero = tb_telefono1.Text;
            args.IsValid = PhoneValidator.isValid(numero);
        }

        protected async void btn_update_profile_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            usuario.dni = int.Parse(tb_dni.Text);
            usuario.nombre = tb_nombre.Text;
            usuario.apellido = tb_apellido.Text;
            usuario.telefono1 = tb_telefono1.Text;
            usuario.correo = tb_mail.Text;
            usuario.fecha_nac = tb_fecha_nac.Text;
            if (Consultorio.usuario_logeado.isProfesional)
            {
                usuario.profesional_bio = tb_desc_pro.Text;
                usuario.profesional_titulo = tb_titulo_pro.Text;
                usuario.isProfesional = true;
            }
            if (Consultorio.usuario_logeado.isAdmin)
            {
                usuario.isAdmin = true;
            }
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
                Consultorio.database.updateUser(usuario);
                Consultorio.usuario_logeado = usuario;
            }
            catch (Exception exp)
            {
                advertencia.InnerText = exp.Message;
                advertencia.Visible = true;
            }
        }

        protected void btn_change_pass_Click(object sender, EventArgs e)
        {
            Consultorio.auth.recuperarContra(tb_mail.Text);
            advertencia.InnerText = "Revisa tu bandeja de entrada para cambiar la contraseña.";
            advertencia.Visible = true;
        }
    }
}