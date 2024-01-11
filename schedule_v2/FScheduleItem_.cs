using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using schedule_v2.data_model_;
using schedule_v2.database_;

namespace schedule_v2
{
    public partial class FScheduleItem_ : Form
    {
        public FScheduleItem_()
        {
            InitializeComponent();
            ucBtnClose_.Text_("r");            
            ucBtnClose_.Width = pnWondowCaption.Height;
            TStudent_.FillComboBox_(cbStudents_);
            TLesson_.FillComboBox_(cbLessons_);
            TLesson_Topic_.FillComboBox_(cbLessonTopics_);
            if (SConnect_DB_.current_row_ != null)
            {
                if (SConnect_DB_.current_row_["stdnt_id"]!=DBNull.Value )
                {
                    cbStudents_.SelectedValue = Convert.ToInt32(SConnect_DB_.current_row_["stdnt_id"]);
                }
                if (SConnect_DB_.current_row_["less_id"] != DBNull.Value)
                {
                    cbLessons_.SelectedValue = Convert.ToInt32(SConnect_DB_.current_row_["less_id"]);
                }
                if (SConnect_DB_.current_row_["less_tpc_id"] != DBNull.Value)
                {
                    cbLessonTopics_.SelectedValue = Convert.ToInt32(SConnect_DB_.current_row_["less_tpc_id"]);
                }
                if (SConnect_DB_.current_row_["is_attended"] != DBNull.Value)
                {
                    chbIsAttended_.Checked = Convert.ToBoolean(SConnect_DB_.current_row_["is_attended"]);
                }
                if (SConnect_DB_.current_row_["is_payed"] != DBNull.Value)
                {
                    chbIsPayed_.Checked = Convert.ToBoolean(SConnect_DB_.current_row_["is_payed"]);
                }
                if (SConnect_DB_.current_row_["date_"] != DBNull.Value)
                {
                    dtpDateLesson_.Value = Convert.ToDateTime(SConnect_DB_.current_row_["date_"]);
                }
                tbDescription_.Text = SConnect_DB_.current_row_["less_description"].ToString();
                
                
            }
            
            
        }

        private void pnWindowBtns_Paint(object sender, PaintEventArgs e)
        {
            Panel btn_ = (Panel)sender;

            ControlPaint.DrawBorder(btn_.CreateGraphics(), btn_.ClientRectangle,
                                Color.White, 1, ButtonBorderStyle.Solid,
                                Color.LightSeaGreen, 1, ButtonBorderStyle.Solid,
                                Color.White, 1, ButtonBorderStyle.Solid,
                                Color.White, 1, ButtonBorderStyle.Solid
                                );
        }

        private void ucBtnClose__myClick_(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ucBtnClose__myMouseEnter_(object sender, EventArgs e)
        {
            (sender as UC_FormCloseBtns_).BackColor = (sender as UC_FormCloseBtns_).BackColorShadow_;
        }

        private void ucBtnClose__myMouseLeave_(object sender, EventArgs e)
        {
            (sender as UC_FormCloseBtns_).BackColor = (sender as UC_FormCloseBtns_).BackColor_;
        }

        private void btnOK__Click(object sender, EventArgs e)
        {
            DataRow row_ = SConnect_DB_.current_row_;
            row_["date_"] = dtpDateLesson_.Value.ToShortDateString();
            row_["stdnt_id"] = Convert.ToInt32(cbStudents_.SelectedValue);
            row_["less_id"] = Convert.ToInt32(cbLessons_.SelectedValue);
            row_["less_tpc_id"] = Convert.ToInt32(cbLessonTopics_.SelectedValue);
            row_["less_description"] = tbDescription_.Text;
            row_["is_attended"] = chbIsAttended_.Checked;
            row_["is_payed"] = chbIsPayed_.Checked;

            switch (SConnect_DB_.current_table_)
            {
                case SConnect_DB_.DB_Tables_.lesson_schedule:
                    if (SConnect_DB_.current_mode_ == SConnect_DB_.DB_Mode_.insert_)
                    {
                       row_["sch_id"] = TSchedule_.Lesson_Insert_(row_);
                        TAttendLesson_.Insert_(row_);
                    }
                    else if (SConnect_DB_.current_mode_ == SConnect_DB_.DB_Mode_.update_)
                    {
                        TSchedule_.Lesson_Update_(row_);
                        TAttendLesson_.Update_(row_);
                    }
                    break;
            }
            DialogResult = DialogResult.OK;
        }

        private void btnCancel__Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
