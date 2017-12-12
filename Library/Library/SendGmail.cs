using System;
using System.Net.Mail;

namespace Library
{
    public class SendGmail
    {
        public FrmVerification verification;
        public FrmHelpCode receive;
        private string password = null;
        private string mail = null;

        public string Mail
        {
            get
            {
                return mail;
            }
            set
            {
                mail = value;
            }
        }
        private Random rand = new Random();

        public char GetLowerCaseLetters()
        {
            return Convert.ToChar(rand.Next(97, 122));
        }

        public char GetUpperCaseLetters()
        {
            return Convert.ToChar(rand.Next(65, 90));
        }

        public int GetNumers()
        {
            return rand.Next(9);
        }
        public string Password
        {
            get
            {
                if (!string.IsNullOrEmpty(password))
                    return password;
                return "";
            }
        }

        public SendGmail(FrmVerification verification)
        {
            this.verification = verification;
            verification.GetSend(this);
        }

        public SendGmail(FrmHelpCode receive, string c)
        {
            this.receive = receive;
            this.receive.GetGmail(this);
        }

        public string GetPassword()
        {
            for (int i = 0; i < 2; i++)
            {
                password += GetUpperCaseLetters();
                password += GetNumers();
                password += GetLowerCaseLetters();
                password += GetNumers();
                password += GetLowerCaseLetters();
                password += GetUpperCaseLetters();
            }

            return Password;
        }

        public void SendCodeForGmail(string to)
        {
            Mail = to;

            MailMessage mail = new MailMessage();
            mail.From = new MailAddress("lnt397@gmail.com");
            mail.IsBodyHtml = true;
            mail.To.Add(to);
            mail.Subject = "Verification";
            mail.Body = "Library password - " + GetPassword();

            SmtpClient smtpserver = new SmtpClient("smtp.gmail.com");
            smtpserver.Port = 587;
            smtpserver.Credentials = new System.Net.NetworkCredential("msngomsn@gmail.com", "Kermitfrog33");
            smtpserver.EnableSsl = true;
            smtpserver.Send(mail);
        }

        public void SendForgotPassword()
        {
            MailMessage mail = new MailMessage();
            mail.From = new MailAddress("lnt397@gmail.com");
            mail.IsBodyHtml = true;
            mail.To.Add("lnt397@gmail.com");
            mail.Subject = "Recovery password";
            mail.Body = "Your password: admin";

            SmtpClient smtpserver = new SmtpClient("smtp.gmail.com");
            smtpserver.Port = 587;
            smtpserver.Credentials = new System.Net.NetworkCredential("msngomsn@gmail.com", "Kermitfrog33");
            smtpserver.EnableSsl = true;
            smtpserver.Send(mail);
        }
    }
}
