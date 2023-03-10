<%@ Page Title="" Language="C#" MasterPageFile="~/DefaultLogin.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="LendasClassicWeb.Pages.Loginn" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div class="row">
            <div class="col-md-6 mt-5 mx-auto text-light">
                <h1 class="font-weight-light text-light  mt-5 mb-4 text-center">FAZER LOGIN</h1>
                <asp:Label runat="server" Text="Nome de usuário" CssClass="lead"/>
                <asp:TextBox AutoCompleteType="Disabled" ID="txtUsuario" CssClass="form-control" MaxLength="50" runat="server" />
                <asp:RequiredFieldValidator ID="RequiredNome" runat="server" ErrorMessage="*Digite o nome do usuário" ForeColor="Red" ControlToValidate="txtUsuario" />
                <br />
                <asp:Label runat="server" Text="Senha" CssClass="lead" />
                <asp:TextBox AutoCompleteType="Disabled" ID="txtSenha" CssClass="form-control" MaxLength="4" runat="server" TextMode="Password" />
                <asp:RequiredFieldValidator ID="RequiredSenha" runat="server" ErrorMessage="*Digite a Senha do usuário" ForeColor="Red" ControlToValidate="txtSenha" />
                <br />
                  <asp:Label ID="lblErro" runat="server" CssClass="lead" ForeColor="Red"></asp:Label>
                  <div class="d-flex justify-content-center mt-3">
            <asp:Button ID="Button1" runat="server" Text="ENTRAR" CssClass="btn py-2 btn-lg w-50 btn-primary rounded" OnClick="btnEntrar_Click" />
                      
        <%--    <asp:Button ID="Button2" runat="server" Text="Cancelar" CssClass="btn btn-secondary rounded" type="reset" value="Reset" OnClick="btnCancelar_Click" />--%>
        </div>
                <div class="mt-4 text-center">
                          <p>Não tem um cadastro? <a href="CadastroUser.aspx" class="link-primary">Cadastrar</a>
                          </p>
                      </div>
            </div>
        </div>
    </div>
</asp:Content>
