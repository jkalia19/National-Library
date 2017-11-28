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
    public partial class database : Form
    {
        public database()
        {
            InitializeComponent();
        }

        private void database_Load(object sender, EventArgs e)
        {
            
            wm1.URL = @"C:/Users/Kalia/documents/visual studio 2010/Projects/national_lib/national_lib/Local pics/Database.avi";
            
        }

        private void wm1_Enter(object sender, EventArgs e)
        {

        }
    }
}
