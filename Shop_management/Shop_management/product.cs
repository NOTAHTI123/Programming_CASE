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
    public partial class product : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ahtis\OneDrive\Documents\Shop_Management_System_DB.mdf;Integrated Security=True;Connect Timeout=30");
        public product()
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
            SqlDataAdapter sda = new SqlDataAdapter("select * from products_tb", con);
            DataTable dt = new DataTable();

            sda.Fill(dt);

            data_table_main_product_form.DataSource = dt;
            con.Close();
        }

        private void add_button_main_employee_form_Click(object sender, EventArgs e)
        {
            if (product_name_text_box_main_product_form.Text == "" || drop_down_menu_main_Customer_form.Text=="" || product_quantity_text_box_main_product_form.Text == "" || product_idtext_box_main_product_form.Text == "" || product_price_text_box_main_product_form.Text=="")
            {
                MessageBox.Show("Please Fill out all the fields");
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("insert into products_tb (product_id, product_name, product_category, product_quantity, product_price)values(@pid, @pname, @pcategory, @pquantity, @pprice)", con);
                    cmd.Parameters.AddWithValue("@pid", product_idtext_box_main_product_form.Text);
                    cmd.Parameters.AddWithValue("@pname", product_name_text_box_main_product_form.Text);
                    cmd.Parameters.AddWithValue("@pcategory", drop_down_menu_main_Customer_form.Text);
                    cmd.Parameters.AddWithValue("@pquantity", product_quantity_text_box_main_product_form.Text);
                    cmd.Parameters.AddWithValue("@pprice", product_price_text_box_main_product_form.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Product added successfully");
                    con.Close();

                    update_data_table();
                }

                catch (Exception Ex)
                {
                    MessageBox.Show("The Product with the matching id already exists");
                    con.Close();
                }
            }
        }

        private void category_dropdown_main_product_form_onItemSelected(object sender, EventArgs e)
        {

        }

        private void edit_button_main_employee_form_Click(object sender, EventArgs e)
        {
            if (product_idtext_box_main_product_form.Text == "")
            {
                MessageBox.Show("Please Enter all the details [Keeping the product id the same]");
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("update products_tb set product_name = @pname, product_category = @pcategory, product_quantity = @pquantity where product_id=@pid", con);
                    cmd.Parameters.AddWithValue("@pid", product_idtext_box_main_product_form.Text);
                    cmd.Parameters.AddWithValue("@pname", product_name_text_box_main_product_form.Text);
                    cmd.Parameters.AddWithValue("@pcategory", drop_down_menu_main_Customer_form.Text);
                    cmd.Parameters.AddWithValue("@pquantity", product_quantity_text_box_main_product_form.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Products's data edited successfully");
                    con.Close();

                    update_data_table();
                }

                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void delete_button_main_employee_form_Click(object sender, EventArgs e)
        {
            if (product_idtext_box_main_product_form.Text == "")
            {
                MessageBox.Show("Please Enter the product id");
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("delete from products_tb  where product_id=@pid", con);
                    cmd.Parameters.AddWithValue("@pid", product_idtext_box_main_product_form.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Product's data deleted successfully");
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
            employee e_p = new employee();
            e_p.Show();
            this.Hide();
        }

        private void customer_button_home_page_Click(object sender, EventArgs e)
        {
            customers c = new customers();
            c.Show();
            this.Hide();
        }

        private void logout_button_home_page_Click(object sender, EventArgs e)
        {
            login l = new login();
            l.Show();
            this.Hide();    
        }

        private void data_table_main_product_form_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void data_table_main_product_form_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                product_name_text_box_main_product_form.Text = data_table_main_product_form.SelectedRows[0].Cells[1].Value.ToString();
                drop_down_menu_main_Customer_form.Text = data_table_main_product_form.SelectedRows[0].Cells[2].Value.ToString();
                product_quantity_text_box_main_product_form.Text = data_table_main_product_form.SelectedRows[0].Cells[3].Value.ToString();
                product_idtext_box_main_product_form.Text = data_table_main_product_form.SelectedRows[0].Cells[0].Value.ToString();
            }
            catch(Exception ex)
            {

            }
        }

        private void billing_button_home_page_Click(object sender, EventArgs e)
        {
            billing_form_admin b = new billing_form_admin();
            b.Show();
            this.Hide();
        }

        private void product_Load(object sender, EventArgs e)
        {

        }
    }
}
