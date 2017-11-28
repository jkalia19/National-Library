using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace national_lib
{
    public partial class Loading : Form
    {
        Login_page l = new Login_page();
        public Loading()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Increment(3);
            if(progressBar1.Value==progressBar1.Maximum)
            {
               
                l.Show();             
                timer1.Stop();
                this.Hide();
            }
            
        }
    }
}
