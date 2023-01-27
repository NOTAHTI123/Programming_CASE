namespace Shop_management
{
    partial class login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.Headin_login_form = new System.Windows.Forms.Label();
            this.username_label_login_form = new System.Windows.Forms.Label();
            this.password_label_login_form = new System.Windows.Forms.Label();
            this.username_text_box_login_form = new System.Windows.Forms.TextBox();
            this.password_text_box_login_form = new System.Windows.Forms.TextBox();
            this.employee_login_button_login_form = new Bunifu.Framework.UI.BunifuThinButton2();
            this.admin_login_button_login_page = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 30;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.Headin_login_form);
            this.panel1.Location = new System.Drawing.Point(-3, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(350, 117);
            this.panel1.TabIndex = 0;
            // 
            // Headin_login_form
            // 
            this.Headin_login_form.AutoSize = true;
            this.Headin_login_form.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Headin_login_form.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Headin_login_form.Location = new System.Drawing.Point(28, 42);
            this.Headin_login_form.Name = "Headin_login_form";
            this.Headin_login_form.Size = new System.Drawing.Size(272, 25);
            this.Headin_login_form.TabIndex = 0;
            this.Headin_login_form.Text = "Shop Management System";
            // 
            // username_label_login_form
            // 
            this.username_label_login_form.AutoSize = true;
            this.username_label_login_form.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username_label_login_form.Location = new System.Drawing.Point(113, 155);
            this.username_label_login_form.Name = "username_label_login_form";
            this.username_label_login_form.Size = new System.Drawing.Size(97, 20);
            this.username_label_login_form.TabIndex = 1;
            this.username_label_login_form.Text = "UserName";
            // 
            // password_label_login_form
            // 
            this.password_label_login_form.AutoSize = true;
            this.password_label_login_form.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_label_login_form.Location = new System.Drawing.Point(113, 229);
            this.password_label_login_form.Name = "password_label_login_form";
            this.password_label_login_form.Size = new System.Drawing.Size(91, 20);
            this.password_label_login_form.TabIndex = 2;
            this.password_label_login_form.Text = "Password";
            // 
            // username_text_box_login_form
            // 
            this.username_text_box_login_form.Location = new System.Drawing.Point(98, 190);
            this.username_text_box_login_form.Name = "username_text_box_login_form";
            this.username_text_box_login_form.Size = new System.Drawing.Size(129, 22);
            this.username_text_box_login_form.TabIndex = 3;
            this.username_text_box_login_form.TextChanged += new System.EventHandler(this.username_text_box_login_form_TextChanged);
            // 
            // password_text_box_login_form
            // 
            this.password_text_box_login_form.Location = new System.Drawing.Point(98, 263);
            this.password_text_box_login_form.Name = "password_text_box_login_form";
            this.password_text_box_login_form.PasswordChar = '*';
            this.password_text_box_login_form.Size = new System.Drawing.Size(129, 22);
            this.password_text_box_login_form.TabIndex = 4;
            this.password_text_box_login_form.Tag = "";
            // 
            // employee_login_button_login_form
            // 
            this.employee_login_button_login_form.ActiveBorderThickness = 1;
            this.employee_login_button_login_form.ActiveCornerRadius = 20;
            this.employee_login_button_login_form.ActiveFillColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.employee_login_button_login_form.ActiveForecolor = System.Drawing.Color.White;
            this.employee_login_button_login_form.ActiveLineColor = System.Drawing.SystemColors.ControlLightLight;
            this.employee_login_button_login_form.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.employee_login_button_login_form.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("employee_login_button_login_form.BackgroundImage")));
            this.employee_login_button_login_form.ButtonText = "Employee Login";
            this.employee_login_button_login_form.Cursor = System.Windows.Forms.Cursors.Hand;
            this.employee_login_button_login_form.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employee_login_button_login_form.ForeColor = System.Drawing.Color.SeaGreen;
            this.employee_login_button_login_form.IdleBorderThickness = 1;
            this.employee_login_button_login_form.IdleCornerRadius = 20;
            this.employee_login_button_login_form.IdleFillColor = System.Drawing.Color.White;
            this.employee_login_button_login_form.IdleForecolor = System.Drawing.SystemColors.ActiveCaptionText;
            this.employee_login_button_login_form.IdleLineColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.employee_login_button_login_form.Location = new System.Drawing.Point(90, 293);
            this.employee_login_button_login_form.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.employee_login_button_login_form.Name = "employee_login_button_login_form";
            this.employee_login_button_login_form.Size = new System.Drawing.Size(141, 40);
            this.employee_login_button_login_form.TabIndex = 5;
            this.employee_login_button_login_form.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.employee_login_button_login_form.Click += new System.EventHandler(this.login_button_login_form_Click);
            // 
            // admin_login_button_login_page
            // 
            this.admin_login_button_login_page.ActiveBorderThickness = 1;
            this.admin_login_button_login_page.ActiveCornerRadius = 20;
            this.admin_login_button_login_page.ActiveFillColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.admin_login_button_login_page.ActiveForecolor = System.Drawing.Color.White;
            this.admin_login_button_login_page.ActiveLineColor = System.Drawing.SystemColors.ControlLightLight;
            this.admin_login_button_login_page.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.admin_login_button_login_page.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("admin_login_button_login_page.BackgroundImage")));
            this.admin_login_button_login_page.ButtonText = "Admin Login";
            this.admin_login_button_login_page.Cursor = System.Windows.Forms.Cursors.Hand;
            this.admin_login_button_login_page.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admin_login_button_login_page.ForeColor = System.Drawing.Color.SeaGreen;
            this.admin_login_button_login_page.IdleBorderThickness = 1;
            this.admin_login_button_login_page.IdleCornerRadius = 20;
            this.admin_login_button_login_page.IdleFillColor = System.Drawing.Color.White;
            this.admin_login_button_login_page.IdleForecolor = System.Drawing.SystemColors.ActiveCaptionText;
            this.admin_login_button_login_page.IdleLineColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.admin_login_button_login_page.Location = new System.Drawing.Point(90, 335);
            this.admin_login_button_login_page.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.admin_login_button_login_page.Name = "admin_login_button_login_page";
            this.admin_login_button_login_page.Size = new System.Drawing.Size(141, 36);
            this.admin_login_button_login_page.TabIndex = 6;
            this.admin_login_button_login_page.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.admin_login_button_login_page.Click += new System.EventHandler(this.admin_login_buttone_login_page_Click);
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(345, 385);
            this.Controls.Add(this.admin_login_button_login_page);
            this.Controls.Add(this.employee_login_button_login_form);
            this.Controls.Add(this.password_text_box_login_form);
            this.Controls.Add(this.username_text_box_login_form);
            this.Controls.Add(this.password_label_login_form);
            this.Controls.Add(this.username_label_login_form);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "login";
            this.Text = "login_form";
            this.Load += new System.EventHandler(this.login_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Headin_login_form;
        private System.Windows.Forms.Label username_label_login_form;
        private System.Windows.Forms.Label password_label_login_form;
        private System.Windows.Forms.TextBox username_text_box_login_form;
        private System.Windows.Forms.TextBox password_text_box_login_form;
        private Bunifu.Framework.UI.BunifuThinButton2 employee_login_button_login_form;
        private Bunifu.Framework.UI.BunifuThinButton2 admin_login_button_login_page;
    }
}