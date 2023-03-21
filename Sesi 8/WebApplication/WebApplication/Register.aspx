<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="WebApplication.Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            color: #FF0000;
        }
        .auto-style3 {
            color: #FF0000;
        }
        .auto-style4 {
            color: #FF0000;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <h1>Registrasi Form</h1>
        <div>
            <table class="auto-style1">
            <tr>
                <td>
                    <asp:Label ID="Label1" runat="server" Text="Username"></asp:Label><br />
                    <asp:TextBox ID="Username" runat="server"></asp:TextBox><br />
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredUsername" runat="server" ErrorMessage="Username Harus Diisi" ControlToValidate="Username" CssClass="auto-style2"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label2" runat="server" Text="Password"></asp:Label><br />
                    <asp:TextBox ID="Password" runat="server" TextMode="Password"></asp:TextBox><br />
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredPassword" runat="server" ControlToValidate="Password" CssClass="auto-style2" ErrorMessage="Password Harus Diisi"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label3" runat="server" Text="Konfirmasi Password"></asp:Label><br />
                    <asp:TextBox ID="ConfirmPassword" runat="server" TextMode="Password"></asp:TextBox><br />
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredConfirmPassword" runat="server" ControlToValidate="ConfirmPassword" CssClass="auto-style2" ErrorMessage="Password Tidak Sama"></asp:RequiredFieldValidator><br />
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" CssClass="auto-style4" ErrorMessage="Konfirmasi Password Harus Diisi" ControlToValidate="ConfirmPassword"></asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label4" runat="server" Text="Email"></asp:Label><br />
                    <asp:TextBox ID="Email" runat="server"></asp:TextBox><br />
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredEmail" runat="server" ControlToValidate="Email" CssClass="auto-style2" ErrorMessage="Email Harus Diisi"></asp:RequiredFieldValidator><br />
                    <asp:RegularExpressionValidator ID="RegularExpressionValidatorEmail" runat="server" ErrorMessage="Masukkan Email Yang Benar" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" CssClass="auto-style3" ControlToValidate="Email"></asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label5" runat="server" Text="Jenis Kelamin"></asp:Label><br />
                    <asp:DropDownList ID="Jenkel" runat="server">
                        <asp:ListItem>Pilih Jenis Kelamin</asp:ListItem>
                        <asp:ListItem>Laki-Laki</asp:ListItem>
                        <asp:ListItem>Perempuan</asp:ListItem>
                    </asp:DropDownList><br />
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredJenisKelamin" runat="server" ControlToValidate="Jenkel" CssClass="auto-style2" ErrorMessage="Pilih Jenis Kelamin" InitialValue="Pilih Jenis Kelamin"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="Daftar" runat="server" Text="Daftar" OnClick="Daftar_Click" />
                </td>
                <td>
                    <asp:Button ID="Reset" runat="server" Text="Reset" />
                </td>
            </tr>
            </table>
            
        </div>
    </form>
    
</body>
</html>
