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
    public partial class Search : Form
    {
        SqlConnection con = new SqlConnection("Data Source=.\\sqlexpress;database=Library_Database;Integrated Security=yes");
        public Search()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Search_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'library_DatabaseDataSet2.author_table' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'library_DatabaseDataSet1.bookstable' table. You can move, or remove it, as needed.
           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            //this.bookstableTableAdapter.Fill(this.library_DatabaseDataSet1.bookstable);
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from bookstable where b_id=@b_id",con);
            cmd.Parameters.Add("@b_id", SqlDbType.NVarChar, 50).Value = textBox1.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataSet ds = new DataSet();
            SqlCommandBuilder cb = new SqlCommandBuilder(da);
            DataTable dt = new DataTable();
            dt.Locale = System.Globalization.CultureInfo.InvariantCulture;
            da.Fill(dt);
            bindingSource1.DataSource = dt;
            dataGridView1.DataSource = bindingSource1;
            dataGridView1.Visible = true;
            cmd.ExecuteNonQuery();
            da.Dispose();
            con.Close();
            

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            //this.author_tableTableAdapter.Fill(this.library_DatabaseDataSet2.author_table);
            con.Open();
            
            SqlCommand cmd = new SqlCommand("select * from author_table where A_id=@A_id",con);
            cmd.Parameters.Add("@A_id", SqlDbType.NVarChar, 50).Value = textBox2.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataSet ds = new DataSet();
            SqlCommandBuilder cb = new SqlCommandBuilder(da);
            DataTable dt = new DataTable();
            dt.Locale = System.Globalization.CultureInfo.InvariantCulture;
            da.Fill(dt);
            bindingSource2.DataSource = dt;
            dataGridView1.DataSource = bindingSource2;
            dataGridView1.Visible = true;
            cmd.ExecuteNonQuery();
            da.Dispose();
            con.Close();
            
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from bookstable", con);

            DataSet ds = new DataSet();
            SqlCommandBuilder cb = new SqlCommandBuilder(da);
            DataTable dt = new DataTable();
            dt.Locale = System.Globalization.CultureInfo.InvariantCulture;
            da.Fill(dt);
            bindingSource1.DataSource = dt;
            dataGridView1.DataSource = bindingSource1;
            dataGridView1.Visible = true;
            da.Dispose();
            con.Close();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from author_table", con);
            DataSet ds = new DataSet();
            SqlCommandBuilder cb = new SqlCommandBuilder(da);
            DataTable dt = new DataTable();
            dt.Locale = System.Globalization.CultureInfo.InvariantCulture;
            da.Fill(dt);
            bindingSource2.DataSource = dt;
            dataGridView1.DataSource = bindingSource2;
            dataGridView1.Visible = true;
            da.Dispose();
            con.Close();
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
