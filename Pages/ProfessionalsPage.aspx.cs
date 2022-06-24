using Lenguajes3_ProyectoFinalv3.Models;
using Lenguajes3_ProyectoFinalv3.Pages.Widgets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lenguajes3_ProyectoFinalv3.Pages
{
    public partial class ProfessionalsPage : System.Web.UI.Page
    {
        private List<Usuario> pros = new List<Usuario>();
        protected async void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                pros = await Consultorio.database.getProfesionales();
                if(pros.Count > 0)
                {
                    foreach (var item in pros)
                    {
                        Profesional pro_widget = (Profesional)LoadControl("Widgets/Profesional.ascx");
                        pro_widget.nombre = item.nombre + " " + item.apellido;
                        pro_widget.titulo = item.profesional_titulo;
                        pro_widget.descripcion = item.profesional_bio;
                        if(item.avatar_link.Length > 0 && item.avatar_link != null)
                        {
                            pro_widget.imagen = item.avatar_link;
                        }
                        else
                        {
                            pro_widget.imagen = "../../images/avatar-default.png";
                        }
                        prof_widgets.Controls.Add(pro_widget);
                    }
                }
                else
                {
                    
                }
                
            }
        }
    }
}