﻿<%@ Page Title="Tu Agenda" Async="true" Language="C#" MasterPageFile="~/Pages/Dashboard.Master" AutoEventWireup="true" CodeBehind="AgendaPage.aspx.cs" Inherits="Lenguajes3_ProyectoFinalv3.Pages.AgendaPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Contenido" runat="server">
    <section class="container">
        <div class="main-container">
            <h4>Tus sesiones esta semana</h4>

            <asp:PlaceHolder runat="server" ID="ph_agenda">

            </asp:PlaceHolder>

        </div>
    </section>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Scripts" runat="server">
</asp:Content>
