<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SingleUserQuery.aspx.cs" Inherits="SingleUserQuery" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>    
        昵称：<asp:TextBox ID="txtUserName" runat="server"></asp:TextBox>
        <asp:Button ID="btnQuery" runat="server" Text="查询" onclick="btnQuery_Click" />
        <br />
        编号：<asp:TextBox ID="txtUserId" runat="server"></asp:TextBox>
        <br />
        真名：<asp:TextBox ID="txtRealName" runat="server"></asp:TextBox>    
        <br />
        <asp:Button ID="btnUpdate" runat="server" onclick="btnUpdate_Click" Text="修改" />
    </div>
    </form>
</body>
</html>
