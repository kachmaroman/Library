using System;
using System.Windows.Forms;

namespace Library
{
    public partial class FrmWait : Form
    {
        public int w = 15;
        public FrmWait()
        {
            InitializeComponent();
        }

        private void FrmWait_Load(object sender, EventArgs e)
        {
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            w--;
            this.Width -= 30;

            if (w == 0)
            {
                timer.Stop();
                this.Close();
            }
        }
    }
}
