using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using schedule_v2.database_;
using schedule_v2.data_model_;

namespace schedule_v2
{
    public partial class FLesson_ : Form
    {
        public FLesson_()
        {
            InitializeComponent();
            pnWondowCaption.BackColor = TPaint_.BackColor_;
            lblFormCaption.ForeColor = Color.White;
            if (SConnect_DB_.current_mode_ == SConnect_DB_.DB_Mode_.insert_)
            {
                lblFormCaption.Text = "Создать новый урок";
            }
            else
            {
                lblFormCaption.Text = "Редактирование урока";
            }
            // заполним поля формы
            DataRow row = SConnect_DB_.current_row_;
            if (Convert.ToInt32(row["id"]) > 0)
            {
                tbStartTime.Text = row["s_time"].ToString();
                tbEndTime.Text = row["e_time"].ToString();                
            }
            else
            {                
                tbStartTime.Text = "00:00";
                tbEndTime.Text = "00:00";

            }
        }

        private void ucBtnClose__myMouseLeave_(object sender, EventArgs e)
        {
            (sender as UC_FormCloseBtns_).BackColor = (sender as UC_FormCloseBtns_).BackColor_;
        }

        private void ucBtnClose__myMouseEnter_(object sender, EventArgs e)
        {
            (sender as UC_FormCloseBtns_).BackColor = (sender as UC_FormCloseBtns_).BackColorShadow_;
        }

        private void ucBtnClose__myClick_(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK__Click(object sender, EventArgs e)
        {
            if (tbStartTime.Text!=tbStartTime.Text || (tbStartTime.Text !="00:00" && tbEndTime.Text!="00:00"))
            switch (SConnect_DB_.current_mode_)
            {
                case SConnect_DB_.DB_Mode_.insert_:
                    TLesson_.Insert_(tbStartTime.Text, tbEndTime.Text);
                    break;
                case SConnect_DB_.DB_Mode_.update_:
                    TLesson_.Update_(tbStartTime.Text, tbEndTime.Text,
                        Convert.ToString(SConnect_DB_.current_row_["id"]));
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
