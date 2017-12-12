using System.Drawing;
using MetroFramework;

namespace Library
{
    public class Design
    {
        static ucDashboard uc = null;
        static FrmMain m = null;
        public Design(ucDashboard _uc, FrmMain _m)
        {
            uc = _uc;
            m = _m;
        }

        public static void ChangeThreme(MetroThemeStyle threme)
        {
            uc.Theme = threme;
            m.Theme = threme;

            uc.Refresh();
            m.Refresh();
        }

        public static void ChangeStyle(MetroColorStyle style)
        {
            uc.mtAuthors.Style = style;
            uc.mtBooks.Style = style;
            uc.mtCategories.Style = style;
            uc.mtCathedra.Style = style;
            uc.mtDebtors.Style = style;
            uc.mtDegrees.Style = style;
            uc.mtEdition.Style = style;
            uc.mtFaculty.Style = style;
            uc.mtGiveBook.Style = style;
            uc.mtOtherReaders.Style = style;
            uc.mtReaders.Style = style;
            uc.mtRoomRead.Style = style;
            uc.mtStudents.Style = style;
            uc.mtTeachers.Style = style;
            m.Style = style;
            m.mcbThreme.Style = style;
            m.mcbChangeStyle.Style = style;
            m.mcbFontWeight.Style = style;
            m.mcbTextSize.Style = style;
            m.mcbColor.Style = style;

            m.Refresh();
            uc.Refresh();
        }

        public static void ChangeTextSize(MetroTileTextSize size)
        {
            uc.mtAuthors.TileTextFontSize = size;
            uc.mtBooks.TileTextFontSize = size;
            uc.mtCategories.TileTextFontSize = size;
            uc.mtCathedra.TileTextFontSize = size;
            uc.mtDebtors.TileTextFontSize = size;
            uc.mtDegrees.TileTextFontSize = size;
            uc.mtEdition.TileTextFontSize = size;
            uc.mtFaculty.TileTextFontSize = size;
            uc.mtGiveBook.TileTextFontSize = size;
            uc.mtOtherReaders.TileTextFontSize = size;
            uc.mtReaders.TileTextFontSize = size;
            uc.mtRoomRead.TileTextFontSize = size;
            uc.mtStudents.TileTextFontSize = size;
            uc.mtTeachers.TileTextFontSize = size;

            uc.Refresh();
        }

        public static void ChangeTextFontWeight(MetroTileTextWeight weight)
        {
            uc.mtAuthors.TileTextFontWeight = weight;
            uc.mtBooks.TileTextFontWeight = weight;
            uc.mtCategories.TileTextFontWeight = weight;
            uc.mtCathedra.TileTextFontWeight = weight;
            uc.mtDebtors.TileTextFontWeight = weight;
            uc.mtDegrees.TileTextFontWeight = weight;
            uc.mtEdition.TileTextFontWeight = weight;
            uc.mtFaculty.TileTextFontWeight = weight;
            uc.mtGiveBook.TileTextFontWeight = weight;
            uc.mtOtherReaders.TileTextFontWeight = weight;
            uc.mtReaders.TileTextFontWeight = weight;
            uc.mtRoomRead.TileTextFontWeight = weight;
            uc.mtStudents.TileTextFontWeight = weight;
            uc.mtTeachers.TileTextFontWeight = weight;
        }

        public static void ChangeColor(Color color)
        {
            uc.mtAuthors.ForeColor = color;
            uc.mtBooks.ForeColor = color;
            uc.mtCategories.ForeColor = color;
            uc.mtCathedra.ForeColor = color;
            uc.mtDebtors.ForeColor = color;
            uc.mtDegrees.ForeColor = color;
            uc.mtEdition.ForeColor = color;
            uc.mtFaculty.ForeColor = color;
            uc.mtGiveBook.ForeColor = color;
            uc.mtOtherReaders.ForeColor = color;
            uc.mtReaders.ForeColor = color;
            uc.mtRoomRead.ForeColor = color;
            uc.mtStudents.ForeColor = color;
            uc.mtTeachers.ForeColor = color;

            m.lblThreme.ForeColor = color;
            m.lblStyle.ForeColor = color;
            m.lblTextSize.ForeColor = color;
            m.lblFontWeight.ForeColor = color;
            m.lblColor.ForeColor = color;

            m.Refresh();
            uc.Refresh();
        }
    }
}
