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
    public partial class FPayment_ : Form
    {
        public FPayment_()
        {
            InitializeComponent();
            tbAmountPayment.TextAlign = HorizontalAlignment.Right;
            if (float.TryParse(SConnect_DB_.current_row_["amount_"].ToString(), out float amount_))
            {
                tbAmountPayment.Text = amount_.ToString();
            }
            else tbAmountPayment.Text = "0";
            if (!int.TryParse(SConnect_DB_.current_row_["stdnt_id"].ToString(),out int stdnt_id))
            { stdnt_id = 0; }
            TStudent_.FillComboBox_(cbStudent, stdnt_id);
            tbPaymentDescription.Text = SConnect_DB_.current_row_["description_"].ToString();
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
            var str = tbAmountPayment.Text;
            float summ_; // = float.Parse(str);//парсим (не преобразуем запятые в точки! используем текущие настройки системы)

            if (!float.TryParse(str, out summ_))
            {
                MessageBox.Show("Неправильно введена сумма. Формат ввода: 123,45");
                tbAmountPayment.Focus();
                tbAmountPayment.SelectAll();
                return;
            }
            DataRow row = SConnect_DB_.current_row_;
            row["date_"] = dtpPayment.Value.ToShortDateString();
            row["amount_"] = summ_.ToString();
            row["stdnt_id"] = cbStudent.SelectedValue.ToString();
            row["description_"] = tbPaymentDescription.Text;
            switch (SConnect_DB_.current_mode_)
            {
                case SConnect_DB_.DB_Mode_.insert_:
                    {
                        
                        TPayment_.Insert_(row);
                    }
                    
                    break;
                case SConnect_DB_.DB_Mode_.update_:
                    {
                        TPayment_.Update_(row);
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
