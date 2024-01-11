namespace schedule_v2
{
    partial class FLesson_
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
            this.pnWondowCaption = new System.Windows.Forms.Panel();
            this.lblFormCaption = new System.Windows.Forms.Label();
            this.pnWindowBtns = new System.Windows.Forms.Panel();
            this.btnCancel_ = new System.Windows.Forms.Button();
            this.btnOK_ = new System.Windows.Forms.Button();
            this.pnData_ = new System.Windows.Forms.Panel();
            this.tbEndTime = new System.Windows.Forms.MaskedTextBox();
            this.tbStartTime = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ucBtnClose_ = new schedule_v2.UC_FormCloseBtns_();
            this.pnWondowCaption.SuspendLayout();
            this.pnWindowBtns.SuspendLayout();
            this.pnData_.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnWondowCaption
            // 
            this.pnWondowCaption.BackColor = System.Drawing.Color.LightSeaGreen;
            this.pnWondowCaption.Controls.Add(this.ucBtnClose_);
            this.pnWondowCaption.Controls.Add(this.lblFormCaption);
            this.pnWondowCaption.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnWondowCaption.Location = new System.Drawing.Point(1, 1);
            this.pnWondowCaption.Margin = new System.Windows.Forms.Padding(5);
            this.pnWondowCaption.Name = "pnWondowCaption";
            this.pnWondowCaption.Size = new System.Drawing.Size(224, 32);
            this.pnWondowCaption.TabIndex = 2;
            // 
            // lblFormCaption
            // 
            this.lblFormCaption.BackColor = System.Drawing.Color.Transparent;
            this.lblFormCaption.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblFormCaption.Location = new System.Drawing.Point(0, 0);
            this.lblFormCaption.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblFormCaption.Name = "lblFormCaption";
            this.lblFormCaption.Padding = new System.Windows.Forms.Padding(17, 0, 0, 0);
            this.lblFormCaption.Size = new System.Drawing.Size(194, 32);
            this.lblFormCaption.TabIndex = 0;
            this.lblFormCaption.Text = "Время проведения урока";
            this.lblFormCaption.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnWindowBtns
            // 
            this.pnWindowBtns.BackColor = System.Drawing.Color.White;
            this.pnWindowBtns.Controls.Add(this.btnCancel_);
            this.pnWindowBtns.Controls.Add(this.btnOK_);
            this.pnWindowBtns.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnWindowBtns.Location = new System.Drawing.Point(1, 135);
            this.pnWindowBtns.Margin = new System.Windows.Forms.Padding(4);
            this.pnWindowBtns.Name = "pnWindowBtns";
            this.pnWindowBtns.Padding = new System.Windows.Forms.Padding(17, 7, 17, 7);
            this.pnWindowBtns.Size = new System.Drawing.Size(224, 57);
            this.pnWindowBtns.TabIndex = 4;
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
            this.pnData_.Controls.Add(this.tbEndTime);
            this.pnData_.Controls.Add(this.tbStartTime);
            this.pnData_.Controls.Add(this.label2);
            this.pnData_.Controls.Add(this.label1);
            this.pnData_.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnData_.Location = new System.Drawing.Point(1, 33);
            this.pnData_.Margin = new System.Windows.Forms.Padding(4);
            this.pnData_.Name = "pnData_";
            this.pnData_.Size = new System.Drawing.Size(224, 102);
            this.pnData_.TabIndex = 5;
            // 
            // tbEndTime
            // 
            this.tbEndTime.Location = new System.Drawing.Point(112, 55);
            this.tbEndTime.Mask = "00:00";
            this.tbEndTime.Name = "tbEndTime";
            this.tbEndTime.Size = new System.Drawing.Size(102, 23);
            this.tbEndTime.TabIndex = 5;
            this.tbEndTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbEndTime.ValidatingType = typeof(System.DateTime);
            // 
            // tbStartTime
            // 
            this.tbStartTime.Location = new System.Drawing.Point(112, 26);
            this.tbStartTime.Mask = "00:00";
            this.tbStartTime.Name = "tbStartTime";
            this.tbStartTime.Size = new System.Drawing.Size(102, 23);
            this.tbStartTime.TabIndex = 4;
            this.tbStartTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbStartTime.ValidatingType = typeof(System.DateTime);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 58);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Конец урока";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Начало урока";
            // 
            // ucBtnClose_
            // 
            this.ucBtnClose_.BackColor = System.Drawing.Color.Transparent;
            this.ucBtnClose_.BackColor_ = System.Drawing.Color.Transparent;
            this.ucBtnClose_.BackColorShadow_ = System.Drawing.Color.Tomato;
            this.ucBtnClose_.Dock = System.Windows.Forms.DockStyle.Right;
            this.ucBtnClose_.Location = new System.Drawing.Point(192, 0);
            this.ucBtnClose_.Margin = new System.Windows.Forms.Padding(5);
            this.ucBtnClose_.Name = "ucBtnClose_";
            this.ucBtnClose_.Size = new System.Drawing.Size(32, 32);
            this.ucBtnClose_.TabIndex = 1;
            this.ucBtnClose_.myMouseEnter_ += new System.EventHandler(this.ucBtnClose__myMouseEnter_);
            this.ucBtnClose_.myMouseLeave_ += new System.EventHandler(this.ucBtnClose__myMouseLeave_);
            this.ucBtnClose_.myClick_ += new System.EventHandler(this.ucBtnClose__myClick_);
            // 
            // FLesson_
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(226, 193);
            this.Controls.Add(this.pnData_);
            this.Controls.Add(this.pnWindowBtns);
            this.Controls.Add(this.pnWondowCaption);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FLesson_";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FLesson_";
            this.pnWondowCaption.ResumeLayout(false);
            this.pnWindowBtns.ResumeLayout(false);
            this.pnData_.ResumeLayout(false);
            this.pnData_.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnWondowCaption;
        private UC_FormCloseBtns_ ucBtnClose_;
        private System.Windows.Forms.Label lblFormCaption;
        private System.Windows.Forms.Panel pnWindowBtns;
        private System.Windows.Forms.Button btnCancel_;
        private System.Windows.Forms.Button btnOK_;
        private System.Windows.Forms.Panel pnData_;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox tbEndTime;
        private System.Windows.Forms.MaskedTextBox tbStartTime;
    }
}