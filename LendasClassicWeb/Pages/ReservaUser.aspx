<%@ Page Title="" Language="C#" MasterPageFile="~/DefaultUser.Master" AutoEventWireup="true" CodeBehind="ReservaUser.aspx.cs" Inherits="LendasClassicWeb.Pages.RservaUser" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container-fluid w-10">

        <div class="container-fluid text-center mb-2">
            <br />
            <asp:Label ID="lblMensagem" runat="server" Text="Label" CssClass=" bg-dark text-center text-uppercase h3  text-light py-2" Visible="false" />
            <br />
            <br />
        </div>

        <%--  <asp:Label ID="lblPergunta" runat="server" Text="Label" CssClass=" h5 mx-2 text-light" Visible="false" />
    <br />
    <asp:Button ID="btnNovaReserva" runat="server" OnClick="btnNovaReserva_Click" Text="RESERVAR" CssClass="btn btn-primary px-5 py-3 mx-3 mt-3" Visible="false" />--%>


        <div class="container-fluid">
            <asp:GridView runat="server" ID="gv1" AutoGenerateColumns="false" ShowFooter="true" DataKeyNames="idUsuario" OnRowUpdating="gv1_RowUpdating" OnRowEditing="gv1_RowEditing" OnRowCancelingEdit="gv1_RowCancelingEdit" OnPageIndexChanging="gv1_PageIndexChanging" OnRowDeleting="gv1_RowDeleting" CssClass="table text-center table-responsive table-striped table-dark" Visible="false">


                <Columns>




                    <asp:TemplateField HeaderText="NOME">

                        <ItemTemplate>
                            <asp:Label runat="server" Text='<%#Eval("nomeUsuario") %>' />
                        </ItemTemplate>

                        <EditItemTemplate>
                            <asp:TextBox ID="txtEmailUsuario" runat="server" MaxLength="50" Text='<%#Eval("nomeUsuario") %>' />
                        </EditItemTemplate>

                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="DATA DA RESERVA">

                        <ItemTemplate>
                            <asp:Label runat="server" Text='<%#Eval("dataReserva" , "{0:dd/MM/yyyy}") %>' />
                        </ItemTemplate>

                        <EditItemTemplate>
                            <asp:TextBox ID="txtDataReserva" runat="server" MaxLength="10" Text='<%#Eval("dataReserva", "{0:dd/MM/yyyy}") %>' />
                            <asp:Calendar ID="calDataReserva" runat="server" Visible="false" SelectionMode="Day" OnSelectionChanged="calDataReserva_SelectionChanged" />
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
                            <asp:ImageButton ID="btnEditar" runat="server" ImageUrl="~/Images/EditarWhite.png" ToolTip="Editar" Width="41" Height="41" CommandName="Edit" />
                            <asp:ImageButton ID="btnExcluir" runat="server" ImageUrl="~/Images/DeleteWhite.png" ToolTip="CANCELAR" Width="36" Height="36" CommandName="Delete" OnClientClick="if (!confirm('Deseja realmente cancelar esta reserva?'))return false" />
                        </ItemTemplate>

                        <EditItemTemplate>
                            <asp:ImageButton ID="btnSalvar" runat="server" ImageUrl="~/Images/UpdateWhite.png" ToolTip="Salvar" Width="30" Height="30" CommandName="Update" />
                            <asp:ImageButton ID="btnCancelar" runat="server" ImageUrl="~/Images/CancelWhite.png" ToolTip="Cancelar" Width="30" Height="30" CommandName="Cancel" />

                        </EditItemTemplate>



                    </asp:TemplateField>





                </Columns>

            </asp:GridView>
            <div class="text-end">
                   <asp:Button ID="btnCadastrar" runat="server" Visible="false" Text="RESERVAR" CssClass="btn py-2 btn-lg mt-0 mx-3 btn-primary rounded" />
            </div>
         


        </div>
    </div>


</asp:Content>
