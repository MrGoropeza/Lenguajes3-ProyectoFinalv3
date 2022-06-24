<%@ Page Title="Nuestros Profesionales" Async="true" Language="C#" MasterPageFile="~/Pages/Dashboard.Master" AutoEventWireup="true" CodeBehind="ProfessionalsPage.aspx.cs" Inherits="Lenguajes3_ProyectoFinalv3.Pages.ProfessionalsPage" %>
<%@ Register Src="~/Pages/Widgets/Profesional.ascx" TagPrefix="pro" TagName="portada"%>


<asp:Content ID="Content1" ContentPlaceHolderID="Head" runat="server">
    <title>Nuestros Profesionales</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Contenido" runat="server">
    <div class="container">
        <div class="main-container">

            <div class="department-title">
                <h3>Nuestros Profesionales</h3>
                <hr>
            </div>

            <asp:PlaceHolder runat="server" ID="prof_widgets"></asp:PlaceHolder>
            
        </div>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Scripts" runat="server">
    <!-- ======================= JQuery libs =========================== -->
    <!-- Main Functions-->
    <script type="text/javascript" src="../MedicalAppointmentUI/js/main.js"></script>
</asp:Content>
