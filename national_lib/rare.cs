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
    public partial class rare : Form
    {
        public rare()
        {
            InitializeComponent();
        }

        private void toprated_Load(object sender, EventArgs e)
        {

        }
        int a = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            a++;
            if (a % 2 == 0)
            {
                pictureBox1.Visible = true;
                pictureBox2.Visible = false;
            }
            else
            {
                pictureBox2.Visible = true;
                pictureBox1.Visible = false;
            }

        }
    }
}
