namespace dnts
{
    partial class frmLoadIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLoadIn));
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBoxBunifuItachi1 = new ItachiUIBunifu.PictureBoxBunifuItachi();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBunifuItachi1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
            this.label1.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(49)))), ((int)(((byte)(84)))));
            this.label1.Location = new System.Drawing.Point(452, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(443, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "INFORMATION MANAGER";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(49)))), ((int)(((byte)(84)))));
            this.label3.Location = new System.Drawing.Point(455, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(436, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Department of Network and Technical Services System";
            // 
            // pictureBoxBunifuItachi1
            // 
            this.pictureBoxBunifuItachi1.BackColor = System.Drawing.Color.White;
            this.pictureBoxBunifuItachi1.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.pictureBoxBunifuItachi1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(190)))), ((int)(((byte)(227)))));
            this.pictureBoxBunifuItachi1.BorderColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(49)))), ((int)(((byte)(107)))));
            this.pictureBoxBunifuItachi1.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.DashDotDot;
            this.pictureBoxBunifuItachi1.BorderSize = 8;
            this.pictureBoxBunifuItachi1.GradientAngle = 50F;
            this.pictureBoxBunifuItachi1.Image = global::dnts.Properties.Resources.dntsLogo;
            this.pictureBoxBunifuItachi1.InitialImage = global::dnts.Properties.Resources.dntsLogo;
            this.pictureBoxBunifuItachi1.Location = new System.Drawing.Point(45, 53);
            this.pictureBoxBunifuItachi1.Name = "pictureBoxBunifuItachi1";
            this.pictureBoxBunifuItachi1.Size = new System.Drawing.Size(359, 359);
            this.pictureBoxBunifuItachi1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxBunifuItachi1.TabIndex = 3;
            this.pictureBoxBunifuItachi1.TabStop = false;
            // 
            // frmLoadIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(962, 460);
            this.Controls.Add(this.pictureBoxBunifuItachi1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmLoadIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DNTS";
            this.Load += new System.EventHandler(this.frmLoadingWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBunifuItachi1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private ItachiUIBunifu.PictureBoxBunifuItachi pictureBoxBunifuItachi1;
    }
}

