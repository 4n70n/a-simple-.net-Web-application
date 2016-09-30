<%@ Page Language="C#" AutoEventWireup="true" CodeFile="MultilineUserQuery.aspx.cs" Inherits="MultilineUserQuery" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
            DataKeyNames="UserId" onrowdeleting="GridView1_RowDeleting">
            <Columns>
                <asp:BoundField DataField="UserId" HeaderText="用户编号" />
                <asp:BoundField DataField="UserName" HeaderText="昵称" />
                <asp:BoundField DataField="Sex" HeaderText="性别" />
                <asp:BoundField DataField="RealName" HeaderText="真实姓名" />
                <asp:BoundField DataField="telephone" HeaderText="电话号码" />
                <asp:CommandField ShowDeleteButton="True" />
    </Columns>
    </asp:GridView>
    </div>
    </form>
</body>
</html>