<%@ Page Language="C#" Async="true" MasterPageFile="Inicio.Master" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="Lenguajes3_ProyectoFinalv3.Pages.HomePage" %>

<asp:Content ID="HeadHomePage" ContentPlaceHolderID="Head" runat="server">
    <title>Inicio</title>
    
    <link rel="stylesheet" href="../MedicalAppointmentUI/css/styleHome.css" />
</asp:Content>

<asp:Content ID="Content1" ContentPlaceHolderID="Contenido" runat="server">
    <div class="body-home">

        <!-- Inicio Header y Hero -->
        <header class="header">
            <div class="menu">
                <div class="container">
                    <div class="row d-flex justify-content-center">
                        <div class="hero-msj">
                            <h1>Ahora, podés reservar tu
                                <br>
                                turno Online!</h1>
                            <p>Sistema de Gestión de Turnos</p>
                            <p runat="server" id="nombre_consul"></p>
                            <asp:Button runat="server"
                                CssClass="btn btn-green btn-small"
                                Text="Reservar ahora"
                                ID="btn_reserve_now"
                                OnClick="btn_reserve_now_Click"
                            />
                        </div>
                    </div>
                </div>
            </div>
        </header>
        <!-- Fin Header y Hero -->

        <!-- Inicio Sección Explicaciones -->
        <section class="container">
            <div class="row">

                <!-- Inicio Info Importante-->
                <div class="elements-aside services solid-color">
                    <ul>
                        <li class="color-1">
                            <i class="fa fa-archive" aria-hidden="true"></i>
                            <h4>Reservar un Turno</h4>
                            <p>Ahora podés reservar tu turno online! Solo registrate o inicia sesión</p>
                            <asp:Button runat="server"
                                CssClass="btn btn-red btn-xsmall"
                                Text="Reservar ahora"
                                ID="btn_reservar_rojo"
                                OnClick="btn_reserve_now_Click"
                            />
                        </li>
                        <li class="color-2">
                            <i class="fa fa-hourglass-half" aria-hidden="true"></i>
                            <h4>Horarios de Atención</h4>
                            <p>Lunes a Viernes <span>10:00am a 12:00am</span> <span>02:00pm a 08:00pm</span></p>
                        </li>
                        <li class="color-1">
                            <i class="fa fa-id-badge" aria-hidden="true"></i>
                            <h4>Contacto</h4>
                            <p>Correo Electrónico <span runat="server" id="contacto_correo"></span></p>
                            <p>Teléfono <span runat="server" id="contacto_telefono"></span></p>
                        </li>
                    </ul>
                </div>
                <!-- Fin Info Importante -->

                <!-- Inicio Servicios -->
                <div style="display:flex;
                    justify-content:center;">
                    <div class="services-app">
                        <img src="../images/agenda.png" alt="icon editar">
                        <h4>Modifica, Cancela o Imprime</h4>
                        <p>Ahora, podés reservar tu turno online, como también modificarlo, cancelarlo o imprimirlo. ¡Donde quierás!</p>
                    </div>
                    <div class="services-app">
                        <img src="../images/psychologist.png" alt="icon doctor">
                        <h4>Busca Psicólogos</h4>
                        <p>Podes ver datos y fotos de los profesionales del consultorio y elegir turno con cualquiera.</p>
                    </div>
                </div>
                <!-- Fin Servicios -->

            </div>
        </section>
        <!-- Fin Sección Explicaciones -->

        <!-- Inicio Sección Cuentas -->
        <section class="account-zone">
            <div class="container">
                <div class="row">
                    <div class="form-intials">
                        <h3>Iniciar Sesión</h3>
                        <!--Form-->
                        <div class="form-login">
                            <p>Número de documento</p>

                            <asp:RangeValidator runat="server" 
                                ControlToValidate="tb_login_dni"
                                MinimumValue="1000000"
                                MaximumValue="100000000"
                                Type="Integer"
                                ErrorMessage="DNI no válido"
                                ValidationGroup="login_form"
                                ForeColor="Red"/>
                            <asp:TextBox runat="server"
                                TextMode="Number"
                                ID="tb_login_dni"/>

                            <p>Contraseña</p>

                            <asp:TextBox TextMode="Password"
                                runat="server"
                                ID="tb_login_pass" />

                            <asp:Button runat="server"
                                CssClass="btn btn-default btn-small"
                                OnClick="Login_Click"
                                Text="Iniciar Sesión"
                                ID="btn_login"
                                CausesValidation="true"
                                ValidationGroup="login_form"/>

                            
                            <!--<button class="btn btn-default" type="submit">Login</button>-->
                        </div>
                        <!--Form-->
                    </div>
                    <!-- Registrarse -->
                    <div class="form-intials">
                        <h3>Registrarse</h3>
                        <!--Form-->
                        <div class="form-login">
                            <p>Número de Documento</p>
                            <asp:RangeValidator runat="server" 
                                ControlToValidate="tb_register_dni"
                                MinimumValue="1000000"
                                MaximumValue="100000000"
                                Type="Integer"
                                ErrorMessage="DNI no válido"
                                ValidationGroup="register_form"
                                ForeColor="Red"/>
                            <asp:TextBox runat="server"
                                ID="tb_register_dni"
                                TextMode="Number"
                                CausesValidation="true"
                                ValidationGroup="register_form"/>

                            <p>Nombre</p>
                            <asp:TextBox runat="server"
                                ID="tb_register_name" />

                            <asp:Button runat="server"
                                CssClass="btn btn-default btn-small"
                                OnClick="Register_Click"
                                Text="Registrarse"
                                ID="register_button"
                                CausesValidation="true"
                                ValidationGroup="register_form"/>
                            <!--<button class="btn btn-default" type="submit">Login</button>-->
                        </div>
                        <!--Form-->
                    </div>
                    <!-- Registrarse -->
                </div>
            </div>
        </section>
        <!-- Fin Sección Cuentas -->

    </div>
</asp:Content>

<asp:Content ID="scripts" ContentPlaceHolderID="Scripts" runat="server">
    <!-- ======================= JQuery libs =========================== -->
    <!-- jQuery local-->
    <script type="text/javascript" src="../MedicalAppointmentUI/js/jquery-home.js"></script>
    <script type="text/javascript" src="../MedicalAppointmentUI/js/jquery-ui-home.min.js"></script>
    <!-- Bootstrap.js-->
    <script type="text/javascript" src="../MedicalAppointmentUI/js/bootstrap-home.min.js"></script>
    <script type="text/javascript" src="../MedicalAppointmentUI/js/bootstrap-sprockets-home.js"></script>
    <!-- Main Functions-->
    <script type="text/javascript" src="../MedicalAppointmentUI/js/main-home.js"></script>
</asp:Content>
