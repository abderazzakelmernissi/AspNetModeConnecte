<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Panel ID="Panel1" runat="server" Height="320px">
            <asp:Label ID="Label1" runat="server" Text="L1"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label2" runat="server" Text="L2"></asp:Label>
            <br />
            <br />
            <asp:ListBox ID="ListBox1" runat="server" Height="226px" Width="147px">
            </asp:ListBox>
            <asp:Button ID="Button3" runat="server" onclick="Button3_Click" 
                Text="&lt;&lt;" />
            <asp:Button ID="Button1" runat="server" onclick="Button1_Click" 
                Text="&gt;&gt;" />
            <asp:ListBox ID="ListBox2" runat="server" Height="226px" 
                style="margin-top: 0px" Width="147px"></asp:ListBox>
        </asp:Panel>
    
    </div>
    </form>
</body>
</html>
