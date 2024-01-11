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
    public partial class FLessonTopic_ : Form
    {
        public FLessonTopic_()
        {
            InitializeComponent();
            tbLessonTopic.Text = Convert.ToString(SConnect_DB_.current_row_["topic"]);
        }

        private void btnOK__Click(object sender, EventArgs e)
        {
            if (tbLessonTopic.Text!="")
            switch (SConnect_DB_.current_mode_)
            {
                case SConnect_DB_.DB_Mode_.insert_:
                    TLesson_Topic_.Insert_(tbLessonTopic.Text);
                    break;
                case SConnect_DB_.DB_Mode_.update_:
                    TLesson_Topic_.Update_(tbLessonTopic.Text,
                        Convert.ToString(SConnect_DB_.current_row_["id"]));
                    break;
            }
            DialogResult = DialogResult.OK;
        }

        private void btnCancel__Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
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
    }
}
