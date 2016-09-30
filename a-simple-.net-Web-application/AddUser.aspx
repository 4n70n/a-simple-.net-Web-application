<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AddUser.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>    
        昵称：<asp:TextBox ID="txtUserName" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="rfvUsrName" runat="server" 
             ControlToValidate="txtUserName">昵称不能为空</asp:RequiredFieldValidator>
        <br />
        密码：<asp:TextBox ID="txtPassword" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="rfvPwd" runat="server" 
             ControlToValidate="txtPassword">密码不能为空</asp:RequiredFieldValidator>
        <br />
        真名：<asp:TextBox ID="txtRealName" 
            runat="server"></asp:TextBox>
        <br />
        性别：<asp:RadioButton ID="rdoMan" runat="server" GroupName="Sex" 
            Text="男" Checked="True" />
        <asp:RadioButton ID="rdoWomen" runat="server" GroupName="Sex" Text="女" />
        <br />
        电话：<asp:TextBox ID="txtPhone" runat="server"></asp:TextBox>
        <asp:RegularExpressionValidator ID="revPhone" runat="server" 
            ErrorMessage="RegularExpressionValidator" ControlToValidate="txtPhone" ValidationExpression= "[0-9]{11}">11位纯数字</asp:RegularExpressionValidator>
        <br />
        地址：<asp:TextBox ID="txtAddress" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="btnAdd" runat="server" Text="添加"  onclick="btnAdd_Click"/>    
    </div>
    </form>
</body>
</html>
