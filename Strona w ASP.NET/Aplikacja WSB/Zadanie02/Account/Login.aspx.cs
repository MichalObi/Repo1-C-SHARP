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
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["RejConnectionString"].ConnectionString);//połączenie z bazą
            con.Open();// otwarcie połączenia
            string cmdStr = "Select count(*) from Registration where UserName='" +TextBox1.Text + "'";
            SqlCommand Checkuser = new SqlCommand(cmdStr, con);
            int temp=Convert.ToInt32(Checkuser.ExecuteScalar().ToString());
            if (temp == 1)
            {
                string cmdStr2= "Select Password from Registration where UserName='" + TextBox1.Text + "'";
                SqlCommand pass = new SqlCommand(cmdStr2, con);
                string password = pass.ExecuteScalar().ToString();
                con.Close();
                if (password == TextBox2.Text)// prawidłowe hasło
                {
                    Session["New"] = TextBox1.Text;
                    Response.Redirect("Secure.aspx");
                }
                else
                {
                    Label1.Visible = true;
                    Label1.Text = "Hasło nieprawidłowe !!!";
                }
            }
                else 
                {
                    Label1.Visible = true;
                    Label1.Text = "Nieprawidłowy Nick !!!";
                }
            }

        }

    }
