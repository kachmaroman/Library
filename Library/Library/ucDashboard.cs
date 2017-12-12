using System;
using MetroFramework.Controls;

namespace Library
{
    public partial class ucDashboard : MetroUserControl
    {
        FrmMain size;
        public ucDashboard(FrmMain size)
        {
            InitializeComponent();
            this.size = size;
        }

        private void mtCategories_Click(object sender, EventArgs e)
        {
            ConnectToUserControl.JoinToUserControl<ucCategories>("ucCategories");
            size.ChangeSizeFrmMain(1008, 390);
        }

        private void mtEdition_Click(object sender, EventArgs e)
        {
            ConnectToUserControl.JoinToUserControl<ucEdition>("ucEdition");
            size.ChangeSizeFrmMain(1008, 495);
        }

        private void mtAuthors_Click(object sender, EventArgs e)
        {
            ConnectToUserControl.JoinToUserControl<ucAuthors>("ucAuthors");
            size.ChangeSizeFrmMain(1008, 488);
        }

        private void mtBooks_Click(object sender, EventArgs e)
        {
            ConnectToUserControl.JoinToUserControl<ucBooks>("ucBooks");
            size.ChangeSizeFrmMain(1008, 700);
        }

        private void mtReaders_Click(object sender, EventArgs e)
        {
            ConnectToUserControl.JoinToUserControl<ucReaders>("ucReaders");
            size.ChangeSizeFrmMain(1008, 560);
        }

        private void mtStudents_Click(object sender, EventArgs e)
        {
            ConnectToUserControl.JoinToUserControl<ucStudents>("ucStudents");
            size.ChangeSizeFrmMain(1008, 530);
        }

        private void mtFaculty_Click(object sender, EventArgs e)
        {
            ConnectToUserControl.JoinToUserControl<ucFaculty>("ucFaculty");
            size.ChangeSizeFrmMain(1008, 470);
        }

        private void mtDegrees_Click(object sender, EventArgs e)
        {
            ConnectToUserControl.JoinToUserControl<ucDegrees>("ucDegrees");
            size.ChangeSizeFrmMain(1008, 490);
        }

        private void mtTeachers_Click(object sender, EventArgs e)
        {
            ConnectToUserControl.JoinToUserControl<ucTeachers>("ucTeachers");
            size.ChangeSizeFrmMain(1008, 520);
        }

        private void mtCathedra_Click(object sender, EventArgs e)
        {
            ConnectToUserControl.JoinToUserControl<ucCathedra>("ucCathedra");
            size.ChangeSizeFrmMain(1008, 480);
        }

        private void mtOtherReaders_Click(object sender, EventArgs e)
        {
            ConnectToUserControl.JoinToUserControl<ucOtherReaders>("ucOtherReaders");
            size.ChangeSizeFrmMain(1008, 480);
        }

        private void mtRoomRead_Click(object sender, EventArgs e)
        {
            ConnectToUserControl.JoinToUserControl<ucRoomRead>("ucRoomRead");
            size.ChangeSizeFrmMain(1008, 450);
        }

        private void mtDebtors_Click(object sender, EventArgs e)
        {
            ConnectToUserControl.JoinToUserControl<ucDebtors>("ucDebtors");
            size.ChangeSizeFrmMain(1008, 478);
        }

        private void mtGiveBook_Click(object sender, EventArgs e)
        {
            ConnectToUserControl.JoinToUserControl<ucGiveBook>("ucGiveBook");
            size.ChangeSizeFrmMain(1008, 535);
        }
    }
}