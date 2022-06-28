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
    public partial class UsersPage : System.Web.UI.Page
    {
        
        protected async void Page_Load(object sender, EventArgs e)
        {
            if(Consultorio.usuario_logeado == null)
            {
                Response.Redirect("HomePage.aspx",true);
                return;
            }
            else
            {
                var master = (Dashboard)this.Master;
                master.setActivePage("users");

                Consultorio.usuario_logeado = await Consultorio.database.getUsuario(Consultorio.usuario_logeado.dni);
                if (!Consultorio.usuario_logeado.isAdmin)
                {
                    Response.Redirect("DashboardPage.aspx",false);
                    return;
                }
                UserWidget actualUserWidget = (UserWidget)LoadControl("Widgets/UserWidget.ascx");
                actualUserWidget.Usuario = Consultorio.usuario_logeado;
                ph_actual_admin.Controls.Add(actualUserWidget);
                List<Usuario> users = await Consultorio.database.getUsuarios();
                foreach (Usuario usuario in users)
                {
                    if(usuario.dni != Consultorio.usuario_logeado.dni)
                    {
                        UserWidget userWidget = (UserWidget)LoadControl("Widgets/UserWidget.ascx");
                        userWidget.Usuario = usuario;
                        ph_users.Controls.Add(userWidget);
                    }
                }
            }
            
        }
    }
}