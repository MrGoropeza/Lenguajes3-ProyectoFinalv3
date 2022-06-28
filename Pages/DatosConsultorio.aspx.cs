using Lenguajes3_ProyectoFinalv3.Models;
using Lenguajes3_ProyectoFinalv3.Models.FirebaseModels;
using Lenguajes3_ProyectoFinalv3.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lenguajes3_ProyectoFinalv3.Pages
{
    public partial class DatosConsultorio : System.Web.UI.Page
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
                    var master = (Dashboard)this.Master;
                    master.setActivePage("datos_consultorio");

                    tb_nombre.Text = Consultorio.nombre;
                    tb_mail.Text = Consultorio.correo;
                    tb_telefono1.Text = Consultorio.numero;
                    tb_direccion.Text = Consultorio.direccion;
                }

            }
        }

        protected void validarTelefono(object source, ServerValidateEventArgs args)
        {
            string numero = tb_telefono1.Text;
            args.IsValid = PhoneValidator.isValid(numero);
        }

        protected void btn_update_profile_Click(object sender, EventArgs e)
        {
            DatosConsul datos = new DatosConsul();
            datos.nombre = tb_nombre.Text;
            datos.telefono = tb_telefono1.Text;
            datos.correo = tb_mail.Text;
            datos.direccion = tb_direccion.Text;
            Consultorio.database.updateDatosConsultorio(datos);
            Consultorio.nombre = tb_nombre.Text;
            Consultorio.numero = tb_telefono1.Text;
            Consultorio.correo = tb_mail.Text;
            Consultorio.direccion = tb_direccion.Text;
        }
    }
}