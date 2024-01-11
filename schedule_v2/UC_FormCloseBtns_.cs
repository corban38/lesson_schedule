using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace schedule_v2
{
    public partial class UC_FormCloseBtns_ : UserControl
    {
        public event EventHandler myMouseEnter_;
        public event EventHandler myMouseLeave_;
        public event EventHandler myClick_;
        public Color BackColor_ { get; set; }
        public Color BackColorShadow_ { get; set; }
        
        public UC_FormCloseBtns_()
        {
            InitializeComponent();
            label1.Font = new Font("Webdings", 10);
            label1.ForeColor = Color.White;
        }

        public void Text_(string text_) { label1.Text = text_; }

        private void label1_Click(object sender, EventArgs e)
        {
            myClick_?.Invoke((sender as Label).Parent, e);
        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            myMouseEnter_?.Invoke((sender as Label).Parent, e);
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            myMouseLeave_?.Invoke((sender as Label).Parent, e);
        }
    }
}
