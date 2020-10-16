<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="PortalEscola.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
        <div class="row">
            <asp:Label ID="lblHora" runat="server"></asp:Label>
        </div>
        <div class="row">
            <asp:Label ID="lblUsuario" Text="Usuario" runat="server"></asp:Label>
            <asp:TextBox ID="txtUsuario" runat="server"></asp:TextBox>
        </div>          
        <div class="row">
            <asp:Label ID="lblSenha" Text="Senha" runat="server">
            </asp:Label>
            <asp:TextBox ID="txtSenha" runat="server" TextMode="Password"></asp:TextBox>
        </div>
        <div class="row">
            <asp:Button ID="btnLogar"  runat="server" TextMode="Button" OnClick="btnLogar_Click" Text="Logar" ></asp:Button>
        </div>
        <div class="row">
            <asp:Label ID="lblResultado" runat="server" TextMode="Label"></asp:Label>
        </div>
    </div>
</asp:Content>
