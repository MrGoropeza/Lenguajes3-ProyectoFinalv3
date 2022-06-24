using Lenguajes3_ProyectoFinalv3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lenguajes3_ProyectoFinalv3
{
    public partial class HomePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if(Consultorio.usuario_logeado == null)
                {
                    Response.Redirect("HomePage.aspx");
                }
                else
                {
                    var master = (Dashboard)this.Master;
                    master.setActivePage("dashboard");
                }
            }
            else
            {

            }
        }
    }
}