<%@ Page Title="" Language="C#" MasterPageFile="~/DefaultAdm.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="LendasClassicWeb.Pages.Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="formulario text-dark mb-4 mx-5" >
        <br />
        <h1 class="text-dark font-weight-light">Autenticação</h1>
        <br />
        <asp:Label runat="server" Text="Usuário" CssClass="lead" />
        <asp:TextBox AutoCompleteType="Disabled" ID="txtUsuario" CssClass="form-control ml-5" MaxLength="50" runat="server" Width="40%" />
        <asp:RequiredFieldValidator ID="RequiredNome" runat="server" ErrorMessage="*Digite o nome do usuário" ForeColor="Red" ControlToValidate="txtUsuario">
        </asp:RequiredFieldValidator>
        
        <br />
        <asp:Label runat="server" Text="Senha" CssClass="lead" />
        <asp:TextBox AutoCompleteType="Disabled" ID="txtSenha" CssClass="form-control" MaxLength="4" runat="server" Width="40%"
            TextMode="Password" />
        <asp:RequiredFieldValidator ID="RequiredSenha" runat="server" ErrorMessage="*Digite a Senha do usuário" ForeColor="Red" ControlToValidate="txtSenha">
        </asp:RequiredFieldValidator>
        <br />
        <asp:Button ID="btnEntrar" runat="server" Text="Entrar" CssClass="btn btn-secondary rounded " OnClick="btnEntrar_Click"/>
        <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" CssClass="btn btn-secondary rounded" type="reset" value="Reset" OnClick="btnCancelar_Click" />
        <br />
        <asp:Label ID="lblErro" runat="server"  CssClass="lead" ForeColor="Red"></asp:Label>
        <asp:Label ID="lblMensagem" runat="server"  CssClass="lead" ForeColor="Red"></asp:Label>
    </div>

</asp:Content>
