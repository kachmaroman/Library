using System;
using System.Windows.Forms;
using MetroFramework;
using System.Net.Mail;

namespace Library
{
    public partial class FrmContact : Form
    {
        public FrmContact()
        {
            InitializeComponent();
        }

        private void tbContactLogin_Click(object sender, EventArgs e)
        {
            if (tbContactLogin.Text == "From")
                tbContactLogin.Text = "";
        }

        private void tbContactLogin_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbContactLogin.Text))
                tbContactLogin.Text = "From";
        }     

        private void tbContactMessage_Click(object sender, EventArgs e)
        {
            if (tbContactMessage.Text == "Message")
                tbContactMessage.Text = "";
        }

        private void tbContactMessage_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbContactMessage.Text))
                tbContactMessage.Text = "Message";
        }

        private void lblContactCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void recContactCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void SendMessage(string login, string message)
        {
            try
            {
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress("msngoo33@gmail.com");
                mail.IsBodyHtml = true;
                mail.To.Add("lnt397@gmail.com");
                mail.Subject = login;
                mail.Body = message;

                SmtpClient smtpserver = new SmtpClient("smtp.gmail.com");
                smtpserver.Port = 587;
                smtpserver.Credentials = new System.Net.NetworkCredential("msngoo33@gmail.com", "kermitfrog");
                smtpserver.EnableSsl = true;
                smtpserver.Send(mail);
                MetroMessageBox.Show(this, "A message was sent by the application", "Message", MessageBoxButtons.OK, MessageBoxIcon.Question, 130);
                this.Close();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Stop, 300);
            }
        }

        private void lblContactSend_Click(object sender, EventArgs e)
        {
            SendMessage(tbContactLogin.Text, tbContactMessage.Text);
        }

        private void recContactSend_Click(object sender, EventArgs e)
        {
            SendMessage(tbContactLogin.Text, tbContactMessage.Text);
        }
    }
}
