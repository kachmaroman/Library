using System;
using System.Data;
using System.Windows.Forms;
using MetroFramework.Controls;
using MetroFramework;

namespace Library
{
    public partial class ucTeachers : MetroUserControl
    {
        public ucTeachers()
        {
            InitializeComponent();
        }

        private void ucTeachers_Load(object sender, EventArgs e)
        {
            teachersTableAdapter.Fill(this.libraryDBDataSet.Teachers);
        }

        private void printTeachers_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Printer.PrintTable(teachersMetroGrid, e);
        }

        private void picTeachersPrint_Click(object sender, EventArgs e)
        {
            try
            {
                printTeachers.Print();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void picTeachersExcel_Click(object sender, EventArgs e)
        {
            try
            {
                Export.ExportToExcel(teachersMetroGrid, "Teachers");
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void picTeachersSave_Click(object sender, EventArgs e)
        {
            try
            {
                Validate();
                teachersBindingSource.EndEdit();
                tableAdapterManager.UpdateAll(libraryDBDataSet);
                MetroMessageBox.Show(this, "The record was saved", "Message", MessageBoxButtons.OK, MessageBoxIcon.Question, 100);
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void picTeachersMinus_Click(object sender, EventArgs e)
        {
            teachersBindingSource.Remove(teachersBindingSource.Current);
        }

        private void picTeachersAdd_Click(object sender, EventArgs e)
        {
            try
            {
                teachersMetroGrid.AllowUserToAddRows = false;
                teachersMetroGrid.Update();
                teachersBindingSource.AddNew();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tbTeachersSearch_Click(object sender, EventArgs e)
        {
            if (tbTeachersSearch.Text == "Search")
                tbTeachersSearch.Text = "";
        }

        private void tbTeachersSearch_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbTeachersSearch.Text))
                tbTeachersSearch.Text = "Search";
        }

        private void tbTeachersSearch_TextChanged(object sender, EventArgs e)
        {
            if (tbTeachersSearch.Text != "Search" && !string.IsNullOrEmpty(tbTeachersSearch.Text))
            {
                DataView dv = new DataView(libraryDBDataSet.Teachers);
                dv.RowFilter = "CathedraID = " + Convert.ToInt32(tbTeachersSearch.Text) + " or DegreeID = " + Convert.ToInt32(tbTeachersSearch.Text);
                teachersBindingSource.DataSource = dv.ToTable();
            }
            else
            {
                DataView dv = new DataView(libraryDBDataSet.Teachers);
                teachersBindingSource.DataSource = dv.ToTable();
            }
        }

        private void tbTeachersSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar > 47 && e.KeyChar < 58 || e.KeyChar == 8)
                e.Handled = false;
            else
                e.Handled = true;
        }
    }
}
