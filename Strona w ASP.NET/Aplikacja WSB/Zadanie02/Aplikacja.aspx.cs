using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Drawing;
using System.Text;


namespace Zadanie02
{
    public partial class Aplikacja : System.Web.UI.Page
    {
        int NumerDnia;
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Bieżący_Click(object sender, EventArgs e)
        {
            Następny.Enabled = Bieżący.Enabled = true; //odblokowanie buttonow
            DateTime Dzisiaj = DateTime.Now; // zczytanie dzisiejszej daty                                      
            NumerDnia = (int)Dzisiaj.DayOfWeek; // konwertowanie dzisiejszej daty na cyfre od 0-6 po przez rzutowanie 
            ViewState["VS_NumerDnia"] = NumerDnia;

            switch (NumerDnia)   // 6 możliwych przypadków                                                         
            {
                case 0:
                    Label1.Text = "wczoraj: sobota";
                    Label2.Text = "dzisiaj: niedziela"; // int 0
                    Label3.Text = "jutro: poniedziałek";
                    break;
                case 1:
                    Label1.Text = "wczoraj: niedziela";
                    Label2.Text = "dzisiaj: poniedziałek"; // int 1
                    Label3.Text = "jutro: wtorek";
                    break;
                case 2:
                    Label1.Text = "wczoraj: poniedzialek";
                    Label2.Text = "dzisiaj: wtorek"; // int 2
                    Label3.Text = "jutro: sroda";
                    break;
                case 3:
                    Label1.Text = "wczoraj: wtorek";
                    Label2.Text = "dzisiaj: sroda"; // int 3
                    Label3.Text = "jutro: czwartek";
                    break;
                case 4:
                    Label1.Text = "wczoraj: sroda";
                    Label2.Text = "dzisiaj: czwartek"; // int 4
                    Label3.Text = "jutro: piatek";
                    break;
                case 5:
                    Label1.Text = "wczoraj: czwartek";
                    Label2.Text = "dzisiaj: piatek"; // int 5
                    Label3.Text = "jutro: sobota";
                    break;
                case 6:
                    Label1.Text = "wczoraj: piatek";
                    Label2.Text = "dzisiaj: sobota"; // int 6
                    Label3.Text = "jutro: niedziela";
                    break;
            }
        }

        protected void Następny_Click(object sender, EventArgs e)
        {
            NumerDnia = ViewState["VS_NumerDnia"] != null ? Convert.ToInt32(ViewState["VS_NumerDnia"]) : 0;
            NumerDnia++; // dzien nastepny = int wiekszy o 1
            if (NumerDnia > 6) NumerDnia = 0; // dzien tygodnia wiekszy od soboty (6) = przeskok do niedzieli (0)

            ViewState["VS_NumerDnia"] = NumerDnia;

            switch (NumerDnia)
            {
                case 0:
                    Label1.Text = "wczoraj: sobota";
                    Label2.Text = "dzisiaj: niedziela";
                    Label3.Text = "jutro: poniedziałek";
                    break;
                case 1:
                    Label1.Text = "wczoraj: niedziela";
                    Label2.Text = "dzisiaj: poniedziałek";
                    Label3.Text = "jutro: wtorek";
                    break;
                case 2:
                    Label1.Text = "wczoraj: poniedzialek";
                    Label2.Text = "dzisiaj: wtorek";
                    Label3.Text = "jutro: sroda";
                    break;
                case 3:
                    Label1.Text = "wczoraj: wtorek";
                    Label2.Text = "dzisiaj: sroda";
                    Label3.Text = "jutro: czwartek";
                    break;
                case 4:
                    Label1.Text = "wczoraj: sroda";
                    Label2.Text = "dzisiaj: czwartek";
                    Label3.Text = "jutro: piatek";
                    break;
                case 5:
                    Label1.Text = "wczoraj: czwartek";
                    Label2.Text = "dzisiaj: piatek";
                    Label3.Text = "jutro: sobota";
                    break;
                case 6:
                    Label1.Text = "wczoraj: piatek";
                    Label2.Text = "dzisiaj: sobota";
                    Label3.Text = "jutro: niedziela";
                    break;
            }
        }


        protected void Poprzedni_Click(object sender, EventArgs e)
        {
            {
                NumerDnia = ViewState["VS_NumerDnia"] != null ? Convert.ToInt32(ViewState["VS_NumerDnia"]) : 0;
                NumerDnia--; // dzien poprzedni = int mniejszy o 1
                if (NumerDnia < 0) NumerDnia = 6; // jezeli dzien tygodznia mniejszy od niedzieli, powrto do soboty
                ViewState["VS_NumerDnia"] = NumerDnia;
                switch (NumerDnia)
                {
                    case 0:
                        Label1.Text = "wczoraj: sobota";
                        Label2.Text = "dzisiaj: niedziela";
                        Label3.Text = "jutro: poniedziałek";
                        break;
                    case 1:
                        Label1.Text = "wczoraj: niedziela";
                        Label2.Text = "dzisiaj: poniedziałek";
                        Label3.Text = "jutro: wtorek";
                        break;
                    case 2:
                        Label1.Text = "wczoraj: poniedzialek";
                        Label2.Text = "dzisiaj: wtorek";
                        Label3.Text = "jutro: sroda";
                        break;
                    case 3:
                        Label1.Text = "wczoraj: wtorek";
                        Label2.Text = "dzisiaj: sroda";
                        Label3.Text = "jutro: czwartek";
                        break;
                    case 4:
                        Label1.Text = "wczoraj: sroda";
                        Label2.Text = "dzisiaj: czwartek";
                        Label3.Text = "jutro: piatek";
                        break;
                    case 5:
                        Label1.Text = "wczoraj: czwartek";
                        Label2.Text = "dzisiaj: piatek";
                        Label3.Text = "jutro: sobota";
                        break;
                    case 6:
                        Label1.Text = "wczoraj: piatek";
                        Label2.Text = "dzisiaj: sobota";
                        Label3.Text = "jutro: niedziela";
                        break;
                }
            }
        }
    }
}

