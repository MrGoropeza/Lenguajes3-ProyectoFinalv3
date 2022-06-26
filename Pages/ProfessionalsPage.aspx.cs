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
                var master = (Dashboard)this.Master;
                master.setActivePage("reservar");
                if (pros.Count > 0)
                {
                    PlaceHolder fila = fila1;
                    fila.Controls.Add(new LiteralControl("<div class\"row\">"));
                    int cant_filas = 1;
                    int cant_filas_cargadas = 1;
                    foreach (var item in pros)
                    {
                        //test_pros.InnerText += item.dni.ToString() + ";  ";
                        Profesional pro_widget = (Profesional)LoadControl("Widgets/Profesional.ascx");
                        pro_widget.nombre = item.nombre + " " + item.apellido;
                        pro_widget.titulo = item.profesional_titulo;
                        pro_widget.descripcion = item.profesional_bio;
                        if(item.avatar_link != null)
                        {
                            if (item.avatar_link.Length > 0)
                            {
                                pro_widget.imagen = item.avatar_link;
                            }
                            else
                            {
                                pro_widget.imagen = "../../images/avatar-default.png";
                            }
                        }
                        else
                        {
                            pro_widget.imagen = "../../images/avatar-default.png";
                        }
                        if(fila.Controls.Count <= 3)
                        {
                            fila.Controls.Add(pro_widget);
                        }
                        else
                        {
                            if (cant_filas > 1)
                            {
                                fila.Controls.Add(new LiteralControl("</div>"));
                                fila.Controls.Add(new LiteralControl("<div class=\"department-title\">"));
                                fila.Controls.Add(new LiteralControl("<hr>"));
                                fila.Controls.Add(new LiteralControl("</div>"));
                                panel_pros.Controls.Add(fila);
                                cant_filas_cargadas++;
                            }
                            else
                            {
                                fila.Controls.Add(new LiteralControl("</div>"));
                                fila.Controls.Add(new LiteralControl("<div class=\"department-title\">"));
                                fila.Controls.Add(new LiteralControl("<hr>"));
                                fila.Controls.Add(new LiteralControl("</div>"));
                            }
                            fila = new PlaceHolder();
                            cant_filas++;
                            fila.Controls.Add(new LiteralControl("<div class\"row\">"));
                            fila.Controls.Add(pro_widget);
                        }
                        
                    }
                    //test_pros.InnerText += cant_filas_cargadas + " vs " + cant_filas + ";  ";
                    if (cant_filas_cargadas < cant_filas)
                    {
                        fila.Controls.Add(new LiteralControl("</div>"));
                        panel_pros.Controls.Add(fila);
                        
                    }
                }
                else
                {
                    
                }
                
            }
        }
    }
}