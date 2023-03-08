<%@ Page Title="" Language="C#" MasterPageFile="~/DefaultAdm.Master" AutoEventWireup="true" CodeBehind="ManagerUsuarioADM.aspx.cs" Inherits="LendasClassicWeb.Pages.ManagerUsuarioADM" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <asp:Label ID="lblSessionMsg" runat="server" CssClass="h4"/>

   <asp:GridView runat="server" ID="gv1" AutoGenerateColumns="false" ShowFooter="true" DataKeyNames="idUsuario" OnRowCommand="gv1_RowCommand" OnRowUpdating="gv1_RowUpdating" OnRowDeleting="gv1_RowDeleting" OnRowEditing="gv1_RowEditing" OnRowCancelingEdit="gv1_RowCancelingEdit" AllowSorting="true" AllowPaging="true" PageSize="10" OnPageIndexChanging="gv1_PageIndexChanging" CssClass="table  table-dark table-responsive table-striped mt-5">
       <Columns>
          <asp:TemplateField HeaderText="Nome">

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
          <asp:TemplateField HeaderText="Tipo Usuario">

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

        <asp:TemplateField HeaderText="Status">

               <ItemTemplate>
                  <asp:Label runat="server" Text='<%#Eval("statusUsuario") %>' />
               </ItemTemplate>
              
               <EditItemTemplate>
                    <asp:TextBox ID="txtStatusUsuario" runat="server" MaxLength="7" Text='<%#Eval("statusUsuario") %>' AutoPostBack="True" OnTextChanged="txtStatusUsuario_TextChanged"/>
               </EditItemTemplate>

               <FooterTemplate>
                      <asp:TextBox ID="txtStatusUsuarioFooter" runat="server" MaxLength="7" AutoPostBack="True" OnTextChanged="txtStatusUsuarioFooter_TextChanged" />
               </FooterTemplate>


           </asp:TemplateField>


          <asp:TemplateField HeaderText="Email">

               <ItemTemplate>
                  <asp:Label runat="server" Text='<%#Eval("emailUsuario") %>' />
               </ItemTemplate>
              
               <EditItemTemplate>
                    <asp:TextBox ID="txtEmailUsuario" runat="server" MaxLength="50" Text='<%#Eval("emailUsuario") %>' />
               </EditItemTemplate>

               <FooterTemplate>
                      <asp:TextBox ID="txtEmailUsuarioFooter"  runat="server" />
               </FooterTemplate>


           </asp:TemplateField>

          <asp:TemplateField HeaderText="Senha">

               <ItemTemplate>
                  <asp:Label runat="server" Text='<%#Eval("senhaUsuario") %>' />
               </ItemTemplate>
              
               <EditItemTemplate>
                    <asp:TextBox ID="txtSenhaUsuario" runat="server" MaxLength="4" Text='<%#Eval("senhaUsuario") %>' />
               </EditItemTemplate>

               <FooterTemplate>
                      <asp:TextBox ID="txtSenhaUsuarioFooter" runat="server" MaxLength="4" />
               </FooterTemplate>


           </asp:TemplateField>

          <asp:TemplateField HeaderText="Cpf">

               <ItemTemplate>
                  <asp:Label runat="server" Text='<%#Eval("cpfUsuario") %>' />
               </ItemTemplate>
              
               <EditItemTemplate>
                    <asp:TextBox ID="txtCpfUsuario" runat="server" MaxLength="14" Text='<%#Eval("cpfUsuario") %>' />
               </EditItemTemplate>

               <FooterTemplate>
                      <asp:TextBox ID="txtCpfUsuarioFooter" runat="server"  MaxLength="14"/>
               </FooterTemplate>


           </asp:TemplateField>  

          <asp:TemplateField HeaderText="Telefone">

               <ItemTemplate>
                  <asp:Label runat="server" Text='<%#Eval("telefoneUsuario") %>' />
               </ItemTemplate>
              
               <EditItemTemplate>
                    <asp:TextBox ID="txtTelefoneUsuario" runat="server" MaxLength="50" Text='<%#Eval("telefoneUsuario") %>' />
               </EditItemTemplate>

               <FooterTemplate>
                      <asp:TextBox ID="txtTelefoneUsuarioFooter" runat="server" MaxLength="14"/>
               </FooterTemplate>


           </asp:TemplateField>  

                 <%--Opções--%>        
          <asp:TemplateField HeaderText="Opções">

               <ItemTemplate>
                   <asp:ImageButton ID="btnEditar" runat="server" ImageUrl="~/Images/Editar60.png" ToolTip="Editar" Width="40" Height="40" CommandName="Edit"/>
                   <asp:ImageButton ID="btnExcluir" runat="server" ImageUrl="~/Images/DeleteUser60.png" ToolTip="Excluir" Width="40" Height="40" CommandName="Delete" OnClientClick="if (!confirm('Deseja realmente eliminar este registro?'))return false"/>
               </ItemTemplate>
              
               <EditItemTemplate>
                      <asp:ImageButton ID="btnSalvar" runat="server" ImageUrl="~/Images/Salvar60.png" ToolTip="Salvar" Width="40" Height="40" CommandName="Update"/>
                      <asp:ImageButton ID="btnCancelar" runat="server" ImageUrl="~/Images/Cancelar60.png" ToolTip="Cancelar" Width="40" Height="40" CommandName="Cancel"/>
               </EditItemTemplate>

               <FooterTemplate>
                     <asp:ImageButton ID="btnAdicionar" runat="server" ImageUrl="~/Images/AddUser60.png" ToolTip="Adicionar" Width="40" Height="40" CommandName="Add"/>
               </FooterTemplate>


           </asp:TemplateField> 

       </Columns>

   </asp:GridView>
    <br />
    <asp:Label ID="lblMessage" runat="server" Text="Label" />
</asp:Content>
