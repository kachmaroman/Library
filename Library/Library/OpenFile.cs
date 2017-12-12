using System;
using System.Windows.Forms;
using System.Diagnostics;

namespace Library
{
    public class OpenFile
    {
        public void OpenExcel(string name)
        {
            try
            {
                Process.Start(Application.StartupPath + "\\Export\\" + name + ".xlsx");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex. Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
