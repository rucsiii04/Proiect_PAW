using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proiectPaw.Others
{
    class Helper
    {
        public static void StyleButton(Button btn)
        {
            btn.BackColor = ColorTranslator.FromHtml("#604d53");
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 1;
            btn.FlatAppearance.BorderColor = Color.Black;
            btn.Cursor = Cursors.Hand;
            btn.TabStop = false;
            btn.ForeColor = Color.White;
            btn.Height = 25;
            btn.Width = 100;
            btn.TextAlign = ContentAlignment.MiddleCenter;
        }
        public static void StyleLButton(Button btn)
        {
            btn.BackColor = ColorTranslator.FromHtml("#604d53");
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 1;
            btn.FlatAppearance.BorderColor = Color.Black;
            btn.Cursor = Cursors.Hand;
            btn.TabStop = false;
            btn.ForeColor = Color.White;
            btn.Height = 25;
            btn.TextAlign = ContentAlignment.MiddleCenter;
        }
        public static void StyleForm(Form form)
        {
            form.BackColor = ColorTranslator.FromHtml("#f2dce0");
        }
        public static void StyleDataGrid(DataGridView dgv)
        {
            dgv.EnableHeadersVisualStyles = false;
            dgv.BackgroundColor = ColorTranslator.FromHtml("#f2dce0");
            dgv.BorderStyle = BorderStyle.None;

            dgv.ColumnHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#7b656c");
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            dgv.ColumnHeadersHeight = 30;

            dgv.DefaultCellStyle.BackColor = ColorTranslator.FromHtml("#B6A4AA");
            dgv.DefaultCellStyle.SelectionBackColor = ColorTranslator.FromHtml("#ffd6dc");
            dgv.DefaultCellStyle.SelectionForeColor = Color.Black;
            dgv.AlternatingRowsDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#917880");
            dgv.RowTemplate.Height = 28;
            dgv.GridColor = ColorTranslator.FromHtml("#7d646c");
        }
    }

    }
