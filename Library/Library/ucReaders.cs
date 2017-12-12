using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using MetroFramework.Controls;
using MetroFramework;

namespace Library
{
    public partial class ucReaders : MetroUserControl
    {
        public ucReaders()
        {
            InitializeComponent();
        }

        private void ucReaders_Load(object sender, EventArgs e)
        {
            readersTableAdapter.Fill(libraryDBDataSet.Readers);
            readersMetroGrid.AllowUserToAddRows = false;
        }

        private void mbtnReaderBrowse_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(Application.StartupPath + "\\Readers"))
            {
                using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "JPEG|*.jpg|PNG|*.png", ValidateNames = true })
                {
                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {
                            string path = Application.StartupPath + "\\Readers\\";
                            string sourceFileName = ofd.FileName;
                            File.Copy(sourceFileName, path + ofd.SafeFileName);
                            picReader.Image = Image.FromFile(path + ofd.SafeFileName);
                            ImageUrlTextBox.Text = ofd.SafeFileName;
                        }
                        catch (Exception ex)
                        {
                            MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else
            {
                DialogResult result = MessageBox.Show("Directory 'Readers' doesn't exist!\nDo you want to create it?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (result == DialogResult.Yes)
                {
                    Directory.CreateDirectory(Application.StartupPath + "\\Readers");
                    mbtnReaderBrowse_Click(sender, e);
                }
            }
        }

        private void readersMetroGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (ImageUrlTextBox.Text.Length != 0)
                    picReader.Image = Image.FromFile(Application.StartupPath + "\\Readers\\" + ImageUrlTextBox.Text);
                else
                    picReader.Image = null;
            }
            catch (FileNotFoundException ex)
            {
                MetroMessageBox.Show(this, ex.Message + " doesn't exist", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning, 130);
            }

            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void printReaders_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Printer.PrintTable(readersMetroGrid, e);
        }

        private void picBookMinus_Click(object sender, EventArgs e)
        {
            readersBindingSource.Remove(readersBindingSource.Current);
        }

        private void picReadersPrint_Click(object sender, EventArgs e)
        {
            try
            {
                printReaders.Print();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void picReadersExcel_Click(object sender, EventArgs e)
        {
            try
            {
                Export.ExportToExcel(readersMetroGrid, "Readers");
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void picReadersSave_Click(object sender, EventArgs e)
        {
            try
            {
                Validate();
                readersBindingSource.EndEdit();
                tableAdapterManager.UpdateAll(libraryDBDataSet);
                MetroMessageBox.Show(this, "The record was saved", "Message", MessageBoxButtons.OK, MessageBoxIcon.Question, 100);
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void picReadersMinus_Click(object sender, EventArgs e)
        {
            readersBindingSource.Remove(readersBindingSource.Current);
        }

        private void picReadersAdd_Click(object sender, EventArgs e)
        {
            try
            {
                readersMetroGrid.AllowUserToAddRows = false;
                readersMetroGrid.Update();
                readersBindingSource.AddNew();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tbReadersSearch_Click(object sender, EventArgs e)
        {
            if (tbReadersSearch.Text == "Search")
                tbReadersSearch.Text = "";
        }

        private void tbReadersSearch_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbReadersSearch.Text))
                tbReadersSearch.Text = "Search";
        }

        private void tbReadersSearch_TextChanged(object sender, EventArgs e)
        {
            if (tbReadersSearch.Text != "Search")
            {
                DataView dv = new DataView(libraryDBDataSet.Readers);
                dv.RowFilter = "LName like '%" + tbReadersSearch.Text + "%' or FName like  '%" + tbReadersSearch.Text +
                    "%' or MName like '%" + tbReadersSearch.Text + "%'";
                readersBindingSource.DataSource = dv.ToTable();
            }
        }
    }
}
