<%@ Page Title="" Language="C#" MasterPageFile="~/DefaultUser.Master" AutoEventWireup="true" CodeBehind="ConsultaUser.aspx.cs" Inherits="LendasClassicWeb.Pages.ConsultaUser" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <asp:GridView runat="server" ID="gv1" AutoGenerateColumns="false">

        <Columns>

            <asp:BoundField DataField="NomeCliente" HeaderText="Nome"/>
            <asp:BoundField DataField="EmailCliente" HeaderText="Email"/>
            <asp:BoundField DataField="FkTpUsuario" HeaderText="Tipo Usuário"/>
            <asp:BoundField DataField="EnderecoCliente" HeaderText="Endereço"/>
            <asp:BoundField DataField="NumeroCliente" HeaderText="Número Endereço"/>
            <asp:BoundField DataField="BairroCliente" HeaderText="Bairro"/>
            <asp:BoundField DataField="CidadeCliente" HeaderText="Cidade"/>
            <asp:BoundField DataField="EstadoCliente" HeaderText="Estado"/>

        </Columns>

        </asp:GridView>

</asp:Content>
