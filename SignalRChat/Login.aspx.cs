using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace SignalRChat
{
    public partial class Login : System.Web.UI.Page
    {
        public string connection = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(connection);
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "sp_login";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@UserId", txtUserId.Text.ToString());
                cmd.Parameters.AddWithValue("@Password", txtPassword.Text.ToString());
                cmd.Connection = con;
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    Session["UserId"] = txtUserId.Text.ToString();
                    txtInfo.Text = "Inicio de sesión exitoso";

                    reader.Close();
                    con.Close();

                    Response.Redirect("~/Index.aspx");
                }
                else
                {
                    txtInfo.Text = "Contraseña o usuario incorrectos";
                }

                reader.Close();

                con.Close();

            }
            catch (Exception ex)
            {
                Console.Out.WriteLine(ex.ToString());
            }
        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Register.aspx");
        } 
    }
}