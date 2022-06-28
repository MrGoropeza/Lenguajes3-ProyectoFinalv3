<%@ Page Title="Datos Consultorio" Async="true" Language="C#" MasterPageFile="~/Pages/Dashboard.Master" AutoEventWireup="true" CodeBehind="DatosConsultorio.aspx.cs" Inherits="Lenguajes3_ProyectoFinalv3.Pages.DatosConsultorio" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Contenido" runat="server">
    <div class="container">
        <div class="main-container">
            <!--Form-->
            <div class="register-form edit-account">

                <!--Form-->
                <div class="form-login">

                    <!--Personal Information-->
                    <div class="row">

                        <h3>Información del consultorio</h3>
                        <div class="datapos">

                            <!--name-->
                            <asp:Label runat="server"
                                AssociatedControlID="tb_nombre"
                                Text="Nombre:" />
                            <asp:RequiredFieldValidator runat="server"
                                ControlToValidate="tb_nombre"
                                ValidationGroup="register_form"
                                EnableClientScript="true"
                                ErrorMessage="Campo Requerido*"
                                ForeColor="Red" />
                            <asp:TextBox runat="server"
                                ID="tb_nombre"
                                placeholder="Tu Nombre" />
                            <!--name-->

                            <!--phone-->
                            <asp:Label runat="server"
                                AssociatedControlID="tb_telefono1"
                                Text="Teléfono:" />
                            <asp:RequiredFieldValidator runat="server"
                                ControlToValidate="tb_telefono1"
                                ValidationGroup="register_form"
                                EnableClientScript="true"
                                ErrorMessage="Campo Requerido*"
                                ForeColor="Red" />
                            <asp:CustomValidator runat="server"
                                ValidateEmptyText="true"
                                ControlToValidate="tb_telefono1"
                                ValidationGroup="register_form"
                                OnServerValidate="validarTelefono"
                                ErrorMessage="Número no válido"
                                ForeColor="Red" />
                            <asp:TextBox runat="server"
                                TextMode="Phone"
                                placeholder="Tu Celular"
                                ID="tb_telefono1" />
                            <!--phone-->

                        </div>

                        <div class="datapos">

                            <!--direccion-->
                            <asp:Label runat="server"
                                AssociatedControlID="tb_nombre"
                                Text="Dirección:" />
                            <asp:RequiredFieldValidator runat="server"
                                ControlToValidate="tb_nombre"
                                ValidationGroup="register_form"
                                EnableClientScript="true"
                                ErrorMessage="Campo Requerido*"
                                ForeColor="Red" />
                            <asp:TextBox runat="server"
                                ID="tb_direccion"
                                placeholder="Dirección del Consultorio" />
                            <!--direccion-->

                            <!--Mail-->
                            <asp:Label runat="server"
                                AssociatedControlID="tb_mail"
                                Text="Correo: " />
                            <asp:RequiredFieldValidator runat="server"
                                ControlToValidate="tb_mail"
                                ValidationGroup="register_form"
                                EnableClientScript="true"
                                ErrorMessage="Campo Requerido*"
                                ForeColor="Red" />
                            <asp:RegularExpressionValidator runat="server"
                                ControlToValidate="tb_mail"
                                ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"
                                ValidationGroup="register_form"
                                ErrorMessage="Correo no válido"
                                ForeColor="Red" />
                            <asp:TextBox runat="server"
                                ID="tb_mail"
                                placeholder="example@provider.com" />
                            <!--Mail-->

                        </div>

                    </div>
                    <!--Personal Information-->

                    <asp:Button runat="server"
                        CssClass="btn btn-btn-default"
                        Text="Actualizar Datos del Consultorio"
                        ValidationGroup="register_form"
                        CausesValidation="true"
                        ID="btn_update_profile"
                        OnClick="btn_update_profile_Click" />
                </div>
            </div>
        </div>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Scripts" runat="server">
</asp:Content>
