using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Sistema_Asistencia.Datos;

namespace Sistema_Asistencia
{
    public partial class Login : System.Web.UI.Page
    {
        private RecuperacionContrasena recuperacionContrasena1;

        protected void Page_Load(object sender, EventArgs e)
        {
            ControlAsistenciaEntities db = new ControlAsistenciaEntities();
            recuperacionContrasena1 = new RecuperacionContrasena(db);
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
		string rol = recuperacionContrasena1.Validar(this.TextBox1.Text, this.TextBox2.Text);
            if (rol != null)
            {
                Session["Login"] = rol;
                Response.Redirect("Principal.aspx");
            }
            else
            {
                this.Label1.Text = "Datos Incorrectos";
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Recuperar.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("CambiarPwd.aspx");
        }
    }
}