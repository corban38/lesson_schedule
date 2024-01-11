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
    public partial class FStudentsItem_ : Form
    {
        ComboBox[] lessons_array;
        CheckBox[] day_of_week_array;
        RadioButton[] schedule_period;

        public FStudentsItem_()
        {
            InitializeComponent();
            pnBackGround_.BackColor = TPaint_.BackColor_;
            pnWondowCaption.BackColor = TPaint_.BackColor_;
            pnScheduleGrid.BackColor = TPaint_.BackColor_;
            pnPaymentGrid_.BackColor = TPaint_.BackColor_;
            lblFormCaption.ForeColor = Color.White;
            if (SConnect_DB_.current_mode_ == SConnect_DB_.DB_Mode_.insert_)
            {
                lblFormCaption.Text = "Создать нового ученика";
            }
            else
            {
                lblFormCaption.Text = "Редактирование ученика";
            }
        }

        private void AddLeesonInSchedule(int id_student)
        {
            // провертить на какой период нужно запланировать уроки
            foreach (RadioButton r_btn in schedule_period)
            {
                if (r_btn.Checked)
                {
                    DateTime begin_date;
                    DateTime end_date;
                    switch (r_btn.Name)
                    {

                        case "rbCurrentWeek":
                            begin_date = DateTime.Today;
                            end_date = SDate_.GetLastDayWeek_(begin_date);
                            break;
                        case "rbCurrentMonth":
                            begin_date = DateTime.Today;
                            end_date = SDate_.GetLastDayMonth(begin_date);
                            break;
                        case "rbNextWeek":
                            begin_date = SDate_.GetStartNextWeek_(DateTime.Today);
                            end_date = SDate_.GetLastDayWeek_(begin_date);
                            break;
                        case "rbNextMonth":
                            begin_date = SDate_.GetLastDayMonth(DateTime.Today);
                            begin_date = SDate_.GetFirstDayMonth(begin_date.AddDays(1));
                            end_date = SDate_.GetLastDayMonth(begin_date);
                            break;
                        default:
                            begin_date = DateTime.Today;
                            end_date = DateTime.Today;
                            break;

                    }

                    if (begin_date >= end_date) { return; }
                    int temp_day;
                    DateTime temp_date = begin_date;
                    while (temp_date <= end_date)
                    {
                        temp_day = SDate_.GetNumDayOfWeek_(temp_date);
                        foreach (CheckBox box_ in day_of_week_array)
                        {
                            if (temp_day == Convert.ToInt32(box_.Tag))
                            {
                                if (box_.Checked)
                                {
                                    string qryInsert_ = "INSERT INTO lesson_schedule " +
                                    " (lesson_date, day_of_week_id, " +
                                    " lesson_id, student_id)" +
                                    " VALUES ('" + temp_date.ToShortDateString() +
                                    "', " + temp_day.ToString() + ", " +
                                    " :lesson_id:," + id_student.ToString() + ")";
                                    foreach (ComboBox combo_ in lessons_array)
                                    {
                                        if (combo_.Tag == box_.Tag)
                                        {
                                            qryInsert_ = qryInsert_.Replace(":lesson_id:", combo_.SelectedValue.ToString());

                                            SConnect_DB_.Query_Execute_(qryInsert_);
                                            break;
                                        }
                                    }

                                }
                                break;
                            }
                        }
                        temp_date = temp_date.AddDays(1);
                    }

                }
            }
        }
        private void LockDayOfWeek()
        {
            int day_num_ = SDate_.GetNumDayOfWeek_(DateTime.Today);
            foreach (CheckBox box_ in day_of_week_array)
            {
                if (Convert.ToInt32(box_.Tag) <= day_num_)
                {
                    box_.Enabled = !rbCurrentWeek.Checked;
                }
            }
            /*foreach (ComboBox box_ in lessons_array)
            {
                if (Convert.ToInt32(box_.Tag) <= day_num_)
                {
                    box_.Enabled = !rbCurrentWeek.Checked;
                }
            }*/
        }

        private void ucBtnClose__myClick_(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ucBtnClose__myMouseLeave_(object sender, EventArgs e)
        {
            (sender as UC_FormCloseBtns_).BackColor = (sender as UC_FormCloseBtns_).BackColor_;
        }

        private void ucBtnClose__myMouseEnter_(object sender, EventArgs e)
        {
            (sender as UC_FormCloseBtns_).BackColor = (sender as UC_FormCloseBtns_).BackColorShadow_;
        }

        private void btnCancel__Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnOK__Click(object sender, EventArgs e)
        {
            
            switch (SConnect_DB_.current_mode_)
            {
                case SConnect_DB_.DB_Mode_.insert_:
                    {
                        //добавить нового ученика
                        int id_student =
                        TStudent_.Insert_(tbFirstName_.Text, tbLastName_.Text, tbDescription.Text, cbIsActive.Checked);
                        if (id_student > 0)
                        {
                            AddLeesonInSchedule(id_student);
                        }
                    }
                    
                    break;
                case SConnect_DB_.DB_Mode_.update_:
                    {
                        DataRow row_ = SConnect_DB_.current_row_;
                        if (
                            !tbFirstName_.Text.Equals(row_["first_name"]) ||
                            !tbLastName_.Text.Equals(row_["last_name"]) ||
                            !tbDescription.Text.Equals(row_["description"]) ||
                            cbIsActive.Checked != Convert.ToBoolean(row_["is_active"])

                        )
                        {
                            TStudent_.Update_(Convert.ToInt32(row_["id"]), tbFirstName_.Text, tbLastName_.Text, tbDescription.Text, cbIsActive.Checked);
                        }
                        AddLeesonInSchedule(Convert.ToInt32(row_["id"]));
                    }
                    
                    break;
            }
            

            DialogResult = DialogResult.OK;
        }

        private void FStudentsItem__Load(object sender, EventArgs e)
        {
            // получим массив комбобоксов с уроками
            lessons_array = gbAddSchedule.Controls.OfType<ComboBox>().ToArray();
            foreach(ComboBox cbLesson in lessons_array)
            {
                cbLesson.Enabled = false;
                TLesson_.FillComboBox_(cbLesson);
            }
            //массив радиокнопок с периодом планирования
            schedule_period = gbAddSchedule.Controls.OfType<RadioButton>().ToArray();
            // получим массив чекбоксов
            day_of_week_array = gbAddSchedule.Controls.OfType<CheckBox>().ToArray();
            // отсортируем его по возрастанию Tag'ов
            CheckBox temp;
            for (int i = 0; i < day_of_week_array.Length; i++)
            {
                for (int j = i + 1; j < day_of_week_array.Length; j++)
                {
                    if (Convert.ToInt32(day_of_week_array[i].Tag) > Convert.ToInt32(day_of_week_array[j].Tag))
                    {
                        temp = day_of_week_array[i];
                        day_of_week_array[i] = day_of_week_array[j];
                        day_of_week_array[j] = temp;
                    }
                }

            }
            // заполним поля формы
            DataRow row = SConnect_DB_.current_row_;
            if (Convert.ToInt32(row["id"]) > 0)
            {
                tbFirstName_.Text = row["first_name"].ToString();
                tbLastName_.Text = row["last_name"].ToString();
                tbDescription.Text = row["description"].ToString();
                cbIsActive.Checked = Convert.ToBoolean(row["is_active"]);
            }

            // загрузим сетку с расписанием
            TSchedule_.ListForStudent_(GridSchedule);
            TPayment_.List_(GridPatments_);
            GridPatments_.Columns["full_name"].Visible = false;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            foreach(ComboBox cbLesson in lessons_array)
            {
                if (cbLesson.Tag == (sender as CheckBox).Tag)
                {
                    cbLesson.Enabled = (sender as CheckBox).Checked;
                }
            }
        }

        private void rbCurrentWeek_CheckedChanged(object sender, EventArgs e)
        {
            LockDayOfWeek();
        }

        private void pnScheduleBtns_Paint(object sender, PaintEventArgs e)
        {
            TPaint_.Border_Paint_((Panel)sender, e);
        }

        private void BtnDeleteScheduleLesson_Click(object sender, EventArgs e)
        {
            TSchedule_.Lesson_Delete((GridSchedule.CurrentRow.DataBoundItem as DataRowView).Row);
            TSchedule_.ListForStudent_(GridSchedule);
        }
    }
}
