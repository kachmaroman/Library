using System;
using System.Data;
using System.Windows.Forms;
using MetroFramework.Controls;
using MetroFramework;

namespace Library
{
    public partial class ucCathedra : MetroUserControl
    {
        public ucCathedra()
        {
            InitializeComponent();
        }

        private void ucCathedra_Load(object sender, EventArgs e)
        {
            cathedraTableAdapter.Fill(libraryDBDataSet.Cathedra);
            cathedraMetroGrid.AllowUserToAddRows = false;
        }

        private void tbCathedraSearch_TextChanged(object sender, EventArgs e)
        {
            if (tbCathedraSearch.Text != "Search")
            {
                DataView dv = new DataView(libraryDBDataSet.Cathedra);
                dv.RowFilter = "CathedraName like '%" + tbCathedraSearch.Text + "%'";
                cathedraBindingSource.DataSource = dv.ToTable();
            }
        }

        private void tbCathedraSearch_Click(object sender, EventArgs e)
        {
            if (tbCathedraSearch.Text == "Search")
                tbCathedraSearch.Text = "";
        }

        private void tbCathedraSearch_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbCathedraSearch.Text))
                tbCathedraSearch.Text = "Search";
        }

        private void picCathedraAdd_Click(object sender, EventArgs e)
        {
            try
            {
                cathedraMetroGrid.AllowUserToAddRows = false;
                cathedraMetroGrid.Update();
                cathedraBindingSource.AddNew();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void picCathedraMinus_Click(object sender, EventArgs e)
        {
            cathedraBindingSource.Remove(cathedraBindingSource.Current);
        }

        private void picCathedraSave_Click(object sender, EventArgs e)
        {
            try
            {
                Validate();
                cathedraBindingSource.EndEdit();
                tableAdapterManager.UpdateAll(libraryDBDataSet);
                MetroMessageBox.Show(this, "The record was saved", "Message", MessageBoxButtons.OK, MessageBoxIcon.Question, 100);
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void picCathedraExcel_Click(object sender, EventArgs e)
        {
            try
            {
                Export.ExportToExcel(cathedraMetroGrid, "Cathedra");
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void picCathedraPrint_Click(object sender, EventArgs e)
        {
            try
            {
                printCathedra.Print();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
