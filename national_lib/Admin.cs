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
    public partial class Admin : Form
    {
       
        SqlConnection con = new SqlConnection("Data Source=.\\sqlexpress;database=Library_Database;Integrated Security=yes");
        Login_page ob = new Login_page();
        public String s2,name;
        public Admin()
        {
            InitializeComponent();
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            openFileDialog1.ShowDialog();
             name = openFileDialog1.FileName.ToString();
            ad_pic.BackgroundImage = Image.FromFile(openFileDialog1.FileName);
            ad_pic.SizeMode = PictureBoxSizeMode.StretchImage;
       }

        private void Admin_Load(object sender, EventArgs e)
        {
           con.Open();
           SqlCommand cmd1 = new SqlCommand("select U_pic from user_table where U_name=@U_name", con);
           cmd1.Parameters.Add("@U_name", SqlDbType.NVarChar, 50).Value = s2;
           SqlDataReader dr1 = cmd1.ExecuteReader();
           string url;
           if (dr1.HasRows)
           {
               dr1.Read();
               try
               {
                   url = dr1.GetValue(0).ToString();
                   ad_pic.BackgroundImage = Image.FromFile(url);
                   //this is for adding initial address in ad_pic
               }
               catch
               {
               }
           }

           dr1.Dispose();
           cmd1.Dispose();

             SqlCommand cmd = new SqlCommand("select * from user_table where U_name=@U_name", con);
             cmd.Parameters.Add("@U_name", SqlDbType.NVarChar, 50).Value =s2;
             SqlDataReader dr = cmd.ExecuteReader();
             if (dr.HasRows)
             {
                 dr.Read();
                 uname.Text = dr.GetValue(1).ToString();
                 textBox4.Text = dr.GetValue(2).ToString();
                 textBox1.Text = dr.GetValue(4).ToString();
                 richTextBox1.Text = dr.GetValue(5).ToString();
                 textBox6.Text = dr.GetValue(6).ToString();
                 textBox7.Text = dr.GetValue(7).ToString();
                 ugender.Text = dr.GetValue(8).ToString();
                 textBox3.Text = dr.GetValue(9).ToString();
                 textBox2.Text = dr.GetValue(10).ToString();
                 //customeremail.Text = dr.GetValue(11).ToString();
             }

             dr.Dispose();
             cmd.Dispose();                
             con.Close();
                       
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand(" update user_table set U_pic=@U_pic where U_name=@U_name", con);
            cmd.Parameters.Add("@U_name", SqlDbType.NVarChar, 50).Value = s2;
            
            cmd.Parameters.Add("@U_pic", SqlDbType.NVarChar, 50).Value =name ;
            cmd.ExecuteNonQuery();
            MessageBox.Show("URL updated");
        }
    }
}
