<%@ Page Title="" Async="true" Language="C#" MasterPageFile="Inicio.Master" AutoEventWireup="true" CodeBehind="LoginPage.aspx.cs" Inherits="Lenguajes3_ProyectoFinalv3.Pages.LoginPage" %>

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
                        <div class="logo">
                            <a href="HomePage.aspx"><img src="../images/img-logo-simple.png" alt="logo"></a>
                        </div>
                        <!--Logo-->

                        <!--Form-->
                        <div class="form-login">
                            <!--number document-->
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
                            <!--number document-->

                            <!--Password-->
                            <asp:Label runat="server"
                                AssociatedControlID="tb_password"
                                Text="Contraseña:" />
                            <asp:RequiredFieldValidator runat="server" 
                                ControlToValidate="tb_password"
                                ValidationGroup="login_form"
                                EnableClientScript="true"
                                ErrorMessage="Campo Requerido*"
                                ForeColor="Red"/>
                            <asp:TextBox runat="server"
                                ID="tb_password"
                                TextMode="Password"
                                placeholder="**********"/>
                            <!--Password-->

                            <asp:Button runat="server"
                                CssClass="btn btn-btn-default"
                                Text="Iniciar Sesión"
                                ValidationGroup="login_form"
                                CausesValidation="true"
                                ID="btn_login"
                                OnClick="btn_login_Click"/>
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
