namespace national_lib
{
    partial class Staff
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Staff));
            this.staffpic = new System.Windows.Forms.PictureBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.sincere = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.staffpic)).BeginInit();
            this.SuspendLayout();
            // 
            // staffpic
            // 
            this.staffpic.BackgroundImage = global::national_lib.Properties.Resources.AJV_7817;
            this.staffpic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.staffpic.Location = new System.Drawing.Point(45, 158);
            this.staffpic.Margin = new System.Windows.Forms.Padding(4);
            this.staffpic.Name = "staffpic";
            this.staffpic.Size = new System.Drawing.Size(508, 418);
            this.staffpic.TabIndex = 0;
            this.staffpic.TabStop = false;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(246)))), ((int)(((byte)(153)))));
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.richTextBox1.Location = new System.Drawing.Point(607, 214);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(512, 254);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // sincere
            // 
            this.sincere.AutoSize = true;
            this.sincere.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(246)))), ((int)(((byte)(153)))));
            this.sincere.Font = new System.Drawing.Font("Microsoft YaHei", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sincere.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.sincere.Location = new System.Drawing.Point(612, 217);
            this.sincere.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sincere.Name = "sincere";
            this.sincere.Size = new System.Drawing.Size(147, 25);
            this.sincere.TabIndex = 2;
            this.sincere.Text = "Sincere Staff :-";
            // 
            // Staff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::national_lib.Properties.Resources.Lib_back;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1148, 650);
            this.Controls.Add(this.sincere);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.staffpic);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Staff";
            this.Text = "Staff";
            ((System.ComponentModel.ISupportInitialize)(this.staffpic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox staffpic;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label sincere;
    }
}