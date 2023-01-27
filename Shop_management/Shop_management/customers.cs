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
    public partial class customers : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ahtis\OneDrive\Documents\Shop_Management_System_DB.mdf;Integrated Security=True;Connect Timeout=30");

        public customers()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.Manual;
            Left = 400;
            Top = 200;
            update_data_table();
        }

        private void update_data_table()
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select * from customer_tb", con);
            DataTable dt = new DataTable();

            sda.Fill(dt);

            data_table_main_customer_form.DataSource = dt;
            con.Close();
        }

        private void add_button_main_Customer_form_Click(object sender, EventArgs e)
        {
            if (Customer_name_text_box_main_Customer_form.Text == "" || Customer_address_text_box_main_Customer_form.Text == "" || phone_text_box_main_Customer_form.Text == "" || Customer_cnic_text_box_main_Customer_form.Text == "")
            {
                MessageBox.Show("Please Fill out all the fields");
            }

            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("insert into customer_tb (customer_cnic, customer_name, customer_phone, customer_address)values(@cid, @cname , @cphone, @caddress)", con);

                    cmd.Parameters.AddWithValue("@cname", Customer_name_text_box_main_Customer_form.Text);
                    cmd.Parameters.AddWithValue("@cid", Customer_cnic_text_box_main_Customer_form.Text);
                    cmd.Parameters.AddWithValue("@caddress", Customer_address_text_box_main_Customer_form.Text);
                    cmd.Parameters.AddWithValue("@cphone", phone_text_box_main_Customer_form.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Customer added successfully");
                    con.Close();

                    update_data_table();
                }

                catch (Exception Ex)
                {
                    MessageBox.Show("The Customer with the matching cnic already exists");
                }
            }
        }

        private void edit_button_main_Customer_form_Click(object sender, EventArgs e)
        {
            if(Customer_name_text_box_main_Customer_form.Text == "" || Customer_address_text_box_main_Customer_form.Text == "" || phone_text_box_main_Customer_form.Text == "" || Customer_cnic_text_box_main_Customer_form.Text == "")
            {
                MessageBox.Show("Please Fill out all the fields [The Customer cnic must be the same]");
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("update customer_tb set customer_name = @cname, customer_address = @caddress, customer_phone = @cphone  where customer_cnic=@cid", con);
                    cmd.Parameters.AddWithValue("@cid", Customer_cnic_text_box_main_Customer_form.Text);
                    cmd.Parameters.AddWithValue("@cname", Customer_name_text_box_main_Customer_form.Text);
                    cmd.Parameters.AddWithValue("@caddress", Customer_address_text_box_main_Customer_form.Text);
                    cmd.Parameters.AddWithValue("@cphone", phone_text_box_main_Customer_form.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Customer's data edited successfully");
                    con.Close();

                    update_data_table();
                }

                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void home_button_home_page_Click(object sender, EventArgs e)
        {
            admin_home_page hp = new admin_home_page(); 
            hp.Show();
            this.Hide();
        }

        private void employee_button_home_page_Click(object sender, EventArgs e)
        {
            employee e_s = new employee();  
            e_s.Show();
            this.Hide();
        }

        private void delete_button_main_Customer_form_Click(object sender, EventArgs e)
        {
            if (Customer_cnic_text_box_main_Customer_form.Text == "")
            {
                MessageBox.Show("Please Enter the Customer CNIC");
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("delete from customer_tb  where customer_cnic=@cid", con);
                    cmd.Parameters.AddWithValue("@cid", Customer_cnic_text_box_main_Customer_form.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Customer's data deleted successfully");
                    con.Close();

                    update_data_table();
                }

                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void logout_button_home_page_Click(object sender, EventArgs e)
        {
            login l = new login();
            l.Show();
            this.Hide();
        }

        private void product_button_home_page_Click(object sender, EventArgs e)
        {
            product p = new product();  
            p.Show();
            this.Hide();
        }

        private void data_table_main_customer_form_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Customer_name_text_box_main_Customer_form.Text = data_table_main_customer_form.SelectedRows[0].Cells[1].Value.ToString();
                Customer_address_text_box_main_Customer_form.Text = data_table_main_customer_form.SelectedRows[0].Cells[3].Value.ToString();
                Customer_cnic_text_box_main_Customer_form.Text = data_table_main_customer_form.SelectedRows[0].Cells[0].Value.ToString();
                phone_text_box_main_Customer_form.Text = data_table_main_customer_form.SelectedRows[0].Cells[2].Value.ToString();
            }
            catch(Exception ex)
            {

            }
        }

        private void billing_button_home_page_Click(object sender, EventArgs e)
        {
            billing_form_admin ba = new billing_form_admin();
            ba.Show();
            this.Hide();
        }

        private void customers_Load(object sender, EventArgs e)
        {

        }
    }
}
