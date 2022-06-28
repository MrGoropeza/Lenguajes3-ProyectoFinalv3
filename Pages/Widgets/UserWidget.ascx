<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="UserWidget.ascx.cs" Inherits="Lenguajes3_ProyectoFinalv3.Pages.Widgets.UserWidget" %>

<!--Item-->
<div class="col-lg-12">
    <div class="item-meeting">
        <!--Item-->
        <div class="avatar-doctor">
            <div class="avatar-image">
                <img src="../../images/avatar-default.png" alt="user profile pic"
                    runat="server" id="user_avatar">
                <h4>

                    <asp:LinkButton runat="server"
                        id="lb_name"
                        Text="User name"
                        OnClick="lb_name_Click">

                    </asp:LinkButton>
                    
                </h4>
                <p runat="server" id="user_title">Cardiothoracic Anesthesia and Anesthesiology - FCI</p>
            </div>
        </div>

        <div class="data-meeting">
            <ul class="list-unstyled">
                <li>
                    <p>DNI: <span runat="server" id="user_dni">9876005-00</span></p>
                </li>
                <li>
                    <p>Género: <span runat="server" id="user_gender">General Medical Assistance</span></p>
                </li>
                <li>
                    <p class="time">Fecha de Nacimiento:
                        <span runat="server" id="user_fecha_nac">September 15, 2017 at 10:00am</span>
                     </p>
                </li>
                <li>
                    <p>Teléfono: <span runat="server" id="user_tel1">General Medical Assistance</span></p>
                </li>
                <li>
                    <p>Correo: <span runat="server" id="user_correo">202</span></p>
                </li>
                <li>
                    <div class="alert alert-warning" runat="server"
                        id="esAdmin"></div>
                </li>
                <li>
                    <div class="alert alert-info" runat="server"
                        id="esProfesional"></div>
                </li>
            </ul>

            <ul class="list-unstyled btns">
                <li>
                    <asp:LinkButton runat="server" ID="btn_admin" OnClick="btn_admin_Click"
                        CssClass="btn btn-red btn-xsmall confirm">
                        <i class="fa fa-times" aria-hidden="true"></i> Hacer o Remover Admin
                    </asp:LinkButton>
                </li>
                <li>
                    <asp:LinkButton runat="server" ID="btn_pro" OnClick="btn_pro_Click"
                        CssClass="btn btn-xsmall">
                        <i class="fa fa-arrow-down" aria-hidden="true"></i> Hacer o Remover Profesional
                    </asp:LinkButton>
                </li>
            </ul>
        </div>
    </div>
</div>
<!--Item-->
