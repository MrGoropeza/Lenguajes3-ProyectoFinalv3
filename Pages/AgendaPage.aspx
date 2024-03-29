﻿<%@ Page Title="Tu Agenda" Async="true" Language="C#" MasterPageFile="~/Pages/Dashboard.Master" AutoEventWireup="true" CodeBehind="AgendaPage.aspx.cs" Inherits="Lenguajes3_ProyectoFinalv3.Pages.AgendaPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Contenido" runat="server">
    <section class="container">
        <div class="main-container">
            <h4>Tus sesiones esta semana</h4>

            <asp:LinkButton runat="server"
                
                CssClass="btn btn-xsmall"
                ID="btn_anterior"
                OnClick="btn_anterior_Click">
                <i class="fa fa-arrow-left"></i> Semana Anterior
            </asp:LinkButton>

            <asp:LinkButton runat="server"
                
                CssClass="btn btn-xsmall"
                ID="btn_hoy"
                OnClick="btn_hoy_Click">
                <i class="fa fa-arrow-circle-down"></i> Esta Semana
            </asp:LinkButton>

            <asp:LinkButton runat="server"
                CssClass="btn btn-xsmall"
                ID="btn_siguiente"
                OnClick="btn_siguiente_Click">
                <i class="fa fa-arrow-right"></i> Semana Siguiente
            </asp:LinkButton>

            <asp:LinkButton runat="server"
                CssClass="btn btn-xsmall"
                ID="btn_refresh"
                OnClick="btn_refresh_Click">
                <i class="fa fa-refresh"></i> Recargar
            </asp:LinkButton>

            <asp:LinkButton runat="server"
                CssClass="btn btn-xsmall"
                Visible="false"
                ID="btn_print"
                OnClientClick="window:print()"
                OnClick="btn_print_Click">
                <i class="fa fa-print"></i> Imprimir Semana
            </asp:LinkButton>

            <asp:PlaceHolder runat="server" ID="ph_agenda">

            </asp:PlaceHolder>

        </div>
    </section>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Scripts" runat="server">
</asp:Content>
