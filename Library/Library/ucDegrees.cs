using System;
using System.Data;
using System.Windows.Forms;
using MetroFramework.Controls;
using MetroFramework;

namespace Library
{
    public partial class ucDegrees : MetroUserControl
    {
        public ucDegrees()
        {
            InitializeComponent();
        }

        private void ucDegrees_Load(object sender, EventArgs e)
        {
            degreesTableAdapter.Fill(libraryDBDataSet.Degrees);
            degreesMetroGrid.AllowUserToAddRows = false;
        }

        private void picDegreesPrint_Click(object sender, EventArgs e)
        {
            try
            {
                printDegrees.Print();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void printDegrees_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Printer.PrintTable(degreesMetroGrid, e);
        }

        private void picDegreesExcel_Click(object sender, EventArgs e)
        {
            try
            {
                Export.ExportToExcel(degreesMetroGrid, "Degrees");
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void picDegreesSave_Click(object sender, EventArgs e)
        {
            try
            {
                Validate();
                degreesBindingSource.EndEdit();
                tableAdapterManager.UpdateAll(libraryDBDataSet);
                MetroMessageBox.Show(this, "The record was saved", "Message", MessageBoxButtons.OK, MessageBoxIcon.Question, 100);
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void picDegreesMinus_Click(object sender, EventArgs e)
        {
            degreesBindingSource.Remove(degreesBindingSource.Current);
        }

        private void picDegreesAdd_Click(object sender, EventArgs e)
        {
            try
            {
                degreesMetroGrid.AllowUserToAddRows = false;
                degreesMetroGrid.Update();
                degreesBindingSource.AddNew();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tbDegreesSearch_TextChanged(object sender, EventArgs e)
        {
            if (tbDegreesSearch.Text != "Search")
            {
                DataView dv = new DataView(libraryDBDataSet.Degrees);
                dv.RowFilter = "DegreeName like '%" + tbDegreesSearch.Text + "%'";
                degreesBindingSource.DataSource = dv.ToTable();
            }
        }

        private void tbDegreesSearch_Click(object sender, EventArgs e)
        {
            if (tbDegreesSearch.Text == "Search")
                tbDegreesSearch.Text = "";
        }

        private void tbDegreesSearch_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbDegreesSearch.Text))
                tbDegreesSearch.Text = "Search";
        }
    }
}
