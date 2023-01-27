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
    public partial class employee : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ahtis\OneDrive\Documents\Shop_Management_System_DB.mdf;Integrated Security=True;Connect Timeout=30");

        public employee()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.Manual;
            Left = 400;
            Top = 200;
            update_data_table();
        }

        private void logout_button_home_page_Click(object sender, EventArgs e)
        {
            login l = new login();
            l.Show();
            this.Hide();
        }

        private void home_button_home_page_Click(object sender, EventArgs e)
        {
            admin_home_page hp = new admin_home_page();
            hp.Show();
            this.Hide();
        }

        private void data_table_main_employee_form_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void update_data_table()
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select * from employee_tb", con);
            DataTable dt = new DataTable();

            sda.Fill(dt);

            data_table_main_employee_form.DataSource = dt;
            con.Close();
        }

        private void add_button_main_employee_form_Click(object sender, EventArgs e)
        {
            if(employee_idtext_box_main_employee_form.Text==""|| employee_name_text_box_main_employee_form.Text == ""|| employee_address_text_box_main_employee_form.Text==""|| employee_phone_text_box_main_employee_form.Text==""|| password_text_box_main_employee_form.Text == "")
            {
                MessageBox.Show("Please Fill out all the fields");
            }

            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("insert into employee_tb (employee_id, employee_name, employee_address, employee_phone, employee_dob, employee_password)values(@eid, @ename, @eaddress, @ephone, @edob, @epass)", con);
                    cmd.Parameters.AddWithValue("@eid", employee_idtext_box_main_employee_form.Text);
                    cmd.Parameters.AddWithValue("@ename", employee_name_text_box_main_employee_form.Text);
                    cmd.Parameters.AddWithValue("@eaddress", employee_address_text_box_main_employee_form.Text);
                    cmd.Parameters.AddWithValue("@ephone", employee_phone_text_box_main_employee_form.Text);
                    cmd.Parameters.AddWithValue("@edob", date_select_main_employee_form.Value);
                    cmd.Parameters.AddWithValue("@epass", password_text_box_main_employee_form.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Employee added successfully");
                    con.Close();

                    update_data_table();
                }

                catch (Exception Ex)
                {
                    MessageBox.Show("The Employee with the matching id already exists");
                }
            }
        }

        private void edit_button_main_employee_form_Click(object sender, EventArgs e)
        {
            if (employee_idtext_box_main_employee_form.Text == "")
            {
                MessageBox.Show("Please Enter the Employee ID");
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("update employee_tb set employee_name = @ename, employee_address = @eaddress, employee_phone = @ephone, employee_dob = @edob, employee_password=@epass  where employee_id=@eid", con);
                    cmd.Parameters.AddWithValue("@eid", employee_idtext_box_main_employee_form.Text);
                    cmd.Parameters.AddWithValue("@ename", employee_name_text_box_main_employee_form.Text);
                    cmd.Parameters.AddWithValue("@eaddress", employee_address_text_box_main_employee_form.Text);
                    cmd.Parameters.AddWithValue("@ephone", employee_phone_text_box_main_employee_form.Text);
                    cmd.Parameters.AddWithValue("@edob", date_select_main_employee_form.Value);
                    cmd.Parameters.AddWithValue("@epass", password_text_box_main_employee_form.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Employee's data edited successfully");
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
            if (employee_idtext_box_main_employee_form.Text == "")
            {
                MessageBox.Show("Please Enter the Employee ID");
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("delete from employee_tb  where employee_id=@eid", con);
                    cmd.Parameters.AddWithValue("@eid", employee_idtext_box_main_employee_form.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Employee's data deleted successfully");
                    con.Close();

                    update_data_table();
                }

                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
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

        private void data_table_main_employee_form_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                employee_name_text_box_main_employee_form.Text = data_table_main_employee_form.SelectedRows[0].Cells[1].Value.ToString();
                employee_address_text_box_main_employee_form.Text = data_table_main_employee_form.SelectedRows[0].Cells[2].Value.ToString();
                password_text_box_main_employee_form.Text = data_table_main_employee_form.SelectedRows[0].Cells[5].Value.ToString();
                employee_idtext_box_main_employee_form.Text = data_table_main_employee_form.SelectedRows[0].Cells[0].Value.ToString();
                employee_phone_text_box_main_employee_form.Text = data_table_main_employee_form.SelectedRows[0].Cells[3].Value.ToString();
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

        private void employee_Load(object sender, EventArgs e)
        {

        }
    }
}
