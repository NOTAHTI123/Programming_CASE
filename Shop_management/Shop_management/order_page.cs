using System;
//using System.Collections;
using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
using System.Data.SqlClient;
//using System.Drawing;
using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shop_management
{
    public partial class order_page : Form
    {
        Queue<string> q = new Queue<string>();

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ahtis\OneDrive\Documents\Shop_Management_System_DB.mdf;Integrated Security=True;Connect Timeout=30");

        int bill_no = 0;
        int total_bill = 0;
        public order_page()
        {
            InitializeComponent();
        }

        public order_page(string s)
        {
            InitializeComponent();
            name_label_text_box_main_billing_home_page.Text = s;
            StartPosition = FormStartPosition.Manual;
            Left = 400;
            Top = 200;
            update_data_table();
            update_drop_down_list();
            update_data_table_product_headings();
        }


        //update heading
        private void update_data_table_product_headings()
        {
            products_bill_data_table_main_billing_employee_form.ColumnCount = 2;
            products_bill_data_table_main_billing_employee_form.Columns[0].Name = "Name";
            products_bill_data_table_main_billing_employee_form.Columns[1].Name = "Quantity";
        }



        private void update_data_table()
        {


            SqlDataAdapter sda = new SqlDataAdapter("select product_name,product_quantity from products_tb", con);
            System.Data.DataTable dt = new System.Data.DataTable();

            sda.Fill(dt);

            products_data_table_main_billing_employee_form.DataSource = dt;
            con.Close();
        }



        private void update_drop_down_list()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Select customer_name from customer_tb", con);
            SqlDataReader sdr = cmd.ExecuteReader();


            while (sdr.Read())
            {
                dropdown_customer_id_main_billing_employee_form.Items.Add(sdr.GetString(0));
            }

            con.Close();
        }

        private void order_page_Load(object sender, EventArgs e)
        {

        }

        private void home_button_home_page_Click(object sender, EventArgs e)
        {
            employee_home_page ep = new employee_home_page(name_label_text_box_main_billing_home_page.Text);
            ep.Show();
            this.Hide();
        }

        private void billing_button_home_page_Click(object sender, EventArgs e)
        {
            billing_form_employee_form ef = new billing_form_employee_form(name_label_text_box_main_billing_home_page.Text);
            ef.Show();
            this.Hide();
        }

        private void logout_button_home_page_Click(object sender, EventArgs e)
        {
            login l = new login();
            l.Show();
            this.Hide();
        }

        private void add_button_main_billing_employee_form_Click(object sender, EventArgs e)
        {
            con.Open();


            SqlDataAdapter sda = new SqlDataAdapter("Select product_quantity from products_tb where product_name='" + product_name_text_box_main_billing_employee_form.Text + "'", con);


            System.Data.DataTable dt = new System.Data.DataTable();

            sda.Fill(dt);


            try
            {

                int qty_converted = Convert.ToInt32(dt.Rows[0][0].ToString());
                int qty_passed = Convert.ToInt32(product_quantity_text_box_main_billing_employee_form.Text);



                if (qty_passed > qty_converted)
                {
                    MessageBox.Show("Not Enough Stock");
                }

                else
                {
                    qty_converted = qty_converted - qty_passed;

                    string latest_bill = get_bill_no();

                    if (latest_bill == "0" || bill_no == 0)
                    {

                        //insert_in_current_session();

                        new_bill(latest_bill);
                        update_data_table();
                        update_products_table(qty_converted.ToString());



                        bill_no++;



                        update_data_table_product_bill();
                        con.Close();
                    }

                    else
                    {

                        //insert_in_current_session();



                        update_bill_table();

                        update_data_table();


                        update_products_table(qty_converted.ToString());

                        update_data_table();

                        update_data_table_product_bill();
                        con.Close();
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



            con.Close();
        }


        private void update_bill_table()
        {
            string current_bill_no = get_bill_no();
            SqlCommand cmd_update_bill = new SqlCommand("update bill_tb set product_names=product_names+' - '+@productname+' - '+@quantity where bill_no=@max_key", con);
            cmd_update_bill.Parameters.AddWithValue("@quantity", product_quantity_text_box_main_billing_employee_form.Text);
            cmd_update_bill.Parameters.AddWithValue("@productname", product_name_text_box_main_billing_employee_form.Text);
            cmd_update_bill.Parameters.AddWithValue("@max_key", current_bill_no);

            increase_total_bill();

            cmd_update_bill.ExecuteNonQuery();
            update_data_table();
        }

        //update data in product bill table
        private void update_data_table_product_bill()
        {
            products_bill_data_table_main_billing_employee_form.Rows.Add(product_name_text_box_main_billing_employee_form.Text, product_quantity_text_box_main_billing_employee_form.Text);
        }
        private void update_products_table(string qty_converted)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("update products_tb set product_quantity=@qty where product_name='" + product_name_text_box_main_billing_employee_form.Text + "'", con);
            cmd.Parameters.AddWithValue("@qty", qty_converted);
            cmd.ExecuteNonQuery();
            //MessageBox.Show("Product Added to the bill");
        }
        private string get_bill_no()
        {
            //Getting latest Bill
            SqlDataAdapter sda_count = new SqlDataAdapter("select count(*) from bill_tb", con);
            System.Data.DataTable dt_count = new System.Data.DataTable();
            sda_count.Fill(dt_count);

            string count_bill = dt_count.Rows[0][0].ToString();


            if (count_bill == "0")
            {
                return count_bill;
            }
            else
            {
                SqlDataAdapter sda_max = new SqlDataAdapter("select max(bill_no) from bill_tb", con);
                System.Data.DataTable dt_max = new System.Data.DataTable();
                sda_max.Fill(dt_max);

                string max_primary_key_bill = dt_max.Rows[0][0].ToString();


                return max_primary_key_bill;
            }
        }

        private void new_bill(string latest_bill)
        {
            string bill_no_returned = get_bill_no();


            SqlCommand cmd_update_bill = new SqlCommand("insert into bill_tb( product_names, bill_date)values(@name+'-'+@quantity+'-', current_timestamp)", con);
            cmd_update_bill.Parameters.AddWithValue("@name", product_name_text_box_main_billing_employee_form.Text);
            cmd_update_bill.Parameters.AddWithValue("@quantity", product_quantity_text_box_main_billing_employee_form.Text);

            cmd_update_bill.Parameters.AddWithValue("@max_key", latest_bill);

            increase_total_bill();

            cmd_update_bill.ExecuteNonQuery();
        }

        private void increase_total_bill()
        {

            SqlDataAdapter price_received = new SqlDataAdapter("select product_price from roducts_tb where product_name='" + product_name_text_box_main_billing_employee_form.Text + "'", con);

            System.Data.DataTable table_price_received = new System.Data.DataTable();

            price_received.Fill(table_price_received);

            total_bill = total_bill + (Convert.ToInt32(table_price_received.Rows[0][0].ToString())) * Convert.ToInt32(product_quantity_text_box_main_billing_employee_form.Text);

            total_money_text_main_billing_employee_form.Text = total_bill.ToString();
        }
        private void confirm_bill_button_main_billing_employee_form_Click(object sender, EventArgs e)
        {
            
            con.Open();



            bill_no--;

            if (product_name_text_box_main_billing_employee_form.Text == "" || product_quantity_text_box_main_billing_employee_form.Text == "" || dropdown_customer_id_main_billing_employee_form.Text == "")
            {
                MessageBox.Show("Make sure the fields are not empty");
            }
            else
            {

                if (products_bill_data_table_main_billing_employee_form.Rows.Count >= 1)
                {

                    MessageBox.Show("Bill Generated");

                    //Inserting total bill price
                    SqlCommand cmd = new SqlCommand("update bill_tb set total_bill=@tbill where bill_no=@bno", con);
                    cmd.Parameters.AddWithValue("@bno", get_bill_no());
                    cmd.Parameters.AddWithValue("@tbill", total_bill);

                    cmd.ExecuteNonQuery();
                    q.Enqueue(get_bill_no());

                }
                else
                {
                    MessageBox.Show("ERROR");
                }


                //Clearing the products bill data table[grid]
                products_bill_data_table_main_billing_employee_form.Rows.Clear();

                //Reseting bill price to 0 so that the previous bill price shall not interfere
                total_bill = 0;

                //:)
                total_money_text_main_billing_employee_form.Text = "**";
            }
            con.Close();
        }

        private void current_session_button_main_billing_employee_form_Click(object sender, EventArgs e)
        {
            if(q.Count == 0)
            {
                MessageBox.Show("THE QUEUE IS EMPTY");
            }
            else
            {
                string current_bill_no = q.First().ToString();
                MessageBox.Show("id no : " + current_bill_no + "dequeued");
                q.Dequeue();
            }
        }

        private void products_data_table_main_billing_employee_form_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                product_name_text_box_main_billing_employee_form.Text = products_data_table_main_billing_employee_form.SelectedRows[0].Cells[0].Value.ToString();
            }
            catch (Exception ex)
            {
            }
        }
    }
}
