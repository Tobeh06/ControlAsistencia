<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CambiarPwd.aspx.cs" Inherits="Sistema_Asistencia.CambiarPwd" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>CambiarPwd<br />
            Usuario:
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            Contraseña:
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <br />
            Nueva Contraseña:
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            <br />
            Confirmar Contraseña:
            <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label1" runat="server"></asp:Label>
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Actualizar" />
        </div>
    </form>
</body>
</html>
