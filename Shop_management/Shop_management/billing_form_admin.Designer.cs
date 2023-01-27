namespace Shop_management
{
    partial class billing_form_admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(billing_form_admin));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.left_panel_buttons_home_page = new System.Windows.Forms.Panel();
            this.buttons_skeleton = new System.Windows.Forms.Panel();
            this.logout_button_home_page = new Bunifu.Framework.UI.BunifuThinButton2();
            this.billing_button_home_page = new Bunifu.Framework.UI.BunifuThinButton2();
            this.product_button_home_page = new Bunifu.Framework.UI.BunifuThinButton2();
            this.customer_button_home_page = new Bunifu.Framework.UI.BunifuThinButton2();
            this.employee_button_home_page = new Bunifu.Framework.UI.BunifuThinButton2();
            this.home_button_home_page = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panel3 = new System.Windows.Forms.Panel();
            this.billing_page_heading = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bills_history_data_table_main_billing_admin_form = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.left_panel_buttons_home_page.SuspendLayout();
            this.buttons_skeleton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bills_history_data_table_main_billing_admin_form)).BeginInit();
            this.SuspendLayout();
            // 
            // left_panel_buttons_home_page
            // 
            this.left_panel_buttons_home_page.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.left_panel_buttons_home_page.Controls.Add(this.buttons_skeleton);
            this.left_panel_buttons_home_page.Location = new System.Drawing.Point(0, -7);
            this.left_panel_buttons_home_page.Name = "left_panel_buttons_home_page";
            this.left_panel_buttons_home_page.Size = new System.Drawing.Size(197, 507);
            this.left_panel_buttons_home_page.TabIndex = 2;
            // 
            // buttons_skeleton
            // 
            this.buttons_skeleton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttons_skeleton.Controls.Add(this.logout_button_home_page);
            this.buttons_skeleton.Controls.Add(this.billing_button_home_page);
            this.buttons_skeleton.Controls.Add(this.product_button_home_page);
            this.buttons_skeleton.Controls.Add(this.customer_button_home_page);
            this.buttons_skeleton.Controls.Add(this.employee_button_home_page);
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
            // product_button_home_page
            // 
            this.product_button_home_page.ActiveBorderThickness = 1;
            this.product_button_home_page.ActiveCornerRadius = 20;
            this.product_button_home_page.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.product_button_home_page.ActiveForecolor = System.Drawing.Color.White;
            this.product_button_home_page.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.product_button_home_page.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.product_button_home_page.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("product_button_home_page.BackgroundImage")));
            this.product_button_home_page.ButtonText = "Products";
            this.product_button_home_page.Cursor = System.Windows.Forms.Cursors.Hand;
            this.product_button_home_page.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.product_button_home_page.ForeColor = System.Drawing.Color.SeaGreen;
            this.product_button_home_page.IdleBorderThickness = 1;
            this.product_button_home_page.IdleCornerRadius = 20;
            this.product_button_home_page.IdleFillColor = System.Drawing.Color.Transparent;
            this.product_button_home_page.IdleForecolor = System.Drawing.SystemColors.ControlLightLight;
            this.product_button_home_page.IdleLineColor = System.Drawing.SystemColors.ControlLightLight;
            this.product_button_home_page.Location = new System.Drawing.Point(7, 184);
            this.product_button_home_page.Margin = new System.Windows.Forms.Padding(5);
            this.product_button_home_page.Name = "product_button_home_page";
            this.product_button_home_page.Size = new System.Drawing.Size(133, 41);
            this.product_button_home_page.TabIndex = 3;
            this.product_button_home_page.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.product_button_home_page.Click += new System.EventHandler(this.product_button_home_page_Click);
            // 
            // customer_button_home_page
            // 
            this.customer_button_home_page.ActiveBorderThickness = 1;
            this.customer_button_home_page.ActiveCornerRadius = 20;
            this.customer_button_home_page.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.customer_button_home_page.ActiveForecolor = System.Drawing.Color.White;
            this.customer_button_home_page.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.customer_button_home_page.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.customer_button_home_page.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("customer_button_home_page.BackgroundImage")));
            this.customer_button_home_page.ButtonText = "Customers";
            this.customer_button_home_page.Cursor = System.Windows.Forms.Cursors.Hand;
            this.customer_button_home_page.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customer_button_home_page.ForeColor = System.Drawing.Color.SeaGreen;
            this.customer_button_home_page.IdleBorderThickness = 1;
            this.customer_button_home_page.IdleCornerRadius = 20;
            this.customer_button_home_page.IdleFillColor = System.Drawing.Color.Transparent;
            this.customer_button_home_page.IdleForecolor = System.Drawing.SystemColors.ControlLightLight;
            this.customer_button_home_page.IdleLineColor = System.Drawing.SystemColors.ControlLightLight;
            this.customer_button_home_page.Location = new System.Drawing.Point(6, 136);
            this.customer_button_home_page.Margin = new System.Windows.Forms.Padding(5);
            this.customer_button_home_page.Name = "customer_button_home_page";
            this.customer_button_home_page.Size = new System.Drawing.Size(133, 41);
            this.customer_button_home_page.TabIndex = 2;
            this.customer_button_home_page.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.customer_button_home_page.Click += new System.EventHandler(this.customer_button_home_page_Click);
            // 
            // employee_button_home_page
            // 
            this.employee_button_home_page.ActiveBorderThickness = 1;
            this.employee_button_home_page.ActiveCornerRadius = 20;
            this.employee_button_home_page.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.employee_button_home_page.ActiveForecolor = System.Drawing.Color.White;
            this.employee_button_home_page.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.employee_button_home_page.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.employee_button_home_page.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("employee_button_home_page.BackgroundImage")));
            this.employee_button_home_page.ButtonText = "Employees";
            this.employee_button_home_page.Cursor = System.Windows.Forms.Cursors.Hand;
            this.employee_button_home_page.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employee_button_home_page.ForeColor = System.Drawing.Color.SeaGreen;
            this.employee_button_home_page.IdleBorderThickness = 1;
            this.employee_button_home_page.IdleCornerRadius = 20;
            this.employee_button_home_page.IdleFillColor = System.Drawing.Color.Transparent;
            this.employee_button_home_page.IdleForecolor = System.Drawing.SystemColors.ControlLightLight;
            this.employee_button_home_page.IdleLineColor = System.Drawing.SystemColors.ControlLightLight;
            this.employee_button_home_page.Location = new System.Drawing.Point(6, 85);
            this.employee_button_home_page.Margin = new System.Windows.Forms.Padding(5);
            this.employee_button_home_page.Name = "employee_button_home_page";
            this.employee_button_home_page.Size = new System.Drawing.Size(133, 41);
            this.employee_button_home_page.TabIndex = 1;
            this.employee_button_home_page.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.employee_button_home_page.Click += new System.EventHandler(this.employee_button_home_page_Click);
            // 
            // home_button_home_page
            // 
            this.home_button_home_page.ActiveBorderThickness = 1;
            this.home_button_home_page.ActiveCornerRadius = 20;
            this.home_button_home_page.ActiveFillColor = System.Drawing.Color.SeaGreen;
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
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel3.Location = new System.Drawing.Point(755, -4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 75);
            this.panel3.TabIndex = 9;
            // 
            // billing_page_heading
            // 
            this.billing_page_heading.AutoSize = true;
            this.billing_page_heading.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.billing_page_heading.Location = new System.Drawing.Point(453, 11);
            this.billing_page_heading.Name = "billing_page_heading";
            this.billing_page_heading.Size = new System.Drawing.Size(125, 25);
            this.billing_page_heading.TabIndex = 10;
            this.billing_page_heading.Text = "Bills History";
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 30;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bills_history_data_table_main_billing_admin_form
            // 
            this.bills_history_data_table_main_billing_admin_form.AllowUserToAddRows = false;
            this.bills_history_data_table_main_billing_admin_form.AllowUserToDeleteRows = false;
            this.bills_history_data_table_main_billing_admin_form.AllowUserToResizeColumns = false;
            this.bills_history_data_table_main_billing_admin_form.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bills_history_data_table_main_billing_admin_form.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.bills_history_data_table_main_billing_admin_form.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.bills_history_data_table_main_billing_admin_form.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bills_history_data_table_main_billing_admin_form.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bills_history_data_table_main_billing_admin_form.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.bills_history_data_table_main_billing_admin_form.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bills_history_data_table_main_billing_admin_form.DoubleBuffered = true;
            this.bills_history_data_table_main_billing_admin_form.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.bills_history_data_table_main_billing_admin_form.EnableHeadersVisualStyles = false;
            this.bills_history_data_table_main_billing_admin_form.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.bills_history_data_table_main_billing_admin_form.HeaderForeColor = System.Drawing.Color.SeaGreen;
            this.bills_history_data_table_main_billing_admin_form.Location = new System.Drawing.Point(203, 77);
            this.bills_history_data_table_main_billing_admin_form.MultiSelect = false;
            this.bills_history_data_table_main_billing_admin_form.Name = "bills_history_data_table_main_billing_admin_form";
            this.bills_history_data_table_main_billing_admin_form.ReadOnly = true;
            this.bills_history_data_table_main_billing_admin_form.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.bills_history_data_table_main_billing_admin_form.RowHeadersWidth = 51;
            this.bills_history_data_table_main_billing_admin_form.RowTemplate.Height = 24;
            this.bills_history_data_table_main_billing_admin_form.ShowCellErrors = false;
            this.bills_history_data_table_main_billing_admin_form.ShowCellToolTips = false;
            this.bills_history_data_table_main_billing_admin_form.ShowEditingIcon = false;
            this.bills_history_data_table_main_billing_admin_form.ShowRowErrors = false;
            this.bills_history_data_table_main_billing_admin_form.Size = new System.Drawing.Size(738, 407);
            this.bills_history_data_table_main_billing_admin_form.TabIndex = 11;
            this.bills_history_data_table_main_billing_admin_form.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bills_history_data_table_main_billing_admin_form_CellContentClick_1);
            // 
            // billing_form_admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 496);
            this.Controls.Add(this.bills_history_data_table_main_billing_admin_form);
            this.Controls.Add(this.billing_page_heading);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.left_panel_buttons_home_page);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "billing_form_admin";
            this.Text = "billing_form_admin";
            this.Load += new System.EventHandler(this.billing_form_admin_Load);
            this.left_panel_buttons_home_page.ResumeLayout(false);
            this.buttons_skeleton.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bills_history_data_table_main_billing_admin_form)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel left_panel_buttons_home_page;
        private System.Windows.Forms.Panel buttons_skeleton;
        private Bunifu.Framework.UI.BunifuThinButton2 logout_button_home_page;
        private Bunifu.Framework.UI.BunifuThinButton2 billing_button_home_page;
        private Bunifu.Framework.UI.BunifuThinButton2 product_button_home_page;
        private Bunifu.Framework.UI.BunifuThinButton2 customer_button_home_page;
        private Bunifu.Framework.UI.BunifuThinButton2 employee_button_home_page;
        private Bunifu.Framework.UI.BunifuThinButton2 home_button_home_page;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label billing_page_heading;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuCustomDataGrid bills_history_data_table_main_billing_admin_form;
    }
}