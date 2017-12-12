using System;
using System.Drawing;
using System.Windows.Forms;
using MetroFramework.Forms;
using MetroFramework.Controls;
using MetroFramework;

namespace Library
{
    public partial class FrmMain : MetroForm
    {
        private static FrmMain _instance;
        OpenFile open = new OpenFile();
        public static FrmMain Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new FrmMain();
                return _instance;
            }
        }

        public MetroPanel MetroContainer
        {
            get { return mPanel; }
            set { mPanel = value; }
        }

        public MetroLink MetroBack
        {
            get { return mlBack; }
            set { mlBack = value; }
        }
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            mlBack.Visible = false;
            _instance = this;
            ucDashboard uc = new ucDashboard(this);
            new Design(uc, this);
            mPanel.Controls.Add(uc);
            ChangeSizeFrmMain(1008, 425);
        }

        private void mlBack_Click(object sender, EventArgs e)
        {
            mPanel.Controls["ucDashboard"].BringToFront();
            mlBack.Visible = false;
            ChangeSizeFrmMain(1008, 425);
        }

        public void ChangeSizeFrmMain(int width, int height)
        {
            this.Size = new Size(width, height);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void changeMailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmVerification login = new FrmVerification();
            login.Show();
            this.Hide();
        }

        private void contactsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmContact contact = new FrmContact();
            contact.Show();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAbout about = new FrmAbout();
            about.ShowDialog();
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void categoriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            open.OpenExcel("Categories");
        }

        private void editionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            open.OpenExcel("Editions");
        }

        private void authorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            open.OpenExcel("Authors");
        }

        private void booksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            open.OpenExcel("Books");
        }

        private void readersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            open.OpenExcel("Readers");
        }

        private void studentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            open.OpenExcel("Students");
        }

        private void facultyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            open.OpenExcel("Faculty");
        }

        private void degreesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            open.OpenExcel("Degrees");
        }

        private void teachersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            open.OpenExcel("Teachers");
        }

        private void cathedraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            open.OpenExcel("Cathedra");
        }

        private void otherReadersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            open.OpenExcel("Other readers");
        }

        private void roomReadsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            open.OpenExcel("Room reads");
        }

        private void debtorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            open.OpenExcel("Debtors");
        }

        private void giveBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            open.OpenExcel("Give book");
        }

        private void mcbThreme_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (mcbThreme.SelectedIndex == 0)
                Design.ChangeThreme(MetroThemeStyle.Dark);
            else
                Design.ChangeThreme(MetroThemeStyle.Light);
        }

        private void mcbChangeStyle_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(mcbChangeStyle.SelectedIndex)
            {
                case 0:
                    Design.ChangeStyle(MetroColorStyle.Black);
                    break;
                case 1:
                    Design.ChangeStyle(MetroColorStyle.Blue);
                    break;
                case 2:
                    Design.ChangeStyle(MetroColorStyle.Brown);
                    break;
                case 3:
                    Design.ChangeStyle(MetroColorStyle.Green);
                    break;
                case 4:
                    Design.ChangeStyle(MetroColorStyle.Lime);
                    break;
                case 5:
                    Design.ChangeStyle(MetroColorStyle.Magenta);
                    break;
                case 6:
                    Design.ChangeStyle(MetroColorStyle.Orange);
                    break;
                case 7:
                    Design.ChangeStyle(MetroColorStyle.Pink);
                    break;
                case 8:
                    Design.ChangeStyle(MetroColorStyle.Purple);
                    break;
                case 9:
                    Design.ChangeStyle(MetroColorStyle.Red);
                    break;
                case 10:
                    Design.ChangeStyle(MetroColorStyle.Silver);
                    break;
                case 11:
                    Design.ChangeStyle(MetroColorStyle.Teal);
                    break;
                case 12:
                    Design.ChangeStyle(MetroColorStyle.White);
                    break;
                case 13:
                    Design.ChangeStyle(MetroColorStyle.Yellow);
                    break;
                default:
                    Design.ChangeStyle(MetroColorStyle.Default);
                    break;
            }
        }

        private void mcbTextSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (mcbTextSize.SelectedIndex)
            {
                case 0:
                    Design.ChangeTextSize(MetroTileTextSize.Small);
                    break; 
                case 1:    
                    Design.ChangeTextSize(MetroTileTextSize.Medium);
                    break; 
                case 2:    
                    Design.ChangeTextSize(MetroTileTextSize.Tall);
                    break;
                default:   
                    Design.ChangeTextSize(MetroTileTextSize.Medium);
                    break;
            }
        }

        private void mcbFontWeight_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (mcbFontWeight.SelectedIndex)
            {
                case 0:
                    Design.ChangeTextFontWeight(MetroTileTextWeight.Light);
                    break;
                case 1:
                    Design.ChangeTextFontWeight(MetroTileTextWeight.Regular);
                    break;
                case 2:
                    Design.ChangeTextFontWeight(MetroTileTextWeight.Bold);
                    break;
                default:
                    Design.ChangeTextFontWeight(MetroTileTextWeight.Regular);
                    break;
            }
        }

        private void mcbColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (mcbColor.SelectedIndex)
            {
                case 0:
                    Design.ChangeColor(Color.Aqua);
                    break;
                case 1:
                    Design.ChangeColor(Color.Black);
                    break;
                case 2:
                    Design.ChangeColor(Color.Blue);
                    break;
                case 3:
                    Design.ChangeColor(Color.Gold);
                    break;
                case 4:
                    Design.ChangeColor(Color.Gray);
                    break;
                case 5:
                    Design.ChangeColor(Color.Green);
                    break;
                case 6:
                    Design.ChangeColor(Color.Lime);
                    break;
                case 7:
                    Design.ChangeColor(Color.Magenta);
                    break;
                case 8:
                    Design.ChangeColor(Color.Orange);
                    break;
                case 9:
                    Design.ChangeColor(Color.Pink);
                    break;
                case 10:
                    Design.ChangeColor(Color.Red);
                    break;
                case 11:
                    Design.ChangeColor(Color.Teal);
                    break;
                case 12:
                    Design.ChangeColor(Color.White);
                    break;
                case 13:
                    Design.ChangeColor(Color.Yellow);
                    break;
                default:
                    Design.ChangeColor(Color.White);
                    break;
            }
        }
    }
}
