<%@ Page Title="" Language="C#" MasterPageFile="~/DefaultLogin.Master" AutoEventWireup="true" CodeBehind="CadastroUser.aspx.cs" Inherits="LendasClassicWeb.Pages.CadastroUser" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">

        <div class="row">
            <div class=" col-md-4 mt-5 mx-auto text-light">

                <h1 class="font-weight-light text-light  mt-5 mb-4 text-center">CADASTRO</h1>

                <asp:Label runat="server" Text="Nome" CssClass="lead" />
                <asp:TextBox AutoCompleteType="Disabled" ID="txtUsuario" CssClass="form-control" MaxLength="50" runat="server" />
                <asp:RequiredFieldValidator ID="RequiredNome" runat="server" ErrorMessage="*Digite o nome" ForeColor="Red" ControlToValidate="txtUsuario" />
                <br />
                <asp:Label runat="server" Text="Email" CssClass="lead" />
                <asp:TextBox AutoCompleteType="Disabled" ID="txtEmail" CssClass="form-control" MaxLength="50" runat="server" />
                <asp:RequiredFieldValidator ID="RequiredEmail" runat="server" ErrorMessage="*Digite o email" ForeColor="Red" ControlToValidate="txtEmail" />
                <br />
                <asp:Label runat="server" Text="Senha" CssClass="lead" />
                <asp:TextBox AutoCompleteType="Disabled" ID="txtSenha" CssClass="form-control" MaxLength="4" runat="server" TextMode="Password" />
                <asp:RequiredFieldValidator ID="RequiredSenha" runat="server" ErrorMessage="*Digite a Senha" ForeColor="Red" ControlToValidate="txtSenha" />
                <br />

                <asp:Label runat="server" Text="CPF" CssClass="lead" />
                <asp:TextBox AutoCompleteType="Disabled" ID="txtCpf" CssClass="form-control" MaxLength="14" runat="server" />
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="*Digite o cpf" ForeColor="Red" ControlToValidate="txtCpf" />
                                <br />

                   <asp:Label runat="server" Text="Telefone" CssClass="lead" />
                <asp:TextBox AutoCompleteType="Disabled" ID="txtTelefone" CssClass="form-control" MaxLength="14" runat="server" />
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="*Digite o telefone" ForeColor="Red" ControlToValidate="txtTelefone" />

                <asp:Label ID="lblErro" runat="server" CssClass="lead" ForeColor="Red"></asp:Label>

                <div class="d-flex justify-content-center mt-2">
                          <asp:Button ID="Button1" runat="server" Text="CADASTRAR" CssClass="btn py-2 btn-lg w-50 btn-primary rounded"   />
                    <%--   <asp:Button ID="Button1" runat="server" Text="CADASTRAR" CssClass="btn py-2 btn-lg w-50 btn-primary rounded" OnClick="btnEntrar_Click" />--%>

                    <%--    <asp:Button ID="Button2" runat="server" Text="Cancelar" CssClass="btn btn-secondary rounded" type="reset" value="Reset" OnClick="btnCancelar_Click" />--%>
                </div>
                <div class="mt-4 text-center">
                    <p>
                        Já tem um cadastro? <a href="Login.aspx" class="link-primary">Entrar</a>
                    </p>
                </div>


            </div>






        </div>

    </div>



</asp:Content>
