using System;
using System.Windows.Forms;

namespace Shop_management
{
    public partial class Loading : Form
    {
        public Loading()
        {
            InitializeComponent();
            timer1.Start();
            loading_bar_loading_screen.Value = 0;
            timer1.Interval = 5;
        }

        private void bunifuProgressBar1_progressChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (loading_bar_loading_screen.Value < 100)
            {
                loading_bar_loading_screen.Value += 2;
                percentage_text_loading_form.Text = loading_bar_loading_screen.Value.ToString();
            }
            else
            {
                timer1.Stop();
                login l = new login();
                l.Show();
                this.Hide();
            }
        }

        private void Loading_Load(object sender, EventArgs e)
        {

        }
    }
}
