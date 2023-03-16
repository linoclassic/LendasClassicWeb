<%@ Page Title="" Language="C#" MasterPageFile="~/DefaultCadReserva.Master" AutoEventWireup="true" CodeBehind="CadastroReserva.aspx.cs" Inherits="LendasClassicWeb.Pages.CadastroReservaa" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
   <asp:Label ID="lblNot" runat="server" Text="Label" CssClass="card bg-transparent border-0 text-center h2 text-light py-0 pb-4 my-5 mb-0" />
<div class="container-fluid text-center">
    <asp:Label ID="lblPergunta" runat="server" Text="Label" CssClass="h4 mx-2 text-light" Visible="false" />
    
    <asp:Button ID="btnNovaReserva" runat="server" OnClick="btnNovaReserva_Click" Text="CADASTRAR" CssClass="btn btn-primary px-4 py-3 mt-3" Visible="false" />
</div>
<div class="container">
    <div class="row">
        <div class="col-md-4 mt-0 mx-auto text-light">
            <asp:TextBox AutoCompleteType="Disabled" ID="tipoUsuario" CssClass="form-control" MaxLength="50" Visible="false" runat="server" />
            <asp:Label runat="server" Text="Data da reserva:" CssClass="lead"  Visible="false"/>
            <asp:Calendar ID="calDataReserva" OnDayRender="calDataReserva_DayRender" CssClass="bg-light text-black calendar-hide" Width="100%" Height="100%" runat="server"  Visible="false" SelectionMode="Day" VisibleDate='<%# DateTime.Today.AddDays(1) %>'></asp:Calendar>
            <div class="d-flex justify-content-center mt-2">
                <asp:Button ID="btnCadastrar" OnClick="btnCadastrar_Click" runat="server"  Visible="false" Text="RESERVAR" CssClass="btn py-2 btn-lg mt-3 mx-3 btn-primary rounded" />
                <asp:Button ID="btnCancelar" runat="server" Text="CANCELAR" CssClass="btn btn-danger px-4 py-3 mt-3" Visible="false" OnClick="btnCancelar_Click" />

            </div>
        </div>
    </div>
</div>

</asp:Content>
