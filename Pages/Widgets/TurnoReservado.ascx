<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="TurnoReservado.ascx.cs" Inherits="Lenguajes3_ProyectoFinalv3.Pages.Widgets.TurnoReservado" %>


<div class="row">
    <!--Item-->
    <div class="col-lg-12">
        <div class="item-meeting">
            <!--Item-->
            <div class="avatar-doctor">
                <div class="avatar-image">
                    <img src="../images/avatar-default.png" alt="foto profesional"
                         runat="server" id="pro_avatar">
                    <h4><a href="../ProfessionalsPage.aspx" title="Ver Perfil"
                            runat="server" id="pro_name">Dr. Jurado</a></h4>
                    <p runat="server" id="pro_title">Cardiothoracic Anesthesia and Anesthesiology - FCI</p>
                </div>
            </div>

            <div class="data-meeting">
                <ul class="list-unstyled info-meet">

                    <li>
                        <p class="time">Fecha: <span runat="server" id="turno_fecha">September 15, 2017 at 10:00am</span></p>
                    </li>

                    <%--<li>
                        <div class="alert alert-info" role="alert">Observaciones: None.</div>
                    </li>--%>
                </ul>

                <ul class="list-unstyled btns">
                    <li>
                        <asp:LinkButton runat="server"
                            CssClass="btn btn-red btn-xsmall confirm"
                            ID="btn_cancelar"
                            OnClick="btn_cancelar_Click">
                            <i class="fa fa-times" aria-hidden="true"></i> Cancelar
                        </asp:LinkButton>
                    </li>
                    <%--<li>
                        <asp:LinkButton runat="server"
                            CssClass="btn btn-green btn-xsmall"
                            ID="btn_modificar"
                            OnClick="btn_modificar_Click">
                            <i class="fa fa-pencil" aria-hidden="true"></i> Modificar
                        </asp:LinkButton>
                    </li>--%>
                </ul>
            </div>
        </div>
    </div>
    <!--Item-->
</div>
