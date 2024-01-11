namespace schedule_v2
{
    partial class FMain_
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panTop = new System.Windows.Forms.Panel();
            this.panTopBorder = new System.Windows.Forms.Panel();
            this.pnTaskBtns = new System.Windows.Forms.Panel();
            this.pnScheduleTaskBtns = new System.Windows.Forms.Panel();
            this.BtnDeleteScheduleItem_ = new System.Windows.Forms.Button();
            this.BtnEditScheduleItem_ = new System.Windows.Forms.Button();
            this.BtnAddScheduleItem_ = new System.Windows.Forms.Button();
            this.pnMainMenuForm = new System.Windows.Forms.Panel();
            this.panMenuForm = new System.Windows.Forms.Panel();
            this.lblMainFormCaption = new System.Windows.Forms.Label();
            this.panFill = new System.Windows.Forms.Panel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmSetRedForeColor = new System.Windows.Forms.ToolStripMenuItem();
            this.cmSetYellowForeColor = new System.Windows.Forms.ToolStripMenuItem();
            this.cmSetGreenForeColor = new System.Windows.Forms.ToolStripMenuItem();
            this.cmSetBlueForeColor = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.CancelColorSelectedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnGridTitle = new System.Windows.Forms.Panel();
            this.lblGridTitle = new System.Windows.Forms.Label();
            this.BtnChangeSchedulePeriod = new System.Windows.Forms.Button();
            this.GridMainForm_ = new schedule_v2.data_model_.DataGridViewEx_();
            this.ucBtnPayments_ = new schedule_v2.UC_BtnMenu_();
            this.ucBtnLessons_ = new schedule_v2.UC_BtnMenu_();
            this.ucBtnLessonTopics_ = new schedule_v2.UC_BtnMenu_();
            this.ucBtnStudents_ = new schedule_v2.UC_BtnMenu_();
            this.ucBtnSchedule_ = new schedule_v2.UC_BtnMenu_();
            this.ucFormMinimizeBtn_ = new schedule_v2.UC_FormCloseBtns_();
            this.ucFormCloseBtn_ = new schedule_v2.UC_FormCloseBtns_();
            this.panTop.SuspendLayout();
            this.panTopBorder.SuspendLayout();
            this.pnTaskBtns.SuspendLayout();
            this.pnScheduleTaskBtns.SuspendLayout();
            this.pnMainMenuForm.SuspendLayout();
            this.panMenuForm.SuspendLayout();
            this.panFill.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.pnGridTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridMainForm_)).BeginInit();
            this.SuspendLayout();
            // 
            // panTop
            // 
            this.panTop.BackColor = System.Drawing.Color.White;
            this.panTop.Controls.Add(this.panTopBorder);
            this.panTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panTop.Location = new System.Drawing.Point(0, 0);
            this.panTop.Margin = new System.Windows.Forms.Padding(4);
            this.panTop.Name = "panTop";
            this.panTop.Size = new System.Drawing.Size(1067, 108);
            this.panTop.TabIndex = 0;
            // 
            // panTopBorder
            // 
            this.panTopBorder.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panTopBorder.Controls.Add(this.pnTaskBtns);
            this.panTopBorder.Controls.Add(this.pnMainMenuForm);
            this.panTopBorder.Controls.Add(this.panMenuForm);
            this.panTopBorder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panTopBorder.Location = new System.Drawing.Point(0, 0);
            this.panTopBorder.Margin = new System.Windows.Forms.Padding(4);
            this.panTopBorder.Name = "panTopBorder";
            this.panTopBorder.Size = new System.Drawing.Size(1067, 108);
            this.panTopBorder.TabIndex = 2;
            this.panTopBorder.Paint += new System.Windows.Forms.PaintEventHandler(this.panTopBorder_Paint);
            // 
            // pnTaskBtns
            // 
            this.pnTaskBtns.BackColor = System.Drawing.Color.White;
            this.pnTaskBtns.Controls.Add(this.pnGridTitle);
            this.pnTaskBtns.Controls.Add(this.pnScheduleTaskBtns);
            this.pnTaskBtns.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnTaskBtns.Location = new System.Drawing.Point(0, 68);
            this.pnTaskBtns.Name = "pnTaskBtns";
            this.pnTaskBtns.Padding = new System.Windows.Forms.Padding(1);
            this.pnTaskBtns.Size = new System.Drawing.Size(1067, 40);
            this.pnTaskBtns.TabIndex = 6;
            // 
            // pnScheduleTaskBtns
            // 
            this.pnScheduleTaskBtns.BackColor = System.Drawing.Color.Transparent;
            this.pnScheduleTaskBtns.Controls.Add(this.BtnDeleteScheduleItem_);
            this.pnScheduleTaskBtns.Controls.Add(this.BtnEditScheduleItem_);
            this.pnScheduleTaskBtns.Controls.Add(this.BtnAddScheduleItem_);
            this.pnScheduleTaskBtns.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnScheduleTaskBtns.Location = new System.Drawing.Point(1, 1);
            this.pnScheduleTaskBtns.Name = "pnScheduleTaskBtns";
            this.pnScheduleTaskBtns.Padding = new System.Windows.Forms.Padding(5);
            this.pnScheduleTaskBtns.Size = new System.Drawing.Size(563, 38);
            this.pnScheduleTaskBtns.TabIndex = 0;
            // 
            // BtnDeleteScheduleItem_
            // 
            this.BtnDeleteScheduleItem_.Dock = System.Windows.Forms.DockStyle.Left;
            this.BtnDeleteScheduleItem_.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnDeleteScheduleItem_.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDeleteScheduleItem_.Location = new System.Drawing.Point(269, 5);
            this.BtnDeleteScheduleItem_.Name = "BtnDeleteScheduleItem_";
            this.BtnDeleteScheduleItem_.Size = new System.Drawing.Size(132, 28);
            this.BtnDeleteScheduleItem_.TabIndex = 2;
            this.BtnDeleteScheduleItem_.Text = "Удалить запись";
            this.BtnDeleteScheduleItem_.UseVisualStyleBackColor = true;
            this.BtnDeleteScheduleItem_.Click += new System.EventHandler(this.BtnDeleteScheduleItem__Click);
            // 
            // BtnEditScheduleItem_
            // 
            this.BtnEditScheduleItem_.Dock = System.Windows.Forms.DockStyle.Left;
            this.BtnEditScheduleItem_.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnEditScheduleItem_.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEditScheduleItem_.Location = new System.Drawing.Point(137, 5);
            this.BtnEditScheduleItem_.Name = "BtnEditScheduleItem_";
            this.BtnEditScheduleItem_.Size = new System.Drawing.Size(132, 28);
            this.BtnEditScheduleItem_.TabIndex = 1;
            this.BtnEditScheduleItem_.Text = "Изменить запись";
            this.BtnEditScheduleItem_.UseVisualStyleBackColor = true;
            this.BtnEditScheduleItem_.Click += new System.EventHandler(this.BtnEditScheduleItem__Click);
            // 
            // BtnAddScheduleItem_
            // 
            this.BtnAddScheduleItem_.Dock = System.Windows.Forms.DockStyle.Left;
            this.BtnAddScheduleItem_.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnAddScheduleItem_.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAddScheduleItem_.Location = new System.Drawing.Point(5, 5);
            this.BtnAddScheduleItem_.Name = "BtnAddScheduleItem_";
            this.BtnAddScheduleItem_.Size = new System.Drawing.Size(132, 28);
            this.BtnAddScheduleItem_.TabIndex = 0;
            this.BtnAddScheduleItem_.Text = "Новая запись";
            this.BtnAddScheduleItem_.UseVisualStyleBackColor = true;
            this.BtnAddScheduleItem_.Click += new System.EventHandler(this.BtnAddScheduleItem__Click);
            // 
            // pnMainMenuForm
            // 
            this.pnMainMenuForm.BackColor = System.Drawing.Color.Transparent;
            this.pnMainMenuForm.Controls.Add(this.ucBtnPayments_);
            this.pnMainMenuForm.Controls.Add(this.ucBtnLessons_);
            this.pnMainMenuForm.Controls.Add(this.ucBtnLessonTopics_);
            this.pnMainMenuForm.Controls.Add(this.ucBtnStudents_);
            this.pnMainMenuForm.Controls.Add(this.ucBtnSchedule_);
            this.pnMainMenuForm.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnMainMenuForm.Location = new System.Drawing.Point(0, 32);
            this.pnMainMenuForm.Name = "pnMainMenuForm";
            this.pnMainMenuForm.Size = new System.Drawing.Size(1067, 36);
            this.pnMainMenuForm.TabIndex = 5;
            // 
            // panMenuForm
            // 
            this.panMenuForm.BackColor = System.Drawing.Color.Transparent;
            this.panMenuForm.Controls.Add(this.ucFormMinimizeBtn_);
            this.panMenuForm.Controls.Add(this.ucFormCloseBtn_);
            this.panMenuForm.Controls.Add(this.lblMainFormCaption);
            this.panMenuForm.Dock = System.Windows.Forms.DockStyle.Top;
            this.panMenuForm.Location = new System.Drawing.Point(0, 0);
            this.panMenuForm.Margin = new System.Windows.Forms.Padding(4);
            this.panMenuForm.Name = "panMenuForm";
            this.panMenuForm.Size = new System.Drawing.Size(1067, 32);
            this.panMenuForm.TabIndex = 4;
            // 
            // lblMainFormCaption
            // 
            this.lblMainFormCaption.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblMainFormCaption.ForeColor = System.Drawing.Color.LightCyan;
            this.lblMainFormCaption.Location = new System.Drawing.Point(0, 0);
            this.lblMainFormCaption.Name = "lblMainFormCaption";
            this.lblMainFormCaption.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblMainFormCaption.Size = new System.Drawing.Size(287, 32);
            this.lblMainFormCaption.TabIndex = 1;
            this.lblMainFormCaption.Text = "Планирование уроков";
            this.lblMainFormCaption.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panFill
            // 
            this.panFill.BackColor = System.Drawing.Color.White;
            this.panFill.Controls.Add(this.GridMainForm_);
            this.panFill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panFill.Location = new System.Drawing.Point(0, 108);
            this.panFill.Margin = new System.Windows.Forms.Padding(4);
            this.panFill.Name = "panFill";
            this.panFill.Size = new System.Drawing.Size(1067, 446);
            this.panFill.TabIndex = 2;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmSetRedForeColor,
            this.cmSetYellowForeColor,
            this.cmSetGreenForeColor,
            this.cmSetBlueForeColor,
            this.toolStripMenuItem1,
            this.CancelColorSelectedToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(170, 120);
            // 
            // cmSetRedForeColor
            // 
            this.cmSetRedForeColor.ForeColor = System.Drawing.Color.Red;
            this.cmSetRedForeColor.Name = "cmSetRedForeColor";
            this.cmSetRedForeColor.Size = new System.Drawing.Size(169, 22);
            this.cmSetRedForeColor.Text = "Красный";
            this.cmSetRedForeColor.Click += new System.EventHandler(this.cmSetBlueForeColor_Click);
            // 
            // cmSetYellowForeColor
            // 
            this.cmSetYellowForeColor.ForeColor = System.Drawing.Color.Yellow;
            this.cmSetYellowForeColor.Name = "cmSetYellowForeColor";
            this.cmSetYellowForeColor.Size = new System.Drawing.Size(169, 22);
            this.cmSetYellowForeColor.Text = "Желтый";
            this.cmSetYellowForeColor.Click += new System.EventHandler(this.cmSetBlueForeColor_Click);
            // 
            // cmSetGreenForeColor
            // 
            this.cmSetGreenForeColor.ForeColor = System.Drawing.Color.Green;
            this.cmSetGreenForeColor.Name = "cmSetGreenForeColor";
            this.cmSetGreenForeColor.Size = new System.Drawing.Size(169, 22);
            this.cmSetGreenForeColor.Text = "Зелёный";
            this.cmSetGreenForeColor.Click += new System.EventHandler(this.cmSetBlueForeColor_Click);
            // 
            // cmSetBlueForeColor
            // 
            this.cmSetBlueForeColor.ForeColor = System.Drawing.Color.Blue;
            this.cmSetBlueForeColor.Name = "cmSetBlueForeColor";
            this.cmSetBlueForeColor.Size = new System.Drawing.Size(169, 22);
            this.cmSetBlueForeColor.Text = "Синий";
            this.cmSetBlueForeColor.Click += new System.EventHandler(this.cmSetBlueForeColor_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(166, 6);
            // 
            // CancelColorSelectedToolStripMenuItem
            // 
            this.CancelColorSelectedToolStripMenuItem.Name = "CancelColorSelectedToolStripMenuItem";
            this.CancelColorSelectedToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.CancelColorSelectedToolStripMenuItem.Text = "Снять выделение";
            this.CancelColorSelectedToolStripMenuItem.Click += new System.EventHandler(this.cmSetBlueForeColor_Click);
            // 
            // pnGridTitle
            // 
            this.pnGridTitle.Controls.Add(this.BtnChangeSchedulePeriod);
            this.pnGridTitle.Controls.Add(this.lblGridTitle);
            this.pnGridTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnGridTitle.Location = new System.Drawing.Point(564, 1);
            this.pnGridTitle.Name = "pnGridTitle";
            this.pnGridTitle.Padding = new System.Windows.Forms.Padding(3);
            this.pnGridTitle.Size = new System.Drawing.Size(502, 38);
            this.pnGridTitle.TabIndex = 1;
            // 
            // lblGridTitle
            // 
            this.lblGridTitle.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblGridTitle.Location = new System.Drawing.Point(3, 3);
            this.lblGridTitle.Name = "lblGridTitle";
            this.lblGridTitle.Size = new System.Drawing.Size(336, 32);
            this.lblGridTitle.TabIndex = 0;
            this.lblGridTitle.Text = "Расписание уроков с";
            this.lblGridTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BtnChangeSchedulePeriod
            // 
            this.BtnChangeSchedulePeriod.Dock = System.Windows.Forms.DockStyle.Left;
            this.BtnChangeSchedulePeriod.FlatAppearance.BorderSize = 0;
            this.BtnChangeSchedulePeriod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnChangeSchedulePeriod.Location = new System.Drawing.Point(339, 3);
            this.BtnChangeSchedulePeriod.Name = "BtnChangeSchedulePeriod";
            this.BtnChangeSchedulePeriod.Size = new System.Drawing.Size(149, 32);
            this.BtnChangeSchedulePeriod.TabIndex = 1;
            this.BtnChangeSchedulePeriod.Text = "Другой период";
            this.BtnChangeSchedulePeriod.UseVisualStyleBackColor = true;
            this.BtnChangeSchedulePeriod.Click += new System.EventHandler(this.BtnChangeSchedulePeriod_Click);
            // 
            // GridMainForm_
            // 
            this.GridMainForm_.AllowUserToAddRows = false;
            this.GridMainForm_.AllowUserToDeleteRows = false;
            this.GridMainForm_.AllowUserToResizeRows = false;
            this.GridMainForm_.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridMainForm_.BackgroundColor = System.Drawing.Color.White;
            this.GridMainForm_.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GridMainForm_.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.GridMainForm_.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridMainForm_.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.GridMainForm_.ColumnHeadersHeight = 40;
            this.GridMainForm_.ContextMenuStrip = this.contextMenuStrip1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.PaleTurquoise;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridMainForm_.DefaultCellStyle = dataGridViewCellStyle2;
            this.GridMainForm_.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridMainForm_.EnableHeadersVisualStyles = false;
            this.GridMainForm_.GridColor = System.Drawing.Color.Teal;
            this.GridMainForm_.Location = new System.Drawing.Point(0, 0);
            this.GridMainForm_.MultiSelect = false;
            this.GridMainForm_.Name = "GridMainForm_";
            this.GridMainForm_.ReadOnly = true;
            this.GridMainForm_.RowHeadersVisible = false;
            this.GridMainForm_.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.GridMainForm_.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridMainForm_.Size = new System.Drawing.Size(1067, 446);
            this.GridMainForm_.TabIndex = 0;
            this.GridMainForm_.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.GridMainForm__CellFormatting);
            this.GridMainForm_.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.GridMainForm__CellMouseDown);
            this.GridMainForm_.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.GridMainForm__CellPainting);
            this.GridMainForm_.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.GridMainForm__RowPrePaint);
            this.GridMainForm_.MouseEnter += new System.EventHandler(this.GridMainForm__MouseEnter);
            // 
            // ucBtnPayments_
            // 
            this.ucBtnPayments_.BackColor = System.Drawing.Color.Transparent;
            this.ucBtnPayments_.BackColor_ = System.Drawing.Color.Transparent;
            this.ucBtnPayments_.BackColorActive_ = System.Drawing.Color.White;
            this.ucBtnPayments_.BackColorShadow_ = System.Drawing.Color.CadetBlue;
            this.ucBtnPayments_.Dock = System.Windows.Forms.DockStyle.Left;
            this.ucBtnPayments_.ForeColor = System.Drawing.Color.White;
            this.ucBtnPayments_.Location = new System.Drawing.Point(747, 0);
            this.ucBtnPayments_.Margin = new System.Windows.Forms.Padding(5);
            this.ucBtnPayments_.Name = "ucBtnPayments_";
            this.ucBtnPayments_.Size = new System.Drawing.Size(183, 36);
            this.ucBtnPayments_.TabIndex = 4;
            this.ucBtnPayments_.myMouseEnter_ += new System.EventHandler(this.ucBtnSchedule__myMouseEnter_);
            this.ucBtnPayments_.myMouseLeave_ += new System.EventHandler(this.ucBtnSchedule__myMouseLeave_);
            this.ucBtnPayments_.myClick_ += new System.EventHandler(this.ucBtnPayments__myClick_);
            // 
            // ucBtnLessons_
            // 
            this.ucBtnLessons_.BackColor = System.Drawing.Color.Transparent;
            this.ucBtnLessons_.BackColor_ = System.Drawing.Color.Transparent;
            this.ucBtnLessons_.BackColorActive_ = System.Drawing.Color.White;
            this.ucBtnLessons_.BackColorShadow_ = System.Drawing.Color.CadetBlue;
            this.ucBtnLessons_.Dock = System.Windows.Forms.DockStyle.Left;
            this.ucBtnLessons_.ForeColor = System.Drawing.Color.White;
            this.ucBtnLessons_.Location = new System.Drawing.Point(564, 0);
            this.ucBtnLessons_.Margin = new System.Windows.Forms.Padding(5);
            this.ucBtnLessons_.Name = "ucBtnLessons_";
            this.ucBtnLessons_.Size = new System.Drawing.Size(183, 36);
            this.ucBtnLessons_.TabIndex = 3;
            this.ucBtnLessons_.myMouseEnter_ += new System.EventHandler(this.ucBtnSchedule__myMouseEnter_);
            this.ucBtnLessons_.myMouseLeave_ += new System.EventHandler(this.ucBtnSchedule__myMouseLeave_);
            this.ucBtnLessons_.myClick_ += new System.EventHandler(this.ucBtnLessons__myClick_);
            // 
            // ucBtnLessonTopics_
            // 
            this.ucBtnLessonTopics_.BackColor = System.Drawing.Color.Transparent;
            this.ucBtnLessonTopics_.BackColor_ = System.Drawing.Color.Transparent;
            this.ucBtnLessonTopics_.BackColorActive_ = System.Drawing.Color.White;
            this.ucBtnLessonTopics_.BackColorShadow_ = System.Drawing.Color.CadetBlue;
            this.ucBtnLessonTopics_.Dock = System.Windows.Forms.DockStyle.Left;
            this.ucBtnLessonTopics_.ForeColor = System.Drawing.Color.White;
            this.ucBtnLessonTopics_.Location = new System.Drawing.Point(320, 0);
            this.ucBtnLessonTopics_.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.ucBtnLessonTopics_.Name = "ucBtnLessonTopics_";
            this.ucBtnLessonTopics_.Size = new System.Drawing.Size(244, 36);
            this.ucBtnLessonTopics_.TabIndex = 2;
            this.ucBtnLessonTopics_.myMouseEnter_ += new System.EventHandler(this.ucBtnSchedule__myMouseEnter_);
            this.ucBtnLessonTopics_.myMouseLeave_ += new System.EventHandler(this.ucBtnSchedule__myMouseLeave_);
            this.ucBtnLessonTopics_.myClick_ += new System.EventHandler(this.ucBtnLessonTopics__myClick_);
            // 
            // ucBtnStudents_
            // 
            this.ucBtnStudents_.BackColor = System.Drawing.Color.Transparent;
            this.ucBtnStudents_.BackColor_ = System.Drawing.Color.Transparent;
            this.ucBtnStudents_.BackColorActive_ = System.Drawing.Color.White;
            this.ucBtnStudents_.BackColorShadow_ = System.Drawing.Color.CadetBlue;
            this.ucBtnStudents_.Dock = System.Windows.Forms.DockStyle.Left;
            this.ucBtnStudents_.ForeColor = System.Drawing.Color.White;
            this.ucBtnStudents_.Location = new System.Drawing.Point(137, 0);
            this.ucBtnStudents_.Margin = new System.Windows.Forms.Padding(5);
            this.ucBtnStudents_.Name = "ucBtnStudents_";
            this.ucBtnStudents_.Size = new System.Drawing.Size(183, 36);
            this.ucBtnStudents_.TabIndex = 1;
            this.ucBtnStudents_.myMouseEnter_ += new System.EventHandler(this.ucBtnSchedule__myMouseEnter_);
            this.ucBtnStudents_.myMouseLeave_ += new System.EventHandler(this.ucBtnSchedule__myMouseLeave_);
            this.ucBtnStudents_.myClick_ += new System.EventHandler(this.ucBtnStudents__myClick_);
            // 
            // ucBtnSchedule_
            // 
            this.ucBtnSchedule_.BackColor = System.Drawing.Color.Transparent;
            this.ucBtnSchedule_.BackColor_ = System.Drawing.Color.Transparent;
            this.ucBtnSchedule_.BackColorActive_ = System.Drawing.Color.White;
            this.ucBtnSchedule_.BackColorShadow_ = System.Drawing.Color.CadetBlue;
            this.ucBtnSchedule_.Dock = System.Windows.Forms.DockStyle.Left;
            this.ucBtnSchedule_.ForeColor = System.Drawing.Color.White;
            this.ucBtnSchedule_.Location = new System.Drawing.Point(0, 0);
            this.ucBtnSchedule_.Margin = new System.Windows.Forms.Padding(4);
            this.ucBtnSchedule_.Name = "ucBtnSchedule_";
            this.ucBtnSchedule_.Size = new System.Drawing.Size(137, 36);
            this.ucBtnSchedule_.TabIndex = 0;
            this.ucBtnSchedule_.myMouseEnter_ += new System.EventHandler(this.ucBtnSchedule__myMouseEnter_);
            this.ucBtnSchedule_.myMouseLeave_ += new System.EventHandler(this.ucBtnSchedule__myMouseLeave_);
            this.ucBtnSchedule_.myClick_ += new System.EventHandler(this.ucBtnSchedule__myClick_);
            // 
            // ucFormMinimizeBtn_
            // 
            this.ucFormMinimizeBtn_.BackColor = System.Drawing.Color.Transparent;
            this.ucFormMinimizeBtn_.BackColor_ = System.Drawing.Color.Transparent;
            this.ucFormMinimizeBtn_.BackColorShadow_ = System.Drawing.Color.CadetBlue;
            this.ucFormMinimizeBtn_.Dock = System.Windows.Forms.DockStyle.Right;
            this.ucFormMinimizeBtn_.Location = new System.Drawing.Point(901, 0);
            this.ucFormMinimizeBtn_.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.ucFormMinimizeBtn_.Name = "ucFormMinimizeBtn_";
            this.ucFormMinimizeBtn_.Size = new System.Drawing.Size(95, 32);
            this.ucFormMinimizeBtn_.TabIndex = 7;
            this.ucFormMinimizeBtn_.myMouseEnter_ += new System.EventHandler(this.ucFormMinimizeBtn__myMouseEnter_);
            this.ucFormMinimizeBtn_.myMouseLeave_ += new System.EventHandler(this.ucFormMinimizeBtn__myMouseLeave_);
            this.ucFormMinimizeBtn_.myClick_ += new System.EventHandler(this.ucFormMinimizeBtn__myClick_);
            // 
            // ucFormCloseBtn_
            // 
            this.ucFormCloseBtn_.BackColor = System.Drawing.Color.Transparent;
            this.ucFormCloseBtn_.BackColor_ = System.Drawing.Color.Transparent;
            this.ucFormCloseBtn_.BackColorShadow_ = System.Drawing.Color.Tomato;
            this.ucFormCloseBtn_.Dock = System.Windows.Forms.DockStyle.Right;
            this.ucFormCloseBtn_.Location = new System.Drawing.Point(996, 0);
            this.ucFormCloseBtn_.Margin = new System.Windows.Forms.Padding(5);
            this.ucFormCloseBtn_.Name = "ucFormCloseBtn_";
            this.ucFormCloseBtn_.Size = new System.Drawing.Size(71, 32);
            this.ucFormCloseBtn_.TabIndex = 6;
            this.ucFormCloseBtn_.myMouseEnter_ += new System.EventHandler(this.ucFormMinimizeBtn__myMouseEnter_);
            this.ucFormCloseBtn_.myMouseLeave_ += new System.EventHandler(this.ucFormMinimizeBtn__myMouseLeave_);
            this.ucFormCloseBtn_.myClick_ += new System.EventHandler(this.ucFormCloseBtn__myClick_);
            // 
            // FMain_
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.panFill);
            this.Controls.Add(this.panTop);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FMain_";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FMain__Load);
            this.panTop.ResumeLayout(false);
            this.panTopBorder.ResumeLayout(false);
            this.pnTaskBtns.ResumeLayout(false);
            this.pnScheduleTaskBtns.ResumeLayout(false);
            this.pnMainMenuForm.ResumeLayout(false);
            this.panMenuForm.ResumeLayout(false);
            this.panFill.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.pnGridTitle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridMainForm_)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panTop;
        private System.Windows.Forms.Panel panFill;
        private System.Windows.Forms.Panel panTopBorder;
        private System.Windows.Forms.Panel panMenuForm;
        // private System.Windows.Forms.DataGridView GridMainForm_;
        private schedule_v2.data_model_.DataGridViewEx_ GridMainForm_;
        private System.Windows.Forms.Label lblMainFormCaption;
        private System.Windows.Forms.Panel pnMainMenuForm;
        private UC_BtnMenu_ ucBtnPayments_;
        private UC_BtnMenu_ ucBtnLessons_;
        private UC_BtnMenu_ ucBtnLessonTopics_;
        private UC_BtnMenu_ ucBtnStudents_;
        private UC_BtnMenu_ ucBtnSchedule_;
        private UC_FormCloseBtns_ ucFormMinimizeBtn_;
        private UC_FormCloseBtns_ ucFormCloseBtn_;
        private System.Windows.Forms.Panel pnTaskBtns;
        private System.Windows.Forms.Panel pnScheduleTaskBtns;
        private System.Windows.Forms.Button BtnEditScheduleItem_;
        private System.Windows.Forms.Button BtnAddScheduleItem_;
        private System.Windows.Forms.Button BtnDeleteScheduleItem_;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cmSetRedForeColor;
        private System.Windows.Forms.ToolStripMenuItem cmSetYellowForeColor;
        private System.Windows.Forms.ToolStripMenuItem cmSetGreenForeColor;
        private System.Windows.Forms.ToolStripMenuItem cmSetBlueForeColor;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem CancelColorSelectedToolStripMenuItem;
        private System.Windows.Forms.Panel pnGridTitle;
        private System.Windows.Forms.Button BtnChangeSchedulePeriod;
        private System.Windows.Forms.Label lblGridTitle;
    }
}

