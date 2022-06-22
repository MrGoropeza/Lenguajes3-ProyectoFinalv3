<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/Dashboard.Master" AutoEventWireup="true" CodeBehind="AccountPage.aspx.cs" Inherits="Lenguajes3_ProyectoFinalv3.Pages.AccountPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Head" runat="server">
    <title>Mi Cuenta</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Contenido" runat="server">
    <div class="container">
        <div class="main-container">
            <!--Form-->
            <div class="register-form edit-account">

                <div class="form-login">
                    <div>
                        <!--Personal Information-->
                        <div class="row">

                            <h3>Información Personal</h3>
                            <hr>
                            <div class="datapos">

                                <!--name-->
                                <div class="icon-data">
                                    <i class="fa fa-user"></i>
                                </div>
                                <input type="text" placeholder="Johna">
                                <!--name-->

                                <!--phone-->
                                <div class="icon-data">
                                    <i class="fa fa-phone"></i>
                                </div>
                                <input type="number" placeholder="090-192763">
                                <!--phone-->

                                <!--gender-->
                                <label>
                                    <input type="radio" checked value="female">
                                    <span>Female</span>
                                </label>
                                <label>
                                    <input type="radio" value="male">
                                    Male
                                </label>
                                <!--gender-->

                                <!--Avatar Profile-->
                                <div class="avatar-profile">
                                    <label>Image Profile</label>
                                    <input type="file" accept="image/*">
                                </div>
                                <!--Avatar Profile-->
                            </div>

                            <div class="datapos">
                                <!--numero documento-->
                                <div class="icon-data">
                                    <i class="fa fa-user-circle"></i>
                                </div>
                                <input type="number" disabled="disabled" class="disable" placeholder="09876543210">
                                <!--numero documento-->

                                <!--apellido-->
                                <div class="icon-data">
                                    <i class="fa fa-user"></i>
                                </div>
                                <input type="text" placeholder="Depp">
                                <!--apellido-->

                                <!--Alternative phone-->
                                <div class="icon-data">
                                    <i class="fa fa-phone"></i>
                                </div>
                                <input type="number" placeholder="090-192763">
                                <!--Alternative phone-->

                            </div>

                        </div>
                        <!--Personal Information-->

                        <!--Data Information-->
                        <div class="row">
                            <h3>Información de la Cuenta</h3>
                            <div class="datapos">

                                <!--usuario-->
                                <div class="icon-data">
                                    <i class="fa fa-user"></i>
                                </div>
                                <input type="text" placeholder="JohnaDeepe">
                                <!--usuario-->

                            </div>
                            
                            <div class="datapos">

                                <!--correo-->
                                <div class="icon-data">
                                    <i class="fa fa-user"></i>
                                </div>
                                <input type="text" placeholder="example@provider.com">
                                <!--correo-->

                            </div>
                        </div>
                        <!--Data Information-->
                        <button class="btn btn-default">guardar cambios</button>
                        <button class="btn btn-default">cambiar contraseña</button>
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
