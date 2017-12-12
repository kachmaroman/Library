using System;
using System.Data;
using System.Windows.Forms;
using MetroFramework.Controls;
using MetroFramework;

namespace Library
{
    public partial class ucEdition : MetroUserControl
    {
        public ucEdition()
        {
            InitializeComponent();
        }

        private void ucEdition_Load(object sender, EventArgs e)
        {
            editionsTableAdapter.Fill(libraryDBDataSet.Editions);
            editionsMetroGrid.AllowUserToAddRows = false;
        }

        private void tbEditionSearch_TextChanged(object sender, EventArgs e)
        {
            if (tbEditionSearch.Text != "Search")
            {
                DataView dv = new DataView(libraryDBDataSet.Editions);
                dv.RowFilter = "EditionName like '%" + tbEditionSearch.Text + "%'";
                editionsBindingSource.DataSource = dv.ToTable();
            }
        }

        private void tbEditionSearch_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbEditionSearch.Text))
                tbEditionSearch.Text = "Search";
        }

        private void tbEditionSearch_Click(object sender, EventArgs e)
        {
            if (tbEditionSearch.Text == "Search")
                tbEditionSearch.Text = "";
        }

        private void picEditionAdd_Click(object sender, EventArgs e)
        {
            try
            {
                editionsMetroGrid.AllowUserToAddRows = false;
                editionsMetroGrid.Update();
                editionsBindingSource.AddNew();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void picEditionMinus_Click(object sender, EventArgs e)
        {
            editionsBindingSource.Remove(editionsBindingSource.Current);
        }

        private void picEditionSave_Click(object sender, EventArgs e)
        {
            try
            {
                Validate();
                editionsBindingSource.EndEdit();
                tableAdapterManager.UpdateAll(libraryDBDataSet);
                MetroMessageBox.Show(this, "The record was saved", "Message", MessageBoxButtons.OK, MessageBoxIcon.Question, 100);
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void picEditionExcel_Click(object sender, EventArgs e)
        {
            try
            {
                Export.ExportToExcel(editionsMetroGrid, "Editions");
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void picEditionPrint_Click(object sender, EventArgs e)
        {
            try
            {
                printEdition.Print();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void printEdition_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Printer.PrintTable(editionsMetroGrid, e);
        }
    }
}
