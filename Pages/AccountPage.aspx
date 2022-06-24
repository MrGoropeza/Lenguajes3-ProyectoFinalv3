<%@ Page Title="" Async="true" Language="C#" MasterPageFile="~/Pages/Dashboard.Master" AutoEventWireup="true" CodeBehind="AccountPage.aspx.cs" Inherits="Lenguajes3_ProyectoFinalv3.Pages.AccountPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Head" runat="server">
    <title>Mi Cuenta</title>
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
                                ForeColor="Red" />
                            <asp:TextBox runat="server"
                                ID="tb_nombre"
                                placeholder="Tu Nombre" />

                            <!--name-->

                            <!--number document-->
                            <asp:Label runat="server"
                                AssociatedControlID="tb_dni"
                                Text="Nro. de Documento:" />
                            <asp:RequiredFieldValidator runat="server"
                                ControlToValidate="tb_dni"
                                ValidationGroup="register_form"
                                EnableClientScript="true"
                                ErrorMessage="Campo Requerido*"
                                ForeColor="Red" />
                            <asp:RangeValidator runat="server"
                                ControlToValidate="tb_dni"
                                MinimumValue="1000000"
                                MaximumValue="100000000"
                                Type="Integer"
                                ErrorMessage="DNI no válido"
                                ValidationGroup="register_form"
                                ForeColor="Red" />
                            <asp:TextBox runat="server"
                                TextMode="Number"
                                MaxLength="8"
                                placeholder="Tu Número de Documento"
                                ID="tb_dni"
                                ReadOnly="true"/>
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
                                    ForeColor="Red" />
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
                                Text="Apellido:" />
                            <asp:RequiredFieldValidator runat="server"
                                ControlToValidate="tb_apellido"
                                ValidationGroup="register_form"
                                EnableClientScript="true"
                                ErrorMessage="Campo Requerido*"
                                ForeColor="Red" />
                            <asp:TextBox runat="server"
                                ID="tb_apellido"
                                placeholder="Tu Apellido" />
                            <!--Last name-->

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
                                ForeColor="Red" />
                            <asp:RegularExpressionValidator runat="server"
                                ControlToValidate="tb_mail"
                                ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"
                                ValidationGroup="register_form"
                                ErrorMessage="Correo no válido"
                                ForeColor="Red" />
                            <asp:TextBox runat="server"
                                ID="tb_mail"
                                placeholder="example@provider.com"
                                ReadOnly="true"/>
                            <!--Mail-->

                            

                        </div>
                        <div class="datapos">

                            <!--Avatar Profile-->
                            <asp:Label runat="server"
                                AssociatedControlID="file_up"
                                Text="Foto de Perfil:" />
                            <asp:FileUpload runat="server"
                                ID="file_up"
                                accept="image/*" />
                            <!--Avatar Profile-->

                        </div>
                    </div>

                    <!--Descripcion Profesional-->
                    <div runat="server"
                        id="desc_pro"
                        >

                        <!--Texto-->
                        <asp:Label runat="server"
                            AssociatedControlID="tb_desc_pro"
                            Text="Breve descipción tuya para los usuarios nuevos:" />
                        <asp:RequiredFieldValidator runat="server"
                            ControlToValidate="tb_desc_pro"
                            ValidationGroup="register_form"
                            EnableClientScript="true"
                            ErrorMessage="Campo Requerido*"
                            ForeColor="Red" />
                        <asp:TextBox runat="server"
                            ID="tb_desc_pro"
                            placeholder="Una breve descripción que te identifique para los nuevos usuarios."
                            MaxLength="300"
                            TextMode="MultiLine"
                            style = "resize:none;"
                            Height="100"
                            Wrap="true"/>
                        <!--Texto-->

                        <!--Titulo-->
                        <asp:Label runat="server"
                            AssociatedControlID="tb_desc_pro"
                            Text="Tu título académico:" />
                        <asp:RequiredFieldValidator runat="server"
                            ControlToValidate="tb_titulo_pro"
                            ValidationGroup="register_form"
                            EnableClientScript="true"
                            ErrorMessage="Campo Requerido*"
                            ForeColor="Red" />
                        <asp:TextBox runat="server"
                            ID="tb_titulo_pro"
                            placeholder="Licenciado en Psicología"
                            MaxLength="100"
                            Wrap="true"/>
                        <!--Titulo-->

                    </div>
                    <!--Descripcion Profesional-->

                    <asp:Button runat="server"
                        CssClass="btn btn-btn-default"
                        Text="Actualizar Perfil"
                        ValidationGroup="register_form"
                        CausesValidation="true"
                        ID="btn_update_profile"
                        OnClick="btn_update_profile_Click" />
                    <asp:Button runat="server"
                        CssClass="btn btn-btn-default"
                        Text="Cambiar Contraseña"
                        ID="btn_change_pass"
                        OnClick="btn_change_pass_Click" />
                    <div class="alert alert-warning" role="alert"
                        runat="server" id="advertencia">
                        Revisa tu bandeja de entrada para cambiar la contraseña.
                    </div>
                </div>

            </div>
            <!--Form-->
        </div>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Scripts" runat="server">
    <!-- ======================= JQuery libs =========================== -->
    <!-- Main Functions-->
    <script type="text/javascript" src="../MedicalAppointmentUI/js/main.js"></script>
</asp:Content>
