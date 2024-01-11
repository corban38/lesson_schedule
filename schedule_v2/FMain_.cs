using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using schedule_v2.data_model_;
using schedule_v2.database_;

namespace schedule_v2
{
    public partial class FMain_ : Form
    {
        private readonly static string path_ = Directory.GetCurrentDirectory();
        private readonly static string base_file = path_ + "\\tutoring.mdb";


        private readonly string db_connection_string = "Provider=Microsoft.Jet.OLEDB.4.0;" +
            "Data Source=:base_file:";


        public FMain_()
        {
            InitializeComponent();
           // path_ = Directory.GetCurrentDirectory();
           // base_file = path_ + "\\tutoring.mdb";
            SConnect_DB_.db_connection_string_ = db_connection_string.Replace(":base_file:", base_file);
            

            panFill.Controls.Add(pnGridTitle);
            pnGridTitle.Dock = DockStyle.Top;
            pnGridTitle.BackColor = TPaint_.BackColor_;
            pnGridTitle.ForeColor = Color.White;
            RefreshGridSheduleTitle();
            
            
            GridMainForm_.MouseWheel += new MouseEventHandler(GridMainForm_MouseWheel);
            ucFormMinimizeBtn_.Text_("0");
            ucFormMinimizeBtn_.Width = panMenuForm.Height;
            ucFormCloseBtn_.Width = panMenuForm.Height;
            ucBtnSchedule_.Text_("Расписание");
            ucBtnStudents_.Text_("Ученики");
            ucBtnLessonTopics_.Text_("Темы уроков");
            ucBtnLessons_.Text_("Уроки");
            ucBtnPayments_.Text_("Оплата");
            TPaint_.arr_btn_menu_uc = pnMainMenuForm.Controls.OfType<UC_BtnMenu_>().ToArray();
            foreach (UC_BtnMenu_ btn_ in TPaint_.arr_btn_menu_uc)
            {
                btn_.Width = 100;
            }

            ucBtnSchedule__myClick_(ucBtnSchedule_, null);
        }


        private void RefreshGridSheduleTitle()
        {
            lblGridTitle.Text = $"Расписание с {SDate_.date_start.ToShortDateString()} по  {SDate_.date_end.ToShortDateString()}";
        }
        private void panTopBorder_Paint(object sender, PaintEventArgs e)
        {
            TPaint_.Border_Paint_((sender as Panel), e);
        }


        private void FMain__Load(object sender, EventArgs e)
        {
            
        }


        void GridMainForm_MouseWheel(object sender, MouseEventArgs e)
        {
            int currentIndex = this.GridMainForm_.FirstDisplayedScrollingRowIndex;
            int scrollLines = SystemInformation.MouseWheelScrollLines;

            if (e.Delta > 0)
            {
                this.GridMainForm_.FirstDisplayedScrollingRowIndex = Math.Max(0, currentIndex - scrollLines);
            }
            else if (e.Delta < 0)
            {
                if (this.GridMainForm_.Rows.Count > (currentIndex + scrollLines))
                    this.GridMainForm_.FirstDisplayedScrollingRowIndex = currentIndex + scrollLines;
            }
        }

        private void GridMainForm__MouseEnter(object sender, EventArgs e)
        {
            GridMainForm_.Focus();
        }

        private void GridMainForm__CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            int last_col_ = (sender as DataGridView).ColumnCount - 1;
            e.AdvancedBorderStyle.Bottom = DataGridViewAdvancedCellBorderStyle.Single;
            e.AdvancedBorderStyle.Right = DataGridViewAdvancedCellBorderStyle.Single;

            if (e.ColumnIndex == last_col_)
            {
                //    e.AdvancedBorderStyle.Right = DataGridViewAdvancedCellBorderStyle.None;
            }




            if (e.ColumnIndex >= 0 && e.RowIndex >= 0)
            {
                if (e.ColumnIndex == last_col_)

                {
                    e.AdvancedBorderStyle.Right = DataGridViewAdvancedCellBorderStyle.None;

                }
                else
                {
                    //  e.AdvancedBorderStyle.Right = DataGridViewAdvancedCellBorderStyle.Single;
                }

                if (Convert.ToInt32((sender as DataGridView).Columns[e.ColumnIndex].Tag) == 101)
                {
                    if (TPaint_.IsNotLastCell_((sender as DataGridView), e.ColumnIndex, e.RowIndex)
                        && TPaint_.IsNotLastCell_((sender as DataGridView), e.ColumnIndex - 1, e.RowIndex))
                    {
                        e.AdvancedBorderStyle.Bottom = DataGridViewAdvancedCellBorderStyle.None;

                    }

                    if (TPaint_.IsSameCellValue((DataGridView)sender, e.ColumnIndex, e.RowIndex)
                        && TPaint_.IsNotLastCell_((sender as DataGridView), e.ColumnIndex - 1, e.RowIndex - 1)
                        )
                    {

                        // если ячейка такая же как предыдущая, то делаем цвет текста под цвет фона
                        e.CellStyle.ForeColor = e.CellStyle.BackColor;
                        e.CellStyle.SelectionForeColor = e.CellStyle.SelectionBackColor;

                    }
                    else
                    {
                        e.CellStyle.ForeColor = SystemColors.WindowText;
                        e.CellStyle.SelectionForeColor = SystemColors.WindowText;
                    }
                }
            } 
        }

        private void ucBtnSchedule__myClick_(object sender, EventArgs e)
        {            
            SConnect_DB_.current_table_ = SConnect_DB_.DB_Tables_.lesson_schedule;
            TPaint_.BtnMenuSetActive_((UC_BtnMenu_)sender);
            GridMainForm_.ContextMenuStrip = contextMenuStrip1;
            BtnDeleteScheduleItem_.Visible = true;
            pnGridTitle.Visible = true;
            pnScheduleTaskBtns.Refresh();
             TSchedule_.List_(GridMainForm_);
            
        }

        private void ucBtnStudents__myClick_(object sender, EventArgs e)
        {
            SConnect_DB_.current_table_ = SConnect_DB_.DB_Tables_.students;
            GridMainForm_.ContextMenuStrip = null;
            BtnDeleteScheduleItem_.Visible = false;
            pnGridTitle.Visible = false;
            pnScheduleTaskBtns.Refresh();
            TPaint_.BtnMenuSetActive_((UC_BtnMenu_)sender);
            TStudent_.List_(GridMainForm_);
        }

        private void ucBtnSchedule__myMouseEnter_(object sender, EventArgs e)
        {
            UC_BtnMenu_ btn_ = (sender as  UC_BtnMenu_);
            if (btn_.BackColor != TPaint_.BackColorBtnActive_) { btn_.BackColor = TPaint_.BackColorBtnShadow_; }
        }

        private void ucBtnSchedule__myMouseLeave_(object sender, EventArgs e)
        {
            UC_BtnMenu_ btn_ = (sender as UC_BtnMenu_);
            if (btn_.BackColor != TPaint_.BackColorBtnActive_) { btn_.BackColor = TPaint_.BackColorBtn_; }
        }

        private void ucBtnLessonTopics__myClick_(object sender, EventArgs e)
        {
            SConnect_DB_.current_table_ = SConnect_DB_.DB_Tables_.lesson_topics;
            GridMainForm_.ContextMenuStrip = null;
            BtnDeleteScheduleItem_.Visible = false;
            pnGridTitle.Visible = false;
            pnScheduleTaskBtns.Refresh();
            TPaint_.BtnMenuSetActive_((UC_BtnMenu_)sender);
            TLesson_Topic_.List_(GridMainForm_);
        }

        private void ucBtnLessons__myClick_(object sender, EventArgs e)
        {
            SConnect_DB_.current_table_ = SConnect_DB_.DB_Tables_.lessons;
            GridMainForm_.ContextMenuStrip = null;
            BtnDeleteScheduleItem_.Visible = false;
            pnGridTitle.Visible = false;
            pnScheduleTaskBtns.Refresh();
            TPaint_.BtnMenuSetActive_((UC_BtnMenu_)sender);
            TLesson_.List_(GridMainForm_);
        }

        private void ucBtnPayments__myClick_(object sender, EventArgs e)
        {
            SConnect_DB_.current_table_ = SConnect_DB_.DB_Tables_.payments;
            GridMainForm_.ContextMenuStrip = null;
            BtnDeleteScheduleItem_.Visible = false;
            pnGridTitle.Visible = false;
            pnScheduleTaskBtns.Refresh();
            TPaint_.BtnMenuSetActive_((UC_BtnMenu_)sender);
            TPayment_.List_(GridMainForm_);
        }

        private void ucFormMinimizeBtn__myMouseEnter_(object sender, EventArgs e)
        {
            (sender as UC_FormCloseBtns_).BackColor = (sender as UC_FormCloseBtns_).BackColorShadow_;
        }

        private void ucFormMinimizeBtn__myMouseLeave_(object sender, EventArgs e)
        {
            (sender as UC_FormCloseBtns_).BackColor = (sender as UC_FormCloseBtns_).BackColor_;
        }


        private void ucFormCloseBtn__myClick_(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ucFormMinimizeBtn__myClick_(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BtnAddScheduleItem__Click(object sender, EventArgs e)
        {
            SConnect_DB_.current_mode_ = SConnect_DB_.DB_Mode_.insert_;
            // получим новую (пустую) строку текущей таблицы в сетке GridMainForm_
            SConnect_DB_.current_row_ = ((DataTable)GridMainForm_.DataSource).NewRow();
            // в зависимости от текущей таблицы создаем форму ввода/редактирования
            switch (SConnect_DB_.current_table_)
            {
                case SConnect_DB_.DB_Tables_.lesson_schedule:
                    SConnect_DB_.current_row_["sch_id"] = 0;
                    
                    FScheduleItem_ f_sch_ = new FScheduleItem_();
                    f_sch_.Owner = this;

                    if (f_sch_.ShowDialog() == DialogResult.OK)
                    {
                        TSchedule_.List_(GridMainForm_);
                    }
                    break;
                case SConnect_DB_.DB_Tables_.students:
                    SConnect_DB_.current_row_["id"] = 0;
                    FStudentsItem_ f_stdnt_ = new FStudentsItem_();
                    f_stdnt_.Owner = this;
                    if (f_stdnt_.ShowDialog() == DialogResult.OK)
                    {
                        TStudent_.List_(GridMainForm_);
                    }
                    break;
                case SConnect_DB_.DB_Tables_.lessons:
                    {
                        SConnect_DB_.current_row_["id"] = 0;
                        FLesson_ f_less = new FLesson_();
                        f_less.Owner = this;
                        if (f_less.ShowDialog() == DialogResult.OK)
                        {
                            TLesson_.List_(GridMainForm_);
                        }
                    }
                    break;
                case SConnect_DB_.DB_Tables_.lesson_topics:
                    {
                        SConnect_DB_.current_row_["id"] = 0;
                        FLessonTopic_ f_less_topic = new FLessonTopic_();
                        f_less_topic.Owner = this;
                        if (f_less_topic.ShowDialog() == DialogResult.OK)
                        {
                            TLesson_Topic_.List_(GridMainForm_);
                        }
                    }
                    break;
                case SConnect_DB_.DB_Tables_.payments:
                    {
                        SConnect_DB_.current_row_["id_"] = 0;
                        FPayment_ f_payment = new FPayment_();
                        f_payment.Owner = this;
                        if (f_payment.ShowDialog() == DialogResult.OK)
                        {
                            TPayment_.List_(GridMainForm_);
                        }
                    }
                    break;
            }
        }

        private void BtnEditScheduleItem__Click(object sender, EventArgs e)
        {
            SConnect_DB_.current_mode_ = SConnect_DB_.DB_Mode_.update_;
            SConnect_DB_.current_row_ = (GridMainForm_.CurrentRow.DataBoundItem as DataRowView).Row;
            switch (SConnect_DB_.current_table_)
            {
                case SConnect_DB_.DB_Tables_.lesson_schedule:
                    FScheduleItem_ f_sch_ = new FScheduleItem_();
                    f_sch_.Owner = this;

                    if (f_sch_.ShowDialog() == DialogResult.OK)
                    {
                        TSchedule_.List_(GridMainForm_);
                    }
                    break;
                case SConnect_DB_.DB_Tables_.students:
                    
                    FStudentsItem_ f_stdnt_ = new FStudentsItem_();
                    f_stdnt_.Owner = this;
                    if (f_stdnt_.ShowDialog() == DialogResult.OK)
                    {
                        TStudent_.List_(GridMainForm_);
                    }
                    break;
                case SConnect_DB_.DB_Tables_.lessons:
                    {
                        
                        FLesson_ f_less = new FLesson_();
                        f_less.Owner = this;
                        if (f_less.ShowDialog() == DialogResult.OK)
                        {
                            TLesson_.List_(GridMainForm_);
                        }
                    }
                    break;
                case SConnect_DB_.DB_Tables_.lesson_topics:
                    {

                        FLessonTopic_ f_less_topic = new FLessonTopic_();
                        f_less_topic.Owner = this;
                        if (f_less_topic.ShowDialog() == DialogResult.OK)
                        {
                            TLesson_Topic_.List_(GridMainForm_);
                        }
                    }
                    break;
                case SConnect_DB_.DB_Tables_.payments:
                    {

                        FPayment_ f_payment = new FPayment_();
                        f_payment.Owner = this;
                        if (f_payment.ShowDialog() == DialogResult.OK)
                        {
                            TPayment_.List_(GridMainForm_);
                        }
                    }
                    break;
            }
            SConnect_DB_.current_row_ = null;
        }

        private void pnTaskBtns_Paint(object sender, PaintEventArgs e)
        {
            Panel btn_ = (Panel)sender;

            ControlPaint.DrawBorder(btn_.CreateGraphics(), btn_.ClientRectangle,
                                Color.White, 1, ButtonBorderStyle.Solid,
                                Color.White, 1, ButtonBorderStyle.Solid,
                                Color.White, 1, ButtonBorderStyle.Solid,
                                Color.LightSeaGreen, 1, ButtonBorderStyle.Solid                                
                                );
        }

        private void BtnDeleteScheduleItem__Click(object sender, EventArgs e)
        {
            SConnect_DB_.current_mode_ = SConnect_DB_.DB_Mode_.delete_;
            SConnect_DB_.current_row_ = (GridMainForm_.CurrentRow.DataBoundItem as DataRowView).Row;
            switch (SConnect_DB_.current_table_)
            {
                case SConnect_DB_.DB_Tables_.lesson_schedule:
                    
                    TSchedule_.Lesson_Delete(SConnect_DB_.current_row_);
                    SConnect_DB_.current_row_ = null;
                    TSchedule_.List_(GridMainForm_);                    
                    break;
                case SConnect_DB_.DB_Tables_.lessons:
                    break;
                case SConnect_DB_.DB_Tables_.lesson_topics:
                    break;
            }
        }

        private void GridMainForm__RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            DataGridView grid = sender as DataGridView;
            if (grid != null)
            {
                try
                {
                    if (Convert.ToInt32(grid["color", e.RowIndex].Value) > 0)
                    {
                        grid.Rows[e.RowIndex].DefaultCellStyle.ForeColor = 
                            SConnect_DB_.GetForeColor_(Convert.ToInt32(grid["color", e.RowIndex].Value));
                        grid.Rows[e.RowIndex].DefaultCellStyle.SelectionForeColor = grid.Rows[e.RowIndex].DefaultCellStyle.ForeColor;
                    }
                        
                }
                catch { }
            }
        }

        private void cmSetBlueForeColor_Click(object sender, EventArgs e)
        {
           
           SConnect_DB_.SetForeColor_((GridMainForm_.CurrentRow.DataBoundItem as DataRowView).Row, (sender as ToolStripMenuItem).ForeColor.Name);
           switch (SConnect_DB_.current_table_)
            {
                case SConnect_DB_.DB_Tables_.lesson_schedule:
                    TSchedule_.List_(GridMainForm_);
                    break;
            }
        }

        private void GridMainForm__CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
           
        }

        private void GridMainForm__CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex != -1 && e.RowIndex != -1 && e.Button == MouseButtons.Right)
            {
                DataGridViewCell c = (sender as DataGridView)[e.ColumnIndex, e.RowIndex];
                if (!c.Selected)
                {
                    c.DataGridView.ClearSelection();
                    c.DataGridView.CurrentCell = c;
                    c.Selected = true;
                }
            }
        }

        private void BtnChangeSchedulePeriod_Click(object sender, EventArgs e)
        {
            FSchedulePeriod_ f_sch_period = new FSchedulePeriod_();
            f_sch_period.Owner = this;
            f_sch_period.BackColor = TPaint_.BackColor_;
            f_sch_period.FormBorderStyle = FormBorderStyle.None;
            f_sch_period.StartPosition = FormStartPosition.CenterParent;
            if (f_sch_period.ShowDialog() == DialogResult.OK)
            {
                RefreshGridSheduleTitle();
                TSchedule_.List_(GridMainForm_);
            }
        }
    }
    
}
