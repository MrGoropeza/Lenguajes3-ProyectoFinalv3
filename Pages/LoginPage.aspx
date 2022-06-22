<%@ Page Title="" Language="C#" MasterPageFile="Inicio.Master" AutoEventWireup="true" CodeBehind="LoginPage.aspx.cs" Inherits="Lenguajes3_ProyectoFinalv3.Pages.LoginPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Head" runat="server">
    <title>Iniciar Sesión</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Contenido" runat="server">
    <div class="panel-access">
        <!--Login-->
        <div class="login">
            <div class="container">
                <div class="login-form">
                    <div class="data-form">
                        <!--Logo-->
                        <a href="HomePage.aspx" class="logo">
                            <img src="../MedicalAppointmentUI/images/img-logo-simple.png" alt="logo" class="img-responsive"></a>
                        <!--Logo-->

                        <!--Form-->
                        <div class="form-login">
                            <div class="icon-data">
                                <i class="fa fa-user-circle"></i>
                            </div>
                            <input type="number" placeholder="Número de Documento">

                            <div class="icon-data">
                                <i class="fa fa-key"></i>
                            </div>
                            <input type="password" placeholder="contraseña">

                            <a href="DashboardPage.aspx" class="btn btn-default" role="button">Iniciar Sesión</a>
                            <!--<button class="btn btn-default" type="submit">Login</button>-->
                        </div>

                        <!--Form-->

                        <a href="RegisterPage.aspx" class="btn btn-red register" role="button">Crear nueva cuenta</a>
                        <span class="help">
                            <a href="ForgotPasswordPage.aspx">¿Olvidaste tu contraseña?</a>
                        </span>
                    </div>
                </div>
            </div>
        </div>

    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Scripts" runat="server">
</asp:Content>
