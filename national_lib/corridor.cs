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
    public partial class corridor : Form
    {
        public corridor()
        {
            InitializeComponent();
        }

        private void corridor_Load(object sender, EventArgs e)
        {
           videos.URL = "C:/Users/Kalia/documents/visual studio 2010/Projects/national_lib/national_lib/Local pics/corridor.avi";
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void videos_Enter(object sender, EventArgs e)
        {

        }
    }
}
