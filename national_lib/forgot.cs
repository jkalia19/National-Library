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
    public partial class forgot : Form
    {
        SqlConnection con = new SqlConnection("Data Source=.\\sqlexpress;database=Library_Database;Integrated Security=yes");
        public forgot()
        {
            InitializeComponent();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            panel2.Visible = true;
            SqlCommand cmd = new SqlCommand("select U_securityq from user_table where U_greencard=@U_greencard", con);
            cmd.Parameters.Add("@U_greencard", SqlDbType.NVarChar, 50).Value = textBox1.Text;
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                dr.Read();
                label2.Text = dr.GetValue(0).ToString();
            }
            con.Close();
        }

        private void forgot_Load(object sender, EventArgs e)
        {
            panel2.Visible = false;

        }
    }
}
