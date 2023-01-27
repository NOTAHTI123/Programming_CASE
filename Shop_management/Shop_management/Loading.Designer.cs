namespace Shop_management
{
    partial class Loading
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
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.loading_bar_loading_screen = new Bunifu.Framework.UI.BunifuProgressBar();
            this.main_label_loading_form = new System.Windows.Forms.Label();
            this.percentage_text_loading_form = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 30;
            this.bunifuElipse1.TargetControl = this;
            // 
            // loading_bar_loading_screen
            // 
            this.loading_bar_loading_screen.BackColor = System.Drawing.Color.Silver;
            this.loading_bar_loading_screen.BorderRadius = 5;
            this.loading_bar_loading_screen.Location = new System.Drawing.Point(99, 249);
            this.loading_bar_loading_screen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.loading_bar_loading_screen.MaximumValue = 100;
            this.loading_bar_loading_screen.Name = "loading_bar_loading_screen";
            this.loading_bar_loading_screen.ProgressColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.loading_bar_loading_screen.Size = new System.Drawing.Size(386, 15);
            this.loading_bar_loading_screen.TabIndex = 0;
            this.loading_bar_loading_screen.Value = 0;
            this.loading_bar_loading_screen.progressChanged += new System.EventHandler(this.bunifuProgressBar1_progressChanged);
            // 
            // main_label_loading_form
            // 
            this.main_label_loading_form.AutoSize = true;
            this.main_label_loading_form.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.main_label_loading_form.Location = new System.Drawing.Point(13, 13);
            this.main_label_loading_form.Name = "main_label_loading_form";
            this.main_label_loading_form.Size = new System.Drawing.Size(272, 25);
            this.main_label_loading_form.TabIndex = 1;
            this.main_label_loading_form.Text = "Shop Management System";
            // 
            // percentage_text_loading_form
            // 
            this.percentage_text_loading_form.AutoSize = true;
            this.percentage_text_loading_form.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.percentage_text_loading_form.Location = new System.Drawing.Point(437, 220);
            this.percentage_text_loading_form.Name = "percentage_text_loading_form";
            this.percentage_text_loading_form.Size = new System.Drawing.Size(48, 25);
            this.percentage_text_loading_form.TabIndex = 2;
            this.percentage_text_loading_form.Text = "100";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Loading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 291);
            this.Controls.Add(this.percentage_text_loading_form);
            this.Controls.Add(this.main_label_loading_form);
            this.Controls.Add(this.loading_bar_loading_screen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Loading";
            this.Text = "Loading";
            this.Load += new System.EventHandler(this.Loading_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuProgressBar loading_bar_loading_screen;
        private System.Windows.Forms.Label main_label_loading_form;
        private System.Windows.Forms.Label percentage_text_loading_form;
        private System.Windows.Forms.Timer timer1;
    }
}

