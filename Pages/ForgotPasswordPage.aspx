<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/Inicio.Master" AutoEventWireup="true" CodeBehind="ForgotPasswordPage.aspx.cs" Inherits="Lenguajes3_ProyectoFinalv3.Pages.ForgotPasswordPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Head" runat="server">
    <title>Recuperar Contraseña</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Contenido" runat="server">
    <div class="panel-access">
        <div class="login">
            <div class="container">
                <div class="login-form">
                    <div class="data-form">
                        <!--Logo-->
                        <a href="HomePage.aspx" class="logo">
                            <img src="../MedicalAppointmentUI/images/img-logo-simple.png" alt="logo"></a>
                        <!--Logo-->


                        <!--Form-->
                        <div class="form-login reset">
                            <div class="alert alert-warning" role="alert">
                                Por favor, ingresa tu DNI y tu correo. Luego revisa tu bandeja de entrada para resetear la contraseña.
                            </div>

                            <div class="icon-data">
                                <i class="fa fa-user-circle"></i>
                            </div>
                            <input type="number" placeholder="Número de Documento">

                            <div class="icon-data">
                                <i class="fa fa-envelope-open-o"></i>
                            </div>

                            <input type="text" placeholder="Correo Electrónico">

                            <button class="btn btn-red" type="submit">Reset</button>
                        </div>
                        <!--Form-->
                        <span class="help">
                            <a href="LoginPage.aspx"><i class="fa fa-angle-double-left"></i> Volver a Inicio de Sesión </a>
                        </span>
                        
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Scripts" runat="server">
</asp:Content>
