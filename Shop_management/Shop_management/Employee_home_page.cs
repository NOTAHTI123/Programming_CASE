using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shop_management
{
    public partial class employee_home_page : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ahtis\OneDrive\Documents\Shop_Management_System_DB.mdf;Integrated Security=True;Connect Timeout=30");

        public employee_home_page(string name)
        {
            InitializeComponent();
            name_label_text_box_main_admin_home_page.Text = name;
            StartPosition = FormStartPosition.Manual;
            Left = 400;
            Top = 200;
            initialize_main_employee_home_page();
        }
        public employee_home_page()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.Manual;
            Left = 400;
            Top = 200;
            initialize_main_employee_home_page();
        }


        private void initialize_main_employee_home_page()
        {
            //address
            SqlDataAdapter employeeaddress = new SqlDataAdapter("select employee_address from employee_tb where employee_name='"+name_label_text_box_main_admin_home_page.Text+"'",con);
            DataTable dt_address = new DataTable();
            employeeaddress.Fill(dt_address);
            address_text_box_main_admin_home_page.Text = dt_address.Rows[0][0].ToString();

            //id
            SqlDataAdapter id = new SqlDataAdapter("select employee_id from employee_tb where employee_name='"+name_label_text_box_main_admin_home_page.Text+"'", con);
            DataTable dt_id = new DataTable();
            id.Fill(dt_id);
            id_text_box_main_admin_home_page.Text = dt_id.Rows[0][0].ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void logout_button_home_page_Click(object sender, EventArgs e)
        {
            login l = new login();
            l.Show();
            this.Close();
        }

        private void billing_button_home_page_Click(object sender, EventArgs e)
        {
            billing_form_employee_form bf = new billing_form_employee_form(name_label_text_box_main_admin_home_page.Text);
            bf.Show();
            this.Hide();
        }

        private void id_text_box_main_admin_home_page_Click(object sender, EventArgs e)
        {

        }

        private void edit_button_main_home_employee_form_Click(object sender, EventArgs e)
        {
            if (old_password_text_box_main_home_employee_form.Text == "" || new_password_text_box_main_home_employee_form.Text == "")
            {
                MessageBox.Show("Please Fill out both the fields");
            }
            else
            {
                con.Open();

                SqlDataAdapter sda = new SqlDataAdapter("select count(*) from employee_tb where employee_name='" +name_label_text_box_main_admin_home_page.Text+"' and employee_password ='"+old_password_text_box_main_home_employee_form.Text+"'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                try
                {

                    if (dt.Rows[0][0].ToString() == "1")
                    {
                        string query = "update employee_tb set employee_password=@enewpass where employee_password='" + old_password_text_box_main_home_employee_form.Text + "' and employee_name='"+name_label_text_box_main_admin_home_page.Text+"'";
                        SqlCommand cmd = new SqlCommand(query, con);
                        cmd.Parameters.AddWithValue("@enewpass", new_password_text_box_main_home_employee_form.Text);
                        MessageBox.Show("Success");
                        cmd.ExecuteNonQuery();
                    }
                    else
                    {
                        MessageBox.Show("Issue");
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                con.Close();
            }
        }

        private void order_button_main_employee_form_Click(object sender, EventArgs e)
        {
            order_page op = new order_page(name_label_text_box_main_admin_home_page.Text);
            op.Show();
            this.Hide();
        }
    }
}
