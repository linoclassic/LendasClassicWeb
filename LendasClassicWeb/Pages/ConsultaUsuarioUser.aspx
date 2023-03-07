<%@ Page Title="" Language="C#" MasterPageFile="~/DefaultUser.Master" AutoEventWireup="true" CodeBehind="ConsultaUsuarioUser.aspx.cs" Inherits="LendasClassicWeb.Pages.ConsultaUser" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <asp:Label ID="lblSessionMsg" runat="server" Text="Label" CssClass="h4"/>

    <asp:GridView runat="server" ID="gv1" AutoGenerateColumns="false" CssClass="table table-responsive table-striped mt-5">

        <Columns>

            <asp:BoundField DataField="nomeUsuario" HeaderText="Nome"/>
            <asp:BoundField DataField="fkTpUsuario" HeaderText="Tipo Usuário"/>
            <asp:BoundField DataField="statusUsuario" HeaderText="Tipo Usuário"/>
            <asp:BoundField DataField="emailUsuario" HeaderText="Email"/>
            <asp:BoundField DataField="senhaUsuario" HeaderText="Senha"/>
            <asp:BoundField DataField="cpfUsuario" HeaderText="Cpf"/>
            <asp:BoundField DataField="telefoneUsuario" HeaderText="Cidade"/>
          

        </Columns>

        </asp:GridView>

</asp:Content>
