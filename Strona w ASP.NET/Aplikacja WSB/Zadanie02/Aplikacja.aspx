<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Aplikacja.aspx.cs" Inherits="Zadanie02.Aplikacja" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <style type="text/css">
        .auto-style1 {
            text-align: center;
            
        }
        #kontent {
            margin-left:500px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <h1 class="auto-style1">Aplikacja wyświetlająca bieżącą dzień tygodnia, oraz dzień jutrzejszy i wczorajszy.</h1>
    <div id="kontent">
    <p>
        <asp:Label ID="Label1" runat="server" BorderColor="Blue" BorderStyle="Solid" Width="100px" style="font-weight: 700; color: #000000"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Poprzedni" runat="server" Height="50px" OnClick="Poprzedni_Click" Text="Poprzedni" Font-Bold="True" ForeColor="#0000CC" Width="100px" />
    </p>
    <p>
        <asp:Label ID="Label2" runat="server" BorderColor="Red" BorderStyle="Dotted" Width="100px" style="font-weight: 700; color: #000000"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Bieżący" runat="server" OnClick="Bieżący_Click" Text="Bieżący" Font-Bold="True" ForeColor="Red" Height="50px" Width="100px" />
    </p>
    <p>
        <asp:Label ID="Label3" runat="server" BorderColor="Lime" BorderStyle="Ridge" Width="100px" style="font-weight: 700; color: #000000"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Następny" runat="server" OnClick="Następny_Click" Text="Następny" Font-Bold="True" ForeColor="#33CC33" Height="50px" Width="100px" Enabled="False" />
    </p>
        </div>
</asp:Content>
