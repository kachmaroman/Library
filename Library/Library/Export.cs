using System;
using System.Windows.Forms;
using System.IO;
using MetroFramework.Forms;
namespace Library
{
    class Export
    {
        private static DataGridView saveGrid = null;
        private static string saveName = null;
        public static void ExportToExcel(DataGridView grid, string name)
        {
            saveName = name;
            saveGrid = grid;

            if (Directory.Exists(Application.StartupPath + "\\Export"))
            {
                try
                {
                    Microsoft.Office.Interop.Excel.Application objexcelapp = new Microsoft.Office.Interop.Excel.Application();
                    objexcelapp.Application.Workbooks.Add(Type.Missing);
                    objexcelapp.Columns.ColumnWidth = 25;

                    for (int i = 1; i < grid.Columns.Count + 1; i++)
                    {
                        objexcelapp.Cells[1, i] = grid.Columns[i - 1].HeaderText;
                    }

                    for (int i = 0; i < grid.Rows.Count; i++)
                    {
                        for (int j = 0; j < grid.Columns.Count; j++)
                        {
                            if (grid.Rows[i].Cells[j].Value != null)
                            {
                                objexcelapp.Cells[i + 2, j + 1] = grid.Rows[i].Cells[j].Value.ToString();
                            }
                        }
                    }

                    MessageBox.Show("Your excel file exported successfully at " + Application.StartupPath +
                        "\\" + name + ".xlsx", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    objexcelapp.ActiveWorkbook.SaveCopyAs(Application.StartupPath + "\\Export\\" + name + ".xlsx");
                    objexcelapp.ActiveWorkbook.Saved = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                DialogResult result =  MessageBox.Show("Directory 'Export' doesn't exist!\nDo you want to create it?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (result == DialogResult.Yes)
                {
                    Directory.CreateDirectory(Application.StartupPath + "\\Export");
                    ExportToExcel(grid, name);
                }
            }
        }
    }
}
