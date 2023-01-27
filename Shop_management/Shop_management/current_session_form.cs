using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shop_management
{
    public partial class current_session_form : Form
    {
        public current_session_form()
        {
            InitializeComponent();

        }

        public current_session_form(LinkedList<string> listp, string name_passed, LinkedList<string> quan)
        {
            InitializeComponent();
            current_session_form_data_grid.ColumnCount = 5;
            current_session_form_data_grid.Rows.Add(50);
            current_session_form_data_grid.Columns[0].Name = "Customer";
            current_session_form_data_grid.Columns[1].Name = "Product";
            current_session_form_data_grid.Columns[2].Name = "Quantity";
            current_session_form_data_grid.Rows[1].Cells[0].Value = name_passed;
            int i = 2;
            foreach (string s in listp)
            {
                current_session_form_data_grid.Rows[i].Cells[1].Value = s;
                i++;
            }

            int j = 2;
            foreach(string s_ in quan){
                current_session_form_data_grid.Rows[j].Cells[2].Value = s_;
                j++;
            }
        }

        private void current_session_data_grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void current_session_form_Load(object sender, EventArgs e)
        {

        }

        private void current_session_form_data_grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
