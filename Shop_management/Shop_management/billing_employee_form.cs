
using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;



namespace Shop_management
{
    public partial class billing_form_employee_form : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ahtis\OneDrive\Documents\Shop_Management_System_DB.mdf;Integrated Security=True;Connect Timeout=30");


        LinkedList<string> list_ = new LinkedList<string>();
        LinkedList<string> quantity_product = new LinkedList<string>();

        
        

        int bill_no = 0;
        int total_bill = 0;
        public billing_form_employee_form(string name)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.Manual;
            Left = 400;
            Top = 200;
            name_label_text_box_main_billing_home_page.Text = name;
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
        //update data in product bill table
        private void update_data_table_product_bill()
        {
            products_bill_data_table_main_billing_employee_form.Rows.Add(product_name_text_box_main_billing_employee_form.Text, product_quantity_text_box_main_billing_employee_form.Text);
        }
        public billing_form_employee_form()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.Manual;
            Left = 400;
            Top = 200;
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

        private void update_data_table()
        {


            SqlDataAdapter sda = new SqlDataAdapter("select product_name,product_quantity from products_tb", con);
            System.Data.DataTable dt = new System.Data.DataTable();

            sda.Fill(dt);

            products_data_table_main_billing_employee_form.DataSource = dt;
            con.Close();
        }
        private void update_product_bill_table()
        {

            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select product_name,product_quantity from products_tb", con);
            System.Data.DataTable dt = new System.Data.DataTable();

            sda.Fill(dt);

            products_data_table_main_billing_employee_form.DataSource = dt;
            con.Close();
        }
        public string username_store(string username)
        {
            return username;
        }

        private void home_button_home_page_Click(object sender, EventArgs e)
        {
            employee_home_page ep = new employee_home_page(name_label_text_box_main_billing_home_page.Text);
            ep.Show();
            this.Hide();
        }

        private void logout_button_home_page_Click(object sender, EventArgs e)
        {
            login l = new login();
            l.Show();
            this.Hide();
        }

        private void products_data_table_main_billing_employee_form_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
            
        }

        private void products_data_table_main_billing_employee_form_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                product_name_text_box_main_billing_employee_form.Text = products_data_table_main_billing_employee_form.SelectedRows[0].Cells[0].Value.ToString();
            }
            catch (Exception ex)
            {
            }
        }

        private void search_product_button_main_billing_employee_form_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select product_name from products_tb where product_name='"+product_name_text_box_main_billing_employee_form.Text+"'", con);
            System.Data.DataTable dt = new System.Data.DataTable();

            sda.Fill(dt);

            products_data_table_main_billing_employee_form.DataSource = dt;
            con.Close();
        }

        private void show_all_button_main_billing_employee_form_Click(object sender, EventArgs e)
        {
            update_data_table();
        }

        void insert_in_current_session()
        {
            list_.AddLast(product_name_text_box_main_billing_employee_form.Text);
            quantity_product.AddLast(product_quantity_text_box_main_billing_employee_form.Text);
        }

        //Adding [****]
        private void add_button_main_billing_employee_form_Click(object sender, EventArgs e)
        {
            con.Open();

            SqlDataAdapter sda = new SqlDataAdapter("Select product_quantity from products_tb where product_name='"+ product_name_text_box_main_billing_employee_form.Text+"'", con);


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

                        insert_in_current_session(); //not for OOP [UNDER WORK]

                        new_bill(latest_bill);
                        update_data_table();
                        update_products_table(qty_converted.ToString());



                        bill_no++;



                        update_data_table_product_bill(); //not for OOP [UNDER WORK]
                        con.Close();
                    }

                    else
                    {

                        insert_in_current_session();



                        update_bill_table();

                        update_data_table();


                        update_products_table(qty_converted.ToString());

                        update_data_table();

                        update_data_table_product_bill();
                        con.Close();
                    }
                }
            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            

            con.Close();
        }

        ///Works with ADD
       
        private void increase_total_bill()
        {

            SqlDataAdapter price_received = new SqlDataAdapter("select product_price from products_tb where product_name='"+ product_name_text_box_main_billing_employee_form.Text+"'", con);

            System.Data.DataTable table_price_received = new System.Data.DataTable();

            price_received.Fill(table_price_received);

            total_bill = total_bill + (Convert.ToInt32(table_price_received.Rows[0][0].ToString())) * Convert.ToInt32(product_quantity_text_box_main_billing_employee_form.Text);

            total_money_text_main_billing_employee_form.Text = total_bill.ToString();
        }
        private void update_products_table(string qty_converted)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("update products_tb set product_quantity=@qty where product_name='" + product_name_text_box_main_billing_employee_form.Text + "'", con);
            cmd.Parameters.AddWithValue("@qty", qty_converted);
            cmd.ExecuteNonQuery(); 
            //MessageBox.Show("Product Added to the bill");
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

        private void new_bill(string latest_bill)
        {
            string bill_no_returned = get_bill_no();


            SqlCommand cmd_update_bill = new SqlCommand("insert into bill_tb( product_names, bill_date)values(@name+'-'+@quantity+'-', current_timestamp)", con);
            cmd_update_bill.Parameters.AddWithValue("@name", product_name_text_box_main_billing_employee_form.Text);
            cmd_update_bill.Parameters.AddWithValue("@quantity", product_quantity_text_box_main_billing_employee_form.Text);

            //cmd_update_bill.Parameters.AddWithValue("@max_key", latest_bill);

            increase_total_bill();

            cmd_update_bill.ExecuteNonQuery();
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
        ///

        private void print_bill_button_main_billing_employee_form_Click(object sender, EventArgs e)
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
                    ////////////////////////////
                    ///
                    int total_rows_product_bill_table = products_bill_data_table_main_billing_employee_form.Rows.Count;


                    list_.Clear();
                    quantity_product.Clear();

                    //////////////////////////////INSERT DATA IN EXCEL AT ALL COSTS

                    ///EXCEL WORK
                    excel_work();

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

        private void excel_work()
        {

            string excel_file_path = @"C:\\Users\\ahtis\\OneDrive\\Desktop\\UNI\\Shop_Management\\products_bill_excel_sheet.xlsx";
            Microsoft.Office.Interop.Excel.Application excel_file = new Microsoft.Office.Interop.Excel.Application();
            Workbook wb;
            Worksheet ws;

            wb = excel_file.Workbooks.Open(excel_file_path);

            ws = wb.Worksheets[1];



                int latest_used_row = ws.UsedRange.Rows.Count; //Returns the most recent used row

                latest_used_row = latest_used_row + 2; //Moving to next to row [2]


                string bill_no_current = get_bill_no();

            //assigning seperators
                        ws.Cells[latest_used_row, 1].Value = "-#-"; //row, col
                        ws.Cells[latest_used_row, 2].Value = "-#-";
                        ws.Cells[latest_used_row, 3].Value = "-#-";
                        ws.Cells[latest_used_row, 4].Value = "-#-";
                        ws.Cells[latest_used_row, 5].Value = "-#-";
                        ws.Cells[latest_used_row, 6].Value = "-#-";
                        ws.Cells[latest_used_row, 7].Value = "-#-";

                latest_used_row = latest_used_row + 1;

                ws.Cells[latest_used_row + 1, 1].Value = name_label_text_box_main_billing_home_page.Text; //name of Employee

                ws.Cells[latest_used_row + 1, 2].Value = bill_no_current; //Assigning Bill_no

                ws.Cells[latest_used_row + 1, 3].Value = dropdown_customer_id_main_billing_employee_form.Text; //Name of Customer

                ws.Cells[latest_used_row + 1, 4] = DateTime.Now.ToString("h:mm:ss");//Setting Bill Time

                latest_used_row += 1;

                //Loop For Traversing and inserting data in excel
                for (int data_table_row = 0;data_table_row<products_bill_data_table_main_billing_employee_form.Rows.Count; data_table_row++)
                {
                        ws.Cells[latest_used_row, 5].Value = products_bill_data_table_main_billing_employee_form.Rows[data_table_row].Cells[0].Value;
                        ws.Cells[latest_used_row, 6].Value = products_bill_data_table_main_billing_employee_form.Rows[data_table_row].Cells[1].Value;
                        latest_used_row++;
                }

                //total bill
                ws.Cells[latest_used_row, 7].Value = total_money_text_main_billing_employee_form.Text;

                wb.Close();

                
        }
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

        }

        private void products_bill_data_table_main_billing_employee_form_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void billing_form_employee_form_Load(object sender, EventArgs e)
        {

        }

        private void dropdown_customer_id_main_billing_employee_form_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void products_bill_data_table_main_billing_employee_form_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void current_session_button_main_billing_employee_form_Click(object sender, EventArgs e)
        {
            if (list_.Count == 0 && quantity_product.Count == 0)
            {
                MessageBox.Show("the session is empty");
            }
            else
            {
                current_session_form cf = new current_session_form(list_, dropdown_customer_id_main_billing_employee_form.Text, quantity_product);
                cf.Show();
            }

        }

        private void order_button_main_employee_form_Click(object sender, EventArgs e)
        {
            order_page op = new order_page(name_label_text_box_main_billing_home_page.Text);
            op.Show();
            this.Hide();
        }
    }
}
