using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class SingleUserQuery : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnQuery_Click(object sender, EventArgs e)
    {
        string connectionString = "Data Source=.\\SQLEXPRESS;AttachDbFilename=|DataDirectory|\\BookShop.mdf;Integrated Security=True;User Instance=True";
        SqlConnection connection = new SqlConnection(connectionString);
        connection.Open();
        string sql = "select UserId,RealName from [User] where UserName='"+this.txtUserName.Text+"'";
        SqlCommand cmm = new SqlCommand(sql, connection);       
        SqlDataAdapter da = new SqlDataAdapter(cmm);
        DataSet ds = new DataSet();       
        da.Fill(ds);
        if(ds.Tables[0].Rows.Count>0)
        {
            this.txtUserId.Text = ds.Tables[0].Rows[0]["UserId"].ToString();
            this.txtRealName.Text = ds.Tables[0].Rows[0]["RealName"].ToString();
        }
        connection.Close();
    }
    protected void btnUpdate_Click(object sender, EventArgs e)
    {
        string connectionString = "Data Source=.\\SQLEXPRESS;AttachDbFilename=|DataDirectory|\\BookShop.mdf;Integrated Security=True;User Instance=True";
        SqlConnection connection = new SqlConnection(connectionString);
        connection.Open();
        string sql = "update [User] set UserName='"+this.txtUserName.Text+"',RealName='"+this.txtRealName.Text+"' where UserId=" + this.txtUserId.Text;
        SqlCommand cmm = new SqlCommand(sql, connection);
        cmm.ExecuteNonQuery();
        connection.Close();
    }
}