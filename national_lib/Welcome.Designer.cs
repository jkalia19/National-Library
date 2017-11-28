namespace national_lib
{
    partial class welcome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(welcome));
            this.n_u = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Corridor = new System.Windows.Forms.LinkLabel();
            this.database = new System.Windows.Forms.LinkLabel();
            this.Area = new System.Windows.Forms.LinkLabel();
            this.Staff = new System.Windows.Forms.LinkLabel();
            this.Top = new System.Windows.Forms.LinkLabel();
            this.add = new System.Windows.Forms.LinkLabel();
            this.achievement = new System.Windows.Forms.Label();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // n_u
            // 
            this.n_u.ActiveLinkColor = System.Drawing.Color.Black;
            this.n_u.AutoSize = true;
            this.n_u.BackColor = System.Drawing.Color.Transparent;
            this.n_u.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n_u.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.n_u.Location = new System.Drawing.Point(959, 154);
            this.n_u.Name = "n_u";
            this.n_u.Size = new System.Drawing.Size(178, 25);
            this.n_u.TabIndex = 14;
            this.n_u.TabStop = true;
            this.n_u.Text = " +Create New User";
            this.n_u.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.n_u.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::national_lib.Properties.Resources._1;
            this.pictureBox1.Location = new System.Drawing.Point(12, 98);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(331, 463);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Corridor
            // 
            this.Corridor.ActiveLinkColor = System.Drawing.Color.Black;
            this.Corridor.AutoSize = true;
            this.Corridor.BackColor = System.Drawing.Color.Transparent;
            this.Corridor.Font = new System.Drawing.Font("Comic Sans MS", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Corridor.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Corridor.Location = new System.Drawing.Point(374, 196);
            this.Corridor.Name = "Corridor";
            this.Corridor.Size = new System.Drawing.Size(410, 31);
            this.Corridor.TabIndex = 17;
            this.Corridor.TabStop = true;
            this.Corridor.Text = "Our Library Has the largest corridor";
            this.Corridor.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Corridor.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Corridor_LinkClicked);
            // 
            // database
            // 
            this.database.ActiveLinkColor = System.Drawing.Color.Black;
            this.database.AutoSize = true;
            this.database.BackColor = System.Drawing.Color.Transparent;
            this.database.Font = new System.Drawing.Font("Comic Sans MS", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.database.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.database.Location = new System.Drawing.Point(380, 280);
            this.database.Name = "database";
            this.database.Size = new System.Drawing.Size(479, 38);
            this.database.TabIndex = 18;
            this.database.TabStop = true;
            this.database.Text = "We do have the Largest Database of Books";
            this.database.UseCompatibleTextRendering = true;
            this.database.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.database.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.database_LinkClicked);
            // 
            // Area
            // 
            this.Area.ActiveLinkColor = System.Drawing.Color.Black;
            this.Area.AutoSize = true;
            this.Area.BackColor = System.Drawing.Color.Transparent;
            this.Area.Font = new System.Drawing.Font("Comic Sans MS", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Area.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Area.Location = new System.Drawing.Point(380, 378);
            this.Area.Name = "Area";
            this.Area.Size = new System.Drawing.Size(260, 38);
            this.Area.TabIndex = 20;
            this.Area.TabStop = true;
            this.Area.Text = "Largest Reading Area...";
            this.Area.UseCompatibleTextRendering = true;
            this.Area.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Area.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Area_LinkClicked);
            // 
            // Staff
            // 
            this.Staff.ActiveLinkColor = System.Drawing.Color.Black;
            this.Staff.AutoSize = true;
            this.Staff.BackColor = System.Drawing.Color.Transparent;
            this.Staff.Font = new System.Drawing.Font("Comic Sans MS", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Staff.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Staff.Location = new System.Drawing.Point(380, 481);
            this.Staff.Name = "Staff";
            this.Staff.Size = new System.Drawing.Size(251, 38);
            this.Staff.TabIndex = 21;
            this.Staff.TabStop = true;
            this.Staff.Text = "With the best Staff...";
            this.Staff.UseCompatibleTextRendering = true;
            this.Staff.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Staff.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Staff_LinkClicked);
            // 
            // Top
            // 
            this.Top.ActiveLinkColor = System.Drawing.Color.Black;
            this.Top.AutoSize = true;
            this.Top.BackColor = System.Drawing.Color.Transparent;
            this.Top.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Top.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Top.Location = new System.Drawing.Point(890, 441);
            this.Top.Name = "Top";
            this.Top.Size = new System.Drawing.Size(113, 25);
            this.Top.TabIndex = 30;
            this.Top.TabStop = true;
            this.Top.Text = "Rare Books";
            this.Top.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Top.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Top_LinkClicked);
            this.Top.MouseLeave += new System.EventHandler(this.Criteria_MouseLeave);
            this.Top.MouseHover += new System.EventHandler(this.Criteria_MouseHover);
            // 
            // add
            // 
            this.add.ActiveLinkColor = System.Drawing.Color.Black;
            this.add.AutoSize = true;
            this.add.BackColor = System.Drawing.Color.Transparent;
            this.add.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.add.Location = new System.Drawing.Point(890, 515);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(199, 25);
            this.add.TabIndex = 31;
            this.add.TabStop = true;
            this.add.Text = "Additional Information";
            this.add.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.add.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.add_LinkClicked);
            this.add.MouseLeave += new System.EventHandler(this.Criteria_MouseLeave);
            this.add.MouseHover += new System.EventHandler(this.Criteria_MouseHover);
            // 
            // achievement
            // 
            this.achievement.AutoSize = true;
            this.achievement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(246)))), ((int)(((byte)(153)))));
            this.achievement.Font = new System.Drawing.Font("Modern No. 20", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.achievement.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.achievement.Location = new System.Drawing.Point(377, 113);
            this.achievement.Name = "achievement";
            this.achievement.Size = new System.Drawing.Size(366, 34);
            this.achievement.TabIndex = 32;
            this.achievement.Text = "Features of Our Library :-";
            // 
            // linkLabel2
            // 
            this.linkLabel2.ActiveLinkColor = System.Drawing.Color.Black;
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel2.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.linkLabel2.Location = new System.Drawing.Point(9, 620);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(82, 17);
            this.linkLabel2.TabIndex = 33;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Copyright ©";
            this.linkLabel2.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.Black;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.linkLabel1.Location = new System.Drawing.Point(959, 224);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(106, 25);
            this.linkLabel1.TabIndex = 34;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = " +Sign Out";
            this.linkLabel1.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked_1);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // linkLabel3
            // 
            this.linkLabel3.ActiveLinkColor = System.Drawing.Color.Black;
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel3.Font = new System.Drawing.Font("Comic Sans MS", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel3.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.linkLabel3.Location = new System.Drawing.Point(964, 354);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(189, 38);
            this.linkLabel3.TabIndex = 35;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "Little More Info";
            this.linkLabel3.UseCompatibleTextRendering = true;
            this.linkLabel3.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            // 
            // welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::national_lib.Properties.Resources.Lbrary;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1226, 683);
            this.Controls.Add(this.linkLabel3);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.achievement);
            this.Controls.Add(this.add);
            this.Controls.Add(this.Top);
            this.Controls.Add(this.Staff);
            this.Controls.Add(this.Area);
            this.Controls.Add(this.database);
            this.Controls.Add(this.Corridor);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.n_u);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.MinimizeBox = false;
            this.Name = "welcome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome to Home Page";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel n_u;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel Corridor;
        private System.Windows.Forms.LinkLabel database;
        private System.Windows.Forms.LinkLabel Area;
        private System.Windows.Forms.LinkLabel Staff;
        private System.Windows.Forms.LinkLabel Top;
        private System.Windows.Forms.LinkLabel add;
        private System.Windows.Forms.Label achievement;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.LinkLabel linkLabel3;

    }
}