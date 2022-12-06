using MailKit.Net.Smtp;
using MailKit.Security;
using MimeKit;
using System;

namespace AppModelo.Model.Infra.Services
{
    /// <summary>
    /// Essa classe é a responsável pelas regras de negócios que compõem o serviço de e-mail,usada para enviar e-mail para um servidor.
    /// </summary>
    public class EmailService
    {
        /// <summary>
        /// Método para enviar e-mail ao destinatário via servidor usando recuros de tratativas de erro como o try catch para conseguir realizar 
        /// o precessamento
        /// </summary>
        /// <param name="nome"></param>
        /// <param name="email"></param>
        /// <param name="assunto"></param>
        /// <param name="mensagem"></param>
        /// <returns></returns>
        public bool EnviarEmail(string nome, string email, string assunto, string mensagem)
        {
            try
            {
                var mimeMessage = new MimeMessage();
                mimeMessage.From.Add(new MailboxAddress("Sistema Senai", "teste@wwonline.com.br"));
                mimeMessage.To.Add(new MailboxAddress(nome, email));
                mimeMessage.Subject = assunto;

                mimeMessage.Body = new TextPart("html")
                {
                    Text = mensagem
                };

                using (var client = new SmtpClient())
                {
                    client.Connect("smtp.gmail.com", 587, SecureSocketOptions.Auto);

                    client.Authenticate("welton.castoldi@docente.senai.br", "thjqhgtpctrhbugt");

                    client.Send(mimeMessage);
                    client.Disconnect(true);
                }

                return true;

            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
