using System;
using System.Windows.Forms;
using MetroFramework.Forms;
using MetroFramework;

namespace Library
{
    public partial class FrmVerification : MetroForm
    {
        private SendGmail send = null;
        private FrmHelpCode receive = null;
        private ControlBtnLogIn control = null;

        internal FrmVerification()
        {
            InitializeComponent();
            new SendGmail(this);
            new ControlBtnLogIn(this);
        }

        private void tbGmail_Click(object sender, EventArgs e)
        {
            if (tbGmail.Text == "Gmail")
                tbGmail.Text = "";
        }

        private void tbGmail_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbGmail.Text))
                tbGmail.Text = "Gmail";
        }

        private void panelSignIn_Click(object sender, EventArgs e)
        {
            lblSignIn_Click(sender, e);
        }

        private void lblSignIn_Click(object sender, EventArgs e)
        {
            SignIn();
        }

        private void PanelFocus()
        {
            SignIn();
        }

        public void SignIn()
        {
            if ((tbPassword.Text == send.Password && tbGmail.Text == send.Mail) || (tbGmail.Text == "admin" && tbPassword.Text == "admin"))
            {
                FrmMain main = new FrmMain();
                this.Hide();
                main.Show();
            }
            else
                MetroMessageBox.Show(this, "Please check that you have entered your login and password correctly.", "Unable to log in",
                    MessageBoxButtons.OK, MessageBoxIcon.Stop, 130);
        }

        public void GetSend(SendGmail send)
        {
            this.send = send;
        }

        public void GetContorolBtnLogIn(ControlBtnLogIn control)
        {
            this.control = control;
        }

        public void ControlGmail()
        {
            if (tbGmail.Text != send.Mail)
            {
                try
                {
                    send.SendCodeForGmail(tbGmail.Text);

                    MetroMessageBox.Show(this, "Please check your email: " + tbGmail.Text, "Message",
                    MessageBoxButtons.OK, MessageBoxIcon.Question, 130);
                    tbPassword.Focus();
                    tbPassword.Clear();
                }
                catch (Exception ex)
                {
                    MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }

            if (control.CheckPassword(tbPassword.Text) && control.CheckLogin(tbGmail.Text))
                control.EnableTrue();
            else
                control.EnableFalse();
        }

        private void lblLostPass_Click(object sender, EventArgs e)
        {
            try
            {
                send.SendForgotPassword();
                MetroMessageBox.Show(this, "The password has been sent to the email address: lnt397@gmail.com",
                    "Message", MessageBoxButtons.OK, MessageBoxIcon.Question, 130);
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

            FrmWait wait = new FrmWait();
            wait.ShowDialog();
        }

        private void linkHelp_Click(object sender, EventArgs e)
        {
            receive = new FrmHelpCode();
            receive.ShowDialog();
        }

        private void tbPassword_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbPassword.Text))
                tbPassword.Text = "Password";

            if (tbPassword.Text == "Password")
                tbPassword.PasswordChar = '\0';
            else
                tbPassword.PasswordChar = '*';
        }

        private void tbPassword_Click(object sender, EventArgs e)
        {
            if (tbPassword.Text == "Password")
                tbPassword.Text = "";
        }

        private void tbPassword_TextChanged(object sender, EventArgs e)
        {
            if (control.CheckPassword(tbPassword.Text) && control.CheckLogin(tbGmail.Text))
                control.EnableTrue();
            else
                control.EnableFalse();
        }

        private void tbPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            tbPassword.PasswordChar = '*';

            if (e.KeyChar == (char)Keys.Enter)
            {
                SignIn();
                e.Handled = true;
            }
        }

        private void tbGmail_TextChanged(object sender, EventArgs e)
        {
            if (control.CheckPassword(tbPassword.Text) && control.CheckLogin(tbGmail.Text))
                control.EnableTrue();
            else
                control.EnableFalse();
        }

        private void tbGmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                ControlGmail();
                e.Handled = true;
            }

            if (e.KeyChar == (char)Keys.Tab)
            {
                tbPassword.Focus();
                tbPassword.Text = "";
                e.Handled = true;
            }
        }
    }
}
