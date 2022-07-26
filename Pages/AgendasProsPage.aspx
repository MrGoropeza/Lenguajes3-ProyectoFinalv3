<%@ Page Title="Agendas" Async="true" ViewStateMode="Enabled" Language="C#" MasterPageFile="~/Pages/Dashboard.Master" AutoEventWireup="true" CodeBehind="AgendasProsPage.aspx.cs" Inherits="Lenguajes3_ProyectoFinalv3.Pages.AgendasProsPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Contenido" runat="server">
    <section class="container">
        <div class="main-container">

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

            <h4>Sesiones del profesional</h4>

            <asp:LinkButton runat="server"
                
                CssClass="btn btn-xsmall"
                ID="btn_anterior"
                OnClick="btn_anterior_Click">
                <i class="fa fa-arrow-left"></i> Semana Anterior
            </asp:LinkButton>

            <asp:LinkButton runat="server"
                CssClass="btn btn-xsmall"
                ID="btn_siguiente"
                OnClick="btn_siguiente_Click">
                <i class="fa fa-arrow-right"></i> Semana Siguiente
            </asp:LinkButton>

            <asp:PlaceHolder runat="server" ID="ph_agenda">

            </asp:PlaceHolder>

        </div>
    </section>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Scripts" runat="server">
</asp:Content>
