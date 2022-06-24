using Lenguajes3_ProyectoFinalv3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lenguajes3_ProyectoFinalv3.Pages.Widgets
{
    public partial class Profesional : System.Web.UI.UserControl
    {

        public string descripcion
        {
            set { pro_desc.InnerText = value; }
        }

        public string imagen
        {
            set { pro_img.Attributes["src"] = value; }
        }

        public string nombre
        {
            set { pro_name.InnerText = value; }
        }

        public string titulo
        {
            set { pro_title.InnerText = value; }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
        }
    }
}