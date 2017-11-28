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
    public partial class Book_Profile : Form
    {
        SqlConnection con = new SqlConnection("Data Source=.\\sqlexpress;database=Library_Database;Integrated Security=yes");
        
        public Book_Profile()
        {
            InitializeComponent();
        }

        private void Book_Profile_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from bookstable where b_id=@b_id", con);
            cmd.Parameters.Add("@b_id", SqlDbType.NVarChar, 50).Value = textBox1.Text;
         
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                dr.Read();
                book_t.Text = dr.GetValue(1).ToString();
                author_t.Text = dr.GetValue(2).ToString();
                pages_t.Text = dr.GetValue(3).ToString();
                publisher_t.Text = dr.GetValue(4).ToString();
                cost_t.Text = dr.GetValue(5).ToString();
                info_t.Text = dr.GetValue(6).ToString();
                sanction_t.Text = dr.GetValue(7).ToString();
            }
            
            dr.Dispose();
            cmd.Dispose();
            con.Close();
            //con.Open();
            //SqlCommand comm = new SqlCommand("select b_picfront from bookstable where b_id=@b_id", con);
            //comm.Parameters.Add("b_id", SqlDbType.NVarChar, 50).Value = textBox1.Text;
            //SqlDataReader dr1 = comm.ExecuteReader();
            //string url;
            //if (dr1.HasRows)
            //{
            //    dr1.Read();
            //    try
            //    {
            //        url = dr1.GetValue(0).ToString();
            //        pictureBox2.BackgroundImage = Image.FromFile(url);
            //        //this is for adding initial address in ad_pic
            //    }
            //    catch
            //    {
            //    }
            //}

            //dr1.Dispose();
            //comm.Dispose();
            //con.Close();
            //con.Open();
            //SqlCommand comm2 = new SqlCommand("select b_picback from bookstable where b_id=@b_id", con);
            //comm2.Parameters.Add("b_id", SqlDbType.NVarChar, 50).Value = textBox1.Text;
            //SqlDataReader dr2 = comm.ExecuteReader();
            //string url1;
            //if (dr2.HasRows)
            //{
            //    dr2.Read();
            //    try
            //    {
            //        url1 = dr1.GetValue(0).ToString();
            //        pictureBox2.BackgroundImage = Image.FromFile(url1);
            //        //this is for adding initial address in ad_pic
            //    }
            //    catch
            //    {
            //    }
            //}

            //dr2.Dispose();
            //comm2.Dispose();
            //con.Close();
        }
      
    }
}
