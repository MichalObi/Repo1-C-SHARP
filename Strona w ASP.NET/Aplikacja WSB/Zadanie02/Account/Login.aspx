<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Zadanie02.Account.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <style type="text/css">
        .auto-style1 {
            text-align: center;
        }
        .auto-style2 {
            width: 100%;
        }
        .auto-style3 {
            width: 119px;
        }
        .auto-style4 {
            width: 119px;
            text-align: center;
        }
        .auto-style5 {
            width: 119px;
            height: 25px;
        }
        .auto-style6 {
            height: 25px;
        }
        .auto-style7 {
            width: 185px;
        }
        .auto-style8 {
            height: 25px;
            width: 185px;
        }
        .auto-style9 {
            font-size: medium;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <div class="auto-style1">

        <strong><span class="auto-style9">Login

        </span></strong>

        <br />
        <br />
        <asp:Label ID="Label1" runat="server" Text="Label" Visible="False"></asp:Label>

    </div>

    <table class="auto-style2">
        <tr>
            <td class="auto-style4"><strong>Nick</strong></td>
            <td class="auto-style7">
                <asp:TextBox ID="TextBox1" runat="server" MaxLength="15" Width="180px"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="Prosze podać Nick" ForeColor="Red" style="font-style: italic"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style4"><strong>Hasło</strong></td>
            <td class="auto-style7">
                <asp:TextBox ID="TextBox2" runat="server" MaxLength="15" TextMode="Password" Width="180px"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox2" ErrorMessage="Prosze podać Hasło" ForeColor="Red" style="font-style: italic"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style5"></td>
            <td class="auto-style8">
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Login" Width="100px" />
            </td>
            <td class="auto-style6"></td>
        </tr>
        <tr>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style7">&nbsp;</td>
            <td>
                <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Account/Registration.aspx" ForeColor="#660033">Rejestracja dla Nowych</asp:HyperLink>
            </td>
        </tr>
    </table>

</asp:Content>
