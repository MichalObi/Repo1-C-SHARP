<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Ksiega.aspx.cs" Inherits="Zadanie02.Ksiega" %>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <div>
        <h1 class="auto-style2">Napisz, co sadzisz o mojej stronie :)</h1>
        <table>
            <tr><td class="auto-style1"><strong>Nick: 
                </strong> 
                <br />
                <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
                </td></tr>
            <tr><td class="auto-style1"><strong>Email: 
                </strong> 
                <br />
                <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
                </td></tr>
            <tr><td class="auto-style1"><strong>Opinia: 
                </strong> 
                <br />
                <asp:TextBox ID="txtMessage" runat="server" Height="67px" TextMode="MultiLine" Width="152px"></asp:TextBox>
                </td></tr>
            <tr><td>
                <asp:Button ID="Button1" runat="server" Text="Wyslij " OnClick="Button1_Click" /></td></tr>
        </table>
        <p class="auto-style3"><strong>Wasze komentarze:</strong></p>
        <asp:DataList ID="DataList1" runat="server" DataSourceID="XmlDataSource1" Height="99px" Width="277px" CellPadding="4" ForeColor="#333333">
            <AlternatingItemStyle BackColor="White" ForeColor="#284775" />        
                        <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <ItemStyle BackColor="#F7F6F3" ForeColor="#333333" />
                        <ItemTemplate>
                        <table border="1">
                            <tr><td>Wiadomosc: <%#XPath("wiadomosc") %></td></tr> <!-- zczytywanie informacji zapisanych w pliku XML -->
                            <tr><td>Nick: <B><%#XPath("nick") %></B>(<%#XPath("email") %>)</td></tr>
                        </table>
                    </ItemTemplate>
            <SelectedItemStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
        </asp:DataList>
        <asp:XmlDataSource ID="XmlDataSource1" runat="server" DataFile="~/datebase.xml" XPath="komentarze/komentarz"></asp:XmlDataSource>
    </div>
</asp:Content>
<asp:Content ID="Content4" runat="server" contentplaceholderid="HeadContent">
    <style type="text/css">
        .auto-style1 {
            width: 246px;
            text-align: left;
        }
        .auto-style2 {
            text-align: center;
        }
        .auto-style3 {
            font-size: medium;
        }
    </style>
</asp:Content>

