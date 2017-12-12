using System;
using System.Data;
using System.Windows.Forms;
using MetroFramework.Controls;
using MetroFramework;

namespace Library
{
    public partial class ucOtherReaders : MetroUserControl
    {
        public ucOtherReaders()
        {
            InitializeComponent();
        }

        private void ucOtherReaders_Load(object sender, EventArgs e)
        {
            otherReadersTableAdapter.Fill(libraryDBDataSet.OtherReaders);
            otherReadersMetroGrid.AllowUserToAddRows = false;
        }

        private void tbOtherReadersSearch_Click(object sender, EventArgs e)
        {
            if (tbOtherReadersSearch.Text == "Search")
                tbOtherReadersSearch.Text = "";
        }

        private void tbOtherReadersSearch_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbOtherReadersSearch.Text))
                tbOtherReadersSearch.Text = "Search";
        }

        private void tbOtherReadersSearch_TextChanged(object sender, EventArgs e)
        {
            if (tbOtherReadersSearch.Text != "Search")
            {
                DataView dv = new DataView(libraryDBDataSet.OtherReaders);
                dv.RowFilter = "Phone like '%" + tbOtherReadersSearch.Text + "%'";
                otherReadersBindingSource.DataSource = dv.ToTable();
            }
        }

        private void picOtherReadersAdd_Click(object sender, EventArgs e)
        {
            try
            {
                otherReadersMetroGrid.AllowUserToAddRows = false;
                otherReadersMetroGrid.Update();
                otherReadersBindingSource.AddNew();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void picOtherReadersMinus_Click(object sender, EventArgs e)
        {
            otherReadersBindingSource.Remove(otherReadersBindingSource.Current);
        }

        private void picOtherReadersSave_Click(object sender, EventArgs e)
        {
            try
            {
                Validate();
                otherReadersBindingSource.EndEdit();
                tableAdapterManager.UpdateAll(libraryDBDataSet);
                MetroMessageBox.Show(this, "The record was saved", "Message", MessageBoxButtons.OK, MessageBoxIcon.Question, 100);
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void picOtherReadersExcel_Click(object sender, EventArgs e)
        {
            try
            {
                Export.ExportToExcel(otherReadersMetroGrid, "Other readers");
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void printOtherReaders_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Printer.PrintTable(otherReadersMetroGrid, e);
        }

        private void picOtherReadersPrint_Click(object sender, EventArgs e)
        {
            printOtherReaders.Print();
        }
    }
}
