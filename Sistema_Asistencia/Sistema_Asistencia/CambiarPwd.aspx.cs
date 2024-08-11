using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Sistema_Asistencia.Datos;

namespace Sistema_Asistencia
{
    public partial class CambiarPwd : System.Web.UI.Page
    {
        private RecuperacionContrasena recuperacionContrasena1;
        
        protected void Page_Load(object sender, EventArgs e)
        {
            ControlAsistenciaEntities db = new ControlAsistenciaEntities();
            recuperacionContrasena1 = new RecuperacionContrasena(db);
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (TextBox3.Text == TextBox4.Text)
            {
                if (recuperacionContrasena1.Validar(this.TextBox1.Text, this.TextBox2.Text) != null)
                {
                    recuperacionContrasena1.Actualizar(TextBox3.Text, TextBox1.Text);
                    ClientScript.RegisterStartupScript(this.GetType(), "redirect", "if(confirm('Contraseña Actualizada')){window.location='Login.aspx';}", true);
                }
                else
                {
                    Label1.Text = "usuario y contraseña incorrectos";
                }
            }
            else
            {
                Label1.Text = "Las nuevas contraseñas no coinciden";
            }
        }
    }
}