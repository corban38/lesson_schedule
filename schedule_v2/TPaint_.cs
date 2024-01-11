using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;


namespace schedule_v2
{
    static class TPaint_
    {
        public static Color BackColor_ = Color.LightSeaGreen;
        public static Color BackColorBtnShadow_ = Color.CadetBlue;
        public static Color BackColorBtnActive_ = Color.White;
        public static Color BackColorBtn_ = Color.Transparent;

        public static UC_BtnMenu_[] arr_btn_menu_uc;
        
        public static void Border_Paint_(Panel panel, PaintEventArgs e)
        {
            float width = (float)1.0;
            Pen pen = new Pen(BackColor_, width);
            pen.DashStyle = DashStyle.Solid;
            e.Graphics.DrawLine(pen, 0, 0, 0, panel.Height - 0);
            e.Graphics.DrawLine(pen, 0, 0, panel.Width - 0, 0);
            e.Graphics.DrawLine(pen, panel.Width - 1, panel.Height - 1, 0, panel.Height - 1);
            e.Graphics.DrawLine(pen, panel.Width - 1, panel.Height - 1, panel.Width - 1, 0);
        }
        public static void BtnMenuSetActive_ (UC_BtnMenu_ sender_)
        {
            
            foreach (UC_BtnMenu_ btn_ in arr_btn_menu_uc)
                {
                if (btn_.BackColor == BackColorBtnActive_ && btn_ != sender_)
                {
                    btn_.BackColor = BackColorBtn_;
                    btn_.ForeColor = Color.White;
                    btn_.Refresh();
                } else
                
                if (btn_ == sender_)
                {
                    btn_.BackColor = BackColorBtnActive_;
                    btn_.ForeColor = Color.Black;
                    btn_.Refresh();
                }
                
            }
               
               
        }
        
        public static void Button_MouseOver_Paint_(object sender)
        {
           
            Panel btn_ = (Panel)sender;
            
            ControlPaint.DrawBorder(btn_.CreateGraphics(), btn_.ClientRectangle,
                                SystemColors.ControlDark, 1, ButtonBorderStyle.Solid,
                                SystemColors.ControlDark, 1, ButtonBorderStyle.Solid,
                                SystemColors.Control, 1, ButtonBorderStyle.Solid,
                                SystemColors.ControlDark, 1, ButtonBorderStyle.Solid
                                );

        }

        public static bool IsSameCellValue(DataGridView dg_, int column, int row)
        {
            if (row == 0) { return false; }
            DataGridViewCell cell1 = dg_[column, row];
            DataGridViewCell cell2 = dg_[column, row - 1];
            if (cell1.Value == null || cell2.Value == null)
            {
                return false;
            }
            return cell1.Value.ToString() == cell2.Value.ToString();
        }
        public static bool IsFirstCell_(DataGridView dg_, int column, int row)
        {
            return false;
        }
        public static bool IsNotLastCell_(DataGridView dg_, int column, int row)
        {
            bool pred_ = true;

            if (column <= 0 || row < 0) { return pred_; }
            if (dg_.Columns["date_"].Index == column + 1) { return pred_; }
            // проверяем является ли ячейка последней строкой в таблице 
            if (row == dg_.RowCount - 1) { return false; }
            else
            {
                //или в наборе одинаковых значений, если посленее другое значение то - false
                DataGridViewCell cell1 = dg_[column, row];
                DataGridViewCell cell2 = dg_[column, row + 1];
                if (Convert.ToInt32(dg_.Columns[column - 1].Tag) == 101)
                {
                    DataGridViewCell cell3 = dg_[column - 1, row];
                    DataGridViewCell cell4 = dg_[column - 1, row + 1];
                    pred_ = (cell3.Value.ToString() == cell4.Value.ToString());
                }


                return pred_ && (cell1.Value.ToString() == cell2.Value.ToString());
            }
        }
    }
}
