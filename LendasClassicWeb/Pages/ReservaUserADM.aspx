<%@ Page Title="" Language="C#" MasterPageFile="~/DefaultAdm.Master" AutoEventWireup="true" CodeBehind="ReservaUserADM.aspx.cs" Inherits="LendasClassicWeb.Pages.ReservaUserADM" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

     <br />
    <div class="text-center text-uppercase">
        <asp:Label ID="lblSessionMsg" runat="server" CssClass="h3 text-light" />

    </div>
    <br />
    <asp:Label runat="server" Text="Selecione a opção desejada:" CssClass="text-light" /> |
        <asp:DropDownList ID="ddl1" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddl1_SelectedIndexChanged" CssClass="dropdown dropdown-menu-dark" Width="200">
           <%-- <asp:ListItem Text="ADMINISTRADOR" Value="1" />
            <asp:ListItem Text="OUTROS" Value="2" />--%>
            <asp:ListItem Text=""  />
            <asp:ListItem Text="ATIVO" Value="ATIVO" />
            <asp:ListItem Text="INATIVO" Value="INATIVO" />
            <asp:ListItem Text="CANCELADO" Value="CANCELADO" />
        </asp:DropDownList> |
    <asp:Button runat="server" Text="Limpar Filtro" ID="btnLimpaFiltro" OnClick="btnLimpaFiltro_Click" CssClass="btn btn-sm btn-primary" /> |
    <br /><hr />
    <asp:GridView runat="server" ID="gv1" AutoGenerateColumns="false" ShowFooter="true" DataKeyNames="idReserva" OnRowCommand="gv1_RowCommand" OnRowUpdating="gv1_RowUpdating" OnRowDeleting="gv1_RowDeleting" OnRowEditing="gv1_RowEditing" OnRowCancelingEdit="gv1_RowCancelingEdit" AllowSorting="true" AllowPaging="true" PageSize="10" OnPageIndexChanging="gv1_PageIndexChanging" CssClass="table table-dark table-responsive table-responsive-sm table-striped mt-0">
       
         <Columns>

                    <asp:TemplateField HeaderText="NOME">

                        <ItemTemplate>
                            <asp:Label runat="server" Text='<%#Eval("nomeUsuario") %>' />
                        </ItemTemplate>

                        <EditItemTemplate>
                            <asp:TextBox ID="txtEmailUsuario" runat="server" MaxLength="50" Text='<%#Eval("nomeUsuario") %>' />
                        </EditItemTemplate>

                    </asp:TemplateField>

               <asp:TemplateField HeaderText="EMAIL">

                        <ItemTemplate>
                            <asp:Label runat="server" Text='<%#Eval("emailUsuario") %>' />
                        </ItemTemplate>

                        <EditItemTemplate>
                            <asp:TextBox ID="txtEmailUsuario" runat="server" MaxLength="50" Text='<%#Eval("emailUsuario") %>' />
                        </EditItemTemplate>

                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="DATA DA RESERVA">

                        <ItemTemplate>
                            <asp:Label runat="server" Text='<%#Eval("dataReserva" , "{0:dd/MM/yyyy}") %>' />
                        </ItemTemplate>

                        <EditItemTemplate>
                            <%--<asp:TextBox ID="txtDataReserva" runat="server" MaxLength="10" Text='<%#Eval("dataReserva", "{0:dd/MM/yyyy}") %>' />
                            <asp:Calendar ID="calDataReserva" runat="server" Visible="false" SelectionMode="Day" OnSelectionChanged="calDataReserva_SelectionChanged" />--%>
                        </EditItemTemplate>
                        <%--  <FooterTemplate>
                    <asp:TextBox ID="txtDataReservaFooter" runat="server" />
                </FooterTemplate>--%>

                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="STATUS DA RESERVA">

                        <ItemTemplate>
                            <asp:Label runat="server" Text='<%#Eval("statusReserva") %>' />
                        </ItemTemplate>
                      
                    </asp:TemplateField>

               <%--Opções--%>
            <asp:TemplateField HeaderText="OPÇÕES">

                <ItemTemplate>
<%--                    <asp:ImageButton ID="btnEditar" runat="server" ImageUrl="~/Images/EditarWhite.png" ToolTip="Editar" Width="40" Height="40" CommandName="Edit" />--%>
                    <asp:ImageButton ID="btnExcluir" runat="server" ImageUrl="~/Images/DeleteWhite.png" ToolTip="Cancelar" Width="36" Height="36" CommandName="Delete" OnClientClick="if (!confirm('Deseja realmente cancelar este registro?'))return false" />
                </ItemTemplate>

                <EditItemTemplate>
                   <%-- <asp:ImageButton ID="btnSalvar" runat="server" ImageUrl="~/Images/UpdateWhite.png" ToolTip="Salvar" Width="40" Height="40" CommandName="Update" />
                    <asp:ImageButton ID="btnCancelar" runat="server" ImageUrl="~/Images/CancelWhite.png" ToolTip="Cancelar" Width="40" Height="40" CommandName="Cancel" />--%>
                </EditItemTemplate>

                <FooterTemplate>
                  <%--  <asp:ImageButton ID="btnAdicionar" runat="server" ImageUrl="~/Images/AddWhite.png" ToolTip="Adicionar" Width="35" Height="35" CommandName="Add" />--%>
                </FooterTemplate>


            </asp:TemplateField>

             </Columns>

        </asp:GridView>
</asp:Content>
