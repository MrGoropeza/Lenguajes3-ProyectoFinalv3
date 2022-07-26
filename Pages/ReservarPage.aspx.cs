using Lenguajes3_ProyectoFinalv3.Models;
using Lenguajes3_ProyectoFinalv3.Pages.Widgets;
using Lenguajes3_ProyectoFinalv3.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace Lenguajes3_ProyectoFinalv3.Pages
{
    public partial class ReservarPage : System.Web.UI.Page
    {
        public bool div {
            get
            {
                return selector_time.Visible;
            }
            set
            {
                selector_time.Visible = value;
            }
        }
        public string label
        {
            get
            {
                return selector_time_day.Text;
            }
            set
            {
                selector_time_day.Text = value;
            }

        }
        public RadioButtonList radioButtons { get; set; }

        protected async void Page_Load(object sender, EventArgs e)
        {
            
            if (!IsPostBack)
            {
                if(Consultorio.usuario_logeado == null)
                {
                    Response.Redirect("HomePage.aspx", false);
                }
                else
                {
                    var master = (Dashboard)this.Master;
                    master.setActivePage("reservar");

                    Consultorio.profesionales = await Consultorio.database.getProfesionales();
                    foreach (var pro in Consultorio.profesionales)
                    {
                        if(pro.dni != Consultorio.usuario_logeado.dni)
                        {
                            dpls_pros.Items.Add(new ListItem(pro.nombre + " " + pro.apellido, pro.dni.ToString()));
                        }
                    }

                    //if (Consultorio.usuario_logeado.isAdmin)
                    //{
                    //    selector_user.Visible = true;
                    //    reg_user.Visible = true;
                    //    List<Usuario> users = await Consultorio.database.getUsuarios();
                    //    foreach (var user in users)
                    //    {
                    //        if (!user.isProfesional)
                    //        {
                    //            dpls_user.Items.Add(
                    //                new ListItem(user.nombre + " " + user.apellido
                    //                + ", DNI: " + user.dni, user.dni.ToString()));
                    //        }
                            
                    //    }
                    //}
                    //else
                    //{
                        //selector_user.Visible = false;
                        //reg_user.Visible = false;
                    //}

                }

            }
        }

        protected async void btn_agenda_Click(object sender, EventArgs e)
        {
            DateTime fecha_selected = DateTime.Today;
            bool isFechaValida = DateTime.TryParse(tb_fecha.Text, out fecha_selected);
            if (dpls_pros.SelectedValue == "0")
            {
                dpls_validator.Visible = true;
                dpls_validator.IsValid = false;
            }
            if (!isFechaValida)
            {
                tb_fecha_validator.Visible = true;
                tb_fecha_validator.IsValid = false;
            }
            //if (Consultorio.usuario_logeado.isAdmin)
            //{
            //    if (dpls_user.SelectedValue == "0")
            //    {
            //        rfv_user.Visible = true;
            //        rfv_user.IsValid = false;
            //    }
            //}
            //else
            //{
            //    rfv_user.IsValid = true;
            //}
            if ( dpls_validator.IsValid && tb_fecha_validator.IsValid)
            {
                dpls_validator.Visible = false;
                dpls_validator.IsValid = true;

                if(fecha_selected >= DateTime.Today)
                {
                    if (fecha_selected.DayOfWeek == DayOfWeek.Sunday || fecha_selected.DayOfWeek == DayOfWeek.Saturday)
                    {
                        advertencia.InnerText = "No trabajamos los fines de semana.";
                        advertencia.Visible = true;
                        return;
                    }
                    //else if(fecha_selected == DateTime.Today)
                    //{
                    //    advertencia.InnerText = "Los turnos solo se pueden reservar con un día de anticipación.";
                    //    advertencia.Visible = true;
                    //    return;
                    //}
                    advertencia.Visible = false;
                    Usuario pro_selected = Consultorio.profesionales.
                        Where(pro => pro.dni.ToString() == dpls_pros.SelectedItem.Value).First();
                    List<Turno> turnos = await Consultorio.database.getAgendaProfesional(pro_selected.dni, fecha_selected);
                    DateTime hora = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day
                            , 10, 0, 0);
                    rdbtnls_turnos.Items.Clear();

                    //var ctl_prueba = new ListItem("hola", "22", true);
                    //ctl_prueba.Attributes.CssStyle.Add("color", "blue");
                    //rdbtnls_turnos.Items.Add(ctl_prueba);



                    //revisar si ya tiene un turno reservado ese día


                    for (int i = 0; i < 4; i++)
                    {
                        if(hora > DateTime.Now)
                        {
                            rdbtnls_turnos.Items.Add(new ListItem(
                                hora.ToString("HH:mm") + " - " + hora.AddMinutes(30).ToString("HH:mm")
                                , i.ToString()
                            ));
                        }

                        hora = hora.AddMinutes(30);

                    }
                    hora = hora.AddHours(2);
                    for (int i = 4; i < 16; i++)
                    {
                        if (hora > DateTime.Now)
                        {
                            rdbtnls_turnos.Items.Add(new ListItem(
                                hora.ToString("HH:mm") + " - " + hora.AddMinutes(30).ToString("HH:mm")
                                , i.ToString()
                            ));
                        }
                        hora = hora.AddMinutes(30);
                    }

                    if (turnos != null)
                    {
                        foreach (var turno in turnos)
                        {
                            ListItem item = rdbtnls_turnos.Items.FindByValue(turno.slot.ToString());
                            rdbtnls_turnos.Items.Remove(item);
                        }
                        if(rdbtnls_turnos.Items.Count == 0)
                        {
                            advertencia.InnerText = "No hay turnos en este día para el profesional.";
                            advertencia.Visible = true;
                            return;
                        }
                    }
                    selector_time.Visible = true;
                    selector_time_day.Text = "Turnos disponibles el "
                        + fecha_selected.Day + " de "
                        + monthFromInt(fecha_selected.Month) + " del "
                        + fecha_selected.Year;
                }
                else
                {
                    advertencia.InnerText = "La fecha no puede ser anterior a hoy";
                    advertencia.Visible = true;
                }
            }
        }

        private string monthFromInt(int month)
        {
            string respuesta = "";
            switch (month)
            {
                case 1:
                    respuesta = "Enero";
                    break;
                case 2:
                    respuesta = "Febrero";
                    break;
                case 3:
                    respuesta = "Marzo";
                    break;
                case 4:
                    respuesta = "Abril";
                    break;
                case 5:
                    respuesta = "Mayo";
                    break;
                case 6:
                    respuesta = "Junio";
                    break;
                case 7:
                    respuesta = "Julio";
                    break;
                case 8:
                    respuesta = "Agosto";
                    break;
                case 9:
                    respuesta = "Septiembre";
                    break;
                case 10:
                    respuesta = "Octubre";
                    break;
                case 11:
                    respuesta = "Noviembre";
                    break;
                case 12:
                    respuesta = "Diciembre";
                    break;
            }
            return respuesta;
        }

        protected void dpls_pros_SelectedIndexChanged(object sender, EventArgs e)
        {
            Usuario pro_selected = Consultorio.profesionales.
                Where(pro => pro.dni.ToString() == dpls_pros.SelectedItem.Value).First();
            pro_name.InnerText = pro_selected.nombre + " " + pro_selected.apellido;
            pro_title.InnerText = pro_selected.profesional_titulo;
            if(pro_selected.avatar_link != null)
            {
                if(pro_selected.avatar_link != "")
                {
                    pro_avatar.Attributes["src"] = pro_selected.avatar_link;
                }
                else
                {
                    pro_avatar.Attributes["src"] = "../images/avatar-default.png";
                }
            }
        }

        protected async void btn_reservar_Click(object sender, EventArgs e)
        {
            DateTime fecha_selected = DateTime.Today;
            bool isFechaValida = DateTime.TryParse(tb_fecha.Text, out fecha_selected);
            if (dpls_pros.SelectedValue == "0")
            {
                dpls_validator.Visible = true;
                dpls_validator.IsValid = false;
            }
            if (!isFechaValida)
            {
                tb_fecha_validator.Visible = true;
                tb_fecha_validator.IsValid = false;
            }
            //if (Consultorio.usuario_logeado.isAdmin)
            //{
            //    if (dpls_user.SelectedValue == "0")
            //    {
            //        rfv_user.Visible = true;
            //        rfv_user.IsValid = false;
            //    }
            //}
            //else
            //{
            //    rfv_user.IsValid = true;
            //}
            
            if (dpls_validator.IsValid && tb_fecha_validator.IsValid)
            {
                Turno nuevo = new Turno();
                Usuario pro_selected = Consultorio.profesionales.
                Where(pro => pro.dni.ToString() == dpls_pros.SelectedItem.Value).First();
                nuevo.slot = Convert.ToInt32(rdbtnls_turnos.SelectedValue);
                nuevo.pacienteDNI = Consultorio.usuario_logeado.dni;
                nuevo.fecha = fecha_selected;
                nuevo.profesionalDNI = pro_selected.dni;

                bool encontrado_en_mismo_horario = false;
                bool turno_en_el_mismo_dia = false;
                int index = 0;
                Consultorio.turnos_logeado = await Consultorio.database.getTurnosPaciente(Consultorio.usuario_logeado.dni);

                if(Consultorio.turnos_logeado != null)
                {
                    while (!encontrado_en_mismo_horario && index < Consultorio.turnos_logeado.Count())
                    {
                        System.Diagnostics.Debug.WriteLine("Iteración " + index + ": \n" +
                            "  " + Consultorio.turnos_logeado[index].slot + " == " + nuevo.slot + "\n" +
                            "  " + Consultorio.turnos_logeado[index].fecha + " == " + fecha_selected);
                        if (Consultorio.turnos_logeado[index].slot == nuevo.slot
                            && Consultorio.turnos_logeado[index].fecha.Day == fecha_selected.Day
                            && Consultorio.turnos_logeado[index].fecha.Month == fecha_selected.Month
                            && Consultorio.turnos_logeado[index].fecha.Year == fecha_selected.Year)
                        {
                            encontrado_en_mismo_horario = true;
                        }
                        else if (Consultorio.turnos_logeado[index].fecha.Day == fecha_selected.Day
                            && Consultorio.turnos_logeado[index].fecha.Month == fecha_selected.Month
                            && Consultorio.turnos_logeado[index].fecha.Year == fecha_selected.Year)
                        {
                            turno_en_el_mismo_dia = true;
                        }
                        index++;
                    }
                    if (encontrado_en_mismo_horario)
                    {
                        advertencia.InnerText = "Ya tenés un turno en esa fecha y hora.";
                        advertencia.Visible = true;
                        return;
                    }
                    else if (turno_en_el_mismo_dia)
                    {
                        advertencia.InnerText = "Ya tenés un turno ese día. No podés tener dos turnos en un día.";
                        advertencia.Visible = true;
                        return;
                    }
                    else
                    {
                        System.Diagnostics.Debug.WriteLine(fecha_selected.ToString("dd-MM-yyyy"));
                        Consultorio.database.addTurno(nuevo);
                        Consultorio.turnos_logeado =
                            await Consultorio.database
                            .getTurnosPaciente(Consultorio.usuario_logeado.dni);
                        GMailProvider.mandarInfoTurno(nuevo, Consultorio.usuario_logeado);
                        Response.Redirect("DashboardPage.aspx", false);
                    }
                }
                else
                {
                    Consultorio.database.addTurno(nuevo);
                    Consultorio.turnos_logeado =
                        await Consultorio.database
                        .getTurnosPaciente(Consultorio.usuario_logeado.dni);
                    GMailProvider.mandarInfoTurno(nuevo, Consultorio.usuario_logeado);
                    Response.Redirect("DashboardPage.aspx", false);
                }
                
                
            }
        }

        protected void reg_user_Click(object sender, EventArgs e)
        {
            Response.Redirect("RegisterPage.aspx?a=1",false);
        }

        protected void rdbtnls_turnos_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (ListItem item in rdbtnls_turnos.Items)
            {
                string color = item.Selected ? "Blue" : "Black";
                item.Attributes.CssStyle.Add("color",color);

                
            }
        }
    }
}