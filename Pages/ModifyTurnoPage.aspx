﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/Dashboard.Master" AutoEventWireup="true" CodeBehind="ModifyTurnoPage.aspx.cs" Inherits="Lenguajes3_ProyectoFinalv3.Pages.ModifyTurnoPage" %>


<asp:Content ID="Content1" ContentPlaceHolderID="Head" runat="server">
    <title>Modificar Turno</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Contenido" runat="server">
    <div class="main-container">
        <div class="container">
            <div class="row">
                <div class="col-lg-12">
                    <h2>Edit your medical Appointment</h2>
                    <em>As you only can modify the date of your appointment. You'll see all data of appointment reserved and just the calendar could be modificated.</em>
                    <hr>
                </div>
                <div class="preview-appointment">
                    <div class="preview-doctor">
                        <img src="../MedicalAppointmentUI/images/img-doctor-pic.jpg" alt="doctor preview">
                    </div>
                    <ul>
                        <li>
                            <h5>Dr. Smith Jeniffer</h5>
                        </li>
                        <li>Specialization: <span>Cardiothoracic Anesthesia and Anesthesiology - FCI</span></li>
                        <li>Price Appointment: <span class="price">15</span></li>
                    </ul>
                </div>
            </div>

            <div class="row">
            </div>

        </div>
    </div>

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Scripts" runat="server">
    <!-- ======================= JQuery libs =========================== -->
    <script type="text/javascript" src="../MedicalAppointmentUI/js/jquery-bookappointment.js"></script>
    <script type="text/javascript" src="../MedicalAppointmentUI/js/jquery-ui-book.min.js"></script>
    <script type="text/javascript" src="../MedicalAppointmentUI/js/bootstrap-book.min.js"></script>
    <script type="text/javascript" src="../MedicalAppointmentUI/js/bootstrap-sprockets-book.js"></script>
    <!-- Main Functions-->
    <script type="text/javascript" src="../MedicalAppointmentUI/js/main-book.js"></script>
</asp:Content>
