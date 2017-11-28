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
    public partial class Reading : Form
    {
        public Reading()
        {
            InitializeComponent();
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }

        private void Reading_Load(object sender, EventArgs e)
        {
            wm.URL="C:/Users/Kalia/documents/visual studio 2010/Projects/national_lib/national_lib/Local pics/Readin area.FLV";
        }
    }
}
