namespace Shop_management
{
    partial class current_session_form
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.current_session_form_data_grid = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            ((System.ComponentModel.ISupportInitialize)(this.current_session_form_data_grid)).BeginInit();
            this.SuspendLayout();
            // 
            // current_session_form_data_grid
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.current_session_form_data_grid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.current_session_form_data_grid.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.current_session_form_data_grid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.current_session_form_data_grid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.current_session_form_data_grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.current_session_form_data_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.current_session_form_data_grid.DoubleBuffered = true;
            this.current_session_form_data_grid.EnableHeadersVisualStyles = false;
            this.current_session_form_data_grid.HeaderBgColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.current_session_form_data_grid.HeaderForeColor = System.Drawing.Color.SeaGreen;
            this.current_session_form_data_grid.Location = new System.Drawing.Point(300, 112);
            this.current_session_form_data_grid.Name = "current_session_form_data_grid";
            this.current_session_form_data_grid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.current_session_form_data_grid.RowHeadersWidth = 51;
            this.current_session_form_data_grid.RowTemplate.Height = 24;
            this.current_session_form_data_grid.Size = new System.Drawing.Size(488, 326);
            this.current_session_form_data_grid.TabIndex = 0;
            this.current_session_form_data_grid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.current_session_form_data_grid_CellContentClick);
            // 
            // current_session_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.current_session_form_data_grid);
            this.Name = "current_session_form";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.current_session_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.current_session_form_data_grid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomDataGrid current_session_form_data_grid;
    }
}