<%@ Page Title="Reservar un Turno" Async="true" Language="C#" MasterPageFile="~/Pages/Dashboard.Master" AutoEventWireup="true" CodeBehind="ReservarAdminPage.aspx.cs" Inherits="Lenguajes3_ProyectoFinalv3.Pages.ReservarAdminPage" %>

<asp:Content ID="ContenidoHead" ContentPlaceHolderID="Head" runat="server">
    <title>Reservar un Turno</title>
    <link rel="stylesheet" href="../MedicalAppointmentUI/css/styleBookAppointment.css" />
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="Contenido" runat="server">
    <div class="container">
        <div class="main-container">
            <div class="row">

                <div class="col-lg-12">
                    <h2>Reservar un Turno</h2>
                    <em>Seleccioná tu profesional preferido y se habilitará la opción para seleccionar el turno.
                        <br>
                    </em>
                    <hr>
                </div>

                <div class="search-appointment">
                    <div class="make-app">

                        <!--Select Profesional-->
                        <asp:Label runat="server"
                            AssociatedControlID="dpls_pros"
                            Text="Profesional:" />
                        <asp:RequiredFieldValidator runat="server"
                            ValidationGroup="prof_form"
                            ControlToValidate="dpls_pros"
                            Text="Seleccioná un profesional*"
                            ForeColor="Red"
                            Visible="false"
                            ID="dpls_validator" />
                        <asp:DropDownList runat="server"
                            ID="dpls_pros"
                            ValidationGroup="prof_form"
                            AutoPostBack="true"
                            CausesValidation="true"
                            OnSelectedIndexChanged="dpls_pros_SelectedIndexChanged">
                            <asp:ListItem Value="0">Selecciona un profesional</asp:ListItem>
                        </asp:DropDownList>
                        <!--Select Profesional-->

                        <br />

                        <!--Select dia-->
                        <asp:Label runat="server"
                            AssociatedControlID="tb_fecha"
                            Text="Día:"/>
                        <asp:RequiredFieldValidator runat="server" 
                            ControlToValidate="tb_fecha"
                            ValidationGroup="prof_form"
                            EnableClientScript="true"
                            ErrorMessage="Campo Requerido*"
                            ForeColor="Red"
                            ID="tb_fecha_validator"/>
                        <asp:TextBox runat="server"
                            TextMode="Date"
                            placeholder="dd/mm/aaaa"
                            ID="tb_fecha" />
                        <!--Select dia-->

                        <a href="ProfessionalsPage.aspx" class="know-doctors">¿No conoces a nuestros profesionales?</a>


                        <asp:LinkButton runat="server" ID="reg_user"
                            OnClick="reg_user_Click"
                            Text="Registrar un Usuario">

                        </asp:LinkButton>
                        
                        <!--Select user-->
                        <div runat="server" id="selector_user">
                        <asp:Label runat="server"
                            AssociatedControlID="dpls_user"
                            Text="Usuario:" />
                        <asp:RequiredFieldValidator runat="server"
                            ValidationGroup="prof_form"
                            ControlToValidate="dpls_user"
                            Text="Seleccioná un usuario*"
                            ForeColor="Red"
                            Visible="false"
                            ID="rfv_user" />
                        <asp:DropDownList runat="server"
                            ID="dpls_user"
                            ValidationGroup="prof_form"
                            AutoPostBack="true"
                            CausesValidation="true">
                            <asp:ListItem Value="0">Selecciona un usuario</asp:ListItem>
                        </asp:DropDownList>
                        </div>
                        <!--Select user-->

                        <asp:LinkButton runat="server"
                            CssClass="btn btn-green btn-small btn-search-appointment"
                            ID="btn_agenda"
                            OnClick="btn_agenda_Click">
                            <i class="fa fa-search"></i> Ver Agenda
                        </asp:LinkButton>

                        

                    </div>
                </div>
                <!--Perfil Profesional-->
                <div class="preview-appointment">
                    <div class="preview-doctor">
                        <img src="../images/avatar-default.png" alt="foto profesional"
                            runat="server" id="pro_avatar">
                    </div>
                    <ul>
                        <li>
                            <h5 runat="server" id="pro_name">Selecciona un profesional</h5>
                        </li>
                        <li>Especialización: <span runat="server" id="pro_title"></span></li>
                    </ul>
                </div>
                <!--Perfil Profesional-->
            </div>

            <br>

            <div class="alert alert-warning" role="alert"
                runat="server" id="advertencia"
                visible="false">
            </div>

            <!-- Selector Turno -->
                    <%--<h4 runat="server" id="selector_day_text">Available Appointments on February 18, 2017</h4>--%>
            <div class="row">
                <!--List Book-->
                <div class="time-book"
                    runat="server"
                    id="selector_time"
                    visible="false">

                    <asp:Label runat="server"
                        ID="selector_time_day"
                        AssociatedControlID="rdbtnls_turnos"
                        Text="Available Appointments on February 18, 2017"/>
                    <asp:RequiredFieldValidator runat="server"
                        ValidationGroup="reservar_form" 
                        ErrorMessage="Selección requerida*"
                        EnableClientScript="true"
                        ControlToValidate="rdbtnls_turnos"
                        ForeColor="Red"/>
                    <asp:RadioButtonList runat="server"
                        ID="rdbtnls_turnos"
                        CssClass="radio"
                        RepeatDirection="Vertical">
                        <%--<asp:ListItem value="0" Text="10:00 - 10:30"></asp:ListItem>
                        <asp:ListItem value="1" Text="10:30 - 11:00"></asp:ListItem>
                        <asp:ListItem value="2" Text="11:00 - 11:30"></asp:ListItem>
                        <asp:ListItem value="3" Text="11:30 - 12:00"></asp:ListItem>
                        <asp:ListItem value="4" Text="14:00 - 14:30"></asp:ListItem>
                        <asp:ListItem value="5" Text="14:30 - 15:00"></asp:ListItem>
                        <asp:ListItem value="6" Text="15:00 - 15:30"></asp:ListItem>
                        <asp:ListItem value="7" Text="15:30 - 16:00"></asp:ListItem>
                        <asp:ListItem value="8" Text="16:00 - 16:30"></asp:ListItem>
                        <asp:ListItem value="9" Text="16:30 - 17:00"></asp:ListItem>
                        <asp:ListItem value="10" Text="17:00 - 17:30"></asp:ListItem>
                        <asp:ListItem value="11" Text="17:30 - 18:00"></asp:ListItem>
                        <asp:ListItem value="12" Text="18:00 - 18:30"></asp:ListItem>
                        <asp:ListItem value="13" Text="18:30 - 19:00"></asp:ListItem>
                        <asp:ListItem value="14" Text="19:00 - 19:30"></asp:ListItem>
                        <asp:ListItem value="15" Text="19:30 - 20:00"></asp:ListItem>--%>
                    </asp:RadioButtonList>

                    <asp:Button runat="server"
                        ID="btn_reservar"
                        CssClass="btn btn-xsmall"
                        Text="Reservar Turno"
                        ValidationGroup="reservar_form"
                        OnClick="btn_reservar_Click"/>

                    

                </div>
                
            </div>
            <!-- Selector Turno -->

            <asp:PlaceHolder runat="server" ID="ph_calendario"></asp:PlaceHolder>

        </div>
    </div>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Scripts" runat="server">
    <!-- ======================= JQuery libs =========================== -->
    <script type="text/javascript" src="../MedicalAppointmentUI/js/jquery-bookappointment.js"></script>
    <script type="text/javascript" src="../MedicalAppointmentUI/js/jquery-ui-book.min.js"></script>
    <script type="text/javascript" src="../MedicalAppointmentUI/js/bootstrap-book.min.js"></script>
    <script type="text/javascript" src="../MedicalAppointmentUI/js/bootstrap-sprockets-book.js"></script>
    <!-- Main Functions-->
    <script type="text/javascript" src="../MedicalAppointmentUI/js/main-book.js"></script>
</asp:Content>
