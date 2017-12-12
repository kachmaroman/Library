using System;
using System.Data;
using System.Windows.Forms;
using MetroFramework.Controls;
using MetroFramework;

namespace Library
{
    public partial class ucStudents : MetroUserControl
    {
        public ucStudents()
        {
            InitializeComponent();
        }

        private void ucStudents_Load(object sender, EventArgs e)
        {
            studentsTableAdapter.Fill(libraryDBDataSet.Students);
            studentsMetroGrid.AllowUserToAddRows = false;
        }

        private void printStudents_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Printer.PrintTable(studentsMetroGrid, e);
        }

        private void picStudentsPrint_Click(object sender, EventArgs e)
        {
            try
            {
                printStudents.Print();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void picStudentsExcel_Click(object sender, EventArgs e)
        {
            try
            {
                Export.ExportToExcel(studentsMetroGrid, "Students");
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void picStudentsSave_Click(object sender, EventArgs e)
        {
            try
            {
                Validate();
                studentsBindingSource.EndEdit();
                tableAdapterManager.UpdateAll(libraryDBDataSet);
                MetroMessageBox.Show(this, "The record was saved", "Message", MessageBoxButtons.OK, MessageBoxIcon.Question, 100);
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void picStudentsMinus_Click(object sender, EventArgs e)
        {
            studentsBindingSource.Remove(studentsBindingSource.Current);
        }

        private void picStudentsAdd_Click(object sender, EventArgs e)
        {
            try
            {
                studentsMetroGrid.AllowUserToAddRows = false;
                studentsMetroGrid.Update();
                studentsBindingSource.AddNew();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tbStudentsSearch_Click(object sender, EventArgs e)
        {
            if (tbStudentsSearch.Text == "Search")
                tbStudentsSearch.Text = "";
        }

        private void tbStudentsSearch_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbStudentsSearch.Text))
                tbStudentsSearch.Text = "Search";
        }

        private void tbStudentsSearch_TextChanged(object sender, EventArgs e)
        {
            if (tbStudentsSearch.Text != "Search")
            {
                DataView dv = new DataView(libraryDBDataSet.Students);
                dv.RowFilter = "Group like '%" + tbStudentsSearch.Text + "%'";
                studentsBindingSource.DataSource = dv.ToTable();
            }
        }
    }
}
