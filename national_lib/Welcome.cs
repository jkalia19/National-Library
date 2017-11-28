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
    public partial class welcome : Form
    {
        public welcome()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
        }

        public void Method()
        {
            throw new System.NotImplementedException();
        }
      int i = 890;
        private void timer1_Tick(object sender, EventArgs e)
        {
           
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            U_login ulo = new U_login();
            ulo.ShowDialog();
            


        }

        private void Corridor_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            corridor cor = new corridor();
            cor.Show();
        }

        private void database_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            database db = new database();
            db.Show();
        }

        private void Area_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Reading read = new Reading();
            read.Show();
        }

        private void money_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //fee_fine fe = new fee_fine();
            //fe.Show();

        }

        private void Staff_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Staff st = new Staff();
            st.Show();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Contact_Us tc = new Contact_Us();
            tc.Show();
        }

        private void Criteria_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //finecriteria fine = new finecriteria();
            //fine.Show();
        }

        private void Top_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            rare topr = new rare();
            topr.Show();
        }

        private void add_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            add_info ad = new add_info();
            ad.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        int a = 0;
        private void timer2_Tick(object sender, EventArgs e)
        {
            
            if (a % 2 == 0)
                pictureBox1.ImageLocation = "C:/Users/Kalia/documents/visual studio 2010/Projects/national_lib/national_lib/Local pics/2.jpg";
            else
                pictureBox1.ImageLocation = "C:/Users/Kalia/documents/visual studio 2010/Projects/national_lib/national_lib/Local pics/1.jpg";
            a++;
        }

        private void Criteria_MouseHover(object sender, EventArgs e)
        {
            timer1.Stop();
            
        }

        private void Criteria_MouseLeave(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login_page n = new Login_page();
            n.Show();
            this.Close();
            Lib_home lib = new Lib_home();
            lib.Close();
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            if (i <= 1235)
            {
                Top.Left = i++;
                add.Left = i++;
            }
            else
                i = 890;

            
        }
    }
}

