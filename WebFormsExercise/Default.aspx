<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h3>Please enter your name</h3>
        <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
        <br />
        <asp:Label ID="lblNameOutput" runat="server" Text=""></asp:Label>
    </div>
        <br />
    <div>
        <h3>Please check the checkbox and then click the button!</h3>
        <asp:CheckBox ID="CheckBox1" runat="server" />
        <asp:Button ID="Button2" runat="server" Text="Button" OnClick="Button2_Click" />
        <br />
        <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
    </div>
        <br />
        <div>
            <asp:RadioButtonList ID="RadioButtonList1" runat="server">
                <asp:ListItem>Value 1</asp:ListItem>
                <asp:ListItem>Value 2</asp:ListItem>
                <asp:ListItem>Value 3</asp:ListItem>
            </asp:RadioButtonList>
            <br />
            <asp:Button ID="Button3" runat="server" Text="Button" OnClick="Button3_Click" />
            <br />
            <asp:Label ID="Label2" runat="server" Text=""></asp:Label>
        </div>
        <br />
        <div>
            <asp:TextBox ID="nameTwo" runat="server"></asp:TextBox><br />
            <asp:CheckBox ID="CheckBox2" runat="server" OnCheckedChanged="CheckedChanged" AutoPostBack="true" Checked="false" /><br />
            <asp:RadioButton ID="RadioButton1" runat="server" OnCheckedChanged="CheckedChanged" AutoPostBack="true" Checked="false" /><br />
            <asp:Label ID="Label3" runat="server" Text=""></asp:Label>

        </div>
        <br />
        <div>

        </div>

    </form>
</body>
</html>
