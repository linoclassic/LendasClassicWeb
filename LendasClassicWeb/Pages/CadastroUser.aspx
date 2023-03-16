<%@ Page Title="" Language="C#" MasterPageFile="~/DefaultLogin.Master" AutoEventWireup="true" CodeBehind="CadastroUser.aspx.cs" Inherits="LendasClassicWeb.Pages.CadastroUser" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
      
        <div class="row">
            
            <div class=" col-md-4 mt-5 mx-auto text-light">
                  <br />
                <h1 class="font-weight-light text-light h3 mt-5 mb-4 text-center">CRIAR CONTA</h1>

                <asp:Label runat="server" Text="Nome" CssClass="lead" />
               <asp:TextBox AutoCompleteType="Disabled" ID="txtUsuario" CssClass="form-control" MaxLength="50" runat="server" placeholder="Nome Completo*"/>

                <asp:RequiredFieldValidator ID="RequiredNome" runat="server" ErrorMessage="*Digite o nome" ForeColor="Red" ControlToValidate="txtUsuario" />
                <br />
                   <asp:TextBox AutoCompleteType="Disabled" ID="tipoUsuario" CssClass="form-control" MaxLength="50" Visible="false" runat="server"/>
                <asp:Label runat="server" Text="Email" CssClass="lead" />
                <asp:TextBox AutoCompleteType="Disabled" ID="txtEmail" CssClass="form-control" MaxLength="50" runat="server" placeholder="E-mail*"/>
                <asp:RequiredFieldValidator ID="RequiredEmail" runat="server" ErrorMessage="*Digite o email" ForeColor="Red" ControlToValidate="txtEmail" />
                <br />
                <asp:Label runat="server"  Text="Senha"  CssClass="lead"/>
                <asp:TextBox AutoCompleteType="Disabled" ID="txtSenha" CssClass="form-control" runat="server" minlength="8"  TextMode="Password" placeholder="Crie sua senha*"/>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="*Digite a senha" ForeColor="Red" ControlToValidate="txtSenha" />
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtSenha"  ValidationExpression="^[a-zA-Z0-9]{8,}$" ForeColor="Red"></asp:RegularExpressionValidator>
                <asp:CustomValidator ID="CustomValidator1" runat="server" ControlToValidate="txtSenha" ErrorMessage="*A senha deve conter 8 dígitos" ClientValidationFunction="ValidatePasswordLength" ForeColor="Red"></asp:CustomValidator>
                <br />

                <asp:Label runat="server" Text="CPF" CssClass="lead" />
                <asp:TextBox AutoCompleteType="Disabled" ID="txtCpf" CssClass="form-control" MaxLength="14" runat="server" data-mask="000.000.000-00" placeholder="CPF*"/>
                <asp:RequiredFieldValidator ID="RequiredCpf" runat="server" ErrorMessage="*Digite o cpf" ForeColor="Red" ControlToValidate="txtCpf" />
                <br />

                <asp:Label runat="server" Text="Telefone" CssClass="lead" />
                <asp:TextBox AutoCompleteType="Disabled" ID="txtTelefone" CssClass="form-control mb-1" MaxLength="14" runat="server" data-mask="(00) 0000-0000" placeholder="Telefone Celular*" />
                <asp:RequiredFieldValidator ID="RequiredTelefone" runat="server" ErrorMessage="*Digite o telefone" ForeColor="Red" ControlToValidate="txtTelefone" />
                <asp:Label runat="server" Text="(*)Campos Obrigatórios" CssClass="" />
                <asp:Label ID="lblErro" runat="server" CssClass="lead" ForeColor="Red"></asp:Label>

                <asp:Label ID="lblMsg" runat="server" CssClass="lead" ForeColor="Red"></asp:Label>

                <div class="d-flex justify-content-center mt-2">
                    <asp:Button ID="btCadastrar" OnClick="btCadastrar_Click" runat="server" Text="CADASTRAR" CssClass="btn py-2 btn-lg mt-4 w-50 btn-primary rounded" />
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
