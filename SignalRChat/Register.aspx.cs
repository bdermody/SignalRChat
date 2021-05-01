using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SignalRChat
{
    public partial class Register : System.Web.UI.Page
    {
        public string connection = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void InsertUser(object sender, EventArgs e)
        {

            using (SqlConnection c = new SqlConnection(connection))
            {
                SqlCommand cmd = new SqlCommand("InsertUser", c);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@user", txtUserId.Text.ToString());
                cmd.Parameters.AddWithValue("@password", txtPassword.Text.ToString());
                c.Open();
                cmd.ExecuteNonQuery();
                Response.Redirect("~/Login.aspx");

            }


        }
    }
}