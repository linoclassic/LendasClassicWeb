<%@ Page Title="" Language="C#" MasterPageFile="~/DefaultAdm.Master" AutoEventWireup="true" CodeBehind="ManagerUsuarioADM.aspx.cs" Inherits="LendasClassicWeb.Pages.ManagerUsuarioADM" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

   <asp:GridView runat="server" ID="gv1" AutoGenerateColumns="false" ShowFooter="true" DataKeyNames="IdCliente" OnRowCommand="gv1_RowCommand" OnRowUpdating="gv1_RowUpdating" OnRowDeleting="gv1_RowDeleting" OnRowEditing="gv1_RowEditing" OnRowCancelingEdit="gv1_RowCancelingEdit">

       <Columns>

          <asp:TemplateField HeaderText="Nome">

               <ItemTemplate>
                  <asp:Label runat="server" Text='<%#Eval("NomeCliente") %>' />
               </ItemTemplate>
              
               <EditItemTemplate>
                    <asp:TextBox ID="txtNomeUsuario" runat="server" MaxLength="50" Text='<%#Eval("NomeCliente") %>' />
               </EditItemTemplate>

               <FooterTemplate>
                      <asp:TextBox ID="txtNomeUsuarioFooter" runat="server" />
               </FooterTemplate>


           </asp:TemplateField>

                         <%--radiobutton--%>
          <asp:TemplateField HeaderText="Tipo Usuario">

               <ItemTemplate>
                  <asp:Label runat="server" Text='<%#Eval("FkTpUsuario") %>' />
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

          <asp:TemplateField HeaderText="Status">

               <ItemTemplate>
                  <asp:Label runat="server" Text='<%#Eval("StatusCliente") %>' />
               </ItemTemplate>
              
               <EditItemTemplate>
                    <asp:TextBox ID="txtStatusUsuario" runat="server" MaxLength="50" Text='<%#Eval("StatusCliente") %>' />
               </EditItemTemplate>

               <FooterTemplate>
                      <asp:TextBox ID="txtStatusfUsuarioFooter" runat="server" />
               </FooterTemplate>


           </asp:TemplateField>   

          <asp:TemplateField HeaderText="Email">

               <ItemTemplate>
                  <asp:Label runat="server" Text='<%#Eval("EmailCliente") %>' />
               </ItemTemplate>
              
               <EditItemTemplate>
                    <asp:TextBox ID="txtEmailUsuario" runat="server" MaxLength="50" Text='<%#Eval("EmailCliente") %>' />
               </EditItemTemplate>

               <FooterTemplate>
                      <asp:TextBox ID="txtEmailUsuarioFooter" runat="server" />
               </FooterTemplate>


           </asp:TemplateField>

          <asp:TemplateField HeaderText="Senha">

               <ItemTemplate>
                  <asp:Label runat="server" Text='<%#Eval("SenhaCliente") %>' />
               </ItemTemplate>
              
               <EditItemTemplate>
                    <asp:TextBox ID="txtSenhaUsuario" runat="server" MaxLength="50" Text='<%#Eval("SenhaCliente") %>' />
               </EditItemTemplate>

               <FooterTemplate>
                      <asp:TextBox ID="txtSenhaUsuarioFooter" runat="server" />
               </FooterTemplate>


           </asp:TemplateField>

          <asp:TemplateField HeaderText="Cpf">

               <ItemTemplate>
                  <asp:Label runat="server" Text='<%#Eval("CpfCliente") %>' />
               </ItemTemplate>
              
               <EditItemTemplate>
                    <asp:TextBox ID="txtCpfUsuario" runat="server" MaxLength="50" Text='<%#Eval("CpfCliente") %>' />
               </EditItemTemplate>

               <FooterTemplate>
                      <asp:TextBox ID="txtCpfUsuarioFooter" runat="server" />
               </FooterTemplate>


           </asp:TemplateField>  

          <asp:TemplateField HeaderText="Telefone">

               <ItemTemplate>
                  <asp:Label runat="server" Text='<%#Eval("TelefoneCliente") %>' />
               </ItemTemplate>
              
               <EditItemTemplate>
                    <asp:TextBox ID="txtTelefoneUsuario" runat="server" MaxLength="50" Text='<%#Eval("TelefoneCliente") %>' />
               </EditItemTemplate>

               <FooterTemplate>
                      <asp:TextBox ID="txtTelefoneUsuarioFooter" runat="server" />
               </FooterTemplate>


           </asp:TemplateField>  

          <asp:TemplateField HeaderText="Cidade">

               <ItemTemplate>
                  <asp:Label runat="server" Text='<%#Eval("CidadeCliente") %>' />
               </ItemTemplate>
              
               <EditItemTemplate>
                    <asp:TextBox ID="txtCidadeUsuario" runat="server" MaxLength="50" Text='<%#Eval("CidadeCliente") %>' />
               </EditItemTemplate>

               <FooterTemplate>
                      <asp:TextBox ID="txtCidadeUsuarioFooter" runat="server" />
               </FooterTemplate>


           </asp:TemplateField>  

          <asp:TemplateField HeaderText="Estado">

               <ItemTemplate>
                  <asp:Label runat="server" Text='<%#Eval("EstadoCliente") %>' />
               </ItemTemplate>
              
               <EditItemTemplate>
                    <asp:TextBox ID="txtEstadoUsuario" runat="server" MaxLength="50" Text='<%#Eval("EstadoCliente") %>' />
               </EditItemTemplate>

               <FooterTemplate>
                      <asp:TextBox ID="txtEstadoUsuarioFooter" runat="server" />
               </FooterTemplate>


           </asp:TemplateField>

          <asp:TemplateField HeaderText="Bairro">

               <ItemTemplate>
                  <asp:Label runat="server" Text='<%#Eval("BairroCliente") %>' />
               </ItemTemplate>
              
               <EditItemTemplate>
                    <asp:TextBox ID="txtBairroUsuario" runat="server" MaxLength="50" Text='<%#Eval("BairroCliente") %>' />
               </EditItemTemplate>

               <FooterTemplate>
                      <asp:TextBox ID="txtBairroUsuarioFooter" runat="server" />
               </FooterTemplate>


           </asp:TemplateField>  

          <asp:TemplateField HeaderText="Endereço">

               <ItemTemplate>
                  <asp:Label runat="server" Text='<%#Eval("EnderecoCliente") %>' />
               </ItemTemplate>
              
               <EditItemTemplate>
                    <asp:TextBox ID="txtEnderecoUsuario" runat="server" MaxLength="50" Text='<%#Eval("EnderecoCliente") %>' />
               </EditItemTemplate>

               <FooterTemplate>
                      <asp:TextBox ID="txtEnderecoUsuarioFooter" runat="server" />
               </FooterTemplate>


           </asp:TemplateField>  
        
          <asp:TemplateField HeaderText="Número">

               <ItemTemplate>
                  <asp:Label runat="server" Text='<%#Eval("NumeroCliente") %>' />
               </ItemTemplate>
              
               <EditItemTemplate>
                    <asp:TextBox ID="txtNumeroUsuario" runat="server" MaxLength="50" Text='<%#Eval("NumeroCliente") %>' />
               </EditItemTemplate>

               <FooterTemplate>
                      <asp:TextBox ID="txtNumeroUsuarioFooter" runat="server" />
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
