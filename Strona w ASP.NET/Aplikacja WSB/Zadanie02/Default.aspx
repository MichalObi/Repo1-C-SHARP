<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Zadanie02._Default" %>
<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
    <link rel="stylesheet" href="http://code.jquery.com/ui/1.10.3/themes/smoothness/jquery-ui.css" />
<script src="http://code.jquery.com/jquery-1.9.1.js"></script>
<script src="http://code.jquery.com/ui/1.10.3/jquery-ui.js"></script>
<link rel="stylesheet" href="/resources/demos/style.css" />
<script> // start js
    $(function () {
        var miasta = [ // funkcja wywołująca zmienną posiadajaca nazwy miast
"Alicante",
"Augustów",
"Barcelona",
"Berlin",
"Bełchatów",
"Bratysława",
"Budapeszt",
"Bukareszt",
"Bydgoszcz",
"Cieszyn",
"Chicago",
"Craiova",
"Dortmund",
"Dzierżoniów",
"Drawsko",
"Ełk",
"Frombork",
"Giżycko",
"Göteborg",
"Gorzów Wielkopolski",
"Hel",
"Hamburg",
"Hanower",
"Iława",
"Inowrocław",
"Jelenia Góra",
"Jurata",
"Kair",
"Kalisz",
"Katowice",
"Krosno",
"Kraków",
"Leszno",
"Londyn",
"Los Angeles",
"Lubin",
"Luboń",
"Łask",
"Łańcut",
"Madryt",
"Mediolan",
"Mikołajki",
"Mława",
"Moskwa",
"Mrągowo",
"Neapol",
"Nowy Jork",
"Nowy Sącz",
"Nakło",
"Niewiadów",
"Olsztyn",
"Olsztynek",
"Opole",
"Orzysz",
"Oslo",
"Paryż",
"Pekin",
"Piła",
"Petersburg",
"Polanica Zdrój",
"Rzeszów",
"Radom",
"Rio de Janeiro",
"San Sebastian",
"Sanok",
"Suwałki",
"Szczecin",
"Świebodzin",
"Tarnów",
"Tokio",
"Toledo",
"Toruń",
"Turawa",
"Ustrzyki Górne",
"Walencia",
"Wałbrzych",
"Wenecja",
"Werona",
"Wrocław",
"Zielona Góra",
"Złotów",
"Żary"
        ];
        $("#miasta").autocomplete({ // funckja autouzupełniająca imput miastami z poprzedniej funkcji/zmiennej
            source: miasta
        });
    });
</script>
    <script type="text/jscript">
        $(function () {
            $(document).tooltip();
        });
</script>
    <style type="text/css"> /*styl dotyczący listy autouzupełnień - wywalić do osobnego pliku*/
        .style1
        {
            width: 82px;
            height: 100px;
        }
        label {
        display: inline-block;
        width: 5em;
        }
        .klasa
        {
        color: Red;
        text-decoration: none; 
        font-style:oblique;
        text-decoration: none;
        border-bottom: 1px solid green;
        }
        .klasa:hover {
        border-bottom-color: blue;
        }
        .underline{
        color: blue;
        border-bottom:1px solid red;
        }
        .auto-style1 {
            text-align: center;
            font-size: 2em;
        }
    </style>
    </asp:Content>
<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <h3 class="auto-style1">Proszę Podać swoje dane</h3>
    <p>&nbsp;</p>
    <p><strong style="font-size: large">Proszę podać Nick: </strong> </p>
    <asp:TextBox ID="nick" runat="server" Height="50px" Width="150px"></asp:TextBox>
    <p><strong style="font-size: large">Proszę podać swoje ulubione miasto: </strong> </p>
    <p>
        <asp:TextBox ID="miasto" runat="server" for="miasta" Height="50px" Width="150px"></asp:TextBox>
    </p>
    &nbsp;<!--Zrobić alert po kliknięciu buttonu - Dodałeś wpiś - sprawdź podstrone --><p><asp:Button ID="Przycisk" runat="server" Text="Wysyłam !" OnClick="Button1_Click" /></p> <!-- mozna porobić to w divach - łatwiejsze pozycjonowanie -->
</asp:Content>    