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
    public partial class Author_pro : Form
    { 
        SqlConnection con = new SqlConnection("Data Source=.\\sqlexpress;database=Library_Database;Integrated Security=yes");
            
       
        public Author_pro()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from author_table where A_id=@A_id", con);
            cmd.Parameters.Add("@A_id", SqlDbType.NVarChar, 50).Value = textBox3.Text;

            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                dr.Read();
                textBox2.Text = dr.GetValue(1).ToString();
                textBox1.Text = dr.GetValue(2).ToString();
                richTextBox2.Text = dr.GetValue(3).ToString();
                richTextBox1.Text = dr.GetValue(4).ToString();
            }
            cmd.Dispose();
            dr.Dispose();
            SqlCommand comm = new SqlCommand("select A_pic from author_table where A_name=@A_name", con);
            comm.Parameters.Add("A_name", SqlDbType.NVarChar, 50).Value = textBox2.Text;
            SqlDataReader dr1 = comm.ExecuteReader();
            string url;
            if (dr1.HasRows)
            {
                dr1.Read();
                try
                {
                    url = dr1.GetValue(0).ToString();
                    pictureBox1.BackgroundImage = Image.FromFile(url);
                    //this is for adding initial address in ad_pic
                }
                catch
                {
                }
            }

            dr1.Dispose();
            comm.Dispose();
            con.Close();
            
        }

        private void Author_pro_Load(object sender, EventArgs e)
        {
           
        }
    }   
}
