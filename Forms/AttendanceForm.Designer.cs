namespace dnts.Forms
{
    partial class AttendanceForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AttendanceForm));
            this.pnlFrame1 = new System.Windows.Forms.Panel();
            this.dataGridView_AssistantsLoggedIn = new System.Windows.Forms.DataGridView();
            this.Name1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeIn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeOut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Attendance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlFrame2 = new System.Windows.Forms.Panel();
            this.dateTimePickerBunifuItachi1 = new ItachiUIBunifu.DateTimePickerBunifuItachi();
            this.pnlFrame3 = new System.Windows.Forms.Panel();
            this.testLogOut = new System.Windows.Forms.Button();
            this.testLogIn = new System.Windows.Forms.Button();
            this.pnlNotificationPanel = new System.Windows.Forms.Panel();
            this.lblNotificationMessage = new System.Windows.Forms.Label();
            this.UIBehavior = new System.Windows.Forms.Timer(this.components);
            this.UIClock = new System.Windows.Forms.Timer(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.pnlTime = new System.Windows.Forms.Panel();
            this.lbl_time = new System.Windows.Forms.Label();
            this.pictureBoxBunifuItachi1 = new ItachiUIBunifu.PictureBoxBunifuItachi();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlFrame1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_AssistantsLoggedIn)).BeginInit();
            this.pnlFrame2.SuspendLayout();
            this.pnlFrame3.SuspendLayout();
            this.pnlNotificationPanel.SuspendLayout();
            this.pnlTime.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBunifuItachi1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlFrame1
            // 
            this.pnlFrame1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(229)))), ((int)(((byte)(247)))));
            this.pnlFrame1.Controls.Add(this.dataGridView_AssistantsLoggedIn);
            this.pnlFrame1.Controls.Add(this.label2);
            this.pnlFrame1.Location = new System.Drawing.Point(50, 71);
            this.pnlFrame1.Name = "pnlFrame1";
            this.pnlFrame1.Size = new System.Drawing.Size(856, 632);
            this.pnlFrame1.TabIndex = 4;
            // 
            // dataGridView_AssistantsLoggedIn
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Format = "t";
            dataGridViewCellStyle1.NullValue = "--:--";
            this.dataGridView_AssistantsLoggedIn.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_AssistantsLoggedIn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(229)))), ((int)(((byte)(247)))));
            this.dataGridView_AssistantsLoggedIn.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_AssistantsLoggedIn.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView_AssistantsLoggedIn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_AssistantsLoggedIn.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Name1,
            this.TimeIn,
            this.TimeOut,
            this.Attendance,
            this.Status});
            this.dataGridView_AssistantsLoggedIn.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(229)))), ((int)(((byte)(247)))));
            this.dataGridView_AssistantsLoggedIn.Location = new System.Drawing.Point(51, 75);
            this.dataGridView_AssistantsLoggedIn.Name = "dataGridView_AssistantsLoggedIn";
            this.dataGridView_AssistantsLoggedIn.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.Format = "t";
            dataGridViewCellStyle7.NullValue = null;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_AssistantsLoggedIn.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewCellStyle8.NullValue = null;
            this.dataGridView_AssistantsLoggedIn.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridView_AssistantsLoggedIn.RowTemplate.ReadOnly = true;
            this.dataGridView_AssistantsLoggedIn.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_AssistantsLoggedIn.Size = new System.Drawing.Size(745, 330);
            this.dataGridView_AssistantsLoggedIn.TabIndex = 5;
            // 
            // Name1
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(49)))), ((int)(((byte)(84)))));
            this.Name1.DefaultCellStyle = dataGridViewCellStyle2;
            this.Name1.HeaderText = "Name";
            this.Name1.Name = "Name1";
            this.Name1.ReadOnly = true;
            this.Name1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Name1.ToolTipText = "Technical Assistant\'s Name";
            this.Name1.Width = 300;
            // 
            // TimeIn
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(49)))), ((int)(((byte)(84)))));
            this.TimeIn.DefaultCellStyle = dataGridViewCellStyle3;
            this.TimeIn.HeaderText = "Time In";
            this.TimeIn.Name = "TimeIn";
            this.TimeIn.ReadOnly = true;
            this.TimeIn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.TimeIn.ToolTipText = "Time logged In";
            // 
            // TimeOut
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(49)))), ((int)(((byte)(84)))));
            this.TimeOut.DefaultCellStyle = dataGridViewCellStyle4;
            this.TimeOut.HeaderText = "Time Out";
            this.TimeOut.Name = "TimeOut";
            this.TimeOut.ReadOnly = true;
            this.TimeOut.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.TimeOut.ToolTipText = "Time Logged Out";
            // 
            // Attendance
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(49)))), ((int)(((byte)(84)))));
            this.Attendance.DefaultCellStyle = dataGridViewCellStyle5;
            this.Attendance.HeaderText = "Attendance";
            this.Attendance.Name = "Attendance";
            this.Attendance.ReadOnly = true;
            this.Attendance.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Attendance.ToolTipText = "Technical Assistant\'s Attendance";
            // 
            // Status
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(49)))), ((int)(((byte)(84)))));
            this.Status.DefaultCellStyle = dataGridViewCellStyle6;
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Status.ToolTipText = "Busy or Available";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(49)))), ((int)(((byte)(84)))));
            this.label2.Location = new System.Drawing.Point(286, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(239, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "ATTENDANCE FOR TODAY";
            // 
            // pnlFrame2
            // 
            this.pnlFrame2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(233)))), ((int)(((byte)(255)))));
            this.pnlFrame2.Controls.Add(this.pnlTime);
            this.pnlFrame2.Controls.Add(this.dateTimePickerBunifuItachi1);
            this.pnlFrame2.Location = new System.Drawing.Point(925, 72);
            this.pnlFrame2.Name = "pnlFrame2";
            this.pnlFrame2.Size = new System.Drawing.Size(392, 133);
            this.pnlFrame2.TabIndex = 5;
            // 
            // dateTimePickerBunifuItachi1
            // 
            this.dateTimePickerBunifuItachi1.BorderColor = System.Drawing.Color.Aqua;
            this.dateTimePickerBunifuItachi1.BorderSize = 0;
            this.dateTimePickerBunifuItachi1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerBunifuItachi1.Location = new System.Drawing.Point(12, 16);
            this.dateTimePickerBunifuItachi1.MinimumSize = new System.Drawing.Size(4, 35);
            this.dateTimePickerBunifuItachi1.Name = "dateTimePickerBunifuItachi1";
            this.dateTimePickerBunifuItachi1.Size = new System.Drawing.Size(360, 35);
            this.dateTimePickerBunifuItachi1.SkinColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(233)))), ((int)(((byte)(255)))));
            this.dateTimePickerBunifuItachi1.TabIndex = 0;
            this.dateTimePickerBunifuItachi1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(49)))), ((int)(((byte)(84)))));
            // 
            // pnlFrame3
            // 
            this.pnlFrame3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(224)))), ((int)(((byte)(255)))));
            this.pnlFrame3.Controls.Add(this.pictureBox1);
            this.pnlFrame3.Controls.Add(this.testLogOut);
            this.pnlFrame3.Controls.Add(this.testLogIn);
            this.pnlFrame3.Location = new System.Drawing.Point(925, 223);
            this.pnlFrame3.Name = "pnlFrame3";
            this.pnlFrame3.Size = new System.Drawing.Size(392, 480);
            this.pnlFrame3.TabIndex = 6;
            // 
            // testLogOut
            // 
            this.testLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.testLogOut.Location = new System.Drawing.Point(322, 440);
            this.testLogOut.Name = "testLogOut";
            this.testLogOut.Size = new System.Drawing.Size(70, 23);
            this.testLogOut.TabIndex = 0;
            this.testLogOut.Text = "test log out";
            this.testLogOut.UseVisualStyleBackColor = true;
            this.testLogOut.Click += new System.EventHandler(this.testLogOut_Click);
            // 
            // testLogIn
            // 
            this.testLogIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.testLogIn.Location = new System.Drawing.Point(322, 412);
            this.testLogIn.Name = "testLogIn";
            this.testLogIn.Size = new System.Drawing.Size(70, 23);
            this.testLogIn.TabIndex = 0;
            this.testLogIn.Text = "test log in";
            this.testLogIn.UseVisualStyleBackColor = true;
            this.testLogIn.Click += new System.EventHandler(this.testLogIn_Click);
            // 
            // pnlNotificationPanel
            // 
            this.pnlNotificationPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(125)))), ((int)(((byte)(186)))));
            this.pnlNotificationPanel.Controls.Add(this.panel3);
            this.pnlNotificationPanel.Controls.Add(this.lblNotificationMessage);
            this.pnlNotificationPanel.Location = new System.Drawing.Point(1033, 212);
            this.pnlNotificationPanel.Name = "pnlNotificationPanel";
            this.pnlNotificationPanel.Size = new System.Drawing.Size(392, 55);
            this.pnlNotificationPanel.TabIndex = 7;
            // 
            // lblNotificationMessage
            // 
            this.lblNotificationMessage.AutoSize = true;
            this.lblNotificationMessage.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotificationMessage.ForeColor = System.Drawing.Color.White;
            this.lblNotificationMessage.Location = new System.Drawing.Point(56, 14);
            this.lblNotificationMessage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNotificationMessage.Name = "lblNotificationMessage";
            this.lblNotificationMessage.Size = new System.Drawing.Size(216, 27);
            this.lblNotificationMessage.TabIndex = 4;
            this.lblNotificationMessage.Text = "You have successfully logged In";
            // 
            // UIBehavior
            // 
            this.UIBehavior.Enabled = true;
            this.UIBehavior.Interval = 10;
            this.UIBehavior.Tick += new System.EventHandler(this.UI_Behavior);
            // 
            // UIClock
            // 
            this.UIClock.Enabled = true;
            this.UIClock.Interval = 1000;
            this.UIClock.Tick += new System.EventHandler(this.UI_Clock);
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::dnts.Properties.Resources.check;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Location = new System.Drawing.Point(7, 8);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(39, 38);
            this.panel3.TabIndex = 5;
            // 
            // pnlTime
            // 
            this.pnlTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(182)))), ((int)(((byte)(219)))));
            this.pnlTime.BackgroundImage = global::dnts.Properties.Resources.clockBG;
            this.pnlTime.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlTime.Controls.Add(this.lbl_time);
            this.pnlTime.Location = new System.Drawing.Point(10, 57);
            this.pnlTime.Name = "pnlTime";
            this.pnlTime.Size = new System.Drawing.Size(372, 66);
            this.pnlTime.TabIndex = 1;
            // 
            // lbl_time
            // 
            this.lbl_time.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_time.AutoSize = true;
            this.lbl_time.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_time.Font = new System.Drawing.Font("Century Gothic", 38.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_time.ForeColor = System.Drawing.Color.White;
            this.lbl_time.Location = new System.Drawing.Point(28, -1);
            this.lbl_time.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_time.Name = "lbl_time";
            this.lbl_time.Size = new System.Drawing.Size(235, 60);
            this.lbl_time.TabIndex = 3;
            this.lbl_time.Text = "--:--:-- --";
            // 
            // pictureBoxBunifuItachi1
            // 
            this.pictureBoxBunifuItachi1.BackColor = System.Drawing.Color.White;
            this.pictureBoxBunifuItachi1.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.pictureBoxBunifuItachi1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(190)))), ((int)(((byte)(227)))));
            this.pictureBoxBunifuItachi1.BorderColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(49)))), ((int)(((byte)(107)))));
            this.pictureBoxBunifuItachi1.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.DashDotDot;
            this.pictureBoxBunifuItachi1.BorderSize = 3;
            this.pictureBoxBunifuItachi1.GradientAngle = 50F;
            this.pictureBoxBunifuItachi1.Image = global::dnts.Properties.Resources.dntsLogo;
            this.pictureBoxBunifuItachi1.InitialImage = global::dnts.Properties.Resources.dntsLogo;
            this.pictureBoxBunifuItachi1.Location = new System.Drawing.Point(12, 6);
            this.pictureBoxBunifuItachi1.Name = "pictureBoxBunifuItachi1";
            this.pictureBoxBunifuItachi1.Size = new System.Drawing.Size(85, 85);
            this.pictureBoxBunifuItachi1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxBunifuItachi1.TabIndex = 3;
            this.pictureBoxBunifuItachi1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::dnts.Properties.Resources.header;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1336, 53);
            this.panel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
            this.label3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(49)))), ((int)(((byte)(84)))));
            this.label3.Location = new System.Drawing.Point(99, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(301, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Department of Network and Technical Services System";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(49)))), ((int)(((byte)(84)))));
            this.label1.Location = new System.Drawing.Point(96, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(298, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "EMPLOYEE ATTENDANCE";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(123, 66);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 139);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // AttendanceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1336, 725);
            this.Controls.Add(this.pnlNotificationPanel);
            this.Controls.Add(this.pnlFrame3);
            this.Controls.Add(this.pnlFrame2);
            this.Controls.Add(this.pictureBoxBunifuItachi1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlFrame1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AttendanceForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AttendanceForm";
            this.Load += new System.EventHandler(this.AttendanceForm_Load);
            this.pnlFrame1.ResumeLayout(false);
            this.pnlFrame1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_AssistantsLoggedIn)).EndInit();
            this.pnlFrame2.ResumeLayout(false);
            this.pnlFrame3.ResumeLayout(false);
            this.pnlNotificationPanel.ResumeLayout(false);
            this.pnlNotificationPanel.PerformLayout();
            this.pnlTime.ResumeLayout(false);
            this.pnlTime.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBunifuItachi1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private ItachiUIBunifu.PictureBoxBunifuItachi pictureBoxBunifuItachi1;
        private System.Windows.Forms.Panel pnlFrame1;
        private System.Windows.Forms.DataGridView dataGridView_AssistantsLoggedIn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlFrame2;
        private ItachiUIBunifu.DateTimePickerBunifuItachi dateTimePickerBunifuItachi1;
        private System.Windows.Forms.Panel pnlTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeIn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeOut;
        private System.Windows.Forms.DataGridViewTextBoxColumn Attendance;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.Label lbl_time;
        private System.Windows.Forms.Panel pnlNotificationPanel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblNotificationMessage;
        private System.Windows.Forms.Panel pnlFrame3;
        private System.Windows.Forms.Button testLogOut;
        private System.Windows.Forms.Button testLogIn;
        private System.Windows.Forms.Timer UIBehavior;
        private System.Windows.Forms.Timer UIClock;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}