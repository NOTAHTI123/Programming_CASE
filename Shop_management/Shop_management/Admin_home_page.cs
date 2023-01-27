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
    public partial class admin_home_page : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ahtis\OneDrive\Documents\Shop_Management_System_DB.mdf;Integrated Security=True;Connect Timeout=30");

        public admin_home_page()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.Manual;
            Left = 400;
            Top = 200;
            update_progress_employee();
            update_food_and_beverages();
            update_beauty();
            update_clothing();
        }

        private void logout_button_home_page_Click(object sender, EventArgs e)
        {
            login l = new login();
            l.Show();
            this.Hide();
        }

        private void clothing_button_main_home_page_Click(object sender, EventArgs e)
        {

        }

        private void update_progress_employee()
        {
            
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("select count(*) from employee_tb", con);
            DataTable dt = new DataTable();

            da.Fill(dt);

            string number_of_employees;


            number_of_employees = dt.Rows[0][0].ToString();

            employee_circle_progress_bar_home_page.Text = number_of_employees;

            con.Close();
        }

        private void update_food_and_beverages()
        {
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("select count(*) from products_tb where product_category = 'food and beverages'", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            string number_of_food_and_beverages = dt.Rows[0][0].ToString();
            count_food_and_beverages_main_home_page.Text = number_of_food_and_beverages;
            con.Close();
        }

        private void update_beauty()
        {
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("select count(*) from products_tb where product_category = 'beauty'", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            string number_of_food_and_beverages = dt.Rows[0][0].ToString();
            count_beauty_main_home_page.Text = number_of_food_and_beverages;
            con.Close();
        }

        private void update_clothing()
        {
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("select count(*) from products_tb where product_category = 'clothing'", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            string number_of_food_and_beverages = dt.Rows[0][0].ToString();
            count_clothing_main_home_page.Text = number_of_food_and_beverages;
            con.Close();
        }

        private void home_button_home_page_Click(object sender, EventArgs e)
        {

        }

        private void employee_button_home_page_Click(object sender, EventArgs e)
        {
            employee e_f = new employee();
            e_f.Show();
            this.Hide();
        }

        private void customer_button_home_page_Click(object sender, EventArgs e)
        {
            customers c = new customers();
            c.Show();
            this.Hide();
        }

        private void product_button_home_page_Click(object sender, EventArgs e)
        {
            product p = new product();
            p.Show();
            this.Hide();
        }

        private void home_page_Load(object sender, EventArgs e)
        {

        }

        private void billing_button_home_page_Click(object sender, EventArgs e)
        {
            billing_form_admin ba = new billing_form_admin();
            ba.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void count_food_and_beverages_main_home_page_Click(object sender, EventArgs e)
        {

        }
    }
}
