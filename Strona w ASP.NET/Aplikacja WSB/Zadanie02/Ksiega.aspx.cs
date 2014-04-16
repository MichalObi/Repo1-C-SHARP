using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;
using System.IO;

namespace Zadanie02
{
    public partial class Ksiega : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
           // Otwieram plik XML
            XDocument doc = XDocument.Load(Server.MapPath("~/datebase.xml"));
            var komentarze = from itm in doc.Descendants("komentarz") select itm; // tworzymy zmienna komentarze do której dodajemy bierzacy komentarz
            StreamWriter stream = new StreamWriter(Server.MapPath("~/datebase.xml"));
            stream.WriteLine("<?xml version=\"1.0\" encoding=\"utf-8\" ?>");
            stream.WriteLine("<komentarze>");

            // od tego momentu do pliku XML dodawany jest ostatnio dodany komentarz

            stream.WriteLine("<komentarz>");
            stream.WriteLine("<nick>" + txtName.Text + "</nick>");
            stream.WriteLine("<email>" + txtEmail.Text + "</email>");
            stream.WriteLine("<wiadomosc>" + txtMessage.Text + "</wiadomosc>");
            stream.WriteLine("</komentarz>");
            // dodawanie starych komentów do pliku XML
            foreach (var item in komentarze)
            {
                stream.WriteLine("<komentarz>");
                stream.WriteLine("<nick>" + item.Descendants("nick").First().Value.ToString() + "</nick>");
                stream.WriteLine("<email>" + item.Descendants("email").First().Value.ToString() + "</email>");
                stream.WriteLine("<wiadomosc>" + item.Descendants("wiadomosc").First().Value.ToString() + "</wiadomosc>");
                stream.WriteLine("</komentarz>");
            }
            //zamykanie pliku
            stream.WriteLine("</komentarze>");// tag zamykający na wyjściu
            stream.Close();// zamyka strumień danych

            // czyszczenie textboxów
            txtName.Text = "";
            txtEmail.Text = "";
            txtMessage.Text = "";
            DataList1.DataBind();
        }
    }
}