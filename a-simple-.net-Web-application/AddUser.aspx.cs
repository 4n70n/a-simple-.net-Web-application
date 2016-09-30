using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnAdd_Click(object sender, EventArgs e)
    {
        // string connectionString = @"server=.\MARK;database=BookShop;uid=sa;pwd=123456";
        string connectionString = "Data Source=.\\SQLEXPRESS;AttachDbFilename=|DataDirectory|\\BookShop.mdf;Integrated Security=True;User Instance=True";
        SqlConnection connection = new SqlConnection(connectionString);
        connection.Open();
        string sql1 = "select UserName from [User] where UserName='txtUserName.Text'";
        SqlCommand cmm = new SqlCommand(sql1, connection);
    }
}