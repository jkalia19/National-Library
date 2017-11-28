using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace national_lib
{
    public partial class Delete : Form
    {
        SqlConnection con = new SqlConnection("Data Source=.\\sqlexpress;database=Library_Database;Integrated Security=yes");
            
        public Delete()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
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
           // this.bookstableTableAdapter.Fill(this.library_DatabaseDataSet3.bookstable);
            //this.author_tableTableAdapter.Fill(this.library_DatabaseDataSet2.author_table);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from bookstable", con);

            DataSet ds = new DataSet();
            SqlCommandBuilder cb = new SqlCommandBuilder(da);
            DataTable dt1 = new DataTable();
            dt1.Locale = System.Globalization.CultureInfo.InvariantCulture;
            da.Fill(dt1);
            bindingSource1.DataSource = dt1;
            dataGridView1.DataSource = bindingSource1;
            dataGridView1.Visible = true;
            da.Dispose();
            con.Close();
            //this.bookstableTableAdapter.Fill(this.library_DatabaseDataSet1.bookstable);
        }

        private void Delete_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'library_DatabaseDataSet4.author_table' table. You can move, or remove it, as needed.
            //this.author_tableTableAdapter.Fill(this.library_DatabaseDataSet4.author_table);
            // TODO: This line of code loads data into the 'library_DatabaseDataSet3.bookstable' table. You can move, or remove it, as needed.
            //this.bookstableTableAdapter.Fill(this.library_DatabaseDataSet3.bookstable);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("delete from bookstable where b_id=@b_id", con);
            cmd.Parameters.Add("@b_id", SqlDbType.NVarChar, 50).Value = textBox1.Text;
            cmd.ExecuteNonQuery();
            
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
            // this.customer_databaseTableAdapter.Fill(this.hRHOTELDataSet.Customer_database);
            // cmd.ExecuteNonQuery();
            MessageBox.Show("Deleted Successfully..");
            textBox1.Clear();
            con.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            con.Open();
            SqlCommand cmd = new SqlCommand("delete from author_table where A_id=@A_id", con);
            cmd.Parameters.Add("@A_id", SqlDbType.NVarChar, 50).Value = textBox2.Text;
            cmd.ExecuteNonQuery();

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
            // this.customer_databaseTableAdapter.Fill(this.hRHOTELDataSet.Customer_database);
            // cmd.ExecuteNonQuery();
            MessageBox.Show("Deleted Successfully..");
            textBox2.Clear();
            con.Close();
        }
    }
}
