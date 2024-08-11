<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Menu.aspx.cs" Inherits="Sistema_Asistencia.Menu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
<style>
      body {
        background-color: #A9D0F5; /* color rojo en formato hexadecimal */
      }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <ul class="nav">
			<li><a target="frmBody" href="Inicio.aspx">INICIO</a></li>
	                <li><a target="frmBody" href="Login.aspx">LOGIN</a></li>
	                <li><a target="frmBody" href="Recuperar.aspx">RECUPERAR CONTRASEÑA</a></li>
	                <li><a target="frmBody" href="CambiarPwd.aspx">CAMBIAR CONTRASEÑA</a></li>
	                <li><a target="frmBody" href="Principal.aspx">PRINCIPAL</a></li>
	            </ul>
        </div>
    </form>
</body>
</html>
