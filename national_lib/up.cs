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
    public partial class up : Form
    {
        SqlConnection con = new SqlConnection("Data Source=.\\sqlexpress;database=Library_Database;Integrated Security=yes");
        public string d;  
        public up()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("update user_table set U_name=@U_name,U_email=@U_email,U_street=@U_street,U_city=@U_city,U_state=@U_state,U_dob=@U_dob,U_pancard=@U_pancard,U_greencard=@U_greencard",con);
            cmd.Parameters.Add("@U_name", SqlDbType.NVarChar, 50).Value = textBox5.Text;
                cmd.Parameters.Add("@U_email", SqlDbType.NVarChar, 50).Value = textBox4.Text;
                //cmd.Parameters.Add("@U_password", SqlDbType.NVarChar, 50).Value = pwd_t.Text;
                //cmd.Parameters.Add("@U_securityq", SqlDbType.NVarChar, 50).Value = textBox1.Text;
                cmd.Parameters.Add("@U_street", SqlDbType.NVarChar, 50).Value = richTextBox1.Text;
                cmd.Parameters.Add("@U_city", SqlDbType.NVarChar, 50).Value = textBox6.Text;
                cmd.Parameters.Add("@U_state", SqlDbType.NVarChar, 50).Value = textBox7.Text;
                cmd.Parameters.Add("@U_dob", SqlDbType.NVarChar, 50).Value = textBox8.Text;
                cmd.Parameters.Add("@U_pancard", SqlDbType.NVarChar, 50).Value = textBox3.Text;
                cmd.Parameters.Add("@U_greencard", SqlDbType.NVarChar, 50).Value = textBox2.Text;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Value Updated successfully");
            con.Close();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
        }

        private void up_Load(object sender, EventArgs e)
        {
            
            Login_page ob = new Login_page();
            con.Open();
           SqlCommand cmd1 = new SqlCommand("select U_pic from user_table where U_name=@U_name", con);
           cmd1.Parameters.Add("@U_name", SqlDbType.NVarChar, 50).Value = d;
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
               cmd1.Dispose();
               dr1.Dispose();
               SqlCommand cmd = new SqlCommand("select * from user_table where U_name=@U_name", con);
               cmd.Parameters.Add("@U_name", SqlDbType.NVarChar, 50).Value = d;

               SqlDataReader dr = cmd.ExecuteReader();
               if (dr.HasRows)
               {
                   dr.Read();
                   textBox5.Text = dr.GetValue(1).ToString();
                   textBox4.Text = dr.GetValue(2).ToString();
                   textBox1.Text = dr.GetValue(4).ToString();
                   richTextBox1.Text = dr.GetValue(5).ToString();
                   textBox6.Text = dr.GetValue(6).ToString();
                   textBox7.Text = dr.GetValue(7).ToString();
                   textBox8.Text = dr.GetValue(8).ToString();
                   textBox3.Text = dr.GetValue(9).ToString();
                   textBox2.Text = dr.GetValue(10).ToString();
                   //customeremail.Text = dr.GetValue(11).ToString();
               }
               cmd.Dispose();
               dr.Dispose();
               con.Close();
               //SqlCommand cmd = new SqlCommand("
           }
        }
    }
}
