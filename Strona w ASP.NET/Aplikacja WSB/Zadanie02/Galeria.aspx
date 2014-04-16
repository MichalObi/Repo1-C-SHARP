<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Galeria.aspx.cs" Inherits="Zadanie02.Galeria" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <style type="text/css">
        .auto-style1 {
            font-size: medium;
        }
        .auto-style2 {
            color: #669900;
            font-size: medium;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <p class="auto-style1" style="color: #003300"><strong>Dodaj plik .JPG do Galerii</strong></p>
    <asp:FileUpload ID="FileUpload1" runat="server" Width="275px" Height="54px" BorderColor="#990033" BorderStyle="Solid" ForeColor="#3333CC" />
    <br />
    <br />
    <br />
    <asp:Button ID="Upload" runat="server" Text="Dodaj" Height="50px" OnClick="Upload_Click" Width="150px" />
    <p class="auto-style2"><strong>Galeria dodanych obrazków: </strong> </p>
    <asp:Panel ID="Panel1" runat="server" BorderColor="Red" BorderStyle="Solid" Width="440px">
    </asp:Panel>
</asp:Content>
