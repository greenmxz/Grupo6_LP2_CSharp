using System;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;
/* Basado en: https://www.youtube.com/watch?v=EYAzV-uVEzI */

namespace Vista
{
    class EnvioCorreo
    {
        MailMessage correos = new MailMessage();
        SmtpClient envios = new SmtpClient();

        public void enviarCorreo(string emisor, string emisorCC, string emisorBCC, string password, string mensaje, string asunto, string destinatario, string ruta)
        {
            try
            {
                correos.To.Clear();
                correos.Body = "";
                correos.Subject = "";
                correos.Body = mensaje;
                correos.Subject = asunto;
                correos.IsBodyHtml = true;
                correos.To.Add(destinatario.Trim());
                if (ruta.Equals("") == false)
                {
                    Attachment archivo = new Attachment(ruta);
                    correos.Attachments.Add(archivo);
                }
                correos.From = new MailAddress(emisor);
                if (emisorCC != "") { correos.CC.Add(emisorCC); }
                if (emisorBCC != "") { correos.Bcc.Add(emisorBCC); }
                
                envios.Host = "smtp.gmail.com";
                envios.Port = 587;
                envios.EnableSsl = true;
                envios.DeliveryMethod = SmtpDeliveryMethod.Network;
                envios.UseDefaultCredentials = false;
                envios.Credentials = new NetworkCredential(emisor, password);

                envios.Send(correos);
                MessageBox.Show("El documento solicitado ha sido enviado a la(s) dirección(es) indicada(s)", "Éxito de operación");

            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message, "Mensajería 1.0 vb net", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
