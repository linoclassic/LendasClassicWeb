<%@ Page Title="" Language="C#" MasterPageFile="~/DefaultAdm.Master" AutoEventWireup="true" CodeBehind="ManagerUsuarioADM.aspx.cs" Inherits="LendasClassicWeb.Pages.ManagerUsuarioADM" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <br />
    <div class="text-center text-uppercase">
        <asp:Label ID="lblSessionMsg" runat="server" CssClass="h3 text-light" />

    </div>
    <br />
    <asp:Label runat="server" Text="Selecione a opção desejada:" CssClass="text-light" />
    |
        <asp:DropDownList ID="ddl1" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddl1_SelectedIndexChanged" CssClass="dropdown dropdown-menu-dark" Width="200">
            <%-- <asp:ListItem Text="ADMINISTRADOR" Value="1" />
            <asp:ListItem Text="OUTROS" Value="2" />--%>
            <asp:ListItem Text="" />
            <asp:ListItem Text="ATIVO" Value="ATIVO" />
            <asp:ListItem Text="INATIVO" Value="INATIVO" />
        </asp:DropDownList>
    |
    <asp:Button runat="server" Text="Limpar Filtro" ID="btnLimpaFiltro" OnClick="btnLimpaFiltro_Click" CssClass="btn btn-sm btn-primary" />
    |
    <br />
    <hr />
    <asp:GridView runat="server" ID="gv1" AutoGenerateColumns="false" ShowFooter="true" DataKeyNames="idUsuario" OnRowCommand="gv1_RowCommand" OnRowUpdating="gv1_RowUpdating" OnRowDeleting="gv1_RowDeleting" OnRowEditing="gv1_RowEditing" OnRowCancelingEdit="gv1_RowCancelingEdit" AllowSorting="true" AllowPaging="true" PageSize="9" OnPageIndexChanging="gv1_PageIndexChanging" CssClass="table table-dark table-responsive table-responsive-sm table-striped mt-0">
        <Columns>
            <asp:TemplateField HeaderText="NOME">

                <ItemTemplate>
                    <asp:Label runat="server" Text='<%#Eval("nomeUsuario") %>' />
                </ItemTemplate>

                <EditItemTemplate>
                    <asp:TextBox ID="txtNomeUsuario" runat="server" MaxLength="50" Text='<%#Eval("nomeUsuario") %>' />
                </EditItemTemplate>

                <FooterTemplate>
                    <asp:TextBox ID="txtNomeUsuarioFooter" runat="server" />
                </FooterTemplate>


            </asp:TemplateField>

            <%--radiobutton--%>
            <asp:TemplateField HeaderText="TIPO USUÁRIO">

                <ItemTemplate>
                    <asp:Label runat="server" Text='<%#Eval("fkTpUsuario") %>' />
                </ItemTemplate>

                <EditItemTemplate>
                    <asp:RadioButtonList ID="rbl1" runat="server">
                        <asp:ListItem Value="1" Text="Administrador" />
                        <asp:ListItem Value="2" Text="Outros" />
                    </asp:RadioButtonList>
                </EditItemTemplate>

                <FooterTemplate>
                    <asp:RadioButtonList ID="rbl1" runat="server">
                        <asp:ListItem Value="1" Text="Administrador" />
                        <asp:ListItem Value="2" Text="Outros" />
                    </asp:RadioButtonList>
                </FooterTemplate>


            </asp:TemplateField>

            <%--          <asp:TemplateField HeaderText="Status">

               <ItemTemplate>
                  <asp:Label runat="server" Text='<%#Eval("statusUsuario") %>' />
               </ItemTemplate>
              
               <EditItemTemplate>
                   <asp:RadioButtonList ID="rbl2" runat="server">
                       <asp:ListItem Value="1" Text="ATIVO" />
                       <asp:ListItem Value="2" Text="INATIVO" />
                   </asp:RadioButtonList>
               </EditItemTemplate>

               <FooterTemplate>
                      <asp:RadioButtonList ID="rbl2" runat="server">
                       <asp:ListItem Value="1" Text="ATIVO" />
                       <asp:ListItem Value="2" Text="INATIVO" />
                   </asp:RadioButtonList>
               </FooterTemplate>


           </asp:TemplateField> --%>

            <%--radiobutton--%>
            <asp:TemplateField HeaderText="STATUS">

                <ItemTemplate>
                    <asp:Label runat="server" Text='<%#Eval("statusUsuario") %>' />
                </ItemTemplate>

                <EditItemTemplate>
                    <asp:RadioButtonList ID="rbl2" runat="server">
                        <asp:ListItem Value="ATIVO" Text="ATIVO" />
                        <asp:ListItem Value="INATIVO" Text="INATIVO" />
                    </asp:RadioButtonList>
                </EditItemTemplate>

                <FooterTemplate>
                    <asp:Label ID="txtStatus" runat="server" Text="ATIVO" CssClass=" text-light" />
                    <%--       <asp:TextBox ID="txtStatusUsuario" Text="ATIVO"  runat="server" />--%>

                    <%--                    <asp:RadioButtonList ID="rbl2" runat="server">--%>
                    <%-- <asp:ListItem Value="ATIVO" Text="ATIVO" />
                       <asp:ListItem Value="INATIVO" Text="INATIVO" />--%>
                    <%--  <asp:TextBox ID="txtStatus" runat="server" />--%>
                    <%-- </asp:RadioButtonList>--%>
                </FooterTemplate>


            </asp:TemplateField>




            <%--  <asp:TemplateField HeaderText="Status">

               <ItemTemplate>
                  <asp:Label runat="server" Text='<%#Eval("statusUsuario") %>' />
               </ItemTemplate>
              
               <EditItemTemplate>
                    <asp:TextBox ID="txtStatusUsuario" runat="server" MaxLength="7" Text='<%#Eval("statusUsuario") %>' AutoPostBack="True" OnTextChanged="txtStatusUsuario_TextChanged"/>
               </EditItemTemplate>

               <FooterTemplate>
                      <asp:TextBox ID="txtStatusUsuarioFooter" runat="server" MaxLength="7" AutoPostBack="True" OnTextChanged="txtStatusUsuarioFooter_TextChanged" />
               </FooterTemplate>


           </asp:TemplateField>--%>


            <asp:TemplateField HeaderText="EMAIL">

                <ItemTemplate>
                    <asp:Label runat="server" Text='<%#Eval("emailUsuario") %>' />
                </ItemTemplate>

                <EditItemTemplate>
                    <asp:TextBox ID="txtEmailUsuario" runat="server" MaxLength="50" Text='<%#Eval("emailUsuario") %>' />
                </EditItemTemplate>

                <FooterTemplate>
                    <asp:TextBox ID="txtEmailUsuarioFooter" runat="server" />
                </FooterTemplate>


            </asp:TemplateField>

            <asp:TemplateField HeaderText="SENHA">

                <ItemTemplate>
                    <asp:Label runat="server" Text='<%#Eval("senhaUsuario") %>' />
                </ItemTemplate>

                <EditItemTemplate>
                    <asp:TextBox ID="txtSenhaUsuario" runat="server" MaxLength="8" Text='<%#Eval("senhaUsuario") %>' />
                </EditItemTemplate>

                <FooterTemplate>
                    <asp:TextBox ID="txtSenhaUsuarioFooter" runat="server" MaxLength="8" />

                </FooterTemplate>


            </asp:TemplateField>

            <asp:TemplateField HeaderText="CPF">

                <ItemTemplate>
                    <asp:Label runat="server" Text='<%#Eval("cpfUsuario") %>' />
                </ItemTemplate>

                <EditItemTemplate>
                    <asp:TextBox ID="txtCpfUsuario" runat="server" data-mask="000.000.000-00" MaxLength="14" Text='<%#Eval("cpfUsuario") %>' />
                </EditItemTemplate>

                <FooterTemplate>
                    <asp:TextBox ID="txtCpfUsuarioFooter" data-mask="000.000.000-00" runat="server" MaxLength="14" />
                </FooterTemplate>


            </asp:TemplateField>

            <asp:TemplateField HeaderText="TELEFONE">

                <ItemTemplate>
                    <asp:Label runat="server" Text='<%#Eval("telefoneUsuario") %>' />
                </ItemTemplate>

                <EditItemTemplate>
                    <asp:TextBox ID="txtTelefoneUsuario" runat="server" MaxLength="50" Text='<%#Eval("telefoneUsuario") %>' data-mask="(00) 0000-0000" />
                </EditItemTemplate>

                <FooterTemplate>
                    <asp:TextBox ID="txtTelefoneUsuarioFooter" runat="server" MaxLength="14" data-mask="(00) 0000-0000" />
                </FooterTemplate>


            </asp:TemplateField>

            <%--Opções--%>
            <asp:TemplateField HeaderText="OPÇÕES">

                <ItemTemplate>
                    <asp:ImageButton ID="btnEditar" runat="server" ImageUrl="~/Images/EditarWhite.png" ToolTip="Editar" Width="40" Height="40" CommandName="Edit" />
                    <asp:ImageButton ID="btnExcluir" runat="server" ImageUrl="~/Images/DeleteWhite.png" ToolTip="Inativar" Width="36" Height="36" CommandName="Delete" OnClientClick="if (!confirm('Deseja realmente inativar este registro?'))return false" />
                </ItemTemplate>

                <EditItemTemplate>
                    <asp:ImageButton ID="btnSalvar" runat="server" ImageUrl="~/Images/UpdateWhite.png" ToolTip="Salvar" Width="40" Height="40" CommandName="Update" />
                    <asp:ImageButton ID="btnCancelar" runat="server" ImageUrl="~/Images/CancelWhite.png" ToolTip="Cancelar" Width="40" Height="40" CommandName="Cancel" />
                </EditItemTemplate>

                <FooterTemplate>
                    <asp:ImageButton ID="btnAdicionar" runat="server" ImageUrl="~/Images/AddWhite.png" ToolTip="Adicionar" Width="35" Height="35" CommandName="Add" />
                </FooterTemplate>


            </asp:TemplateField>

        </Columns>

    </asp:GridView>
    <br />
    <%-- <asp:Label ID="lblMessage" runat="server" Text="Label" />--%>
</asp:Content>
