<%@ Page Title="Registrarse" Async="true" Language="C#" MasterPageFile="~/Pages/Inicio.Master" AutoEventWireup="true" CodeBehind="RegisterPage.aspx.cs" Inherits="Lenguajes3_ProyectoFinalv3.Pages.RegisterPage1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Head" runat="server">
    <link rel="stylesheet" href="../MedicalAppointmentUI/css/styleHome.css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Contenido" runat="server">
    <div class="panel-access">
        <!--Login-->
       <div class="login">
            <div class="container">
                <div class="register-form">

                    <!--Data form-->
                    <div class="data-form">
                        <span class="back-to-login">
                            <a class="btn btn-green btn-xsmall" href="LoginPage.aspx"><i class="fa fa-angle-double-left"></i>Ir a Inicio de Sesión</a>
                        </span>
                        <!--Logo-->
                        <div class="logo">
                            <a href="HomePage.aspx"><img src="../images/img-logo-simple.png" alt="logo"></a>
                        </div>
                        <!--Logo-->

                        <!--Form-->
                        <div class="form-login">
                            <!--Personal Information-->
                            <div class="row">

                                <h3>Información Personal</h3>
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
                                        ForeColor="Red"/>
                                    <asp:TextBox runat="server"
                                        ID="tb_nombre"
                                        placeholder="Tu Nombre"/>
                                    
                                    <!--name-->

                                    <!--number document-->
                                    <asp:Label runat="server"
                                        AssociatedControlID="tb_dni"
                                        Text="Nro. de Documento:"/>
                                    <asp:RequiredFieldValidator runat="server" 
                                        ControlToValidate="tb_dni"
                                        ValidationGroup="register_form"
                                        EnableClientScript="true"
                                        ErrorMessage="Campo Requerido*"
                                        ForeColor="Red"/>
                                    <asp:RangeValidator runat="server" 
                                        ControlToValidate="tb_dni"
                                        MinimumValue="1000000"
                                        MaximumValue="100000000"
                                        Type="Integer"
                                        ErrorMessage="DNI no válido"
                                        ValidationGroup="register_form"
                                        ForeColor="Red"/>
                                    <asp:TextBox runat="server"
                                        TextMode="Number"
                                        MaxLength="8"
                                        placeholder="Tu Número de Documento"
                                        ID="tb_dni" />
                                    <!--number document-->

                                    

                                    <!--genere-->
                                    
                                    <label>
                                        <asp:Label runat="server"
                                            AssociatedControlID="rdbtnls_genero"
                                            Text="Género:" />
                                        <asp:RequiredFieldValidator runat="server"
                                            ValidationGroup="register_form" 
                                            ErrorMessage="Selección requerida*"
                                            EnableClientScript="true"
                                            ControlToValidate="rdbtnls_genero"
                                            ForeColor="Red"/>
                                        <asp:RadioButtonList runat="server"
                                            RepeatDirection="Horizontal"
                                            ID="rdbtnls_genero">
                                            <asp:ListItem>Femenino</asp:ListItem>
                                            <asp:ListItem>Masculino</asp:ListItem>
                                            <asp:ListItem>Otro</asp:ListItem>
                                        </asp:RadioButtonList>
                                        
                                        <!--<input type="radio" name="inlineRadioOptions" value="Masculino">-->
                                    </label>
                                    <!--genere-->
                                </div>

                                <div class="datapos">
                                    
                                    <!--Last name-->
                                    <asp:Label runat="server"
                                        AssociatedControlID="tb_apellido"
                                        Text="Apellido:"/>
                                    <asp:RequiredFieldValidator runat="server" 
                                        ControlToValidate="tb_apellido"
                                        ValidationGroup="register_form"
                                        EnableClientScript="true"
                                        ErrorMessage="Campo Requerido*"
                                        ForeColor="Red"/>
                                    <asp:TextBox runat="server"
                                        ID="tb_apellido"
                                        placeholder="Tu Apellido"/>
                                    <!--Last name-->

                                    <!--phone-->
                                    <asp:Label runat="server"
                                        AssociatedControlID="tb_telefono1"
                                        Text="Teléfono:"/>
                                    <asp:RequiredFieldValidator runat="server" 
                                        ControlToValidate="tb_telefono1"
                                        ValidationGroup="register_form"
                                        EnableClientScript="true"
                                        ErrorMessage="Campo Requerido*"
                                        ForeColor="Red"/>
                                    <asp:CustomValidator runat="server"
                                        ValidateEmptyText="true"
                                        ControlToValidate="tb_telefono1"
                                        ValidationGroup="register_form"
                                        OnServerValidate="validarTelefono"
                                        ErrorMessage="Número no válido"
                                        ForeColor="Red"/>
                                    <asp:TextBox runat="server"
                                        TextMode="Phone"
                                        placeholder="Tu Celular"
                                        ID="tb_telefono1" />
                                    
                                    <!--phone-->

                                    <!--Fecha Nacimiento-->
                                    <asp:Label runat="server"
                                        AssociatedControlID="tb_fecha_nac"
                                        Text="Fecha de Nacimiento:"/>
                                    <asp:RequiredFieldValidator runat="server" 
                                        ControlToValidate="tb_fecha_nac"
                                        ValidationGroup="register_form"
                                        EnableClientScript="true"
                                        ErrorMessage="Campo Requerido*"
                                        ForeColor="Red"/>
                                    <asp:TextBox runat="server"
                                        lang="es"
                                        TextMode="Date"
                                        placeholder="dd/mm/aaaa"
                                        ID="tb_fecha_nac" />
                                    <!--Fecha Nacimiento-->
                                </div>

                            </div>
                            <!--Personal Information-->

                            <!--Data Information-->
                            <div class="row">
                                <h3>Información de la Cuenta</h3>
                                <div class="datapos">

                                    <!--Mail-->
                                    <asp:Label runat="server"
                                        AssociatedControlID="tb_mail"
                                        Text="Correo: " />
                                    <asp:RequiredFieldValidator runat="server" 
                                        ControlToValidate="tb_mail"
                                        ValidationGroup="register_form"
                                        EnableClientScript="true"
                                        ErrorMessage="Campo Requerido*"
                                        ForeColor="Red"/>
                                    <asp:RegularExpressionValidator runat="server"
                                        ControlToValidate="tb_mail"
                                        ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"
                                        ValidationGroup="register_form"
                                        ErrorMessage="Correo no válido"
                                        ForeColor="Red"/>
                                    <asp:TextBox runat="server"
                                        ID="tb_mail"
                                        placeholder="example@provider.com"/>
                                    <!--Mail-->

                                    <!--Avatar Profile-->
                                    <asp:Label runat="server"
                                        AssociatedControlID="file_up"
                                        Text="Foto de Perfil:" />
                                    <asp:FileUpload runat="server"
                                        ID="file_up"
                                        accept="image/*"/>
                                    <!--Avatar Profile-->

                                </div>
                                <div class="datapos">

                                    <!--Password-->
                                    <asp:Label runat="server"
                                        AssociatedControlID="tb_password"
                                        Text="Contraseña:" />
                                    <asp:RequiredFieldValidator runat="server" 
                                        ControlToValidate="tb_password"
                                        ValidationGroup="register_form"
                                        EnableClientScript="true"
                                        ErrorMessage="Campo Requerido*"
                                        ForeColor="Red"/>
                                    <asp:RegularExpressionValidator runat="server"
                                        ControlToValidate="tb_password"
                                        ValidationExpression="^(?=.*\d)(?=.*[a-z])(?=.*[A-Z]).{8,20}$"
                                        ValidationGroup="register_form"
                                        ErrorMessage="La contraseña debe tener entre 8 y 20 carácteres, un número, una mayúscula y una minúscula."
                                        ForeColor="Red"/>
                                    <asp:TextBox runat="server"
                                        ID="tb_password"
                                        TextMode="Password"
                                        placeholder="**********"/>
                                    <!--Password-->

                                    <!--Confirm Password-->
                                    <asp:Label runat="server"
                                        AssociatedControlID="tb_repeat_password"
                                        Text="Repetir Contraseña:" />
                                    <asp:RequiredFieldValidator runat="server" 
                                        ControlToValidate="tb_repeat_password"
                                        ValidationGroup="register_form"
                                        EnableClientScript="true"
                                        ErrorMessage="Campo Requerido*"
                                        ForeColor="Red"/>
                                    <asp:CompareValidator runat="server"
                                        ControlToValidate="tb_repeat_password"
                                        ControlToCompare="tb_password"
                                        ValidationGroup="register_form"
                                        ErrorMessage="Las contraseñas no coinciden"
                                        ForeColor="Red"/>
                                    <asp:TextBox runat="server"
                                        ID="tb_repeat_password"
                                        TextMode="Password"
                                        placeholder="**********"/>
                                    <!--Confirm Password-->

                                    
                                </div>
                            </div>
                            <asp:Button runat="server"
                                CssClass="btn btn-btn-default"
                                Text="Crear Cuenta"
                                ValidationGroup="register_form"
                                CausesValidation="true"
                                ID="btn_register"
                                OnClick="btn_register_Click"/>
                        </div>
                        <!--Form-->
                    </div>
                    <!--Data form-->
                </div>
            </div>
        </div>
        <!--Login-->
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Scripts" runat="server">
</asp:Content>
