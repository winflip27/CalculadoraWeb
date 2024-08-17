<%@ Page Title="" Language="C#" MasterPageFile="~/Vistas/LoginMaestra.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="CalculadoraWeb.Vistas.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Iniciar Sesión</h2>
    <asp:Label ID="lblMensaje" runat="server" ForeColor="Red"></asp:Label>
    <br />
    <asp:TextBox ID="txtUsuario" runat="server" Placeholder="Correo Electrónico"></asp:TextBox>
    <br />
    <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" Placeholder="Contraseña"></asp:TextBox>
    <br />
    <asp:Button ID="btnLogin" runat="server" Text="Iniciar Sesión" OnClick="btnLogin_Click" />
</asp:Content>
