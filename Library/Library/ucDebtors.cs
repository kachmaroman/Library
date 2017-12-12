using System;
using System.Windows.Forms;
using MetroFramework.Controls;
using MetroFramework;
using System.Data;

namespace Library
{
    public partial class ucDebtors : MetroUserControl
    {
        public ucDebtors()
        {
            InitializeComponent();
        }

        private void ucDebtors_Load(object sender, EventArgs e)
        {
            debtorsTableAdapter.Fill(libraryDBDataSet.Debtors);
            debtorsMetroGrid.AllowUserToAddRows = false;
        }

        private void picDebtorsAdd_Click(object sender, EventArgs e)
        {
            try
            {
                debtorsMetroGrid.AllowUserToAddRows = false;
                debtorsMetroGrid.Update();
                debtorsBindingSource.AddNew();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void picAuthorMinus_Click(object sender, EventArgs e)
        {
            debtorsBindingSource.Remove(debtorsBindingSource.Current);
        }

        private void picDebtorsSave_Click(object sender, EventArgs e)
        {
            try
            {
                Validate();
                debtorsBindingSource.EndEdit();
                tableAdapterManager.UpdateAll(libraryDBDataSet);
                MetroMessageBox.Show(this, "The record was saved", "Message", MessageBoxButtons.OK, MessageBoxIcon.Question, 100);
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void picDebtorsExcel_Click(object sender, EventArgs e)
        {
            try
            {
                Export.ExportToExcel(debtorsMetroGrid, "Debtors");
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void picDebtorsPrint_Click(object sender, EventArgs e)
        {
            try
            {
                printDebtors.Print();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void printDebtors_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Printer.PrintTable(debtorsMetroGrid, e);
        }

        private void tbDebtorsSearch_TextChanged(object sender, EventArgs e)
        {
            if (tbDebtorsSearch.Text != "Search" && !string.IsNullOrEmpty(tbDebtorsSearch.Text))
            {
                DataView dv = new DataView(libraryDBDataSet.Debtors);
                dv.RowFilter = "BookID = " + Convert.ToInt32(tbDebtorsSearch.Text) + " or ReaderID = " + Convert.ToInt32(tbDebtorsSearch.Text);
                debtorsBindingSource.DataSource = dv.ToTable();
            }
            else
            {
                DataView dv = new DataView(libraryDBDataSet.Debtors);
                debtorsBindingSource.DataSource = dv.ToTable();
            }
        }

        private void tbDebtorsSearch_Click(object sender, EventArgs e)
        {
            if (tbDebtorsSearch.Text == "Search")
                tbDebtorsSearch.Text = "";
        }

        private void tbDebtorsSearch_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbDebtorsSearch.Text))
                tbDebtorsSearch.Text = "Search";
        }
    }
}
