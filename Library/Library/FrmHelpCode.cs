using System;
using MetroFramework.Forms;

namespace Library
{
    public partial class FrmHelpCode : MetroForm
    {
        private SendGmail gmail;
        public FrmHelpCode()
        {
            InitializeComponent();
            new SendGmail(this, "");
        }

        public void GetGmail(SendGmail send)
        {
            this.gmail = send;
        }

        private void picCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void picSend_Click(object sender, EventArgs e)
        {
            FrmContact contact = new FrmContact();
            this.Close();
            contact.Show();
        }
    }
}
