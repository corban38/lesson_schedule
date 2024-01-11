namespace schedule_v2
{
    partial class FScheduleItem_
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
            this.pnFill = new System.Windows.Forms.Panel();
            this.pnWindowBtns = new System.Windows.Forms.Panel();
            this.pnData_ = new System.Windows.Forms.Panel();
            this.lblDateLesson = new System.Windows.Forms.Label();
            this.dtpDateLesson_ = new System.Windows.Forms.DateTimePicker();
            this.lblTimeLesson_ = new System.Windows.Forms.Label();
            this.cbLessons_ = new System.Windows.Forms.ComboBox();
            this.lblStudent_ = new System.Windows.Forms.Label();
            this.cbStudents_ = new System.Windows.Forms.ComboBox();
            this.lblLessonTopic_ = new System.Windows.Forms.Label();
            this.cbLessonTopics_ = new System.Windows.Forms.ComboBox();
            this.lblDescription_ = new System.Windows.Forms.Label();
            this.tbDescription_ = new System.Windows.Forms.TextBox();
            this.chbIsAttended_ = new System.Windows.Forms.CheckBox();
            this.chbIsPayed_ = new System.Windows.Forms.CheckBox();
            this.btnOK_ = new System.Windows.Forms.Button();
            this.btnCancel_ = new System.Windows.Forms.Button();
            this.ucBtnClose_ = new schedule_v2.UC_FormCloseBtns_();
            this.pnWondowCaption.SuspendLayout();
            this.pnFill.SuspendLayout();
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
            this.pnWondowCaption.Location = new System.Drawing.Point(0, 0);
            this.pnWondowCaption.Margin = new System.Windows.Forms.Padding(4);
            this.pnWondowCaption.Name = "pnWondowCaption";
            this.pnWondowCaption.Size = new System.Drawing.Size(375, 32);
            this.pnWondowCaption.TabIndex = 0;
            // 
            // lblFormCaption
            // 
            this.lblFormCaption.BackColor = System.Drawing.Color.Transparent;
            this.lblFormCaption.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblFormCaption.Location = new System.Drawing.Point(0, 0);
            this.lblFormCaption.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFormCaption.Name = "lblFormCaption";
            this.lblFormCaption.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.lblFormCaption.Size = new System.Drawing.Size(329, 32);
            this.lblFormCaption.TabIndex = 0;
            this.lblFormCaption.Text = "Урок";
            this.lblFormCaption.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnFill
            // 
            this.pnFill.BackColor = System.Drawing.Color.LightSeaGreen;
            this.pnFill.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnFill.Controls.Add(this.pnData_);
            this.pnFill.Controls.Add(this.pnWindowBtns);
            this.pnFill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnFill.Location = new System.Drawing.Point(0, 32);
            this.pnFill.Name = "pnFill";
            this.pnFill.Padding = new System.Windows.Forms.Padding(1);
            this.pnFill.Size = new System.Drawing.Size(375, 292);
            this.pnFill.TabIndex = 2;
            // 
            // pnWindowBtns
            // 
            this.pnWindowBtns.BackColor = System.Drawing.Color.White;
            this.pnWindowBtns.Controls.Add(this.btnCancel_);
            this.pnWindowBtns.Controls.Add(this.btnOK_);
            this.pnWindowBtns.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnWindowBtns.Location = new System.Drawing.Point(1, 236);
            this.pnWindowBtns.Name = "pnWindowBtns";
            this.pnWindowBtns.Padding = new System.Windows.Forms.Padding(13, 6, 13, 6);
            this.pnWindowBtns.Size = new System.Drawing.Size(371, 53);
            this.pnWindowBtns.TabIndex = 0;
            this.pnWindowBtns.Paint += new System.Windows.Forms.PaintEventHandler(this.pnWindowBtns_Paint);
            // 
            // pnData_
            // 
            this.pnData_.BackColor = System.Drawing.Color.White;
            this.pnData_.Controls.Add(this.chbIsPayed_);
            this.pnData_.Controls.Add(this.chbIsAttended_);
            this.pnData_.Controls.Add(this.tbDescription_);
            this.pnData_.Controls.Add(this.lblDescription_);
            this.pnData_.Controls.Add(this.cbLessonTopics_);
            this.pnData_.Controls.Add(this.lblLessonTopic_);
            this.pnData_.Controls.Add(this.cbStudents_);
            this.pnData_.Controls.Add(this.lblStudent_);
            this.pnData_.Controls.Add(this.cbLessons_);
            this.pnData_.Controls.Add(this.lblTimeLesson_);
            this.pnData_.Controls.Add(this.dtpDateLesson_);
            this.pnData_.Controls.Add(this.lblDateLesson);
            this.pnData_.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnData_.Location = new System.Drawing.Point(1, 1);
            this.pnData_.Name = "pnData_";
            this.pnData_.Size = new System.Drawing.Size(371, 235);
            this.pnData_.TabIndex = 1;
            // 
            // lblDateLesson
            // 
            this.lblDateLesson.AutoSize = true;
            this.lblDateLesson.Location = new System.Drawing.Point(10, 16);
            this.lblDateLesson.Name = "lblDateLesson";
            this.lblDateLesson.Size = new System.Drawing.Size(42, 17);
            this.lblDateLesson.TabIndex = 0;
            this.lblDateLesson.Text = "Дата";
            // 
            // dtpDateLesson_
            // 
            this.dtpDateLesson_.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateLesson_.Location = new System.Drawing.Point(58, 13);
            this.dtpDateLesson_.Name = "dtpDateLesson_";
            this.dtpDateLesson_.Size = new System.Drawing.Size(101, 23);
            this.dtpDateLesson_.TabIndex = 1;
            // 
            // lblTimeLesson_
            // 
            this.lblTimeLesson_.AutoSize = true;
            this.lblTimeLesson_.Location = new System.Drawing.Point(182, 16);
            this.lblTimeLesson_.Name = "lblTimeLesson_";
            this.lblTimeLesson_.Size = new System.Drawing.Size(50, 17);
            this.lblTimeLesson_.TabIndex = 2;
            this.lblTimeLesson_.Text = "Время";
            // 
            // cbLessons_
            // 
            this.cbLessons_.FormattingEnabled = true;
            this.cbLessons_.Location = new System.Drawing.Point(238, 12);
            this.cbLessons_.Name = "cbLessons_";
            this.cbLessons_.Size = new System.Drawing.Size(121, 24);
            this.cbLessons_.TabIndex = 3;
            // 
            // lblStudent_
            // 
            this.lblStudent_.AutoSize = true;
            this.lblStudent_.Location = new System.Drawing.Point(10, 51);
            this.lblStudent_.Name = "lblStudent_";
            this.lblStudent_.Size = new System.Drawing.Size(56, 17);
            this.lblStudent_.TabIndex = 4;
            this.lblStudent_.Text = "Ученик";
            // 
            // cbStudents_
            // 
            this.cbStudents_.FormattingEnabled = true;
            this.cbStudents_.Location = new System.Drawing.Point(72, 47);
            this.cbStudents_.Name = "cbStudents_";
            this.cbStudents_.Size = new System.Drawing.Size(287, 24);
            this.cbStudents_.TabIndex = 5;
            // 
            // lblLessonTopic_
            // 
            this.lblLessonTopic_.AutoSize = true;
            this.lblLessonTopic_.Location = new System.Drawing.Point(10, 84);
            this.lblLessonTopic_.Name = "lblLessonTopic_";
            this.lblLessonTopic_.Size = new System.Drawing.Size(84, 17);
            this.lblLessonTopic_.TabIndex = 6;
            this.lblLessonTopic_.Text = "Тема урока";
            // 
            // cbLessonTopics_
            // 
            this.cbLessonTopics_.FormattingEnabled = true;
            this.cbLessonTopics_.Location = new System.Drawing.Point(13, 107);
            this.cbLessonTopics_.Name = "cbLessonTopics_";
            this.cbLessonTopics_.Size = new System.Drawing.Size(346, 24);
            this.cbLessonTopics_.TabIndex = 7;
            // 
            // lblDescription_
            // 
            this.lblDescription_.AutoSize = true;
            this.lblDescription_.Location = new System.Drawing.Point(10, 144);
            this.lblDescription_.Name = "lblDescription_";
            this.lblDescription_.Size = new System.Drawing.Size(98, 17);
            this.lblDescription_.TabIndex = 8;
            this.lblDescription_.Text = "Комментарий";
            // 
            // tbDescription_
            // 
            this.tbDescription_.Location = new System.Drawing.Point(13, 164);
            this.tbDescription_.Name = "tbDescription_";
            this.tbDescription_.Size = new System.Drawing.Size(346, 23);
            this.tbDescription_.TabIndex = 9;
            // 
            // chbIsAttended_
            // 
            this.chbIsAttended_.AutoSize = true;
            this.chbIsAttended_.Location = new System.Drawing.Point(13, 208);
            this.chbIsAttended_.Name = "chbIsAttended_";
            this.chbIsAttended_.Size = new System.Drawing.Size(92, 21);
            this.chbIsAttended_.TabIndex = 10;
            this.chbIsAttended_.Text = "Проведён";
            this.chbIsAttended_.UseVisualStyleBackColor = true;
            // 
            // chbIsPayed_
            // 
            this.chbIsPayed_.AutoSize = true;
            this.chbIsPayed_.Location = new System.Drawing.Point(111, 208);
            this.chbIsPayed_.Name = "chbIsPayed_";
            this.chbIsPayed_.Size = new System.Drawing.Size(86, 21);
            this.chbIsPayed_.TabIndex = 11;
            this.chbIsPayed_.Text = "Оплачен";
            this.chbIsPayed_.UseVisualStyleBackColor = true;
            // 
            // btnOK_
            // 
            this.btnOK_.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOK_.Location = new System.Drawing.Point(82, 8);
            this.btnOK_.Name = "btnOK_";
            this.btnOK_.Size = new System.Drawing.Size(95, 37);
            this.btnOK_.TabIndex = 0;
            this.btnOK_.Text = "Сохранить";
            this.btnOK_.UseVisualStyleBackColor = true;
            this.btnOK_.Click += new System.EventHandler(this.btnOK__Click);
            // 
            // btnCancel_
            // 
            this.btnCancel_.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel_.Location = new System.Drawing.Point(196, 8);
            this.btnCancel_.Name = "btnCancel_";
            this.btnCancel_.Size = new System.Drawing.Size(95, 37);
            this.btnCancel_.TabIndex = 1;
            this.btnCancel_.Text = "Отменить";
            this.btnCancel_.UseVisualStyleBackColor = true;
            this.btnCancel_.Click += new System.EventHandler(this.btnCancel__Click);
            // 
            // ucBtnClose_
            // 
            this.ucBtnClose_.BackColor = System.Drawing.Color.Transparent;
            this.ucBtnClose_.BackColor_ = System.Drawing.Color.Transparent;
            this.ucBtnClose_.BackColorShadow_ = System.Drawing.Color.Tomato;
            this.ucBtnClose_.Dock = System.Windows.Forms.DockStyle.Right;
            this.ucBtnClose_.Location = new System.Drawing.Point(322, 0);
            this.ucBtnClose_.Margin = new System.Windows.Forms.Padding(4);
            this.ucBtnClose_.Name = "ucBtnClose_";
            this.ucBtnClose_.Size = new System.Drawing.Size(53, 32);
            this.ucBtnClose_.TabIndex = 1;
            this.ucBtnClose_.myMouseEnter_ += new System.EventHandler(this.ucBtnClose__myMouseEnter_);
            this.ucBtnClose_.myMouseLeave_ += new System.EventHandler(this.ucBtnClose__myMouseLeave_);
            this.ucBtnClose_.myClick_ += new System.EventHandler(this.ucBtnClose__myClick_);
            // 
            // FScheduleItem_
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 324);
            this.Controls.Add(this.pnFill);
            this.Controls.Add(this.pnWondowCaption);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FScheduleItem_";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FScheduleItem_";
            this.pnWondowCaption.ResumeLayout(false);
            this.pnFill.ResumeLayout(false);
            this.pnWindowBtns.ResumeLayout(false);
            this.pnData_.ResumeLayout(false);
            this.pnData_.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnWondowCaption;
        private System.Windows.Forms.Label lblFormCaption;
        private UC_FormCloseBtns_ ucBtnClose_;
        private System.Windows.Forms.Panel pnFill;
        private System.Windows.Forms.Panel pnData_;
        private System.Windows.Forms.Panel pnWindowBtns;
        private System.Windows.Forms.CheckBox chbIsPayed_;
        private System.Windows.Forms.CheckBox chbIsAttended_;
        private System.Windows.Forms.TextBox tbDescription_;
        private System.Windows.Forms.Label lblDescription_;
        private System.Windows.Forms.ComboBox cbLessonTopics_;
        private System.Windows.Forms.Label lblLessonTopic_;
        private System.Windows.Forms.ComboBox cbStudents_;
        private System.Windows.Forms.Label lblStudent_;
        private System.Windows.Forms.ComboBox cbLessons_;
        private System.Windows.Forms.Label lblTimeLesson_;
        private System.Windows.Forms.DateTimePicker dtpDateLesson_;
        private System.Windows.Forms.Label lblDateLesson;
        private System.Windows.Forms.Button btnCancel_;
        private System.Windows.Forms.Button btnOK_;
    }
}