using System;
using System.Data;
using System.Windows.Forms;
using MetroFramework.Controls;
using MetroFramework;

namespace Library
{
    public partial class ucGiveBook : MetroUserControl
    {
        public ucGiveBook()
        {
            InitializeComponent();
        }

        private void ucGiveBook_Load(object sender, EventArgs e)
        {
            giveBookTableAdapter.Fill(libraryDBDataSet.GiveBook);
            giveBookMetroGrid.AllowUserToAddRows = false;
        }

        private void tbGiveBookSearch_TextChanged(object sender, EventArgs e)
        {
            if (tbGiveBookSearch.Text != "Search" && !string.IsNullOrEmpty(tbGiveBookSearch.Text))
            {
                DataView dv = new DataView(libraryDBDataSet.GiveBook);
                dv.RowFilter = "GivingID = " + Convert.ToInt32(tbGiveBookSearch.Text) + " or BookID = " + Convert.ToInt32(tbGiveBookSearch.Text) + 
                    " or ReaderID = " + Convert.ToInt32(tbGiveBookSearch.Text) + " or RoomID = " + Convert.ToInt32(tbGiveBookSearch.Text);
                giveBookBindingSource.DataSource = dv.ToTable();
            }
            else
            {
                DataView dv = new DataView(libraryDBDataSet.GiveBook);
                giveBookBindingSource.DataSource = dv.ToTable();
            }
        }

        private void picGiveBookAdd_Click(object sender, EventArgs e)
        {
            try
            {
                giveBookMetroGrid.AllowUserToAddRows = false;
                giveBookMetroGrid.Update();
                giveBookBindingSource.AddNew();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void picGiveBookMinus_Click(object sender, EventArgs e)
        {
            giveBookBindingSource.Remove(giveBookBindingSource.Current);
        }

        private void picGiveBookSave_Click(object sender, EventArgs e)
        {
            try
            {
                Validate();
                giveBookBindingSource.EndEdit();
                tableAdapterManager.UpdateAll(libraryDBDataSet);
                MetroMessageBox.Show(this, "The record was saved", "Message", MessageBoxButtons.OK, MessageBoxIcon.Question, 100);
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void picBookExcel_Click(object sender, EventArgs e)
        {
            try
            {
                Export.ExportToExcel(giveBookMetroGrid, "Give book");
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void picGiveBookPrint_Click(object sender, EventArgs e)
        {
            try
            {
                printGiveBooks.Print();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void printGiveBooks_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Printer.PrintTable(giveBookMetroGrid, e);
        }

        private void tbGiveBookSearch_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbGiveBookSearch.Text))
                tbGiveBookSearch.Text = "Search";
        }

        private void tbGiveBookSearch_Click(object sender, EventArgs e)
        {
            if (tbGiveBookSearch.Text == "Search")
                tbGiveBookSearch.Text = "";
        }

        private void tbGiveBookSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar > 47 && e.KeyChar < 58 || e.KeyChar == 8)
                e.Handled = false;
            else
                e.Handled = true;
        }
    }
}
