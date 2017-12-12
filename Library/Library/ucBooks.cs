using System;
using System.Data;
using System.Windows.Forms;
using MetroFramework.Controls;
using MetroFramework;

namespace Library
{
    public partial class ucBooks : MetroUserControl
    {
        public ucBooks()
        {
            InitializeComponent();
        }

        private void ucBooks_Load(object sender, EventArgs e)
        {
            booksTableAdapter.Fill(libraryDBDataSet.Books);
            booksMetroGrid.AllowUserToAddRows = false;
        }

        private void tbBookSearch_TextChanged(object sender, EventArgs e)
        {
            if (tbBookSearch.Text != "Search")
            {
                DataView dv = new DataView(libraryDBDataSet.Books);
                dv.RowFilter = "BookName like '%" + tbBookSearch.Text + "%'";
                booksBindingSource.DataSource = dv.ToTable();
            }
        }

        private void tbBookSearch_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbBookSearch.Text))
                tbBookSearch.Text = "Search";
        }

        private void tbBookSearch_Click(object sender, EventArgs e)
        {
            if (tbBookSearch.Text == "Search")
                tbBookSearch.Text = "";
        }

        private void picBookAdd_Click(object sender, EventArgs e)
        {
            try
            {
                booksMetroGrid.AllowUserToAddRows = false;
                booksMetroGrid.Update();
                booksBindingSource.AddNew();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void picBookMinus_Click(object sender, EventArgs e)
        {
            booksBindingSource.Remove(booksBindingSource.Current);
        }

        private void picBookSave_Click(object sender, EventArgs e)
        {
            try
            {
                Validate();
                booksBindingSource.EndEdit();
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
                Export.ExportToExcel(booksMetroGrid, "Books");
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void picBookPrint_Click(object sender, EventArgs e)
        {
            try
            {
                printBooks.Print();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void printBooks_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Printer.PrintTable(booksMetroGrid, e);
        }

        private void picBookDiagram_Click(object sender, EventArgs e)
        {
            FrmBooksDiagram dia = new FrmBooksDiagram(this);
            dia.Show();
        }
    }
}
