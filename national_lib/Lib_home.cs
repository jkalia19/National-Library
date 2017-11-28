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
    public partial class Lib_home : Form
    {
        public string s1;
        welcome ob = new welcome();
        public Lib_home()
        {
            InitializeComponent();
            
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Lib_home_Load(object sender, EventArgs e)
        {
            ob.MdiParent = this;

            MessageBox.Show("    Welcome.............!");
            ob.Show();
            
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void profileinfoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Admin ob = new Admin();
            ob.MdiParent = this;
            ob.s2 = s1;
            ob.Show();

        }

        private void bookInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Book ob = new Book();
            ob.MdiParent = this;
            ob.Show();

        }

        private void addPicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            Admin ad = new Admin();
            ad.MdiParent = this;
            ad.s2 = s1;
          
            //ad.label12.Text = s1;
            
//Admin ob = new Admin();
            ad.Show();

            ad.button1.Visible = true;
            ad.button2.Visible = true;
            
        }

        private void updateInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            up ob = new up();
            ob.MdiParent = this;
            ob.d = s1;
            ob.Show();
            
            //ob.button3.Visi
        }

        private void addAuthorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Author_up aut = new Author_up();
            aut.MdiParent = this;
            aut.Show();
        }

        private void newUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            U_login ob = new U_login();
            ob.MdiParent = this;
            ob.Show();
        }

        private void operationsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void addBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Book n = new Book();
            n.MdiParent = this;
           n.Show();
            
        }

        private void profileInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About_Us ab = new About_Us();
            ab.MdiParent = this;
            ab.Show();

        }

        private void reportToolStripMenuItem1_Click(object sender, EventArgs e)
        {
           // Report rep = new Report();
            //rep.Show();
        }

        private void contactUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Contact_Us con = new Contact_Us();
            con.MdiParent = this;
            con.Show();

        }
        int a = 0;
        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
            a++;
            
        }

        private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login_page n = new Login_page();
            n.MdiParent = this;
            n.Show();
            this.Close();
        }

        private void quitToolStripMenuItem_MouseDown(object sender, MouseEventArgs e)
        {
            
        }
        public void closs()
        {
            if (a != 0)
                a = 0;
            this.Close();
        }

        private void authorSearchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Search ob = new Search();
            ob.MdiParent = this;
            ob.Show();
            ob.panel1.Visible = false;
        }

        private void bookSearchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Search ob = new Search();
            ob.MdiParent = this;
            ob.Show();
            ob.panel2.Visible =  false;

        }

        private void deleteBookToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Delete ob = new Delete();
            ob.MdiParent = this;
            ob.Show();
            ob.panel2.Visible = false;

        }

        private void deleteAuthorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Delete ob = new Delete();
            ob.MdiParent = this;
            ob.Show();
            ob.panel1.Visible = false;

        }

        private void bookInfoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void authorProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Author_pro aut = new Author_pro();
            aut.MdiParent = this;
            aut.Show();
        }

        private void bookProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Book_Profile bo = new Book_Profile();
            bo.MdiParent = this;
            bo.Show();
        }


    }
}
