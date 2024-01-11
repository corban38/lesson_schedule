namespace schedule_v2
{
    partial class FLessonTopic_
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnWindowCaption = new System.Windows.Forms.Panel();
            this.ucBtnClose_ = new schedule_v2.UC_FormCloseBtns_();
            this.lblFormCaption = new System.Windows.Forms.Label();
            this.pnWindowBtns = new System.Windows.Forms.Panel();
            this.btnCancel_ = new System.Windows.Forms.Button();
            this.btnOK_ = new System.Windows.Forms.Button();
            this.pnData_ = new System.Windows.Forms.Panel();
            this.tbLessonTopic = new System.Windows.Forms.TextBox();
            this.pnWindowCaption.SuspendLayout();
            this.pnWindowBtns.SuspendLayout();
            this.pnData_.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnWindowCaption
            // 
            this.pnWindowCaption.BackColor = System.Drawing.Color.LightSeaGreen;
            this.pnWindowCaption.Controls.Add(this.ucBtnClose_);
            this.pnWindowCaption.Controls.Add(this.lblFormCaption);
            this.pnWindowCaption.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnWindowCaption.Location = new System.Drawing.Point(1, 1);
            this.pnWindowCaption.Margin = new System.Windows.Forms.Padding(5);
            this.pnWindowCaption.Name = "pnWindowCaption";
            this.pnWindowCaption.Size = new System.Drawing.Size(594, 32);
            this.pnWindowCaption.TabIndex = 3;
            // 
            // ucBtnClose_
            // 
            this.ucBtnClose_.BackColor = System.Drawing.Color.Transparent;
            this.ucBtnClose_.BackColor_ = System.Drawing.Color.Transparent;
            this.ucBtnClose_.BackColorShadow_ = System.Drawing.Color.Tomato;
            this.ucBtnClose_.Dock = System.Windows.Forms.DockStyle.Right;
            this.ucBtnClose_.Location = new System.Drawing.Point(562, 0);
            this.ucBtnClose_.Margin = new System.Windows.Forms.Padding(5);
            this.ucBtnClose_.Name = "ucBtnClose_";
            this.ucBtnClose_.Size = new System.Drawing.Size(32, 32);
            this.ucBtnClose_.TabIndex = 1;
            this.ucBtnClose_.myMouseEnter_ += new System.EventHandler(this.ucBtnClose__myMouseEnter_);
            this.ucBtnClose_.myMouseLeave_ += new System.EventHandler(this.ucBtnClose__myMouseLeave_);
            this.ucBtnClose_.myClick_ += new System.EventHandler(this.ucBtnClose__myClick_);
            // 
            // lblFormCaption
            // 
            this.lblFormCaption.BackColor = System.Drawing.Color.Transparent;
            this.lblFormCaption.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblFormCaption.ForeColor = System.Drawing.Color.White;
            this.lblFormCaption.Location = new System.Drawing.Point(0, 0);
            this.lblFormCaption.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblFormCaption.Name = "lblFormCaption";
            this.lblFormCaption.Padding = new System.Windows.Forms.Padding(17, 0, 0, 0);
            this.lblFormCaption.Size = new System.Drawing.Size(194, 32);
            this.lblFormCaption.TabIndex = 0;
            this.lblFormCaption.Text = "Тема урока";
            this.lblFormCaption.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnWindowBtns
            // 
            this.pnWindowBtns.BackColor = System.Drawing.Color.White;
            this.pnWindowBtns.Controls.Add(this.btnCancel_);
            this.pnWindowBtns.Controls.Add(this.btnOK_);
            this.pnWindowBtns.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnWindowBtns.Location = new System.Drawing.Point(1, 84);
            this.pnWindowBtns.Margin = new System.Windows.Forms.Padding(4);
            this.pnWindowBtns.Name = "pnWindowBtns";
            this.pnWindowBtns.Padding = new System.Windows.Forms.Padding(17, 7, 17, 7);
            this.pnWindowBtns.Size = new System.Drawing.Size(594, 57);
            this.pnWindowBtns.TabIndex = 5;
            // 
            // btnCancel_
            // 
            this.btnCancel_.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel_.Location = new System.Drawing.Point(116, 11);
            this.btnCancel_.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel_.Name = "btnCancel_";
            this.btnCancel_.Size = new System.Drawing.Size(100, 36);
            this.btnCancel_.TabIndex = 1;
            this.btnCancel_.Text = "Отменить";
            this.btnCancel_.UseVisualStyleBackColor = true;
            this.btnCancel_.Click += new System.EventHandler(this.btnCancel__Click);
            // 
            // btnOK_
            // 
            this.btnOK_.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOK_.Location = new System.Drawing.Point(8, 10);
            this.btnOK_.Margin = new System.Windows.Forms.Padding(4);
            this.btnOK_.Name = "btnOK_";
            this.btnOK_.Size = new System.Drawing.Size(100, 36);
            this.btnOK_.TabIndex = 0;
            this.btnOK_.Text = "Сохранить";
            this.btnOK_.UseVisualStyleBackColor = true;
            this.btnOK_.Click += new System.EventHandler(this.btnOK__Click);
            // 
            // pnData_
            // 
            this.pnData_.BackColor = System.Drawing.Color.White;
            this.pnData_.Controls.Add(this.tbLessonTopic);
            this.pnData_.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnData_.Location = new System.Drawing.Point(1, 33);
            this.pnData_.Name = "pnData_";
            this.pnData_.Size = new System.Drawing.Size(594, 51);
            this.pnData_.TabIndex = 6;
            // 
            // tbLessonTopic
            // 
            this.tbLessonTopic.Location = new System.Drawing.Point(8, 16);
            this.tbLessonTopic.Name = "tbLessonTopic";
            this.tbLessonTopic.Size = new System.Drawing.Size(577, 20);
            this.tbLessonTopic.TabIndex = 0;
            // 
            // FLessonTopic_
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(596, 142);
            this.Controls.Add(this.pnData_);
            this.Controls.Add(this.pnWindowBtns);
            this.Controls.Add(this.pnWindowCaption);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FLessonTopic_";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FLessonTopic_";
            this.pnWindowCaption.ResumeLayout(false);
            this.pnWindowBtns.ResumeLayout(false);
            this.pnData_.ResumeLayout(false);
            this.pnData_.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnWindowCaption;
        private UC_FormCloseBtns_ ucBtnClose_;
        private System.Windows.Forms.Label lblFormCaption;
        private System.Windows.Forms.Panel pnWindowBtns;
        private System.Windows.Forms.Button btnCancel_;
        private System.Windows.Forms.Button btnOK_;
        private System.Windows.Forms.Panel pnData_;
        private System.Windows.Forms.TextBox tbLessonTopic;
    }
}