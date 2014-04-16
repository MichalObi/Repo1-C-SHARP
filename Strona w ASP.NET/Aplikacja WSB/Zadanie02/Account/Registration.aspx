<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Registration.aspx.cs" Inherits="Zadanie02.Account.Registeration" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            text-align: right;
            width: 315px;
            font-size: medium;
        }
        .auto-style3 {
            width: 456px;
            text-align: center;
        }
    .auto-style4 {
        background-color: #FFFF99;
    }
        .auto-style5 {
            text-align: center;
        }
        .auto-style6 {
            text-align: right;
            width: 315px;
            height: 48px;
            font-size: medium;
        }
        .auto-style7 {
            width: 456px;
            text-align: center;
            height: 48px;
        }
        .auto-style8 {
            text-align: center;
            height: 48px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
    <div style="text-align: center; font-size: x-large;" class="auto-style4">
        Rejestracja
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">

    <table class="auto-style1">
        <tr>
            <td class="auto-style2"><strong>Nick</strong></td>
            <td class="auto-style3">
                <asp:TextBox ID="TextBoxUN" runat="server" MaxLength="15" Width="180px" BorderColor="#996600" BorderStyle="Solid"></asp:TextBox>
            </td>
            <td class="auto-style5">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBoxUN" ErrorMessage="Podaj swój Nick" ForeColor="Red" style="font-style: italic"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style6"><strong>Hasło</strong></td>
            <td class="auto-style7">
                <asp:TextBox ID="TextBoxPass" runat="server" MaxLength="15" TextMode="Password" Width="180px" BorderColor="#996600" BorderStyle="Solid"></asp:TextBox>
            </td>
            <td class="auto-style8">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBoxPass" ErrorMessage="Podaj Hasło" ForeColor="Red" style="font-style: italic"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style2"><strong>Powtórz Hasło</strong></td>
            <td class="auto-style3">
                <asp:TextBox ID="TextBoxRPass" runat="server" MaxLength="15" TextMode="Password" Width="180px" BorderColor="#996600" BorderStyle="Solid"></asp:TextBox>
            </td>
            <td class="auto-style5">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TextBoxRPass" ErrorMessage="Podaj Hasło Ponownie" ForeColor="Red" style="font-style: italic"></asp:RequiredFieldValidator>
                <br />
                <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="TextBoxPass" ControlToValidate="TextBoxRPass" ErrorMessage="Hasła muszą być identyczne " ForeColor="Red" style="font-style: italic"></asp:CompareValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style2"><strong>Adres E-mail</strong></td>
            <td class="auto-style3">
                <asp:TextBox ID="TextBoxEA" runat="server" MaxLength="50" Width="180px" BorderColor="#996600" BorderStyle="Solid"></asp:TextBox>
            </td>
            <td class="auto-style5">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="TextBoxEA" ErrorMessage="Podaj Adres E-mail" ForeColor="Red" style="font-style: italic"></asp:RequiredFieldValidator>
                <br />
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="TextBoxEA" ErrorMessage="Proszę wprowadzić prawidłowy adres mail" ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" style="font-style: italic"></asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style2"><strong>Imie</strong> </td>
            <td class="auto-style3">
                <asp:TextBox ID="TextBoxFN" runat="server" MaxLength="50" Width="180px" BorderColor="#996600" BorderStyle="Solid"></asp:TextBox>
            </td>
            <td class="auto-style5">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="TextBoxFN" ErrorMessage="Podaj swoje imie" ForeColor="Red" style="font-style: italic"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style2"><strong>Państwo</strong></td>
            <td class="auto-style3">
                <asp:DropDownList ID="DropDownListCountry" runat="server" Width="180px">
                    <asp:ListItem Selected="True">Wybierz Kraj</asp:ListItem>
                    <asp:ListItem>Polska</asp:ListItem>
                    <asp:ListItem>Niemcy</asp:ListItem>
                    <asp:ListItem>Anglia</asp:ListItem>
                    <asp:ListItem>Francja</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td class="auto-style5">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="DropDownListCountry" ErrorMessage="Wybierz Kraj" ForeColor="Red" InitialValue="Wybierz Kraj" style="font-style: italic"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style3">
                <asp:Button ID="Wyślij" runat="server" OnClick="Wyślij_Click" Text="Wyślij" />
                <input id="Reset1" type="reset" value="Reset" /></td>
            <td class="auto-style5">&nbsp;</td>
        </tr>
    </table>

</asp:Content>
