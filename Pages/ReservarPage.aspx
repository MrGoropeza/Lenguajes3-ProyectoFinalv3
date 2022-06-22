<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/Dashboard.Master" AutoEventWireup="true" CodeBehind="ReservarPage.aspx.cs" Inherits="Lenguajes3_ProyectoFinalv3.Pages.ReservarPage" %>
<%@ Register Src="~/Pages/Widgets/CalendarioSelect.ascx" TagPrefix="cal" TagName="CalendarAppointment" %>


<asp:Content ID="ContenidoHead" ContentPlaceHolderID="Head" runat="server">
    <title>Reservar un Turno</title>
    <link rel="stylesheet" href="../MedicalAppointmentUI/css/styleBookAppointment.css"/>
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="Contenido" runat="server">
    <div class="main-container">
        <div class="container">
            <div class="row">

                <div class="col-lg-12">
                    <h2>Book Appointment</h2>
                    <em>Follow these instructions: Select your prefer specialist after select the clinical department then, the calendar is going to be enable to select your appointment
                        <br>
                        (the avatar doctor is loading while you select the specialist).</em>
                    <hr>
                </div>

                <div class="search-appointment">
                    <div class="make-app">
                        <!--Departments-->
                        <div class="icon-data">
                            <i class="fa fa-hospital-o"></i>*
                        </div>
                        <select>
                            <option value="-1" selected>Departments</option>
                            <option value="1">Health Care</option>
                            <option value="2">Cardic Clinic</option>
                            <option value="3">General Surgery</option>
                            <option value="4">Psychology</option>
                            <option value="5">Pediatrics</option>
                        </select>
                        <!--Departments-->

                        <!--name-->
                        <div class="icon-data">
                            <i class="fa fa-user-md"></i>*
                        </div>
                        <select>
                            <option value="-1" selected>Doctors</option>
                            <option value="1">DR. SMITH</option>
                            <option value="2">DR. JURADO</option>
                            <option value="3">DR. RENDON</option>
                            <option value="4">DR. MARTINEZ</option>
                            <option value="5">DR. OUSHY</option>
                        </select>
                        <a href="ProfessionalsPage.aspx" class="know-doctors">¿No conoces a nuestros profesionales?</a>
                        <!--name-->

                        <span class="btn btn-green btn-small btn-search-appointment"><i class="fa fa-search"></i>Book</span><!--Change to Button Attribute-->
                    </div>
                </div>

                <div class="preview-appointment">
                    <div class="preview-doctor">
                        <img src="../MedicalAppointmentUI/images/img-doctor-pic-02.jpg" alt="doctor preview">
                    </div>
                    <ul>
                        <li>
                            <h5>Dr. Jurado Jeniffer</h5>
                        </li>
                        <li>Specialization: <span>Cardiothoracic Anesthesia and Anesthesiology - FCI</span></li>
                        <li>Price Appointment: <span class="price">15</span></li>
                    </ul>
                </div>
            </div>

            <div class="row">
            </div>

            <cal:CalendarAppointment id="calendarioTurno" runat="server"></cal:CalendarAppointment>
        </div>
    </div>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Scripts" runat="server">
    <!-- ======================= JQuery libs =========================== -->
    <script type="text/javascript" src="../MedicalAppointmentUI/js/jquery-bookappointment.js"></script>
    <script type="text/javascript" src="../MedicalAppointmentUI/js/jquery-ui-book.min.js"></script>
    <script type="text/javascript" src="../MedicalAppointmentUI/js/bootstrap-book.min.js"></script>
    <script type="text/javascript" src="../MedicalAppointmentUI/js/bootstrap-sprockets-book.js"></script>
    <!-- Main Functions-->
    <script type="text/javascript" src="../MedicalAppointmentUI/js/main-book.js"></script>
</asp:Content>
