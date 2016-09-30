using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class MultilineUserQuery : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string connectionString = "Data Source=.\\SQLEXPRESS;AttachDbFilename=|DataDirectory|\\BookShop.mdf;Integrated Security=True;User Instance=True";
        SqlConnection connection = new SqlConnection(connectionString);
        connection.Open();
        string sql = "select * from [User]";
        SqlCommand cmm = new SqlCommand(sql, connection);
        SqlDataAdapter da = new SqlDataAdapter(cmm);
        DataSet ds = new DataSet();
        da.Fill(ds);
        this.GridView1.DataSource = ds.Tables[0];
        this.GridView1.DataBind();
        connection.Close();
    }
    protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        string connectionString = "Data Source=.\\SQLEXPRESS;AttachDbFilename=|DataDirectory|\\BookShop.mdf;Integrated Security=True;User Instance=True";
        SqlConnection connection = new SqlConnection(connectionString);
        connection.Open();
        string sql = "delete from [User] where UserId=@UserId";
        SqlCommand cmm = new SqlCommand(sql, connection);
        Int32 userId = Convert.ToInt32(this.GridView1.DataKeys[e.RowIndex].Value);
        cmm.Parameters.Add(new SqlParameter("@UserId", userId));       
        cmm.ExecuteNonQuery();
        connection.Close();
        this.Response.Redirect("MultilineUserQuery.aspx");
    }
}