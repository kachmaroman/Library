using System;
using System.Data;
using System.Windows.Forms;
using MetroFramework.Controls;
using MetroFramework;

namespace Library
{
    public partial class ucRoomRead : MetroUserControl
    {
        public ucRoomRead()
        {
            InitializeComponent();
        }

        private void ucRoomRead_Load(object sender, EventArgs e)
        {
            roomReadingTableAdapter.Fill(libraryDBDataSet.RoomReading);
            roomReadingMetroGrid.AllowUserToAddRows = false;
        }

        private void printRoomRead_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Printer.PrintTable(roomReadingMetroGrid, e);
        }

        private void picRoomReadPrint_Click(object sender, EventArgs e)
        {
            try
            {
                printRoomRead.Print();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void picRoomReadExcel_Click(object sender, EventArgs e)
        {
            try
            {
                Export.ExportToExcel(roomReadingMetroGrid, "Room reads");
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void picRoomReadSave_Click(object sender, EventArgs e)
        {
            try
            {
                Validate();
                roomReadingBindingSource.EndEdit();
                tableAdapterManager.UpdateAll(libraryDBDataSet);
                MetroMessageBox.Show(this, "The record was saved", "Message", MessageBoxButtons.OK, MessageBoxIcon.Question, 100);
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void picRoomReadMinus_Click(object sender, EventArgs e)
        {
            roomReadingBindingSource.Remove(roomReadingBindingSource.Current);
        }

        private void picRoomReadAdd_Click(object sender, EventArgs e)
        {
            try
            {
                roomReadingMetroGrid.AllowUserToAddRows = false;
                roomReadingMetroGrid.Update();
                roomReadingBindingSource.AddNew();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tbRoomReadSearch_Click(object sender, EventArgs e)
        {
            if (tbRoomReadSearch.Text == "Search")
                tbRoomReadSearch.Text = "";
        }

        private void tbRoomReadSearch_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbRoomReadSearch.Text))
                tbRoomReadSearch.Text = "Search";
        }

        private void tbRoomReadSearch_TextChanged(object sender, EventArgs e)
        {
            if (tbRoomReadSearch.Text != "Search")
            {
                DataView dv = new DataView(libraryDBDataSet.RoomReading);
                dv.RowFilter = "RoomName like '%" + tbRoomReadSearch.Text + "%'";
                roomReadingBindingSource.DataSource = dv.ToTable();
            }
        }
    }
}
