<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="AgendaWidget.ascx.cs" Inherits="Lenguajes3_ProyectoFinalv3.Pages.Widgets.AgendaWidget" %>


<div class="alert alert-warning" role="alert"
    runat="server" id="advertencia"
    visible="false">
</div>

<asp:Table runat="server" CssClass="table"
    id="tabla">

    <asp:TableHeaderRow Visible="false">
        <asp:TableCell>
            <asp:LinkButton runat="server"
                CssClass="btn btn-xsmall"
                ID="btn_anterior"
                OnClick="btn_anterior_Click">
                <i class="fa fa-arrow-left"></i> Semana Anterior
            </asp:LinkButton>
        </asp:TableCell>

        <asp:TableCell></asp:TableCell>
        <asp:TableCell></asp:TableCell>
        <asp:TableCell></asp:TableCell>
        <asp:TableCell></asp:TableCell>

        <asp:TableCell>
            <asp:LinkButton runat="server"
                CssClass="btn btn-xsmall"
                ID="btn_siguiente"
                OnClick="btn_siguiente_Click">
                <i class="fa fa-arrow-right"></i> Semana Siguiente
            </asp:LinkButton>
        </asp:TableCell>
    </asp:TableHeaderRow>

    <asp:TableHeaderRow CssClass="days">
        <asp:TableHeaderCell>
                        Horario
        </asp:TableHeaderCell>
        <asp:TableHeaderCell>
                        Lunes
        </asp:TableHeaderCell>
        <asp:TableHeaderCell>
                        Martes
        </asp:TableHeaderCell>
        <asp:TableHeaderCell>
                        Miércoles
        </asp:TableHeaderCell>
        <asp:TableHeaderCell>
                        Jueves
        </asp:TableHeaderCell>
        <asp:TableHeaderCell>
                        Viernes
        </asp:TableHeaderCell>
    </asp:TableHeaderRow>

    <asp:TableRow ID="slot1">
        <asp:TableCell>
                        10:00 - 10:30
        </asp:TableCell>
    </asp:TableRow>

    <asp:TableRow ID="slot2">
        <asp:TableCell>
                        10:30 - 11:00
        </asp:TableCell>
    </asp:TableRow>

    <asp:TableRow ID="slot3">
        <asp:TableCell>
                        11:00 - 11:30
        </asp:TableCell>
    </asp:TableRow>

    <asp:TableRow ID="slot4">
        <asp:TableCell>
                        11:30 - 12:00
        </asp:TableCell>
    </asp:TableRow>

    <asp:TableRow ID="slot5">
        <asp:TableCell>
                        14:00 - 14:30
        </asp:TableCell>
    </asp:TableRow>

    <asp:TableRow ID="slot6">
        <asp:TableCell>
                        14:30 - 15:00
        </asp:TableCell>
    </asp:TableRow>

    <asp:TableRow ID="slot7">
        <asp:TableCell>
                        15:00 - 15:30
        </asp:TableCell>
    </asp:TableRow>

    <asp:TableRow ID="slot8">
        <asp:TableCell>
                        15:30 - 16:00
        </asp:TableCell>
    </asp:TableRow>

    <asp:TableRow ID="slot9">
        <asp:TableCell>
                        16:00 - 16:30
        </asp:TableCell>
    </asp:TableRow>

    <asp:TableRow ID="slot10">
        <asp:TableCell>
                        16:30 - 17:00
        </asp:TableCell>
    </asp:TableRow>

    <asp:TableRow ID="slot11">
        <asp:TableCell>
                        17:00 - 17:30
        </asp:TableCell>
    </asp:TableRow>

    <asp:TableRow ID="slot12">
        <asp:TableCell>
                        17:30 - 18:00
        </asp:TableCell>
    </asp:TableRow>

    <asp:TableRow ID="slot13">
        <asp:TableCell>
                        18:00 - 18:30
        </asp:TableCell>
    </asp:TableRow>

    <asp:TableRow ID="slot14">
        <asp:TableCell>
                        18:30 - 19:00
        </asp:TableCell>
    </asp:TableRow>

    <asp:TableRow ID="slot15">
        <asp:TableCell>
                        19:00 - 19:30
        </asp:TableCell>
    </asp:TableRow>

    <asp:TableRow ID="slot16">
        <asp:TableCell>
                        19:30 - 20:00
        </asp:TableCell>
    </asp:TableRow>

</asp:Table>
