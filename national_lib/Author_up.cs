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
    public partial class Author_up : Form
    {
        SqlConnection con = new SqlConnection("Data Source=.\\sqlexpress;database=Library_Database;Integrated Security=yes");
        String name,s;
        
        public Author_up()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand(" update author_table table set A_pic=@A_pic where A_id=@A_id", con);
            cmd.Parameters.Add("@A_id", SqlDbType.NVarChar, 50).Value = s;
            cmd.Parameters.Add("@A_picfront", SqlDbType.NVarChar, 50).Value = name;
            cmd.ExecuteNonQuery();
            MessageBox.Show("URL updated");
            con.Close();
        }

        
        private void button3_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            name = openFileDialog1.FileName;
            pictureBox1.ImageLocation = Image.FromFile(openFileDialog1.FileName).ToString();
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void Author_up_Load(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            Random d = new Random();
            int st = d.Next(1000, 9999);
            string s = "a" + Convert.ToInt64(st);
            SqlCommand cmd = new SqlCommand("insert into author_table(A_id,A_name,A_dob,A_info,A_reknown)Values(@A_id,@A_name,@A_dob,@A_info,@A_reknown)", con);
            cmd.Parameters.Add("@A_id", SqlDbType.NVarChar, 50).Value = s;
            cmd.Parameters.Add("@A_name", SqlDbType.NVarChar, 50).Value = name_t.Text;
            cmd.Parameters.Add("@A_dob", SqlDbType.NVarChar, 50).Value = dob_t.Text;
            cmd.Parameters.Add("@A_info", SqlDbType.NVarChar, 250).Value = info_t.Text;
            cmd.Parameters.Add("@A_reknown", SqlDbType.NVarChar, 250).Value = reknown_t.Text;
            MessageBox.Show("Value inserted successfully Your Author's ID is " + s);
            cmd.ExecuteNonQuery();
            con.Close();
            name_t.Clear(); dob_t.Clear();
            info_t.Clear();
            reknown_t.Clear();

        }
    }
}
