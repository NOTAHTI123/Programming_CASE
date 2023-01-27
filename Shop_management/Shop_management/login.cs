using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Shop_management
{
    public partial class login : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ahtis\OneDrive\Documents\Shop_Management_System_DB.mdf;Integrated Security=True;Connect Timeout=30");
        public login()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.Manual;
            Left = 600;
            Top = 200;
        }

        private void login_button_login_form_Click(object sender, EventArgs e)
        {

            if (username_text_box_login_form.Text == "" || password_text_box_login_form.Text == "")
            {
                MessageBox.Show("Please Fill out all the fields");
            }
            else
            {
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("select count(*) from employee_tb where employee_name = '"+username_text_box_login_form.Text+"' and employee_password='"+password_text_box_login_form.Text+"'", con);
            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows[0][0].ToString() == "1")
            {
                    employee_home_page ep = new employee_home_page(username_text_box_login_form.Text);
                    
                    ep.Show();
                    this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Credentials");
            }

            con.Close();


            }
        }

        private void username_text_box_login_form_TextChanged(object sender, EventArgs e)
        {

        }

        private void admin_login_buttone_login_page_Click(object sender, EventArgs e)
        {
            if (username_text_box_login_form.Text == "" || password_text_box_login_form.Text == "")
            {
                MessageBox.Show("Please Fill out all the fields");
            }
            else
            {
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select count(*) from admin_tb where admin_name='" + username_text_box_login_form.Text+ "' and admin_password='" + password_text_box_login_form.Text+"'", con);
                DataTable data= new DataTable();
                sda.Fill(data);

                if (data.Rows[0][0].ToString()=="1")
                {
                    admin_home_page hp = new admin_home_page();
                    hp.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid Credentials");
                }
                con.Close();
            }
        }

        private void login_Load(object sender, EventArgs e)
        {

        }
    }
}
