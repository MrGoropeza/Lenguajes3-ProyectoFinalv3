﻿<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="TurnoReservado.ascx.cs" Inherits="Lenguajes3_ProyectoFinalv3.Pages.Widgets.TurnoReservado" %>


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
