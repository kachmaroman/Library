using System;
using System.Data;
using System.Windows.Forms;
using MetroFramework.Controls;
using MetroFramework;

namespace Library
{
    public partial class ucCategories : MetroUserControl
    {
        public ucCategories()
        {
            InitializeComponent();
        }

        private void ucCategories_Load(object sender, EventArgs e)
        {
            categoriesTableAdapter.Fill(libraryDBDataSet.Categories);
            categoriesMetroGrid.AllowUserToAddRows = false;
        }

        private void tbCategorySearch_TextChanged(object sender, EventArgs e)
        {
            if (tbCategorySearch.Text != "Search")
            {
                DataView dv = new DataView(libraryDBDataSet.Categories);
                dv.RowFilter = "CategoryName like '%" + tbCategorySearch.Text + "%'";
                categoriesBindingSource.DataSource = dv.ToTable();
            }
        }

        private void tbCategorySearch_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbCategorySearch.Text))
                tbCategorySearch.Text = "Search";
        }

        private void tbCategorySearch_Click(object sender, EventArgs e)
        {
            if (tbCategorySearch.Text == "Search")
                tbCategorySearch.Text = "";
        }

        private void picCategoryAdd_Click(object sender, EventArgs e)
        {
            try
            {
                categoriesMetroGrid.AllowUserToAddRows = false;
                categoriesMetroGrid.Update();
                categoriesBindingSource.AddNew();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void picCategoryMinus_Click(object sender, EventArgs e)
        {
            categoryBindingSource.Remove(categoryBindingSource.Current);
        }

        private void picCategorySave_Click(object sender, EventArgs e)
        {
            try
            {
                Validate();
                categoryBindingSource.EndEdit();
                tableAdapterManager.UpdateAll(libraryDBDataSet);
                MetroMessageBox.Show(this, "The record was saved", "Message", MessageBoxButtons.OK, MessageBoxIcon.Question, 100);
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void picCategoryExcel_Click(object sender, EventArgs e)
        {
            try
            {
                Export.ExportToExcel(categoriesMetroGrid, "Categories");
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void picCategoryPrint_Click(object sender, EventArgs e)
        {
            try
            {
                printCategory.Print();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
