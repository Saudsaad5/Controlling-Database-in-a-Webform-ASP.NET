<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Webform.aspx.cs" Inherits="test5.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>ASP.NET project</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>
                <tr>
                    <td>Firstname</td>
                    <td><asp:TextBox ID="firstname" runat="server"></asp:TextBox></td>
                </tr>

                <tr>
                    <td>lastname</td>
                    <td><asp:TextBox ID="lastname" runat="server"></asp:TextBox></td>
                </tr>

                <tr>
                    <td>city</td>
                    <td><asp:TextBox ID="city" runat="server"></asp:TextBox></td>
                </tr>

                <tr>
                    <td>id (Only to update data!!)</td>
                    <td><asp:TextBox ID="id" runat="server"></asp:TextBox></td>
                </tr>

                <tr>
                    <td colspan="2" align="center">
                        <asp:Button ID="Button1" runat="server" Text="Insert" OnClick="Button1_Click1" />
                        <asp:Button ID="Button2" runat="server" Text="Delete" OnClick="Button2_Click" />
                        <asp:Button ID="Button3" runat="server" Text="Update" OnClick="Button3_Click" />
                        <asp:Button ID="Button4" runat="server" Text="View" OnClick="Button4_Click" />
                    </td>
                </tr>
            </table>

            <br />
            <asp:GridView ID="GridView1" runat="server"></asp:GridView>
        </div>
    </form>
</body>
</html>
