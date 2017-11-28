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
    public partial class U_login : Form
    {
        SqlConnection con = new SqlConnection("Data Source=.\\sqlexpress;database=Library_Database;Integrated Security=yes");
            
        public U_login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Lib_home ob = new Lib_home();
            ob.closs();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void name_t_TextChanged(object sender, EventArgs e)
        {

        }

        private void recaptcha_t_TextChanged(object sender, EventArgs e)
        {
            //if (recaptcha_t.Text == "fiery church" || recaptcha_t.Text == "FIERY CHURCH")
            //{
            //    MessageBox.Show("wrong name");
            //}
        }

        private void checkbox_l_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            TermsandCondition ter = new TermsandCondition();
            ter.Show();
        }

        private void name_l_Click(object sender, EventArgs e)
        {

        }

        private void pwd_l_Click(object sender, EventArgs e)
        {

        }

        private void cpwd_l_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void addr_l_Click(object sender, EventArgs e)
        {

        }

        private void city_l_Click(object sender, EventArgs e)
        {

        }

        private void state_l_Click(object sender, EventArgs e)
        {

        }

        private void credit_l_Click(object sender, EventArgs e)
        {

        }

        private void green_l_Click(object sender, EventArgs e)
        {

        }

        private void zip_l_Click(object sender, EventArgs e)
        {

        }

        private void submit_Click(object sender, EventArgs e)
        {
            con.Open();
            String rec = "fiery church";
            if (checkBox.Checked == true && cpwd_t.Text == pwd_t.Text && recaptcha_t.Text == rec)
            {
                Random d = new Random();
                int st = d.Next(1000, 9999);
                string s = "u" + Convert.ToInt64(st);
                SqlCommand cmd = new SqlCommand("insert into user_table(U_id,U_name,U_email,U_password,U_securityq,U_street,U_city,U_state,U_dob,U_pancard,U_greencard)values(@U_id,@U_name,@U_email,@U_password,@U_securityq,@U_street,@U_city,@U_state,@U_dob,@U_pancard,@U_greencard)", con);
                cmd.Parameters.Add("@U_id", SqlDbType.NVarChar, 50).Value = s;
                cmd.Parameters.Add("@U_name", SqlDbType.NVarChar, 50).Value = name_t.Text;
                cmd.Parameters.Add("@U_email", SqlDbType.NVarChar, 50).Value = email_t.Text;
                cmd.Parameters.Add("@U_password", SqlDbType.NVarChar, 50).Value = pwd_t.Text;
                cmd.Parameters.Add("@U_securityq", SqlDbType.NVarChar, 350).Value = secure_t.Text;
                cmd.Parameters.Add("@U_street", SqlDbType.NVarChar, 350).Value = addr_t.Text;
                cmd.Parameters.Add("@U_city", SqlDbType.NVarChar, 50).Value = city_t.Text;
                cmd.Parameters.Add("@U_state", SqlDbType.NVarChar, 50).Value = state_t.Text;
                cmd.Parameters.Add("@U_dob", SqlDbType.NVarChar, 50).Value = dob_t.Text;
                cmd.Parameters.Add("@U_pancard", SqlDbType.NVarChar, 50).Value = pan_t.Text;
                cmd.Parameters.Add("@U_greencard", SqlDbType.NVarChar, 50).Value = green_t.Text;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Value inserted successfully. Your ID is " + s);
            }
            else
            {
                MessageBox.Show("Form is not Appropriate... Try Again");
            }
            con.Close();
        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            dob_t.Text = dateTimePicker.Value.ToString();
        }
        public void clear()
        {

            name_t.Clear();
        }
    }
}
