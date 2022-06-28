<%@ Page Title="Usuarios" Async="true" Language="C#" MasterPageFile="~/Pages/Dashboard.Master" AutoEventWireup="true" CodeBehind="UsersPage.aspx.cs" Inherits="Lenguajes3_ProyectoFinalv3.Pages.UsersPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Contenido" runat="server">
    <section class="container">
        <div class="main-container">
            <div class="row">
                <div class="listed">
                    <div class="row">
                        <h4>Tu Usuario</h4>

                        <asp:PlaceHolder runat="server" ID="ph_actual_admin">

                        </asp:PlaceHolder>

                    </div>
                    <!-- Inicio Turnos del Paciente -->
                    <div class="row">

                        <h4>Usuarios Registrados</h4>
                        <asp:PlaceHolder runat="server" ID="ph_users">

                        </asp:PlaceHolder>

                    </div>
                </div>
            </div>
        </div>
    </section>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Scripts" runat="server">
</asp:Content>
