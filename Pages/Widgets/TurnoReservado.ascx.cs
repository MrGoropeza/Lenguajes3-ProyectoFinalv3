using Lenguajes3_ProyectoFinalv3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lenguajes3_ProyectoFinalv3.Pages.Widgets
{
    public partial class TurnoReservado : System.Web.UI.UserControl
    {
        private Usuario profesional;
        public Usuario Profesional
        {
            get
            {
                return profesional;
            }
            set
            {
                this.profesional = value;
                if (profesional.avatar_link != null)
                {
                    if(profesional.avatar_link != "")
                    {
                        pro_avatar.Attributes["src"] = profesional.avatar_link;
                    }
                }
                pro_name.InnerText = profesional.nombre + " " + profesional.apellido;
                pro_title.InnerText = profesional.profesional_titulo;
            }
        }

        private Turno turno;

        public Turno Turno
        {
            get
            {
                return turno;
            }
            set
            {
                this.turno = value;
                turno_fecha.InnerText =
                    turno.fecha.ToString("dd") + " de "
                    + Consultorio.monthFromInt(turno.fecha.Month)
                    + turno.fecha.ToString(", yyyy | ")
                    + Consultorio.hourFromSlot(turno.slot);
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected async void btn_cancelar_Click(object sender, EventArgs e)
        {

            Consultorio.database.removeTurno(this.turno);
            Consultorio.turnos_logeado =
                await Consultorio.database
                .getTurnosPaciente(Consultorio.usuario_logeado.dni);
        }

        protected void btn_modificar_Click(object sender, EventArgs e)
        {

        }
    }
}