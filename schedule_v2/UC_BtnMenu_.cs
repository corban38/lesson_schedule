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
    public partial class UC_BtnMenu_ : UserControl
    {
        public event EventHandler myMouseEnter_;
        public event EventHandler myMouseLeave_;        
        public event EventHandler myClick_;
        

        public Color BackColorActive_ { get; set; }
        public Color BackColor_ { get; set; }
        public Color BackColorShadow_ { get; set; }
        
        public UC_BtnMenu_()
        {
            InitializeComponent();
            
        }

        public void Text_(string text_) { lblCaption.Text = text_; }

        private void lblCaption_MouseEnter(object sender, EventArgs e)
        {
            myMouseEnter_?.Invoke((sender as Label).Parent, e);
        }
               

        private void lblCaption_Click(object sender, EventArgs e)
        {
            myClick_?.Invoke((sender as Label).Parent, e);
        }

        private void lblCaption_MouseLeave(object sender, EventArgs e)
        {
            myMouseLeave_?.Invoke((sender as Label).Parent, e);
        }
    }
}
