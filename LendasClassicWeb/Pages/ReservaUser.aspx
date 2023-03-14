<%@ Page Title="" Language="C#" MasterPageFile="~/DefaultUser.Master" AutoEventWireup="true" CodeBehind="ReservaUser.aspx.cs" Inherits="LendasClassicWeb.Pages.RservaUser" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <asp:Label ID="lblMensagem" runat="server" Text="Label" CssClass="h4 text-light   " />

    <asp:GridView runat="server" ID="gv1" AutoGenerateColumns="false" ShowFooter="true" DataKeyNames="idUsuario" OnRowUpdating="gv1_RowUpdating" OnRowEditing="gv1_RowEditing" OnRowCancelingEdit="gv1_RowCancelingEdit" OnPageIndexChanging="gv1_PageIndexChanging" CssClass="table table-responsive table-striped table-dark mt-5">

        <Columns>

            <asp:TemplateField HeaderText="Nome">

                <ItemTemplate>
                    <asp:Label runat="server" Text='<%#Eval("nomeUsuario") %>' />
                </ItemTemplate>

                <EditItemTemplate>
                    <asp:TextBox ID="txtNomeUsuario" runat="server" MaxLength="50" Text='<%#Eval("nomeUsuario") %>' />
                </EditItemTemplate>



            </asp:TemplateField>

            <asp:TemplateField HeaderText="Email">

                <ItemTemplate>
                    <asp:Label runat="server" Text='<%#Eval("emailUsuario") %>' />
                </ItemTemplate>

                <EditItemTemplate>
                    <asp:TextBox ID="txtEmailUsuario" runat="server" MaxLength="50" Text='<%#Eval("emailUsuario") %>' />
                </EditItemTemplate>

            </asp:TemplateField>


            <asp:TemplateField HeaderText="Telefone">

                <ItemTemplate>
                    <asp:Label runat="server" Text='<%#Eval("telefoneUsuario") %>' />
                </ItemTemplate>

                <EditItemTemplate>
                    <asp:TextBox ID="txtTelefoneUsuario" runat="server" MaxLength="50" Text='<%#Eval("telefoneUsuario") %>' />
                </EditItemTemplate>
            </asp:TemplateField>

            <asp:TemplateField HeaderText="Cpf">

                <ItemTemplate>
                    <asp:Label runat="server" Text='<%#Eval("cpfUsuario") %>' />
                </ItemTemplate>

                <EditItemTemplate>
                    <asp:TextBox ID="txtCpfUsuario" runat="server" MaxLength="14" Text='<%#Eval("cpfUsuario") %>' />
                </EditItemTemplate>

            </asp:TemplateField>


            <asp:TemplateField HeaderText="Data Da Reserva">

                <ItemTemplate>
                    <asp:Label runat="server" Text='<%#Eval("dataReserva") %>' />
                </ItemTemplate>

                <EditItemTemplate>
                    <asp:TextBox ID="txtDataReserva" runat="server" MaxLength="10" Text='<%#Eval("dataReserva", "{0:dd/MM/yyyy}") %>' />
                    <asp:Calendar ID="calDataReserva" runat="server" Visible="false" SelectionMode="Day" OnSelectionChanged="calDataReserva_SelectionChanged" />
                </EditItemTemplate>
                <FooterTemplate>
                    <asp:TextBox ID="txtDataReservaFooter" runat="server" />
                </FooterTemplate>

            </asp:TemplateField>

            <%--Opções--%>
            <asp:TemplateField HeaderText="Opções">

                <ItemTemplate>
                    <asp:ImageButton ID="btnEditar" runat="server" ImageUrl="~/Images/EditarWhite.png" ToolTip="Editar" Width="41" Height="41" CommandName="Edit" />
                </ItemTemplate>

                <EditItemTemplate>
                    <asp:ImageButton ID="btnSalvar" runat="server" ImageUrl="~/Images/UpdateWhite.png" ToolTip="Salvar" Width="30" Height="30" CommandName="Update" />
                    <asp:ImageButton ID="btnCancelar" runat="server" ImageUrl="~/Images/CancelWhite.png" ToolTip="Cancelar" Width="30" Height="30" CommandName="Cancel" />
                </EditItemTemplate>

                <FooterTemplate>
                </FooterTemplate>


            </asp:TemplateField>


        </Columns>

    </asp:GridView>


</asp:Content>
