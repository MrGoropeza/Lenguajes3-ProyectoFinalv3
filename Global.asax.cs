using Lenguajes3_ProyectoFinalv3.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;
using System.Web.UI;

namespace Lenguajes3_ProyectoFinalv3
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {
            Consultorio.initFirebase();
            Consultorio.setDatos();
            ValidationSettings.UnobtrusiveValidationMode = System.Web.UI.UnobtrusiveValidationMode.None;
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("es-ES");
            Thread.CurrentThread.CurrentCulture = new CultureInfo("es-ES");
        }

        protected void Session_Start(object sender, EventArgs e)
        {

        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}