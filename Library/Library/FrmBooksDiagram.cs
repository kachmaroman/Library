using System;
using MetroFramework.Forms;

namespace Library
{
    public partial class FrmBooksDiagram : MetroForm
    {
        ucBooks book;
        public FrmBooksDiagram(ucBooks b)
        {
            InitializeComponent();
            book = b;
        }

        private void FrmBooksDiagram_Load(object sender, EventArgs e)
        {

            LibraryDBDataSet db = new LibraryDBDataSet();
            chartBook.DataSource = db.Books;

            for (int i = 0; i < book.booksMetroGrid.Rows.Count; i++)
            {
                chartBook.Series["Book"].Points.AddXY(book.booksMetroGrid.Rows[i].Cells[1].Value.ToString(), book.booksMetroGrid.Rows[i].Cells[4].Value);
                chartBook.Series["Book"].Points[i].AxisLabel = book.booksMetroGrid.Rows[i].Cells[1].Value.ToString();
            }
        }
    }
}
