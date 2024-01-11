using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace schedule_v2
{
    public partial class FSchedulePeriod_ : Form
    {
        public FSchedulePeriod_()
        {
            InitializeComponent();
        }

        private void btnOK__Click(object sender, EventArgs e)
        {
            SDate_.date_start = mCalendStart_.SelectionStart;
            SDate_.date_end = mCalendEnd_.SelectionStart;

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
