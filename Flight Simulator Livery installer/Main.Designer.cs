namespace Flight_Simulator_Livery_installer
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.closebtn = new System.Windows.Forms.PictureBox();
            this.minimizebtn = new System.Windows.Forms.PictureBox();
            this.titlelbl = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.currentInstalledlbl = new System.Windows.Forms.Label();
            this.currentTitlelbl = new System.Windows.Forms.Label();
            this.currentInstalledTitlelbl = new System.Windows.Forms.Label();
            this.installbtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.downloadbar = new System.Windows.Forms.ProgressBar();
            this.progressbarAnimation = new System.Windows.Forms.Timer(this.components);
            this.currentVersionlbl = new System.Windows.Forms.Label();
            this.progressbarAnimationHide = new System.Windows.Forms.Timer(this.components);
            this.refreshbtn = new System.Windows.Forms.PictureBox();
            this.networkSpeed = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.closebtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizebtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.refreshbtn)).BeginInit();
            this.SuspendLayout();
            // 
            // closebtn
            // 
            this.closebtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closebtn.Image = ((System.Drawing.Image)(resources.GetObject("closebtn.Image")));
            this.closebtn.Location = new System.Drawing.Point(582, 12);
            this.closebtn.Name = "closebtn";
            this.closebtn.Size = new System.Drawing.Size(32, 32);
            this.closebtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.closebtn.TabIndex = 0;
            this.closebtn.TabStop = false;
            this.closebtn.Click += new System.EventHandler(this.Closebtn_Click);
            // 
            // minimizebtn
            // 
            this.minimizebtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minimizebtn.Image = ((System.Drawing.Image)(resources.GetObject("minimizebtn.Image")));
            this.minimizebtn.Location = new System.Drawing.Point(544, 12);
            this.minimizebtn.Name = "minimizebtn";
            this.minimizebtn.Size = new System.Drawing.Size(32, 32);
            this.minimizebtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.minimizebtn.TabIndex = 1;
            this.minimizebtn.TabStop = false;
            this.minimizebtn.Click += new System.EventHandler(this.Minimizebtn_Click);
            // 
            // titlelbl
            // 
            this.titlelbl.Font = new System.Drawing.Font("Microsoft YaHei", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titlelbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(157)))), ((int)(((byte)(185)))));
            this.titlelbl.Location = new System.Drawing.Point(1, 4);
            this.titlelbl.Name = "titlelbl";
            this.titlelbl.Size = new System.Drawing.Size(627, 44);
            this.titlelbl.TabIndex = 2;
            this.titlelbl.Text = "Livery installer";
            this.titlelbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.titlelbl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Titlelbl_MouseDown);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(157)))), ((int)(((byte)(185)))));
            this.pictureBox3.Location = new System.Drawing.Point(0, 56);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(628, 1);
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // currentInstalledlbl
            // 
            this.currentInstalledlbl.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentInstalledlbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.currentInstalledlbl.Location = new System.Drawing.Point(1, 280);
            this.currentInstalledlbl.Name = "currentInstalledlbl";
            this.currentInstalledlbl.Size = new System.Drawing.Size(627, 44);
            this.currentInstalledlbl.TabIndex = 8;
            this.currentInstalledlbl.Text = "7.1";
            this.currentInstalledlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // currentTitlelbl
            // 
            this.currentTitlelbl.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentTitlelbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(157)))), ((int)(((byte)(185)))));
            this.currentTitlelbl.Location = new System.Drawing.Point(1, 56);
            this.currentTitlelbl.Name = "currentTitlelbl";
            this.currentTitlelbl.Size = new System.Drawing.Size(627, 44);
            this.currentTitlelbl.TabIndex = 7;
            this.currentTitlelbl.Text = "Latest version";
            this.currentTitlelbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // currentInstalledTitlelbl
            // 
            this.currentInstalledTitlelbl.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentInstalledTitlelbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(157)))), ((int)(((byte)(185)))));
            this.currentInstalledTitlelbl.Location = new System.Drawing.Point(1, 240);
            this.currentInstalledTitlelbl.Name = "currentInstalledTitlelbl";
            this.currentInstalledTitlelbl.Size = new System.Drawing.Size(627, 44);
            this.currentInstalledTitlelbl.TabIndex = 9;
            this.currentInstalledTitlelbl.Text = "Current version installed";
            this.currentInstalledTitlelbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // installbtn
            // 
            this.installbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.installbtn.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.installbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(157)))), ((int)(((byte)(185)))));
            this.installbtn.Location = new System.Drawing.Point(242, 171);
            this.installbtn.Name = "installbtn";
            this.installbtn.Size = new System.Drawing.Size(145, 42);
            this.installbtn.TabIndex = 10;
            this.installbtn.Text = "Install";
            this.installbtn.UseVisualStyleBackColor = true;
            this.installbtn.Click += new System.EventHandler(this.Installbtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(157)))), ((int)(((byte)(185)))));
            this.pictureBox1.Location = new System.Drawing.Point(1, 237);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(628, 1);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // downloadbar
            // 
            this.downloadbar.Location = new System.Drawing.Point(242, 171);
            this.downloadbar.Name = "downloadbar";
            this.downloadbar.Size = new System.Drawing.Size(145, 23);
            this.downloadbar.TabIndex = 12;
            this.downloadbar.Visible = false;
            // 
            // progressbarAnimation
            // 
            this.progressbarAnimation.Interval = 10;
            this.progressbarAnimation.Tick += new System.EventHandler(this.ProgressbarAnimation_Tick);
            // 
            // currentVersionlbl
            // 
            this.currentVersionlbl.Font = new System.Drawing.Font("Microsoft YaHei", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentVersionlbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.currentVersionlbl.Location = new System.Drawing.Point(1, 100);
            this.currentVersionlbl.Name = "currentVersionlbl";
            this.currentVersionlbl.Size = new System.Drawing.Size(627, 38);
            this.currentVersionlbl.TabIndex = 13;
            this.currentVersionlbl.Text = "7.2";
            this.currentVersionlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // progressbarAnimationHide
            // 
            this.progressbarAnimationHide.Interval = 10;
            this.progressbarAnimationHide.Tick += new System.EventHandler(this.ProgressbarAnimationHide_Tick);
            // 
            // refreshbtn
            // 
            this.refreshbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.refreshbtn.Image = ((System.Drawing.Image)(resources.GetObject("refreshbtn.Image")));
            this.refreshbtn.Location = new System.Drawing.Point(506, 12);
            this.refreshbtn.Name = "refreshbtn";
            this.refreshbtn.Size = new System.Drawing.Size(32, 32);
            this.refreshbtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.refreshbtn.TabIndex = 14;
            this.refreshbtn.TabStop = false;
            this.refreshbtn.Click += new System.EventHandler(this.Refreshbtn_Click);
            // 
            // networkSpeed
            // 
            this.networkSpeed.Interval = 1000;
            this.networkSpeed.Tick += new System.EventHandler(this.NetworkSpeed_Tick);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(31)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(629, 328);
            this.Controls.Add(this.refreshbtn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.currentInstalledTitlelbl);
            this.Controls.Add(this.currentInstalledlbl);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.minimizebtn);
            this.Controls.Add(this.closebtn);
            this.Controls.Add(this.titlelbl);
            this.Controls.Add(this.installbtn);
            this.Controls.Add(this.downloadbar);
            this.Controls.Add(this.currentVersionlbl);
            this.Controls.Add(this.currentTitlelbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "Flight Simulator 2020 livery installer";
            this.Load += new System.EventHandler(this.Main_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Main_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Main_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.closebtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizebtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.refreshbtn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox closebtn;
        private System.Windows.Forms.PictureBox minimizebtn;
        private System.Windows.Forms.Label titlelbl;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label currentInstalledlbl;
        private System.Windows.Forms.Label currentTitlelbl;
        private System.Windows.Forms.Label currentInstalledTitlelbl;
        private System.Windows.Forms.Button installbtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ProgressBar downloadbar;
        private System.Windows.Forms.Timer progressbarAnimation;
        private System.Windows.Forms.Label currentVersionlbl;
        private System.Windows.Forms.Timer progressbarAnimationHide;
        private System.Windows.Forms.PictureBox refreshbtn;
        private System.Windows.Forms.Timer networkSpeed;
    }
}

