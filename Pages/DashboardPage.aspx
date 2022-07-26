<%@ Page Title="" Language="C#" Async="true" MasterPageFile="Dashboard.Master" AutoEventWireup="true" CodeBehind="DashboardPage.aspx.cs" Inherits="Lenguajes3_ProyectoFinalv3.DashboardPage" %>  

<asp:Content ID="ContenidoHeaderDashboardPage" ContentPlaceHolderID="Head" runat="server">
    <title>Tus Turnos</title>
</asp:Content>

<asp:Content ID="Content1" ContentPlaceHolderID="Contenido" runat="server">
    <section class="container">
        <div class="main-container">
            <div class="row">
                <div class="listed">

                    <div class="alert alert-warning" role="alert"
                        runat="server" id="advertencia"
                        visible="false">
                    </div>

                    <asp:PlaceHolder runat="server" ID="ph_turnos">

                    </asp:PlaceHolder>


                    <!-- Inicio Turnos del Paciente -->
                    <%--<div class="row">
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
                    --%>
                    <!-- Fin Turnos del Paciente -->

                    <%--<div class="row">
                        <div class="load-more">
                            <asp:Button runat="server"
                                CssClass="btn btn-green btn-small"
                                ID="btn_load_more"
                                OnClick="btn_load_more_Click"
                                Text="Cargar Más"/>
                        </div>
                    </div>--%>
                </div>

                <!-- Inicio Elementos al Costado -->
                <aside>
                    <div class="elements-aside gray-color">
                        <ul>
                            <li class="color-2">
                                <i class="fa fa-hourglass-half" aria-hidden="true"></i>
                                <h4>Horarios de Atención</h4>
                                <p>Lunes a Viernes
                                    <span>10:00am a 12:00am</span>
                                    <span>02:00pm a 08:00pm</span>
                                </p>
                            </li>
                            <li class="color-3">
                                <i class="fa fa-info" aria-hidden="true"></i>
                                <h4>Contacto</h4>
                                <p>Dirección
                                    <span runat="server" id="direccion"></span>
                                </p>
                                <p>Teléfono
                                    <span runat="server" id="telefono"></span>
                                </p>
                                <p>Correo electrónico
                                    <span runat="server" id="correo"></span>
                                </p>
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
