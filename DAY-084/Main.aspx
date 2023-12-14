<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Main.aspx.cs" Inherits="WebFormApp.Main" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="FrmTicketing" runat="server">
        <table style="font-family:Arial; border:1px solid black; text-align: center">
            <tr>
                <td>
                    <b>Counter 1</b>
                </td>
                <td></td>
                <td>
                    <b>Counter 2</b>
                </td>
                <td></td>
                <td>
                    <b>Counter 3</b>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:TextBox ID="TxtCounter1" runat="server" BackColor="#000099" ForeColor="White" Font-Size="Large" Width="300px"></asp:TextBox>
                </td>
                <td></td>
                <td>
                    <asp:TextBox ID="TxtCounter2" runat="server" BackColor="#000099" ForeColor="White" Font-Size="Large" Width="300px"></asp:TextBox>
                </td>
                <td></td>
                <td>
                    <asp:TextBox ID="TxtCounter3" runat="server" BackColor="#000099" ForeColor="White" Font-Size="Large" Width="300px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="BtnCounter1" runat="server" Text="Next" Width="300px" Font-Size="Large" OnClick="BtnCounter1_Click" />
                </td>
                <td></td>
                <td>
                    <asp:Button ID="BtnCounter2" runat="server" Text="Next" Width="300px" Font-Size="Large" OnClick="BtnCounter2_Click" />
                </td>
                <td></td>
                <td>
                    <asp:Button ID="BtnCounter3" runat="server" Text="Next" Width="300px" Font-Size="Large" OnClick="BtnCounter3_Click" />
                </td>
            </tr>
            <tr>
                <td colspan="5">
                    <asp:TextBox ID="TxtDisplay" runat="server" BackColor="Green" ForeColor="White" Font-Size="Large" Text-Align="center" Width="1000px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td colspan="5">
                    <br />
                    <br />
                    <asp:Label ID="LblQueue" runat="server" Font-Size="Large">Token Queue:</asp:Label>
                </td>
            </tr>
            <tr>
                <td colspan="5">
                    <asp:ListBox ID="LstToken" runat="server" Font-Size="Large" Width="300px"></asp:ListBox>
                </td>
            </tr>
            <tr>
                <td colspan="5">
                    <asp:Button ID="BtnGetToken" runat="server" Text="Get Token" Font-Size="Large" Width="300px" OnClick="BtnGetToken_Click" />
                </td>
            </tr>
            <tr>
                <td colspan="5">
                    <asp:Label ID="LblQueueStatus" runat="server" Font-Size="Large"></asp:Label>
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
