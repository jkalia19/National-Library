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
    public partial class Book : Form
    {
        SqlConnection con = new SqlConnection("Data Source=.\\sqlexpress;database=Library_Database;Integrated Security=yes");
        String name,s,name2;
        public Book()
        {
            InitializeComponent();
        }

        private void Book_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            name = openFileDialog1.FileName.ToString();
            pictureBox2.BackgroundImage = Image.FromFile(openFileDialog1.FileName);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void Submit_Click(object sender, EventArgs e)
        {

            con.Open();
            Random d = new Random();
            int st = d.Next(1000, 9999);
            s = "b" + Convert.ToInt64(st);
            SqlCommand cmd = new SqlCommand("insert into bookstable(b_id,b_name,b_author,b_pages,b_publisher,b_cost,b_info,b_sanction)values(@b_id,@b_name,@b_author,@b_pages,@b_publisher,@b_cost,@b_info,@b_sanction)", con);
            cmd.Parameters.Add("@b_id", SqlDbType.NVarChar, 50).Value = s;
            cmd.Parameters.Add("@b_name", SqlDbType.NVarChar, 50).Value = book_t.Text;
            cmd.Parameters.Add("@b_author", SqlDbType.NVarChar, 50).Value = author_t.Text;
            cmd.Parameters.Add("@b_pages", SqlDbType.Int).Value = Convert.ToInt32(pages_t.Text);
            cmd.Parameters.Add("@b_publisher", SqlDbType.NVarChar, 350).Value = publisher_t.Text;
            cmd.Parameters.Add("@b_cost", SqlDbType.Int).Value = Convert.ToInt32(cost_t.Text);
            cmd.Parameters.Add("@b_info", SqlDbType.NVarChar, 350).Value = info_t.Text;
            cmd.Parameters.Add("@b_sanction", SqlDbType.NVarChar,350).Value = sanction_t.Text;
            cmd.ExecuteNonQuery();
            MessageBox.Show("Value inserted successfully your ID is "+s);
            book_t.Clear();
            author_t.Clear();
            pages_t.Clear();
            publisher_t.Clear();
            cost_t.Clear();
            info_t.Clear();
            sanction_t.Clear();
            con.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void Find_Click(object sender, EventArgs e)
        {
            openFileDialog2.ShowDialog();
            name2 = openFileDialog2.FileName.ToString();
            pictureBox1.BackgroundImage = Image.FromFile(openFileDialog1.FileName);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand(" update bookstable set b_picfront=@b_picfront where b_id=@b_id", con);
            cmd.Parameters.Add("@b_id", SqlDbType.NVarChar, 50).Value = s;

            cmd.Parameters.Add("@b_picfront", SqlDbType.NVarChar, 50).Value = name;
            cmd.ExecuteNonQuery();
            MessageBox.Show("URL updated");
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand(" update bookstable set b_picback=@b_picback where b_id=@b_id", con);
            cmd.Parameters.Add("@b_id", SqlDbType.NVarChar, 50).Value = s;
            cmd.Parameters.Add("@b_picback", SqlDbType.NVarChar, 50).Value = name2;
            cmd.ExecuteNonQuery();
            MessageBox.Show("URL updated");
            con.Close();
        }
    }
}
