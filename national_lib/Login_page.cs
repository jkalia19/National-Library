using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace national_lib
{
    public partial class Login_page : Form
    {
        public String a2, b;
        public int a1=0;
        public Login_page()
        {
            InitializeComponent();
            
        }

        private void Login_page_Load(object sender, EventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
             SqlConnection con = new SqlConnection("Data Source=.\\sqlexpress;database=Library_Database;Integrated Security=yes");
             con.Open();
             SqlCommand cmd = new SqlCommand("select * from user_table where U_name=@U_name and U_password=@U_password", con);
             cmd.Parameters.Add("@U_name", SqlDbType.NVarChar, 50).Value = textBox1.Text;
             cmd.Parameters.Add("@U_password", SqlDbType.NVarChar, 50).Value = textBox2.Text;
            //string pwd= cmd.Parameters.Add("@U_password", SqlDbType.NVarChar, 50).Value;
            //if(@U_password==textBox2)
             SqlDataReader dr = cmd.ExecuteReader();
             Lib_home lh = new Lib_home();
             lh.s1 = textBox1.Text;
             if (dr.HasRows)
             {
                 dr.Read();
                           
                             //Lib_home ob = new Lib_home();
                 lh.Show();
                 this.Close();
             }
             else
             {
                 MessageBox.Show("your user  name or pwd is wrong");
             }
           
        }
        
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void pwd_frgt_Click(object sender, EventArgs e)
        {
            forgot ob=new forgot();
            ob.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Lib_home obj = new Lib_home();
            obj.Show();
        }
    }
}
