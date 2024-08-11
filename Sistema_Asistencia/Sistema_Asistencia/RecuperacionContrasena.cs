using System;
using System.Linq;
using System.Net;
using System.Net.Mail;
using Sistema_Asistencia.Datos;

namespace Sistema_Asistencia
{
    public class RecuperacionContrasena
    {
        private ControlAsistenciaEntities db;

        public RecuperacionContrasena(ControlAsistenciaEntities db)
        {
            this.db = db;
        }

        public bool ValidarCorreo(string usuario, string email)
        {
            var usuariosCoincidentes = db.Usuarios.Where(u => u.usuario == usuario && u.email == email);

            if (usuariosCoincidentes.Any())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Actualizar(string pwd, string user)
        {
            int idusuario = 0;
            Usuarios o = new Usuarios();
            var usuario = db.Usuarios.FirstOrDefault(u => u.usuario == user);
            if (usuario != null)
            {
                idusuario = usuario.id;
            }
            o = db.Usuarios.Find(idusuario);
            o.password = pwd;
            db.SaveChanges();
        }

        public static string GenerateRandomPassword()
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var random = new Random();
            var password = new string(Enumerable.Repeat(chars, 10)
                .Select(s => s[random.Next(s.Length)]).ToArray());
            return password;
        }
        public bool Validar(string user, string pwd)
        {
            var usuario = db.Usuarios.FirstOrDefault(u => u.usuario == user && u.password == pwd);
		return usuario != null ? usuario.rol : null;
        }
        public static void SendPasswordByEmail(string recipientEmail, string password)
        {
            using (MailMessage mailMessage = new MailMessage())
            {
                mailMessage.To.Add(recipientEmail);
                mailMessage.Subject = "Nueva contraseña generada";
                mailMessage.Body = $"Su nueva contraseña es: {password}";
                mailMessage.IsBodyHtml = false;
                mailMessage.From = new MailAddress("juankasj10@gmail.com", "ALERTA");
                using (SmtpClient cliente = new SmtpClient())
                {
                    cliente.UseDefaultCredentials = false;
                    cliente.Credentials = new NetworkCredential("juankasj10@gmail.com", "mkmaikolfort");
                    cliente.Port = 587;
                    cliente.EnableSsl = true;
                    cliente.Host = "smtp.gmail.com";
                    cliente.Send(mailMessage);
                }
            }
        }
    }

}
