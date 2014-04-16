<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Galeria02.aspx.cs" Inherits="Zadanie02.Galeria02" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Button ID="Button1" runat="server" Text="Powrót do Galerii" OnClick="Button1_Click" />
    <br /><br />
    <asp:Image ID="Image1" runat="server" />
    <br /><br />
    <asp:Button ID="Button2" runat="server" Text="Powrót do Galerii" OnClick="Button1_Click" />
</asp:Content>
