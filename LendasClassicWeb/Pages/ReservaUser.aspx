<%@ Page Title="" Language="C#" MasterPageFile="~/DefaultUser.Master" AutoEventWireup="true" CodeBehind="ReservaUser.aspx.cs" Inherits="LendasClassicWeb.Pages.RservaUser" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <br />
    <asp:Label ID="lblMensagem" runat="server" Text="Label" CssClass=" bg-dark text-center h4 text-light py-2" Visible="false" />
      <br />
      <br />  <br />   <br />     
    <asp:Label ID="lblNot" runat="server" Text="Label" CssClass="  card bg-transparent border-0 text-center h2 text-light py-0 pb-4 my-5 mb-0 " Visible="false" />
    <div class="container-fluid text-center">
        <asp:Label ID="lblPergunta" runat="server" Text="Label" CssClass=" h4 mx-2 text-light" Visible="false" />
        <br />
        <asp:Button ID="btnNovaReserva" runat="server" OnClick="btnNovaReserva_Click" Text="RESERVAR" CssClass="btn btn-primary px-4 py-3 mt-3" Visible="false" />
        <br />
        <br />
    </div>

    <%--  <asp:Label ID="lblPergunta" runat="server" Text="Label" CssClass=" h5 mx-2 text-light" Visible="false" />
    <br />
    <asp:Button ID="btnNovaReserva" runat="server" OnClick="btnNovaReserva_Click" Text="RESERVAR" CssClass="btn btn-primary px-5 py-3 mx-3 mt-3" Visible="false" />--%>



    <asp:GridView runat="server" ID="gv1" AutoGenerateColumns="false" ShowFooter="true" DataKeyNames="idUsuario" OnRowUpdating="gv1_RowUpdating" OnRowEditing="gv1_RowEditing" OnRowCancelingEdit="gv1_RowCancelingEdit" OnPageIndexChanging="gv1_PageIndexChanging" CssClass="table table-responsive table-striped table-dark" Visible="false">

        <Columns>


     

            <asp:TemplateField HeaderText="Email">

                <ItemTemplate>
                    <asp:Label runat="server" Text='<%#Eval("emailUsuario") %>' />
                </ItemTemplate>

                <%--                <EditItemTemplate>
                    <asp:TextBox ID="txtEmailUsuario" runat="server" MaxLength="50" Text='<%#Eval("emailUsuario") %>' />
                </EditItemTemplate>--%>

            </asp:TemplateField>

            <asp:TemplateField HeaderText="Data Da Reserva">

                <ItemTemplate>
                    <asp:Label runat="server" Text='<%#Eval("dataReserva") %>' />
                </ItemTemplate>

                <EditItemTemplate>
                    <asp:TextBox ID="txtDataReserva" runat="server" MaxLength="10" Text='<%#Eval("dataReserva", "{0:dd/MM/yyyy}") %>' />
                    <asp:Calendar ID="calDataReserva" runat="server" Visible="false" SelectionMode="Day" OnSelectionChanged="calDataReserva_SelectionChanged" />
                </EditItemTemplate>
                <%--  <FooterTemplate>
                    <asp:TextBox ID="txtDataReservaFooter" runat="server" />
                </FooterTemplate>--%>

            </asp:TemplateField>

            <asp:TemplateField HeaderText="Status da Reserva">

                <ItemTemplate>
                    <asp:Label runat="server" Text='<%#Eval("statusReserva") %>' />
                </ItemTemplate>

                <%-- <EditItemTemplate>
                    <asp:TextBox ID="txtStatusReserva" runat="server" MaxLength="50" Text='<%#Eval("statusReserva") %>' />
                </EditItemTemplate>--%>
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
