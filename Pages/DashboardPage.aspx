<%@ Page Title="" Language="C#" MasterPageFile="Dashboard.Master" AutoEventWireup="true" CodeBehind="DashboardPage.aspx.cs" Inherits="Lenguajes3_ProyectoFinalv3.HomePage" %>

<%@ Register Src="~/Pages/Widgets/UsuarioSinTurnos.ascx" TagPrefix="turn" TagName="sinturnos" %>
<%@ Register Src="~/Pages/Widgets/TurnoReservado.ascx" TagPrefix="turn" TagName="turno" %>   

<asp:Content ID="ContenidoHeaderDashboardPage" ContentPlaceHolderID="Head" runat="server">
    <title>Tus Turnos</title>
</asp:Content>

<asp:Content ID="Content1" ContentPlaceHolderID="Contenido" runat="server">
    <section class="container">
        <div class="main-container">
            <div class="row">
                <div class="listed">
                    <div class="row">
                        <div class="filters">
                            <h4>Filtrar por</h4>
                            <ul class="list-unstyled">
                                <li><a href="#" data-toggle="tooltip" data-placement="bottom" title="highest to lowest"><i class="fa fa-arrow-down" aria-hidden="true"></i></a></li>
                                <li><a href="#" data-toggle="tooltip" data-placement="bottom" title="lowest to highest"><i class="fa fa-arrow-up" aria-hidden="true"></i></a></li>
                                <li>
                                    <select>
                                        <option>Type of Appointment</option>
                                        <option>General</option>
                                        <option>Specialist</option>
                                    </select>
                                </li>
                            </ul>
                        </div>
                    </div>
                    <!-- Inicio Turnos del Paciente -->
                    <div class="row">
                        <!--Item-->
                        <div class="col-lg-12">
                            <div class="item-meeting">
                                <!--Item-->
                                <div class="avatar-doctor">
                                    <div class="avatar-image">
                                        <img src="../MedicalAppointmentUI/images/img-doctor-pic-01.jpg" alt="doctor">
                                        <h4><i class="fa fa-user-md" aria-hidden="true"></i>
                                            <a href="meet-doctors.html" title="Ver Perfil">Dr. Jurado</a></h4>
                                        <p>Cardiothoracic Anesthesia and Anesthesiology - FCI</p>
                                    </div>
                                </div>

                                <div class="data-meeting">
                                    <ul class="list-unstyled info-meet">
                                        <li>
                                            <p>Nro.Ticket: <span>9876005-00</span></p>
                                        </li>
                                        <li>
                                            <p class="time">Fecha: <span>September 15, 2017 at 10:00am</span></p>
                                        </li>
                                        <li>
                                            <p>Tipo de Turno: <span>General Medical Assistance</span></p>
                                        </li>
                                        <li>
                                            <p>Oficina del Doctor: <span>202</span></p>
                                        </li>
                                        <li>
                                            <div class="alert alert-info" role="alert">Observaciones: None.</div>
                                        </li>
                                    </ul>

                                    <ul class="list-unstyled btns">
                                        <li>
                                            <button class="btn btn-red btn-xsmall confirm"><i class="fa fa-times" aria-hidden="true"></i>Cancelar</button></li>
                                        <li><a class="btn btn-xsmall" href="#"><i class="fa fa-arrow-down" aria-hidden="true"></i>Imprimir</a></li>
                                        <li><a class="btn btn-green btn-xsmall" href="ModifyTurnoPage.aspx"><i class="fa fa-pencil" aria-hidden="true"></i>Modificar</a></li>
                                    </ul>
                                </div>
                            </div>
                        </div>
                        <!--Item-->
                    </div>

                    <div class="row">
                        <!--Item-->
                        <div class="col-lg-12">
                            <div class="item-meeting">

                                <!--Item-->
                                <div class="avatar-doctor">
                                    <div class="avatar-image">
                                        <img src="../MedicalAppointmentUI/images/img-doctor-pic.jpg" alt="doctor">
                                        <h4>
                                            <i class="fa fa-user-md" aria-hidden="true"></i>
                                            <a href="meet-doctors.html" title="See Profile">Dr. Smith</a></h4>

                                        <p>Cardiothoracic Anesthesia and Anesthesiology - FdCI</p>
                                    </div>
                                </div>

                                <div class="data-meeting">
                                    <ul class="list-unstyled info-meet">
                                        <li>
                                            <p>no.ticket: <span>9876005-00</span></p>
                                        </li>
                                        <li>
                                            <p class="time">Datetime: <span>December 30, 2017 at 08:00am</span></p>
                                        </li>
                                        <li>
                                            <p>type of appointment: <span>Specialist</span></p>
                                        </li>
                                        <li>
                                            <p>total: <span class="price">15.00</span></p>
                                        </li>
                                        <li>
                                            <p>doctor's office: <span>202</span></p>
                                        </li>
                                        <li>
                                            <div class="alert alert-info" role="alert">Observations: None.</div>
                                        </li>
                                    </ul>

                                    <ul class="list-unstyled btns">
                                        <li>
                                            <button class="btn btn-red btn-xsmall confirm"><i class="fa fa-times" aria-hidden="true"></i>cancel</button></li>
                                        <li><a class="btn btn-xsmall" href="#"><i class="fa fa-arrow-down" aria-hidden="true"></i>print</a></li>
                                        <li><a class="btn btn-green btn-xsmall" href="modify-booked-calendar.html">
                                            <i class="fa fa-pencil" aria-hidden="true"></i>modify</a>
                                        </li>
                                        <li><a class="btn btn-green btn-xsmall" href="http://www.google.com/calendar/event?action=TEMPLATE&amp;text=Cardiothoracic+Anesthesia+and+Anesthesiology+-+FCI&amp;dates=20170916T000000/20170916T000000&amp;details=Cardiothoracic+Anesthesia+and+Anesthesiology+-+FCI&amp;location=MAS+CLINIC&amp;trp=false&amp;amp" target="_blank"><i class="fa fa-calendar" aria-hidden="true"></i>calendar</a></li>
                                    </ul>
                                </div>
                            </div>
                        </div>
                        <!--Item-->
                    </div>
                    <!-- Fin Turnos del Paciente -->

                    <div class="row">
                        <div class="load-more">
                            <a class="btn btn-green btn-small" href="#">Cargar Más</a>
                        </div>
                    </div>
                </div>

                <!-- Inicio Elementos al Costado -->
                <aside>
                    <div class="elements-aside gray-color">
                        <ul>
                            <li class="color-1">
                                <i class="fa fa-heartbeat" aria-hidden="true"></i>
                                <h4>Casos de Emergencia</h4>
                                <p>Si necesitas un doctor urgente fuera del horario de atención, llama al número de turnos por emergencia para un servicio de emergencia.</p>
                            </li>
                            <li class="color-2">
                                <i class="fa fa-hourglass-half" aria-hidden="true"></i>
                                <h4>Horarios de Atención</h4>
                                <p>Lunes a Viernes <span>08:00am a 10:00pm</span></p>
                                <p>Fines de Semana <span>09:00am to 12:00pm</span></p>
                            </li>
                            <li class="color-3">
                                <i class="fa fa-info" aria-hidden="true"></i>
                                <h4>Doubts?</h4>
                                <p>Office Av. 100 #0987-988, <span>Central Park</span></p>
                            </li>
                        </ul>
                    </div>
                </aside>
                <!-- Fin Elementos al Costado -->
            </div>
        </div>
    </section>
</asp:Content>

<asp:Content ID="ContentScripts" ContentPlaceHolderID="Scripts" runat="server">
    <!-- ======================= JQuery libs =========================== -->
    <!-- Main Functions-->
    <script type="text/javascript" src="../MedicalAppointmentUI/js/main.js"></script>
</asp:Content>
