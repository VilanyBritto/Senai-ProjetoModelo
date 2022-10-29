﻿using MailKit.Net.Smtp;
using MimeKit;
using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppModelo.Model.Infra.Services
{
    public class EmailService
    {
        public bool EnviarEmail(string nome, string email, string assunto, string mensagem)
        {
            try
            {
                //Quais campos existem no seu e-mail pessoal?
                var mimeMessage = new MimeMessage();
                mimeMessage.From.Add(new MailboxAddress("Sistema Senai", "user_senai_temp@faceli.edu.br"));
                mimeMessage.To.Add(new MailboxAddress("Sistema Senai", email));

                mimeMessage.Subject = assunto;

                mimeMessage.Body = new TextPart("html")
                {
                    Text = mensagem
                };
                using (var client = new SmtpClient())
                {
                    client.Connect("smtp.gmail.com", 587, false);

                    client.Authenticate("user_senai_temp@faceli.edu.br", "senai@2022");

                    client.Send(mimeMessage);

                    client.Disconnect(true);

                }
                return true;
            }
            catch (Exception)
            {

               return false;
            }


            /*
             using MailKit.Net.Smtp;
using MailKit.Security;
using MimeKit;
using System;
using System.Collections.Generic;
@@ -15,7 +16,7 @@ public bool EnviarEmail(string nome, string email, string assunto, string mensag
            try
            {
                var mimeMessage = new MimeMessage();
                mimeMessage.From.Add(new MailboxAddress("Sistema Senai", "user_senai_temp@faceli.edu.br"));
                mimeMessage.From.Add(new MailboxAddress("Sistema Senai", "teste@wwonline.com.br"));
                mimeMessage.To.Add(new MailboxAddress(nome, email));
                mimeMessage.Subject = assunto;

@@ -26,9 +27,9 @@ public bool EnviarEmail(string nome, string email, string assunto, string mensag

                using (var client = new SmtpClient())
                {
                    client.Connect("smtp.gmail.com", 587, false);
                    client.Connect("smtp.gmail.com", 587, SecureSocketOptions.Auto);

                    client.Authenticate("user_senai_temp@faceli.edu.br", "senai@2022");
                    client.Authenticate("welton.castoldi@docente.senai.br","thjqhgtpctrhbugt");

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
             
            */
        }

    }
}