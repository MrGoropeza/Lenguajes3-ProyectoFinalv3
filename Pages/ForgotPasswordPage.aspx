<%@ Page Title="" Async="true" Language="C#" MasterPageFile="~/Pages/Inicio.Master" AutoEventWireup="true" CodeBehind="ForgotPasswordPage.aspx.cs" Inherits="Lenguajes3_ProyectoFinalv3.Pages.ForgotPasswordPage" %>
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
                        <div class="logo">
                            <a href="HomePage.aspx"><img src="../images/img-logo-simple.png" alt="logo"></a>
                        </div>
                        <!--Logo-->


                        <!--Form-->
                        <div class="form-login reset">
                            <div class="alert alert-warning" role="alert"
                                runat="server" id="advertencia">
                                Por favor, ingresa tu DNI. Luego revisa tu bandeja de entrada para resetear la contraseña.
                            </div>

                            <asp:Label runat="server"
                                AssociatedControlID="tb_dni"
                                Text="Nro. de Documento:"/>
                            <asp:RequiredFieldValidator runat="server" 
                                ControlToValidate="tb_dni"
                                ValidationGroup="login_form"
                                EnableClientScript="true"
                                ErrorMessage="Campo Requerido*"
                                ForeColor="Red"/>
                            <asp:RangeValidator runat="server" 
                                ControlToValidate="tb_dni"
                                MinimumValue="1000000"
                                MaximumValue="100000000"
                                Type="Integer"                                
                                ErrorMessage="DNI no válido"
                                ValidationGroup="login_form"
                                ForeColor="Red"/>
                            <asp:TextBox runat="server"
                                TextMode="Number"
                                MaxLength="8"
                                placeholder="Tu Número de Documento"
                                ID="tb_dni"/>

                            <asp:Button runat="server"
                                CssClass="btn btn-btn-default"
                                Text="Resetear Contraseña"
                                ValidationGroup="login_form"
                                CausesValidation="true"
                                ID="btn_login"
                                OnClick="btn_login_Click"/>
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
