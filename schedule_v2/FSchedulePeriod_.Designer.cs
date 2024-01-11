namespace schedule_v2
{
    partial class FSchedulePeriod_
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
            this.pnData = new System.Windows.Forms.Panel();
            this.pnDataEnd_ = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.mCalendEnd_ = new System.Windows.Forms.MonthCalendar();
            this.pnDataStart = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.mCalendStart_ = new System.Windows.Forms.MonthCalendar();
            this.pnWindowCaption.SuspendLayout();
            this.pnWindowBtns.SuspendLayout();
            this.pnData.SuspendLayout();
            this.pnDataEnd_.SuspendLayout();
            this.panel3.SuspendLayout();
            this.pnDataStart.SuspendLayout();
            this.panel1.SuspendLayout();
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
            this.pnWindowCaption.Size = new System.Drawing.Size(329, 32);
            this.pnWindowCaption.TabIndex = 4;
            // 
            // ucBtnClose_
            // 
            this.ucBtnClose_.BackColor = System.Drawing.Color.Transparent;
            this.ucBtnClose_.BackColor_ = System.Drawing.Color.Transparent;
            this.ucBtnClose_.BackColorShadow_ = System.Drawing.Color.Tomato;
            this.ucBtnClose_.Dock = System.Windows.Forms.DockStyle.Right;
            this.ucBtnClose_.Location = new System.Drawing.Point(297, 0);
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
            this.lblFormCaption.Text = "Показать расисание";
            this.lblFormCaption.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnWindowBtns
            // 
            this.pnWindowBtns.BackColor = System.Drawing.Color.White;
            this.pnWindowBtns.Controls.Add(this.btnCancel_);
            this.pnWindowBtns.Controls.Add(this.btnOK_);
            this.pnWindowBtns.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnWindowBtns.Location = new System.Drawing.Point(1, 227);
            this.pnWindowBtns.Margin = new System.Windows.Forms.Padding(4);
            this.pnWindowBtns.Name = "pnWindowBtns";
            this.pnWindowBtns.Padding = new System.Windows.Forms.Padding(17, 7, 17, 7);
            this.pnWindowBtns.Size = new System.Drawing.Size(329, 57);
            this.pnWindowBtns.TabIndex = 6;
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
            // pnData
            // 
            this.pnData.BackColor = System.Drawing.Color.White;
            this.pnData.Controls.Add(this.pnDataEnd_);
            this.pnData.Controls.Add(this.pnDataStart);
            this.pnData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnData.Location = new System.Drawing.Point(1, 33);
            this.pnData.Name = "pnData";
            this.pnData.Size = new System.Drawing.Size(329, 194);
            this.pnData.TabIndex = 7;
            // 
            // pnDataEnd_
            // 
            this.pnDataEnd_.Controls.Add(this.panel3);
            this.pnDataEnd_.Controls.Add(this.mCalendEnd_);
            this.pnDataEnd_.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnDataEnd_.Location = new System.Drawing.Point(163, 0);
            this.pnDataEnd_.Name = "pnDataEnd_";
            this.pnDataEnd_.Size = new System.Drawing.Size(163, 194);
            this.pnDataEnd_.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(163, 32);
            this.panel3.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Конечная дата";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mCalendEnd_
            // 
            this.mCalendEnd_.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.mCalendEnd_.Location = new System.Drawing.Point(0, 32);
            this.mCalendEnd_.Name = "mCalendEnd_";
            this.mCalendEnd_.TabIndex = 1;
            // 
            // pnDataStart
            // 
            this.pnDataStart.Controls.Add(this.panel1);
            this.pnDataStart.Controls.Add(this.mCalendStart_);
            this.pnDataStart.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnDataStart.Location = new System.Drawing.Point(0, 0);
            this.pnDataStart.Name = "pnDataStart";
            this.pnDataStart.Size = new System.Drawing.Size(163, 194);
            this.pnDataStart.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(163, 32);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Начальная дата";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mCalendStart_
            // 
            this.mCalendStart_.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.mCalendStart_.Location = new System.Drawing.Point(0, 32);
            this.mCalendStart_.MaxSelectionCount = 1;
            this.mCalendStart_.Name = "mCalendStart_";
            this.mCalendStart_.TabIndex = 1;
            // 
            // FSchedulePeriod_
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 285);
            this.Controls.Add(this.pnData);
            this.Controls.Add(this.pnWindowBtns);
            this.Controls.Add(this.pnWindowCaption);
            this.Name = "FSchedulePeriod_";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.Text = "FSchedulePeriod_";
            this.pnWindowCaption.ResumeLayout(false);
            this.pnWindowBtns.ResumeLayout(false);
            this.pnData.ResumeLayout(false);
            this.pnDataEnd_.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.pnDataStart.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnWindowCaption;
        private UC_FormCloseBtns_ ucBtnClose_;
        private System.Windows.Forms.Label lblFormCaption;
        private System.Windows.Forms.Panel pnWindowBtns;
        private System.Windows.Forms.Button btnCancel_;
        private System.Windows.Forms.Button btnOK_;
        private System.Windows.Forms.Panel pnData;
        private System.Windows.Forms.Panel pnDataEnd_;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MonthCalendar mCalendEnd_;
        private System.Windows.Forms.Panel pnDataStart;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MonthCalendar mCalendStart_;
    }
}