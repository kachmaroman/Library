using System;
using System.Data;
using System.Windows.Forms;
using MetroFramework.Controls;
using MetroFramework;

namespace Library
{
    public partial class ucFaculty : MetroUserControl
    {
        public ucFaculty()
        {
            InitializeComponent();
        }

        private void ucFaculty_Load(object sender, EventArgs e)
        {
            facultyTableAdapter.Fill(libraryDBDataSet.Faculty);
            facultyMetroGrid.AllowUserToAddRows = false;
        }

        private void tbFacultySearch_TextChanged(object sender, EventArgs e)
        {
            if (tbFacultySearch.Text != "Search")
            {
                DataView dv = new DataView(libraryDBDataSet.Faculty);
                dv.RowFilter = "FacultyName like '%" + tbFacultySearch.Text + "%'";
                facultyBindingSource.DataSource = dv.ToTable();
            }
        }

        private void tbFacultySearch_Click(object sender, EventArgs e)
        {
            if (tbFacultySearch.Text == "Search")
                tbFacultySearch.Text = "";
        }

        private void tbFacultySearch_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbFacultySearch.Text))
                tbFacultySearch.Text = "Search";
        }

        private void picFacultyAdd_Click(object sender, EventArgs e)
        {
            try
            {
                facultyMetroGrid.AllowUserToAddRows = false;
                facultyMetroGrid.Update();
                facultyBindingSource.AddNew();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void picFacultyMinus_Click(object sender, EventArgs e)
        {
            facultyBindingSource.Remove(facultyBindingSource.Current);
        }

        private void picFacultySave_Click(object sender, EventArgs e)
        {
            try
            {
                Validate();
                facultyBindingSource.EndEdit();
                tableAdapterManager.UpdateAll(libraryDBDataSet);
                MetroMessageBox.Show(this, "The record was saved", "Message", MessageBoxButtons.OK, MessageBoxIcon.Question, 100);
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void picFacultyExcel_Click(object sender, EventArgs e)
        {
            try
            {
                Export.ExportToExcel(facultyMetroGrid, "Faculty");
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void printFaculty_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Printer.PrintTable(facultyMetroGrid, e);
        }

        private void picFacultyPrint_Click(object sender, EventArgs e)
        {
            try
            {
                printFaculty.Print();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
