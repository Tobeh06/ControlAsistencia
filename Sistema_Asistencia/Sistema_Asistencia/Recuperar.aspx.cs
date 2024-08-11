using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net;
using System.Net.Mail;
using Sistema_Asistencia.Datos;

namespace Sistema_Asistencia
{
    public partial class Recuperar : System.Web.UI.Page
    {
        private RecuperacionContrasena recuperacionContrasena1;
        protected void Page_Load(object sender, EventArgs e)
        {
            ControlAsistenciaEntities db = new ControlAsistenciaEntities();
            recuperacionContrasena1 = new RecuperacionContrasena(db);
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
            string Rnd = RecuperacionContrasena.GenerateRandomPassword();
            if (recuperacionContrasena1.ValidarCorreo(TextBox1.Text, TextBox2.Text))
            {
                Label1.Text = $"Su nueva contraseña es: {Rnd}";
                //RecuperacionContrasena.SendPasswordByEmail(TextBox2.Text, Rnd);
                recuperacionContrasena1.Actualizar(Rnd, TextBox1.Text);
                //Response.Redirect("Login.aspx");
            }
            else
            {
                Label1.Text = "Los datos no coinciden";
            }
        }
    }
}