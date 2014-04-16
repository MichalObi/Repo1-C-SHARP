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
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Write("Wpis dodany. Zobacz zakładkę BAZA");
            XDocument doc = XDocument.Load(Server.MapPath("~/baza.xml"));
            var komentarze = from itm in doc.Descendants("komentarz") select itm;
            StreamWriter stream = new StreamWriter(Server.MapPath("~/baza.xml"));
            stream.WriteLine("<?xml version=\"1.0\" encoding=\"utf-8\" ?>");
            stream.WriteLine("<komentarze>");

            stream.WriteLine("<komentarz>");
            stream.WriteLine("<nick>" + nick.Text + "</nick>");
            stream.WriteLine("<miasto>" + miasto.Text + "</miasto>");
            stream.WriteLine("</komentarz>");

            foreach (var item in komentarze)
            {
                stream.WriteLine("<komentarz>");
                stream.WriteLine("<nick>" + item.Descendants("nick").First().Value.ToString()  + "</nick>");
                stream.WriteLine("<miasto>" + item.Descendants("miasto").First().Value.ToString() + "</miasto>");
                stream.WriteLine("</komentarz>");
            }

            stream.WriteLine("</komentarze>");
            stream.Close();
            nick.Text = "";
            miasto.Text = "";
            
        }
    }
}