using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

namespace Zadanie02.Account
{
    public partial class Registeration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["RejConnectionString"].ConnectionString);//połączenie z bazą
                con.Open(); // otwarcie połączenia
                string cmdStr="Select count(*) from Registration where UserName='" + TextBoxUN.Text + "'";
                SqlCommand userExist = new SqlCommand(cmdStr, con);// użytkownik którego nick już istnieje (pod uwage bierzemy pole TextBoxUN )
                int temp = Convert.ToInt32(userExist.ExecuteScalar().ToString());// konwertowanie Tej samej wartości z userExist na zmienną temp = 1
                con.Close();// Zamykamy połączenie z bazą danych
                if (temp == 1) // jeżeli z naszego konwetrowania wyszła 1 = istnieje już user o takim nicku w bazie
                {
                    Response.Write("Użytkownik o takim Nicku już istnieje.<br /> Wybierz sobie inny Nick.");
                }
            }
        }

        protected void Wyślij_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["RejConnectionString"].ConnectionString);//połączenie z bazą
            con.Open();// otwarcie połączenia
            string insCmd = "Insert into Registration (UserName, Password, EmailAddress, FullName, Country) values (@UserName, @Password, @EmailAddress, @FullName, @Country)";
            SqlCommand insertUser = new SqlCommand(insCmd, con);
            insertUser.Parameters.AddWithValue("@UserName,", TextBoxUN.Text);
            insertUser.Parameters.AddWithValue("@Password", TextBoxPass.Text);
            insertUser.Parameters.AddWithValue("@EmailAddress", TextBoxEA.Text);
            insertUser.Parameters.AddWithValue("@FullName", TextBoxFN.Text);
            insertUser.Parameters.AddWithValue("@Country", DropDownListCountry.SelectedItem.ToString());

            try
            {
                insertUser.ExecuteNonQuery();
                con.Close();
                Response.Redirect("/Account/Login.aspx");
            }

            catch (Exception er)
            {
                Response.Write("<b>Coś poszło nie tak :( Proszę spróbować ponownie</b>");
            }
            finally
            {
                //dodatkowe akcje
   
            }
        }
    }
}
