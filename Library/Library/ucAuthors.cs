using System;
using System.Data;
using System.Windows.Forms;
using MetroFramework.Controls;
using MetroFramework;

namespace Library
{
    public partial class ucAuthors : MetroUserControl
    {
        public ucAuthors()
        {
            InitializeComponent();
        }

        private void ucAuthors_Load(object sender, EventArgs e)
        {
            authorsTableAdapter.Fill(libraryDBDataSet.Authors);
            authorsMetroGrid.AllowUserToAddRows = false;
        }

        private void picAuthorAdd_Click(object sender, EventArgs e)
        {
            try
            {
                authorsMetroGrid.AllowUserToAddRows = false;
                authorsMetroGrid.Update();
                authorsBindingSource.AddNew();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void picAuthorMinus_Click(object sender, EventArgs e)
        {
            authorsBindingSource.Remove(authorsBindingSource.Current);
        }

        private void picAuthorSave_Click(object sender, EventArgs e)
        {
            try
            {
                Validate();
                authorsBindingSource.EndEdit();
                tableAdapterManager.UpdateAll(libraryDBDataSet);
                MetroMessageBox.Show(this, "The record was saved", "Message", MessageBoxButtons.OK, MessageBoxIcon.Question, 100);
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void picAuthorPrint_Click(object sender, EventArgs e)
        {
            try
            {
                printAuthors.Print();
            }
            catch(Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void picAuthorExcel_Click(object sender, EventArgs e)
        {  
            try
            {
                Export.ExportToExcel(authorsMetroGrid, "Authors");
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tbAuthorSearch_TextChanged(object sender, EventArgs e)
        {
            if (tbAuthorSearch.Text != "Search")
            {
                DataView dv = new DataView(libraryDBDataSet.Authors);
                dv.RowFilter = "FullName like '%" + tbAuthorSearch.Text + "%'";
                authorsMetroGrid.DataSource = dv.ToTable();
            }
        }

        private void tbAuthorSearch_Click(object sender, EventArgs e)
        {
            if (tbAuthorSearch.Text == "Search")
                tbAuthorSearch.Text = "";
        }

        private void tbAuthorSearch_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbAuthorSearch.Text))
                tbAuthorSearch.Text = "Search";
        }

        private void printAuthors_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Printer.PrintTable(authorsMetroGrid, e);
        }
    }
}
