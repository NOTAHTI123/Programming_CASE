using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Microsoft.Office.Interop.Excel;

namespace Shop_management
{
    public partial class billing_form_admin : Form
    {
        public billing_form_admin()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.Manual;
            Left = 400;
            Top = 200;
            update_bill_table();
        }

        private void update_bill_table()
        {
            bills_history_data_table_main_billing_admin_form.ColumnCount = 6;
            string file_path = "C:\\Users\\ahtis\\OneDrive\\Desktop\\UNI\\Shop_Management\\products_bill_excel_sheet.xlsx";


            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();

            Workbook wb;
            Worksheet ws;

            wb = excel.Workbooks.Open(file_path);
            ws = wb.Worksheets[1];

            for(int row = 1;row <= ws.UsedRange.Rows.Count; row++)
            {
                    bills_history_data_table_main_billing_admin_form.Rows.Add(ws.Cells[row, 1].Value, ws.Cells[row,2].Value, ws.Cells[row, 3].Value, ws.Cells[row, 5].Value, ws.Cells[row, 6].Value, ws.Cells[row, 7].Value);
            }

            wb.Close();
            
        }

        private void product_button_home_page_Click(object sender, EventArgs e)
        {
            product p = new product();
            p.Show();
            this.Hide();
        }

        private void customer_button_home_page_Click(object sender, EventArgs e)
        {
            customers c = new customers();
            c.Show();
            this.Hide();
        }

        private void employee_button_home_page_Click(object sender, EventArgs e)
        {
            employee e_ = new employee();
            e_.Show();
            this.Hide();
        }

        private void home_button_home_page_Click(object sender, EventArgs e)
        {
            admin_home_page ah = new admin_home_page();
            ah.Show();
            this.Hide();
        }

        private void logout_button_home_page_Click(object sender, EventArgs e)
        {
            login l = new login();
            l.Show();
            this.Hide();
        }

        private void bills_history_data_table_main_billing_admin_form_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void billing_form_admin_Load(object sender, EventArgs e)
        {

        }

        private void bills_history_data_table_main_billing_admin_form_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
