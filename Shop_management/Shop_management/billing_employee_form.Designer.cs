namespace Shop_management
{
    partial class billing_form_employee_form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(billing_form_employee_form));
            this.left_panel_buttons_home_page = new System.Windows.Forms.Panel();
            this.buttons_skeleton = new System.Windows.Forms.Panel();
            this.logout_button_home_page = new Bunifu.Framework.UI.BunifuThinButton2();
            this.billing_button_home_page = new Bunifu.Framework.UI.BunifuThinButton2();
            this.home_button_home_page = new Bunifu.Framework.UI.BunifuThinButton2();
            this.billing_label_main_billing_employee_form = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.name_label_text_box_main_billing_home_page = new System.Windows.Forms.Label();
            this.name_label_main_billing_home_page = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.customers_panel_main_billing_employee_form = new System.Windows.Forms.Panel();
            this.customer_name_label_main_billing_employee_form = new System.Windows.Forms.Label();
            this.dropdown_customer_id_main_billing_employee_form = new System.Windows.Forms.ComboBox();
            this.products_bill_label_main_billing_employee_form = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.show_all_button_main_billing_employee_form = new Bunifu.Framework.UI.BunifuThinButton2();
            this.search_product_button_main_billing_employee_form = new Bunifu.Framework.UI.BunifuThinButton2();
            this.add_button_main_billing_employee_form = new Bunifu.Framework.UI.BunifuThinButton2();
            this.product_name_text_box_main_billing_employee_form = new System.Windows.Forms.TextBox();
            this.product_quantity_text_box_main_billing_employee_form = new System.Windows.Forms.TextBox();
            this.product_quantity_label_main_billing_employee_form = new System.Windows.Forms.Label();
            this.product_name_label_main_billing_employee_form = new System.Windows.Forms.Label();
            this.products_label_main_billing_employee_form = new System.Windows.Forms.Label();
            this.confirm_bill_button_main_billing_employee_form = new Bunifu.Framework.UI.BunifuThinButton2();
            this.products_data_table_main_billing_employee_form = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.products_bill_data_table_main_billing_employee_form = new System.Windows.Forms.DataGridView();
            this.total_label_main_billing_employee_form = new System.Windows.Forms.Label();
            this.total_money_text_main_billing_employee_form = new System.Windows.Forms.Label();
            this.current_session_button_main_billing_employee_form = new Bunifu.Framework.UI.BunifuThinButton2();
            this.order_button_main_employee_form = new Bunifu.Framework.UI.BunifuThinButton2();
            this.left_panel_buttons_home_page.SuspendLayout();
            this.buttons_skeleton.SuspendLayout();
            this.panel3.SuspendLayout();
            this.customers_panel_main_billing_employee_form.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.products_data_table_main_billing_employee_form)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.products_bill_data_table_main_billing_employee_form)).BeginInit();
            this.SuspendLayout();
            // 
            // left_panel_buttons_home_page
            // 
            this.left_panel_buttons_home_page.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.left_panel_buttons_home_page.Controls.Add(this.buttons_skeleton);
            this.left_panel_buttons_home_page.Location = new System.Drawing.Point(0, -7);
            this.left_panel_buttons_home_page.Name = "left_panel_buttons_home_page";
            this.left_panel_buttons_home_page.Size = new System.Drawing.Size(197, 507);
            this.left_panel_buttons_home_page.TabIndex = 17;
            // 
            // buttons_skeleton
            // 
            this.buttons_skeleton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttons_skeleton.Controls.Add(this.order_button_main_employee_form);
            this.buttons_skeleton.Controls.Add(this.logout_button_home_page);
            this.buttons_skeleton.Controls.Add(this.billing_button_home_page);
            this.buttons_skeleton.Controls.Add(this.home_button_home_page);
            this.buttons_skeleton.Location = new System.Drawing.Point(23, 43);
            this.buttons_skeleton.Name = "buttons_skeleton";
            this.buttons_skeleton.Size = new System.Drawing.Size(146, 409);
            this.buttons_skeleton.TabIndex = 0;
            // 
            // logout_button_home_page
            // 
            this.logout_button_home_page.ActiveBorderThickness = 1;
            this.logout_button_home_page.ActiveCornerRadius = 20;
            this.logout_button_home_page.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.logout_button_home_page.ActiveForecolor = System.Drawing.Color.White;
            this.logout_button_home_page.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.logout_button_home_page.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.logout_button_home_page.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("logout_button_home_page.BackgroundImage")));
            this.logout_button_home_page.ButtonText = "Logout";
            this.logout_button_home_page.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logout_button_home_page.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout_button_home_page.ForeColor = System.Drawing.Color.SeaGreen;
            this.logout_button_home_page.IdleBorderThickness = 1;
            this.logout_button_home_page.IdleCornerRadius = 20;
            this.logout_button_home_page.IdleFillColor = System.Drawing.Color.Transparent;
            this.logout_button_home_page.IdleForecolor = System.Drawing.SystemColors.ControlLightLight;
            this.logout_button_home_page.IdleLineColor = System.Drawing.SystemColors.ControlLightLight;
            this.logout_button_home_page.Location = new System.Drawing.Point(7, 286);
            this.logout_button_home_page.Margin = new System.Windows.Forms.Padding(5);
            this.logout_button_home_page.Name = "logout_button_home_page";
            this.logout_button_home_page.Size = new System.Drawing.Size(133, 41);
            this.logout_button_home_page.TabIndex = 5;
            this.logout_button_home_page.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.logout_button_home_page.Click += new System.EventHandler(this.logout_button_home_page_Click);
            // 
            // billing_button_home_page
            // 
            this.billing_button_home_page.ActiveBorderThickness = 1;
            this.billing_button_home_page.ActiveCornerRadius = 20;
            this.billing_button_home_page.ActiveFillColor = System.Drawing.SystemColors.AppWorkspace;
            this.billing_button_home_page.ActiveForecolor = System.Drawing.Color.White;
            this.billing_button_home_page.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.billing_button_home_page.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.billing_button_home_page.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("billing_button_home_page.BackgroundImage")));
            this.billing_button_home_page.ButtonText = "Billing";
            this.billing_button_home_page.Cursor = System.Windows.Forms.Cursors.Hand;
            this.billing_button_home_page.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.billing_button_home_page.ForeColor = System.Drawing.Color.SeaGreen;
            this.billing_button_home_page.IdleBorderThickness = 1;
            this.billing_button_home_page.IdleCornerRadius = 20;
            this.billing_button_home_page.IdleFillColor = System.Drawing.SystemColors.AppWorkspace;
            this.billing_button_home_page.IdleForecolor = System.Drawing.SystemColors.ControlLightLight;
            this.billing_button_home_page.IdleLineColor = System.Drawing.SystemColors.ControlLightLight;
            this.billing_button_home_page.Location = new System.Drawing.Point(6, 235);
            this.billing_button_home_page.Margin = new System.Windows.Forms.Padding(5);
            this.billing_button_home_page.Name = "billing_button_home_page";
            this.billing_button_home_page.Size = new System.Drawing.Size(133, 41);
            this.billing_button_home_page.TabIndex = 4;
            this.billing_button_home_page.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // home_button_home_page
            // 
            this.home_button_home_page.ActiveBorderThickness = 1;
            this.home_button_home_page.ActiveCornerRadius = 20;
            this.home_button_home_page.ActiveFillColor = System.Drawing.SystemColors.AppWorkspace;
            this.home_button_home_page.ActiveForecolor = System.Drawing.Color.White;
            this.home_button_home_page.ActiveLineColor = System.Drawing.SystemColors.ControlLightLight;
            this.home_button_home_page.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.home_button_home_page.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("home_button_home_page.BackgroundImage")));
            this.home_button_home_page.ButtonText = "Home";
            this.home_button_home_page.Cursor = System.Windows.Forms.Cursors.Hand;
            this.home_button_home_page.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.home_button_home_page.ForeColor = System.Drawing.Color.SeaGreen;
            this.home_button_home_page.IdleBorderThickness = 1;
            this.home_button_home_page.IdleCornerRadius = 20;
            this.home_button_home_page.IdleFillColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.home_button_home_page.IdleForecolor = System.Drawing.SystemColors.ControlLightLight;
            this.home_button_home_page.IdleLineColor = System.Drawing.SystemColors.ControlLightLight;
            this.home_button_home_page.Location = new System.Drawing.Point(6, 34);
            this.home_button_home_page.Margin = new System.Windows.Forms.Padding(5);
            this.home_button_home_page.Name = "home_button_home_page";
            this.home_button_home_page.Size = new System.Drawing.Size(133, 41);
            this.home_button_home_page.TabIndex = 0;
            this.home_button_home_page.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.home_button_home_page.Click += new System.EventHandler(this.home_button_home_page_Click);
            // 
            // billing_label_main_billing_employee_form
            // 
            this.billing_label_main_billing_employee_form.AutoSize = true;
            this.billing_label_main_billing_employee_form.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.billing_label_main_billing_employee_form.Location = new System.Drawing.Point(475, 11);
            this.billing_label_main_billing_employee_form.Name = "billing_label_main_billing_employee_form";
            this.billing_label_main_billing_employee_form.Size = new System.Drawing.Size(70, 25);
            this.billing_label_main_billing_employee_form.TabIndex = 20;
            this.billing_label_main_billing_employee_form.Text = "Billing";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel3.Controls.Add(this.name_label_text_box_main_billing_home_page);
            this.panel3.Controls.Add(this.name_label_main_billing_home_page);
            this.panel3.Location = new System.Drawing.Point(755, -4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 75);
            this.panel3.TabIndex = 19;
            // 
            // name_label_text_box_main_billing_home_page
            // 
            this.name_label_text_box_main_billing_home_page.AutoSize = true;
            this.name_label_text_box_main_billing_home_page.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_label_text_box_main_billing_home_page.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.name_label_text_box_main_billing_home_page.Location = new System.Drawing.Point(87, 13);
            this.name_label_text_box_main_billing_home_page.Name = "name_label_text_box_main_billing_home_page";
            this.name_label_text_box_main_billing_home_page.Size = new System.Drawing.Size(21, 20);
            this.name_label_text_box_main_billing_home_page.TabIndex = 3;
            this.name_label_text_box_main_billing_home_page.Text = "**";
            // 
            // name_label_main_billing_home_page
            // 
            this.name_label_main_billing_home_page.AutoSize = true;
            this.name_label_main_billing_home_page.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_label_main_billing_home_page.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.name_label_main_billing_home_page.Location = new System.Drawing.Point(3, 13);
            this.name_label_main_billing_home_page.Name = "name_label_main_billing_home_page";
            this.name_label_main_billing_home_page.Size = new System.Drawing.Size(58, 20);
            this.name_label_main_billing_home_page.TabIndex = 2;
            this.name_label_main_billing_home_page.Text = "Name:";
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 30;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 30;
            this.bunifuElipse2.TargetControl = this;
            // 
            // customers_panel_main_billing_employee_form
            // 
            this.customers_panel_main_billing_employee_form.Controls.Add(this.customer_name_label_main_billing_employee_form);
            this.customers_panel_main_billing_employee_form.Controls.Add(this.dropdown_customer_id_main_billing_employee_form);
            this.customers_panel_main_billing_employee_form.Location = new System.Drawing.Point(203, 73);
            this.customers_panel_main_billing_employee_form.Name = "customers_panel_main_billing_employee_form";
            this.customers_panel_main_billing_employee_form.Size = new System.Drawing.Size(160, 128);
            this.customers_panel_main_billing_employee_form.TabIndex = 22;
            // 
            // customer_name_label_main_billing_employee_form
            // 
            this.customer_name_label_main_billing_employee_form.AutoSize = true;
            this.customer_name_label_main_billing_employee_form.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customer_name_label_main_billing_employee_form.Location = new System.Drawing.Point(3, 13);
            this.customer_name_label_main_billing_employee_form.Name = "customer_name_label_main_billing_employee_form";
            this.customer_name_label_main_billing_employee_form.Size = new System.Drawing.Size(144, 20);
            this.customer_name_label_main_billing_employee_form.TabIndex = 25;
            this.customer_name_label_main_billing_employee_form.Text = "Customer Name";
            // 
            // dropdown_customer_id_main_billing_employee_form
            // 
            this.dropdown_customer_id_main_billing_employee_form.FormattingEnabled = true;
            this.dropdown_customer_id_main_billing_employee_form.Location = new System.Drawing.Point(7, 36);
            this.dropdown_customer_id_main_billing_employee_form.Name = "dropdown_customer_id_main_billing_employee_form";
            this.dropdown_customer_id_main_billing_employee_form.Size = new System.Drawing.Size(140, 24);
            this.dropdown_customer_id_main_billing_employee_form.TabIndex = 0;
            this.dropdown_customer_id_main_billing_employee_form.SelectedIndexChanged += new System.EventHandler(this.dropdown_customer_id_main_billing_employee_form_SelectedIndexChanged);
            // 
            // products_bill_label_main_billing_employee_form
            // 
            this.products_bill_label_main_billing_employee_form.AutoSize = true;
            this.products_bill_label_main_billing_employee_form.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.products_bill_label_main_billing_employee_form.Location = new System.Drawing.Point(617, 204);
            this.products_bill_label_main_billing_employee_form.Name = "products_bill_label_main_billing_employee_form";
            this.products_bill_label_main_billing_employee_form.Size = new System.Drawing.Size(132, 25);
            this.products_bill_label_main_billing_employee_form.TabIndex = 23;
            this.products_bill_label_main_billing_employee_form.Text = "Products Bill";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.show_all_button_main_billing_employee_form);
            this.panel1.Controls.Add(this.search_product_button_main_billing_employee_form);
            this.panel1.Controls.Add(this.add_button_main_billing_employee_form);
            this.panel1.Controls.Add(this.product_name_text_box_main_billing_employee_form);
            this.panel1.Controls.Add(this.product_quantity_text_box_main_billing_employee_form);
            this.panel1.Controls.Add(this.product_quantity_label_main_billing_employee_form);
            this.panel1.Controls.Add(this.product_name_label_main_billing_employee_form);
            this.panel1.Location = new System.Drawing.Point(369, 73);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(351, 128);
            this.panel1.TabIndex = 24;
            // 
            // show_all_button_main_billing_employee_form
            // 
            this.show_all_button_main_billing_employee_form.ActiveBorderThickness = 1;
            this.show_all_button_main_billing_employee_form.ActiveCornerRadius = 20;
            this.show_all_button_main_billing_employee_form.ActiveFillColor = System.Drawing.SystemColors.AppWorkspace;
            this.show_all_button_main_billing_employee_form.ActiveForecolor = System.Drawing.Color.White;
            this.show_all_button_main_billing_employee_form.ActiveLineColor = System.Drawing.SystemColors.ControlLightLight;
            this.show_all_button_main_billing_employee_form.BackColor = System.Drawing.SystemColors.Control;
            this.show_all_button_main_billing_employee_form.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("show_all_button_main_billing_employee_form.BackgroundImage")));
            this.show_all_button_main_billing_employee_form.ButtonText = "Show All";
            this.show_all_button_main_billing_employee_form.Cursor = System.Windows.Forms.Cursors.Hand;
            this.show_all_button_main_billing_employee_form.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.show_all_button_main_billing_employee_form.ForeColor = System.Drawing.Color.SeaGreen;
            this.show_all_button_main_billing_employee_form.IdleBorderThickness = 1;
            this.show_all_button_main_billing_employee_form.IdleCornerRadius = 20;
            this.show_all_button_main_billing_employee_form.IdleFillColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.show_all_button_main_billing_employee_form.IdleForecolor = System.Drawing.SystemColors.ControlLightLight;
            this.show_all_button_main_billing_employee_form.IdleLineColor = System.Drawing.SystemColors.ControlLightLight;
            this.show_all_button_main_billing_employee_form.Location = new System.Drawing.Point(238, 66);
            this.show_all_button_main_billing_employee_form.Margin = new System.Windows.Forms.Padding(5);
            this.show_all_button_main_billing_employee_form.Name = "show_all_button_main_billing_employee_form";
            this.show_all_button_main_billing_employee_form.Size = new System.Drawing.Size(104, 41);
            this.show_all_button_main_billing_employee_form.TabIndex = 30;
            this.show_all_button_main_billing_employee_form.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.show_all_button_main_billing_employee_form.Click += new System.EventHandler(this.show_all_button_main_billing_employee_form_Click);
            // 
            // search_product_button_main_billing_employee_form
            // 
            this.search_product_button_main_billing_employee_form.ActiveBorderThickness = 1;
            this.search_product_button_main_billing_employee_form.ActiveCornerRadius = 20;
            this.search_product_button_main_billing_employee_form.ActiveFillColor = System.Drawing.SystemColors.AppWorkspace;
            this.search_product_button_main_billing_employee_form.ActiveForecolor = System.Drawing.Color.White;
            this.search_product_button_main_billing_employee_form.ActiveLineColor = System.Drawing.SystemColors.ControlLightLight;
            this.search_product_button_main_billing_employee_form.BackColor = System.Drawing.SystemColors.Control;
            this.search_product_button_main_billing_employee_form.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("search_product_button_main_billing_employee_form.BackgroundImage")));
            this.search_product_button_main_billing_employee_form.ButtonText = "Search";
            this.search_product_button_main_billing_employee_form.Cursor = System.Windows.Forms.Cursors.Hand;
            this.search_product_button_main_billing_employee_form.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_product_button_main_billing_employee_form.ForeColor = System.Drawing.Color.SeaGreen;
            this.search_product_button_main_billing_employee_form.IdleBorderThickness = 1;
            this.search_product_button_main_billing_employee_form.IdleCornerRadius = 20;
            this.search_product_button_main_billing_employee_form.IdleFillColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.search_product_button_main_billing_employee_form.IdleForecolor = System.Drawing.SystemColors.ControlLightLight;
            this.search_product_button_main_billing_employee_form.IdleLineColor = System.Drawing.SystemColors.ControlLightLight;
            this.search_product_button_main_billing_employee_form.Location = new System.Drawing.Point(131, 66);
            this.search_product_button_main_billing_employee_form.Margin = new System.Windows.Forms.Padding(5);
            this.search_product_button_main_billing_employee_form.Name = "search_product_button_main_billing_employee_form";
            this.search_product_button_main_billing_employee_form.Size = new System.Drawing.Size(104, 41);
            this.search_product_button_main_billing_employee_form.TabIndex = 29;
            this.search_product_button_main_billing_employee_form.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.search_product_button_main_billing_employee_form.Click += new System.EventHandler(this.search_product_button_main_billing_employee_form_Click);
            // 
            // add_button_main_billing_employee_form
            // 
            this.add_button_main_billing_employee_form.ActiveBorderThickness = 1;
            this.add_button_main_billing_employee_form.ActiveCornerRadius = 20;
            this.add_button_main_billing_employee_form.ActiveFillColor = System.Drawing.SystemColors.AppWorkspace;
            this.add_button_main_billing_employee_form.ActiveForecolor = System.Drawing.Color.White;
            this.add_button_main_billing_employee_form.ActiveLineColor = System.Drawing.SystemColors.ControlLightLight;
            this.add_button_main_billing_employee_form.BackColor = System.Drawing.SystemColors.Control;
            this.add_button_main_billing_employee_form.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("add_button_main_billing_employee_form.BackgroundImage")));
            this.add_button_main_billing_employee_form.ButtonText = "Add";
            this.add_button_main_billing_employee_form.Cursor = System.Windows.Forms.Cursors.Hand;
            this.add_button_main_billing_employee_form.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_button_main_billing_employee_form.ForeColor = System.Drawing.Color.SeaGreen;
            this.add_button_main_billing_employee_form.IdleBorderThickness = 1;
            this.add_button_main_billing_employee_form.IdleCornerRadius = 20;
            this.add_button_main_billing_employee_form.IdleFillColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.add_button_main_billing_employee_form.IdleForecolor = System.Drawing.SystemColors.ControlLightLight;
            this.add_button_main_billing_employee_form.IdleLineColor = System.Drawing.SystemColors.ControlLightLight;
            this.add_button_main_billing_employee_form.Location = new System.Drawing.Point(17, 66);
            this.add_button_main_billing_employee_form.Margin = new System.Windows.Forms.Padding(5);
            this.add_button_main_billing_employee_form.Name = "add_button_main_billing_employee_form";
            this.add_button_main_billing_employee_form.Size = new System.Drawing.Size(104, 41);
            this.add_button_main_billing_employee_form.TabIndex = 28;
            this.add_button_main_billing_employee_form.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.add_button_main_billing_employee_form.Click += new System.EventHandler(this.add_button_main_billing_employee_form_Click);
            // 
            // product_name_text_box_main_billing_employee_form
            // 
            this.product_name_text_box_main_billing_employee_form.Location = new System.Drawing.Point(7, 36);
            this.product_name_text_box_main_billing_employee_form.Name = "product_name_text_box_main_billing_employee_form";
            this.product_name_text_box_main_billing_employee_form.Size = new System.Drawing.Size(124, 22);
            this.product_name_text_box_main_billing_employee_form.TabIndex = 27;
            // 
            // product_quantity_text_box_main_billing_employee_form
            // 
            this.product_quantity_text_box_main_billing_employee_form.Location = new System.Drawing.Point(152, 36);
            this.product_quantity_text_box_main_billing_employee_form.Name = "product_quantity_text_box_main_billing_employee_form";
            this.product_quantity_text_box_main_billing_employee_form.Size = new System.Drawing.Size(93, 22);
            this.product_quantity_text_box_main_billing_employee_form.TabIndex = 26;
            // 
            // product_quantity_label_main_billing_employee_form
            // 
            this.product_quantity_label_main_billing_employee_form.AutoSize = true;
            this.product_quantity_label_main_billing_employee_form.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.product_quantity_label_main_billing_employee_form.Location = new System.Drawing.Point(148, 13);
            this.product_quantity_label_main_billing_employee_form.Name = "product_quantity_label_main_billing_employee_form";
            this.product_quantity_label_main_billing_employee_form.Size = new System.Drawing.Size(79, 20);
            this.product_quantity_label_main_billing_employee_form.TabIndex = 25;
            this.product_quantity_label_main_billing_employee_form.Text = "Quantity";
            // 
            // product_name_label_main_billing_employee_form
            // 
            this.product_name_label_main_billing_employee_form.AutoSize = true;
            this.product_name_label_main_billing_employee_form.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.product_name_label_main_billing_employee_form.Location = new System.Drawing.Point(3, 13);
            this.product_name_label_main_billing_employee_form.Name = "product_name_label_main_billing_employee_form";
            this.product_name_label_main_billing_employee_form.Size = new System.Drawing.Size(128, 20);
            this.product_name_label_main_billing_employee_form.TabIndex = 24;
            this.product_name_label_main_billing_employee_form.Text = "Product Name";
            // 
            // products_label_main_billing_employee_form
            // 
            this.products_label_main_billing_employee_form.AutoSize = true;
            this.products_label_main_billing_employee_form.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.products_label_main_billing_employee_form.Location = new System.Drawing.Point(332, 204);
            this.products_label_main_billing_employee_form.Name = "products_label_main_billing_employee_form";
            this.products_label_main_billing_employee_form.Size = new System.Drawing.Size(97, 25);
            this.products_label_main_billing_employee_form.TabIndex = 26;
            this.products_label_main_billing_employee_form.Text = "Products";
            // 
            // confirm_bill_button_main_billing_employee_form
            // 
            this.confirm_bill_button_main_billing_employee_form.ActiveBorderThickness = 1;
            this.confirm_bill_button_main_billing_employee_form.ActiveCornerRadius = 20;
            this.confirm_bill_button_main_billing_employee_form.ActiveFillColor = System.Drawing.SystemColors.AppWorkspace;
            this.confirm_bill_button_main_billing_employee_form.ActiveForecolor = System.Drawing.Color.White;
            this.confirm_bill_button_main_billing_employee_form.ActiveLineColor = System.Drawing.SystemColors.ControlLightLight;
            this.confirm_bill_button_main_billing_employee_form.BackColor = System.Drawing.SystemColors.Control;
            this.confirm_bill_button_main_billing_employee_form.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("confirm_bill_button_main_billing_employee_form.BackgroundImage")));
            this.confirm_bill_button_main_billing_employee_form.ButtonText = "Confirm";
            this.confirm_bill_button_main_billing_employee_form.Cursor = System.Windows.Forms.Cursors.Hand;
            this.confirm_bill_button_main_billing_employee_form.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirm_bill_button_main_billing_employee_form.ForeColor = System.Drawing.Color.SeaGreen;
            this.confirm_bill_button_main_billing_employee_form.IdleBorderThickness = 1;
            this.confirm_bill_button_main_billing_employee_form.IdleCornerRadius = 20;
            this.confirm_bill_button_main_billing_employee_form.IdleFillColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.confirm_bill_button_main_billing_employee_form.IdleForecolor = System.Drawing.SystemColors.ControlLightLight;
            this.confirm_bill_button_main_billing_employee_form.IdleLineColor = System.Drawing.SystemColors.ControlLightLight;
            this.confirm_bill_button_main_billing_employee_form.Location = new System.Drawing.Point(835, 139);
            this.confirm_bill_button_main_billing_employee_form.Margin = new System.Windows.Forms.Padding(5);
            this.confirm_bill_button_main_billing_employee_form.Name = "confirm_bill_button_main_billing_employee_form";
            this.confirm_bill_button_main_billing_employee_form.Size = new System.Drawing.Size(104, 41);
            this.confirm_bill_button_main_billing_employee_form.TabIndex = 29;
            this.confirm_bill_button_main_billing_employee_form.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.confirm_bill_button_main_billing_employee_form.Click += new System.EventHandler(this.print_bill_button_main_billing_employee_form_Click);
            // 
            // products_data_table_main_billing_employee_form
            // 
            this.products_data_table_main_billing_employee_form.AllowUserToAddRows = false;
            this.products_data_table_main_billing_employee_form.AllowUserToDeleteRows = false;
            this.products_data_table_main_billing_employee_form.AllowUserToResizeColumns = false;
            this.products_data_table_main_billing_employee_form.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.products_data_table_main_billing_employee_form.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.products_data_table_main_billing_employee_form.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.products_data_table_main_billing_employee_form.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.products_data_table_main_billing_employee_form.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.products_data_table_main_billing_employee_form.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.products_data_table_main_billing_employee_form.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.products_data_table_main_billing_employee_form.DoubleBuffered = true;
            this.products_data_table_main_billing_employee_form.EnableHeadersVisualStyles = false;
            this.products_data_table_main_billing_employee_form.HeaderBgColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.products_data_table_main_billing_employee_form.HeaderForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.products_data_table_main_billing_employee_form.Location = new System.Drawing.Point(203, 232);
            this.products_data_table_main_billing_employee_form.MultiSelect = false;
            this.products_data_table_main_billing_employee_form.Name = "products_data_table_main_billing_employee_form";
            this.products_data_table_main_billing_employee_form.ReadOnly = true;
            this.products_data_table_main_billing_employee_form.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.products_data_table_main_billing_employee_form.RowHeadersWidth = 51;
            this.products_data_table_main_billing_employee_form.RowTemplate.Height = 24;
            this.products_data_table_main_billing_employee_form.ShowCellErrors = false;
            this.products_data_table_main_billing_employee_form.ShowCellToolTips = false;
            this.products_data_table_main_billing_employee_form.ShowEditingIcon = false;
            this.products_data_table_main_billing_employee_form.ShowRowErrors = false;
            this.products_data_table_main_billing_employee_form.Size = new System.Drawing.Size(342, 252);
            this.products_data_table_main_billing_employee_form.TabIndex = 30;
            this.products_data_table_main_billing_employee_form.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.products_data_table_main_billing_employee_form_CellContentClick_1);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // products_bill_data_table_main_billing_employee_form
            // 
            this.products_bill_data_table_main_billing_employee_form.AllowUserToAddRows = false;
            this.products_bill_data_table_main_billing_employee_form.AllowUserToDeleteRows = false;
            this.products_bill_data_table_main_billing_employee_form.AllowUserToResizeColumns = false;
            this.products_bill_data_table_main_billing_employee_form.AllowUserToResizeRows = false;
            this.products_bill_data_table_main_billing_employee_form.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.products_bill_data_table_main_billing_employee_form.Enabled = false;
            this.products_bill_data_table_main_billing_employee_form.Location = new System.Drawing.Point(561, 232);
            this.products_bill_data_table_main_billing_employee_form.MultiSelect = false;
            this.products_bill_data_table_main_billing_employee_form.Name = "products_bill_data_table_main_billing_employee_form";
            this.products_bill_data_table_main_billing_employee_form.ReadOnly = true;
            this.products_bill_data_table_main_billing_employee_form.RowHeadersWidth = 51;
            this.products_bill_data_table_main_billing_employee_form.RowTemplate.Height = 24;
            this.products_bill_data_table_main_billing_employee_form.ShowCellErrors = false;
            this.products_bill_data_table_main_billing_employee_form.ShowCellToolTips = false;
            this.products_bill_data_table_main_billing_employee_form.ShowEditingIcon = false;
            this.products_bill_data_table_main_billing_employee_form.ShowRowErrors = false;
            this.products_bill_data_table_main_billing_employee_form.Size = new System.Drawing.Size(378, 213);
            this.products_bill_data_table_main_billing_employee_form.TabIndex = 31;
            this.products_bill_data_table_main_billing_employee_form.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.products_bill_data_table_main_billing_employee_form_CellContentClick_1);
            // 
            // total_label_main_billing_employee_form
            // 
            this.total_label_main_billing_employee_form.AutoSize = true;
            this.total_label_main_billing_employee_form.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_label_main_billing_employee_form.Location = new System.Drawing.Point(563, 464);
            this.total_label_main_billing_employee_form.Name = "total_label_main_billing_employee_form";
            this.total_label_main_billing_employee_form.Size = new System.Drawing.Size(69, 20);
            this.total_label_main_billing_employee_form.TabIndex = 32;
            this.total_label_main_billing_employee_form.Text = "Total : ";
            // 
            // total_money_text_main_billing_employee_form
            // 
            this.total_money_text_main_billing_employee_form.AutoSize = true;
            this.total_money_text_main_billing_employee_form.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_money_text_main_billing_employee_form.Location = new System.Drawing.Point(638, 464);
            this.total_money_text_main_billing_employee_form.Name = "total_money_text_main_billing_employee_form";
            this.total_money_text_main_billing_employee_form.Size = new System.Drawing.Size(23, 20);
            this.total_money_text_main_billing_employee_form.TabIndex = 33;
            this.total_money_text_main_billing_employee_form.Text = "**";
            // 
            // current_session_button_main_billing_employee_form
            // 
            this.current_session_button_main_billing_employee_form.ActiveBorderThickness = 1;
            this.current_session_button_main_billing_employee_form.ActiveCornerRadius = 20;
            this.current_session_button_main_billing_employee_form.ActiveFillColor = System.Drawing.SystemColors.AppWorkspace;
            this.current_session_button_main_billing_employee_form.ActiveForecolor = System.Drawing.Color.White;
            this.current_session_button_main_billing_employee_form.ActiveLineColor = System.Drawing.SystemColors.ControlLightLight;
            this.current_session_button_main_billing_employee_form.BackColor = System.Drawing.SystemColors.Control;
            this.current_session_button_main_billing_employee_form.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("current_session_button_main_billing_employee_form.BackgroundImage")));
            this.current_session_button_main_billing_employee_form.ButtonText = "Current";
            this.current_session_button_main_billing_employee_form.Cursor = System.Windows.Forms.Cursors.Hand;
            this.current_session_button_main_billing_employee_form.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.current_session_button_main_billing_employee_form.ForeColor = System.Drawing.Color.SeaGreen;
            this.current_session_button_main_billing_employee_form.IdleBorderThickness = 1;
            this.current_session_button_main_billing_employee_form.IdleCornerRadius = 20;
            this.current_session_button_main_billing_employee_form.IdleFillColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.current_session_button_main_billing_employee_form.IdleForecolor = System.Drawing.SystemColors.ControlLightLight;
            this.current_session_button_main_billing_employee_form.IdleLineColor = System.Drawing.SystemColors.ControlLightLight;
            this.current_session_button_main_billing_employee_form.Location = new System.Drawing.Point(846, 453);
            this.current_session_button_main_billing_employee_form.Margin = new System.Windows.Forms.Padding(5);
            this.current_session_button_main_billing_employee_form.Name = "current_session_button_main_billing_employee_form";
            this.current_session_button_main_billing_employee_form.Size = new System.Drawing.Size(104, 41);
            this.current_session_button_main_billing_employee_form.TabIndex = 34;
            this.current_session_button_main_billing_employee_form.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.current_session_button_main_billing_employee_form.Click += new System.EventHandler(this.current_session_button_main_billing_employee_form_Click);
            // 
            // order_button_main_employee_form
            // 
            this.order_button_main_employee_form.ActiveBorderThickness = 1;
            this.order_button_main_employee_form.ActiveCornerRadius = 20;
            this.order_button_main_employee_form.ActiveFillColor = System.Drawing.SystemColors.AppWorkspace;
            this.order_button_main_employee_form.ActiveForecolor = System.Drawing.Color.White;
            this.order_button_main_employee_form.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.order_button_main_employee_form.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.order_button_main_employee_form.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("order_button_main_employee_form.BackgroundImage")));
            this.order_button_main_employee_form.ButtonText = "Order";
            this.order_button_main_employee_form.Cursor = System.Windows.Forms.Cursors.Hand;
            this.order_button_main_employee_form.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.order_button_main_employee_form.ForeColor = System.Drawing.Color.SeaGreen;
            this.order_button_main_employee_form.IdleBorderThickness = 1;
            this.order_button_main_employee_form.IdleCornerRadius = 20;
            this.order_button_main_employee_form.IdleFillColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.order_button_main_employee_form.IdleForecolor = System.Drawing.SystemColors.ControlLightLight;
            this.order_button_main_employee_form.IdleLineColor = System.Drawing.SystemColors.ControlLightLight;
            this.order_button_main_employee_form.Location = new System.Drawing.Point(7, 184);
            this.order_button_main_employee_form.Margin = new System.Windows.Forms.Padding(5);
            this.order_button_main_employee_form.Name = "order_button_main_employee_form";
            this.order_button_main_employee_form.Size = new System.Drawing.Size(133, 41);
            this.order_button_main_employee_form.TabIndex = 6;
            this.order_button_main_employee_form.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.order_button_main_employee_form.Click += new System.EventHandler(this.order_button_main_employee_form_Click);
            // 
            // billing_form_employee_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 496);
            this.Controls.Add(this.current_session_button_main_billing_employee_form);
            this.Controls.Add(this.total_money_text_main_billing_employee_form);
            this.Controls.Add(this.total_label_main_billing_employee_form);
            this.Controls.Add(this.products_bill_data_table_main_billing_employee_form);
            this.Controls.Add(this.products_data_table_main_billing_employee_form);
            this.Controls.Add(this.confirm_bill_button_main_billing_employee_form);
            this.Controls.Add(this.products_label_main_billing_employee_form);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.products_bill_label_main_billing_employee_form);
            this.Controls.Add(this.customers_panel_main_billing_employee_form);
            this.Controls.Add(this.left_panel_buttons_home_page);
            this.Controls.Add(this.billing_label_main_billing_employee_form);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "billing_form_employee_form";
            this.Text = "Billing";
            this.Load += new System.EventHandler(this.billing_form_employee_form_Load);
            this.left_panel_buttons_home_page.ResumeLayout(false);
            this.buttons_skeleton.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.customers_panel_main_billing_employee_form.ResumeLayout(false);
            this.customers_panel_main_billing_employee_form.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.products_data_table_main_billing_employee_form)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.products_bill_data_table_main_billing_employee_form)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel left_panel_buttons_home_page;
        private System.Windows.Forms.Panel buttons_skeleton;
        private Bunifu.Framework.UI.BunifuThinButton2 logout_button_home_page;
        private Bunifu.Framework.UI.BunifuThinButton2 billing_button_home_page;
        private Bunifu.Framework.UI.BunifuThinButton2 home_button_home_page;
        private System.Windows.Forms.Label billing_label_main_billing_employee_form;
        private System.Windows.Forms.Panel panel3;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private System.Windows.Forms.Label name_label_text_box_main_billing_home_page;
        private System.Windows.Forms.Label name_label_main_billing_home_page;
        private System.Windows.Forms.Panel customers_panel_main_billing_employee_form;
        private System.Windows.Forms.Label products_bill_label_main_billing_employee_form;
        private System.Windows.Forms.ComboBox dropdown_customer_id_main_billing_employee_form;
        private System.Windows.Forms.Label customer_name_label_main_billing_employee_form;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox product_quantity_text_box_main_billing_employee_form;
        private System.Windows.Forms.Label product_quantity_label_main_billing_employee_form;
        private System.Windows.Forms.Label product_name_label_main_billing_employee_form;
        private System.Windows.Forms.TextBox product_name_text_box_main_billing_employee_form;
        private Bunifu.Framework.UI.BunifuThinButton2 add_button_main_billing_employee_form;
        private System.Windows.Forms.Label products_label_main_billing_employee_form;
        private Bunifu.Framework.UI.BunifuThinButton2 confirm_bill_button_main_billing_employee_form;
        private Bunifu.Framework.UI.BunifuCustomDataGrid products_data_table_main_billing_employee_form;
        private Bunifu.Framework.UI.BunifuThinButton2 search_product_button_main_billing_employee_form;
        private Bunifu.Framework.UI.BunifuThinButton2 show_all_button_main_billing_employee_form;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.DataGridView products_bill_data_table_main_billing_employee_form;
        private System.Windows.Forms.Label total_label_main_billing_employee_form;
        private System.Windows.Forms.Label total_money_text_main_billing_employee_form;
        private Bunifu.Framework.UI.BunifuThinButton2 current_session_button_main_billing_employee_form;
        private Bunifu.Framework.UI.BunifuThinButton2 order_button_main_employee_form;
    }
}