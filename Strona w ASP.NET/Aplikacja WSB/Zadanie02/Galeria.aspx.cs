using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

namespace Zadanie02
{
    public partial class Galeria : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            UploadImage();// zaznaczyłem pętle foreach ppm refaktoryzuj wyodrębnij metodę
        }

        protected void Upload_Click(object sender, EventArgs e)
        {
            if (FileUpload1.HasFile) // upload obrazka do folderu 
            {
                string fileName = FileUpload1.FileName; // nazwa nowego obrazka = nazwa uploadowanego pliku
                FileUpload1.PostedFile.SaveAs(Server.MapPath("~/Obrazki/" + fileName)); // zapis w folderze
            }
            Response.Redirect("~/Galeria.aspx");
        }

        private void UploadImage()
        {

            foreach (string strFileName in Directory.GetFiles(Server.MapPath("~/Obrazki/"))) // dla każdego pliku w folderze 
            {
                ImageButton imageButton = new ImageButton();// Kontrola ImageButton pozwala na "klikalność" buttonów
                FileInfo fileInfo = new FileInfo(strFileName); // fileInfo - nazwa pliku
                imageButton.ImageUrl = "~/Obrazki/" + fileInfo.Name; // "klikalność" obrazka 
                imageButton.Width = Unit.Pixel(100); //zdefiniowana na sztywno (statycznie) szerokość ...
                imageButton.Height = Unit.Pixel(100);// i wysokość 
                imageButton.Style.Add("padding", "5px");// odległość między poszczególnymi obrazkami
                imageButton.Click += new ImageClickEventHandler(imageButton_Click); // po kliknięciu na obrazek
                Panel1.Controls.Add(imageButton);// wyświetla obrazki w panelu 
            }
        }

        void imageButton_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("~/Galeria02.aspx?ImageURL=" + ((ImageButton)sender).ImageUrl);
        }
    }
}