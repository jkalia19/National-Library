namespace national_lib
{
    partial class U_login
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
            this.name_t = new System.Windows.Forms.TextBox();
            this.email_t = new System.Windows.Forms.TextBox();
            this.pwd_t = new System.Windows.Forms.TextBox();
            this.city_t = new System.Windows.Forms.TextBox();
            this.zip_t = new System.Windows.Forms.TextBox();
            this.name_l = new System.Windows.Forms.Label();
            this.email_l = new System.Windows.Forms.Label();
            this.pwd_l = new System.Windows.Forms.Label();
            this.city_l = new System.Windows.Forms.Label();
            this.zip_l = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cpwd_t = new System.Windows.Forms.TextBox();
            this.cpwd_l = new System.Windows.Forms.Label();
            this.addr_l = new System.Windows.Forms.Label();
            this.addr_t = new System.Windows.Forms.TextBox();
            this.state_l = new System.Windows.Forms.Label();
            this.state_t = new System.Windows.Forms.TextBox();
            this.green_l = new System.Windows.Forms.Label();
            this.green_t = new System.Windows.Forms.TextBox();
            this.credit_l = new System.Windows.Forms.Label();
            this.pan_t = new System.Windows.Forms.TextBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dob_l = new System.Windows.Forms.Label();
            this.checkBox = new System.Windows.Forms.CheckBox();
            this.checkbox_l = new System.Windows.Forms.LinkLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.recaptcha = new System.Windows.Forms.PictureBox();
            this.recaptcha_t = new System.Windows.Forms.TextBox();
            this.submit = new System.Windows.Forms.Button();
            this.secure_t = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dob_t = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.recaptcha)).BeginInit();
            this.SuspendLayout();
            // 
            // name_t
            // 
            this.name_t.Location = new System.Drawing.Point(42, 148);
            this.name_t.Name = "name_t";
            this.name_t.Size = new System.Drawing.Size(240, 20);
            this.name_t.TabIndex = 0;
            this.name_t.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.name_t.TextChanged += new System.EventHandler(this.name_t_TextChanged);
            // 
            // email_t
            // 
            this.email_t.Location = new System.Drawing.Point(39, 204);
            this.email_t.Name = "email_t";
            this.email_t.Size = new System.Drawing.Size(241, 20);
            this.email_t.TabIndex = 1;
            this.email_t.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // pwd_t
            // 
            this.pwd_t.Location = new System.Drawing.Point(39, 260);
            this.pwd_t.Name = "pwd_t";
            this.pwd_t.PasswordChar = '*';
            this.pwd_t.Size = new System.Drawing.Size(200, 20);
            this.pwd_t.TabIndex = 2;
            this.pwd_t.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // city_t
            // 
            this.city_t.Location = new System.Drawing.Point(40, 512);
            this.city_t.Name = "city_t";
            this.city_t.Size = new System.Drawing.Size(130, 20);
            this.city_t.TabIndex = 5;
            this.city_t.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // zip_t
            // 
            this.zip_t.Location = new System.Drawing.Point(509, 199);
            this.zip_t.Name = "zip_t";
            this.zip_t.Size = new System.Drawing.Size(145, 20);
            this.zip_t.TabIndex = 6;
            this.zip_t.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // name_l
            // 
            this.name_l.AutoSize = true;
            this.name_l.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.name_l.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.name_l.Location = new System.Drawing.Point(41, 151);
            this.name_l.Name = "name_l";
            this.name_l.Size = new System.Drawing.Size(108, 13);
            this.name_l.TabIndex = 7;
            this.name_l.Text = "Enter Your U_Name :";
            this.name_l.Click += new System.EventHandler(this.name_l_Click);
            // 
            // email_l
            // 
            this.email_l.AutoSize = true;
            this.email_l.BackColor = System.Drawing.Color.White;
            this.email_l.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.email_l.Location = new System.Drawing.Point(43, 206);
            this.email_l.Name = "email_l";
            this.email_l.Size = new System.Drawing.Size(78, 13);
            this.email_l.TabIndex = 8;
            this.email_l.Text = "Email address :";
            this.email_l.Click += new System.EventHandler(this.label2_Click);
            // 
            // pwd_l
            // 
            this.pwd_l.AutoSize = true;
            this.pwd_l.BackColor = System.Drawing.Color.White;
            this.pwd_l.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.pwd_l.Location = new System.Drawing.Point(42, 263);
            this.pwd_l.Name = "pwd_l";
            this.pwd_l.Size = new System.Drawing.Size(59, 13);
            this.pwd_l.TabIndex = 9;
            this.pwd_l.Text = "Password :";
            this.pwd_l.Click += new System.EventHandler(this.pwd_l_Click);
            // 
            // city_l
            // 
            this.city_l.AutoSize = true;
            this.city_l.BackColor = System.Drawing.Color.White;
            this.city_l.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.city_l.Location = new System.Drawing.Point(44, 516);
            this.city_l.Name = "city_l";
            this.city_l.Size = new System.Drawing.Size(30, 13);
            this.city_l.TabIndex = 12;
            this.city_l.Text = "City :";
            this.city_l.Click += new System.EventHandler(this.city_l_Click);
            // 
            // zip_l
            // 
            this.zip_l.AutoSize = true;
            this.zip_l.BackColor = System.Drawing.Color.White;
            this.zip_l.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.zip_l.Location = new System.Drawing.Point(513, 202);
            this.zip_l.Name = "zip_l";
            this.zip_l.Size = new System.Drawing.Size(56, 13);
            this.zip_l.TabIndex = 13;
            this.zip_l.Text = "Zip Code :";
            this.zip_l.Click += new System.EventHandler(this.zip_l_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(246)))), ((int)(((byte)(153)))));
            this.label8.Font = new System.Drawing.Font("Arial Black", 25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label8.Location = new System.Drawing.Point(360, 74);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(164, 48);
            this.label8.TabIndex = 14;
            this.label8.Text = "Sign Up";
            // 
            // cpwd_t
            // 
            this.cpwd_t.Location = new System.Drawing.Point(39, 312);
            this.cpwd_t.Name = "cpwd_t";
            this.cpwd_t.PasswordChar = '*';
            this.cpwd_t.Size = new System.Drawing.Size(230, 20);
            this.cpwd_t.TabIndex = 16;
            this.cpwd_t.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cpwd_l
            // 
            this.cpwd_l.AutoSize = true;
            this.cpwd_l.BackColor = System.Drawing.Color.White;
            this.cpwd_l.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.cpwd_l.Location = new System.Drawing.Point(42, 316);
            this.cpwd_l.Name = "cpwd_l";
            this.cpwd_l.Size = new System.Drawing.Size(97, 13);
            this.cpwd_l.TabIndex = 17;
            this.cpwd_l.Text = "Confirm Password :";
            this.cpwd_l.Click += new System.EventHandler(this.cpwd_l_Click);
            // 
            // addr_l
            // 
            this.addr_l.AutoSize = true;
            this.addr_l.BackColor = System.Drawing.Color.Transparent;
            this.addr_l.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.addr_l.Location = new System.Drawing.Point(43, 425);
            this.addr_l.Name = "addr_l";
            this.addr_l.Size = new System.Drawing.Size(82, 13);
            this.addr_l.TabIndex = 19;
            this.addr_l.Text = "Street Address :";
            this.addr_l.Click += new System.EventHandler(this.addr_l_Click);
            // 
            // addr_t
            // 
            this.addr_t.Location = new System.Drawing.Point(40, 439);
            this.addr_t.Multiline = true;
            this.addr_t.Name = "addr_t";
            this.addr_t.Size = new System.Drawing.Size(252, 53);
            this.addr_t.TabIndex = 18;
            this.addr_t.Text = "                ";
            this.addr_t.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // state_l
            // 
            this.state_l.AutoSize = true;
            this.state_l.BackColor = System.Drawing.Color.White;
            this.state_l.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.state_l.Location = new System.Drawing.Point(207, 517);
            this.state_l.Name = "state_l";
            this.state_l.Size = new System.Drawing.Size(38, 13);
            this.state_l.TabIndex = 21;
            this.state_l.Text = "State :";
            this.state_l.Click += new System.EventHandler(this.state_l_Click);
            // 
            // state_t
            // 
            this.state_t.Location = new System.Drawing.Point(203, 513);
            this.state_t.Name = "state_t";
            this.state_t.Size = new System.Drawing.Size(130, 20);
            this.state_t.TabIndex = 20;
            this.state_t.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // green_l
            // 
            this.green_l.AutoSize = true;
            this.green_l.BackColor = System.Drawing.Color.White;
            this.green_l.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.green_l.Location = new System.Drawing.Point(513, 256);
            this.green_l.Name = "green_l";
            this.green_l.Size = new System.Drawing.Size(87, 13);
            this.green_l.TabIndex = 23;
            this.green_l.Text = "Green Card No. :";
            this.green_l.Click += new System.EventHandler(this.green_l_Click);
            // 
            // green_t
            // 
            this.green_t.Location = new System.Drawing.Point(509, 253);
            this.green_t.Name = "green_t";
            this.green_t.Size = new System.Drawing.Size(235, 20);
            this.green_t.TabIndex = 22;
            this.green_t.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // credit_l
            // 
            this.credit_l.AutoSize = true;
            this.credit_l.BackColor = System.Drawing.Color.White;
            this.credit_l.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.credit_l.Location = new System.Drawing.Point(513, 308);
            this.credit_l.Name = "credit_l";
            this.credit_l.Size = new System.Drawing.Size(80, 13);
            this.credit_l.TabIndex = 25;
            this.credit_l.Text = "PAN Card No. :";
            this.credit_l.Click += new System.EventHandler(this.credit_l_Click);
            // 
            // pan_t
            // 
            this.pan_t.Location = new System.Drawing.Point(509, 305);
            this.pan_t.Name = "pan_t";
            this.pan_t.Size = new System.Drawing.Size(235, 20);
            this.pan_t.TabIndex = 24;
            this.pan_t.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(675, 143);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker.TabIndex = 28;
            this.dateTimePicker.ValueChanged += new System.EventHandler(this.dateTimePicker_ValueChanged);
            // 
            // dob_l
            // 
            this.dob_l.AutoSize = true;
            this.dob_l.BackColor = System.Drawing.Color.Transparent;
            this.dob_l.Location = new System.Drawing.Point(464, 151);
            this.dob_l.Name = "dob_l";
            this.dob_l.Size = new System.Drawing.Size(30, 13);
            this.dob_l.TabIndex = 29;
            this.dob_l.Text = "DOB";
            // 
            // checkBox
            // 
            this.checkBox.AutoSize = true;
            this.checkBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(246)))), ((int)(((byte)(153)))));
            this.checkBox.Location = new System.Drawing.Point(509, 366);
            this.checkBox.Name = "checkBox";
            this.checkBox.Size = new System.Drawing.Size(15, 14);
            this.checkBox.TabIndex = 30;
            this.checkBox.UseVisualStyleBackColor = false;
            // 
            // checkbox_l
            // 
            this.checkbox_l.ActiveLinkColor = System.Drawing.Color.Black;
            this.checkbox_l.AutoSize = true;
            this.checkbox_l.BackColor = System.Drawing.Color.Transparent;
            this.checkbox_l.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkbox_l.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.checkbox_l.Location = new System.Drawing.Point(530, 362);
            this.checkbox_l.Name = "checkbox_l";
            this.checkbox_l.Size = new System.Drawing.Size(292, 20);
            this.checkbox_l.TabIndex = 32;
            this.checkbox_l.TabStop = true;
            this.checkbox_l.Text = "I have read all the Terms and Conditions";
            this.checkbox_l.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.checkbox_l.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.checkbox_l_LinkClicked);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.recaptcha);
            this.panel1.Location = new System.Drawing.Point(509, 400);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(205, 57);
            this.panel1.TabIndex = 33;
            // 
            // recaptcha
            // 
            this.recaptcha.BackgroundImage = global::national_lib.Properties.Resources.reCAPTCHA2;
            this.recaptcha.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.recaptcha.Location = new System.Drawing.Point(0, 0);
            this.recaptcha.Name = "recaptcha";
            this.recaptcha.Size = new System.Drawing.Size(205, 57);
            this.recaptcha.TabIndex = 0;
            this.recaptcha.TabStop = false;
            // 
            // recaptcha_t
            // 
            this.recaptcha_t.Location = new System.Drawing.Point(509, 457);
            this.recaptcha_t.Name = "recaptcha_t";
            this.recaptcha_t.Size = new System.Drawing.Size(205, 20);
            this.recaptcha_t.TabIndex = 34;
            this.recaptcha_t.TextChanged += new System.EventHandler(this.recaptcha_t_TextChanged);
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(746, 506);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(115, 26);
            this.submit.TabIndex = 35;
            this.submit.Text = "Submit";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // secure_t
            // 
            this.secure_t.Location = new System.Drawing.Point(35, 378);
            this.secure_t.Name = "secure_t";
            this.secure_t.Size = new System.Drawing.Size(315, 20);
            this.secure_t.TabIndex = 36;
            this.secure_t.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(37, 364);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 13);
            this.label1.TabIndex = 37;
            this.label1.Text = "Write your Security Question... :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dob_t
            // 
            this.dob_t.Location = new System.Drawing.Point(509, 144);
            this.dob_t.Name = "dob_t";
            this.dob_t.Size = new System.Drawing.Size(150, 20);
            this.dob_t.TabIndex = 38;
            this.dob_t.Tag = "";
            // 
            // U_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::national_lib.Properties.Resources.Lib_sign;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(887, 572);
            this.Controls.Add(this.dob_t);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.secure_t);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.recaptcha_t);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.checkbox_l);
            this.Controls.Add(this.checkBox);
            this.Controls.Add(this.dob_l);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.credit_l);
            this.Controls.Add(this.pan_t);
            this.Controls.Add(this.green_l);
            this.Controls.Add(this.green_t);
            this.Controls.Add(this.state_l);
            this.Controls.Add(this.state_t);
            this.Controls.Add(this.addr_l);
            this.Controls.Add(this.addr_t);
            this.Controls.Add(this.cpwd_l);
            this.Controls.Add(this.cpwd_t);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.zip_l);
            this.Controls.Add(this.city_l);
            this.Controls.Add(this.pwd_l);
            this.Controls.Add(this.email_l);
            this.Controls.Add(this.name_l);
            this.Controls.Add(this.zip_t);
            this.Controls.Add(this.city_t);
            this.Controls.Add(this.pwd_t);
            this.Controls.Add(this.email_t);
            this.Controls.Add(this.name_t);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "U_login";
            this.Text = "Sign_In";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.recaptcha)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox email_t;
        private System.Windows.Forms.TextBox city_t;
        private System.Windows.Forms.TextBox zip_t;
        private System.Windows.Forms.Label name_l;
        private System.Windows.Forms.Label email_l;
        private System.Windows.Forms.Label pwd_l;
        private System.Windows.Forms.Label city_l;
        private System.Windows.Forms.Label zip_l;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox name_t;
        public System.Windows.Forms.TextBox pwd_t;
        private System.Windows.Forms.TextBox cpwd_t;
        private System.Windows.Forms.Label cpwd_l;
        private System.Windows.Forms.Label addr_l;
        private System.Windows.Forms.TextBox addr_t;
        private System.Windows.Forms.Label state_l;
        private System.Windows.Forms.TextBox state_t;
        private System.Windows.Forms.Label green_l;
        private System.Windows.Forms.TextBox green_t;
        private System.Windows.Forms.Label credit_l;
        private System.Windows.Forms.TextBox pan_t;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label dob_l;
        private System.Windows.Forms.CheckBox checkBox;
        private System.Windows.Forms.LinkLabel checkbox_l;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox recaptcha;
        private System.Windows.Forms.TextBox recaptcha_t;
        private System.Windows.Forms.Button submit;
        public System.Windows.Forms.TextBox secure_t;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox dob_t;
    }
}