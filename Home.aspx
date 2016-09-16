<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="SAM2017.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form runat="server">
        <div style="">
            <center><h1> Welcome to SAM 2017</center>
            </h1>

    <div style="width: 450px; float: left; height: 400px; margin-left: 200px; margin-top: 10px; background: #FFE4C4">
        <h3>Login:</h3>
        <table>
            <th>User name:</th>
            <th>
                <asp:TextBox runat="server" ID="UsernameTextbox"></asp:TextBox>
            </th>
            <tr>
                <td><b>Password:</td>
                <td>
                    <asp:TextBox runat="server" ID="PasswordTextbox" TextMode="Password"></asp:TextBox>
                </td>
        </table>
        <br />
        <button type="submit">Login</button>
        <asp:Button runat="server" ID="RegisterButton" Text="Register" OnClick="RegisterButton_OnClick" />

    </div>


        </div>
    </form>
</body>
</html>
