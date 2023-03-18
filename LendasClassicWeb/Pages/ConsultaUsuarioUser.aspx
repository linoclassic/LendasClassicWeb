<%@ Page Title="" Language="C#" MasterPageFile="~/DefaultUser.Master" AutoEventWireup="true" CodeBehind="ConsultaUsuarioUser.aspx.cs" Inherits="LendasClassicWeb.Pages.ConsultaUser" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>  

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <asp:Label ID="lblSessionMsg" runat="server" Text="Label" CssClass="h4 text-light   "/>
   
    <asp:GridView runat="server" ID="gv1" AutoGenerateColumns="false" ShowFooter="true" DataKeyNames="idUsuario" OnRowUpdating="gv1_RowUpdating" OnRowEditing="gv1_RowEditing" OnRowCancelingEdit="gv1_RowCancelingEdit"  OnPageIndexChanging="gv1_PageIndexChanging" CssClass="table table-responsive table-striped table-dark mt-5">

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

          <asp:TemplateField HeaderText="Senha">

               <ItemTemplate>
                  <asp:Label runat="server" Text='<%#Eval("senhaUsuario") %>' />
               </ItemTemplate>
              
               <EditItemTemplate>
                    <asp:TextBox ID="txtSenhaUsuario" runat="server" MaxLength="4" Text='<%#Eval("senhaUsuario") %>' />
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

          <asp:TemplateField HeaderText="Telefone">

               <ItemTemplate>
                  <asp:Label runat="server" Text='<%#Eval("telefoneUsuario") %>' />
               </ItemTemplate>
              
               <EditItemTemplate>
                    <asp:TextBox ID="txtTelefoneUsuario" runat="server" MaxLength="50" Text='<%#Eval("telefoneUsuario") %>' />
               </EditItemTemplate>

           


           </asp:TemplateField>  

                 <%--Opções--%>        
          <asp:TemplateField HeaderText="Opções">

               <ItemTemplate>
                   <asp:ImageButton ID="btnEditar" runat="server" ImageUrl="~/Images/EditarWhite.png" ToolTip="Editar" Width="41" Height="41" CommandName="Edit"/> 
               </ItemTemplate>
              
               <EditItemTemplate>
                      <asp:ImageButton ID="btnSalvar" runat="server" ImageUrl="~/Images/UpdateWhite.png" ToolTip="Salvar" Width="30" Height="30" CommandName="Update"/>
                      <asp:ImageButton ID="btnCancelar" runat="server" ImageUrl="~/Images/CancelWhite.png" ToolTip="Cancelar" Width="30" Height="30" CommandName="Cancel"/>
               </EditItemTemplate>

               <FooterTemplate>
                    
               </FooterTemplate>


           </asp:TemplateField> 
          

        </Columns>

        </asp:GridView>
     <br />
    <asp:Label ID="lblMessage" runat="server" Text="Label" />s

</asp:Content>




