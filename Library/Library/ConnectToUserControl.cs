using System.Windows.Forms;

namespace Library
{
    public class ConnectToUserControl
    {
        public static void JoinToUserControl<T>(string controlName) where T : Control, new()
        {
            if(!FrmMain.Instance.MetroContainer.Controls.ContainsKey(controlName))
            {
                T uc = new T();
                uc.Dock = DockStyle.Fill;
                FrmMain.Instance.MetroContainer.Controls.Add(uc);
            }

            FrmMain.Instance.MetroContainer.Controls[controlName].BringToFront();
            FrmMain.Instance.MetroBack.Visible = true;
        }
    }
}
