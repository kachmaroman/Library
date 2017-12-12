using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Printing;
namespace Library
{
    class Printer
    {
        public static void PrintTable(DataGridView data, PrintPageEventArgs e)
        {
            Bitmap bm = new Bitmap(data.Width, data.Height);
            data.DrawToBitmap(bm, new System.Drawing.Rectangle(0, 0, data.Width, data.Height));
            e.Graphics.DrawImage(bm, 10, 10);
        }
    }
}
