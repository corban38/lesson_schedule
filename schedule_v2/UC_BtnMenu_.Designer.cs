namespace schedule_v2
{
    partial class UC_BtnMenu_
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblCaption = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCaption
            // 
            this.lblCaption.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCaption.Location = new System.Drawing.Point(0, 0);
            this.lblCaption.Name = "lblCaption";
            this.lblCaption.Size = new System.Drawing.Size(221, 84);
            this.lblCaption.TabIndex = 0;
            this.lblCaption.Text = "label1";
            this.lblCaption.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCaption.Click += new System.EventHandler(this.lblCaption_Click);
            this.lblCaption.MouseEnter += new System.EventHandler(this.lblCaption_MouseEnter);
            this.lblCaption.MouseLeave += new System.EventHandler(this.lblCaption_MouseLeave);
            // 
            // UC_BtnMenu_
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblCaption);
            this.Name = "UC_BtnMenu_";
            this.Size = new System.Drawing.Size(221, 84);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblCaption;
    }
}
