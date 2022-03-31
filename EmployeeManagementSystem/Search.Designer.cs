
namespace EmployeeManagementSystem
{
    partial class Search
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Search));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.proj_btn = new System.Windows.Forms.Button();
            this.emp_btn = new System.Windows.Forms.Button();
            this.dept_btn = new System.Windows.Forms.Button();
            this.comp_btn = new System.Windows.Forms.Button();
            this.search_btn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.search_grid = new System.Windows.Forms.DataGridView();
            this.search_button = new System.Windows.Forms.Button();
            this.searchbar = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.search_grid)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.proj_btn);
            this.panel1.Controls.Add(this.emp_btn);
            this.panel1.Controls.Add(this.dept_btn);
            this.panel1.Controls.Add(this.comp_btn);
            this.panel1.Controls.Add(this.search_btn);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(245, 691);
            this.panel1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(14, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(217, 127);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // proj_btn
            // 
            this.proj_btn.Location = new System.Drawing.Point(3, 349);
            this.proj_btn.Name = "proj_btn";
            this.proj_btn.Size = new System.Drawing.Size(238, 47);
            this.proj_btn.TabIndex = 5;
            this.proj_btn.Text = "Project Details";
            this.proj_btn.UseVisualStyleBackColor = true;
            this.proj_btn.Click += new System.EventHandler(this.proj_btn_Click);
            // 
            // emp_btn
            // 
            this.emp_btn.Location = new System.Drawing.Point(3, 296);
            this.emp_btn.Name = "emp_btn";
            this.emp_btn.Size = new System.Drawing.Size(238, 47);
            this.emp_btn.TabIndex = 4;
            this.emp_btn.Text = "Employee Details";
            this.emp_btn.UseVisualStyleBackColor = true;
            this.emp_btn.Click += new System.EventHandler(this.emp_btn_Click);
            // 
            // dept_btn
            // 
            this.dept_btn.Location = new System.Drawing.Point(3, 243);
            this.dept_btn.Name = "dept_btn";
            this.dept_btn.Size = new System.Drawing.Size(238, 47);
            this.dept_btn.TabIndex = 3;
            this.dept_btn.Text = "Department Details";
            this.dept_btn.UseVisualStyleBackColor = true;
            this.dept_btn.Click += new System.EventHandler(this.dept_btn_Click);
            // 
            // comp_btn
            // 
            this.comp_btn.Location = new System.Drawing.Point(3, 190);
            this.comp_btn.Name = "comp_btn";
            this.comp_btn.Size = new System.Drawing.Size(238, 47);
            this.comp_btn.TabIndex = 2;
            this.comp_btn.Text = "Company Details";
            this.comp_btn.UseVisualStyleBackColor = true;
            this.comp_btn.Click += new System.EventHandler(this.comp_btn_Click);
            // 
            // search_btn
            // 
            this.search_btn.Location = new System.Drawing.Point(3, 137);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(238, 47);
            this.search_btn.TabIndex = 1;
            this.search_btn.Text = "Search";
            this.search_btn.UseVisualStyleBackColor = true;
            this.search_btn.Click += new System.EventHandler(this.search_btn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel2.Controls.Add(this.search_grid);
            this.panel2.Controls.Add(this.search_button);
            this.panel2.Controls.Add(this.searchbar);
            this.panel2.Location = new System.Drawing.Point(263, 109);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(858, 594);
            this.panel2.TabIndex = 5;
            // 
            // search_grid
            // 
            this.search_grid.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.search_grid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.search_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.search_grid.Location = new System.Drawing.Point(17, 93);
            this.search_grid.Name = "search_grid";
            this.search_grid.RowTemplate.Height = 25;
            this.search_grid.Size = new System.Drawing.Size(820, 486);
            this.search_grid.TabIndex = 2;
            this.search_grid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.search_grid_CellContentClick);
            // 
            // search_button
            // 
            this.search_button.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.search_button.Location = new System.Drawing.Point(542, 40);
            this.search_button.Name = "search_button";
            this.search_button.Size = new System.Drawing.Size(75, 33);
            this.search_button.TabIndex = 1;
            this.search_button.Text = "search";
            this.search_button.UseVisualStyleBackColor = true;
            this.search_button.Click += new System.EventHandler(this.search_button_Click);
            // 
            // searchbar
            // 
            this.searchbar.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.searchbar.Location = new System.Drawing.Point(247, 40);
            this.searchbar.Name = "searchbar";
            this.searchbar.Size = new System.Drawing.Size(277, 33);
            this.searchbar.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel3.Controls.Add(this.label14);
            this.panel3.Location = new System.Drawing.Point(264, 13);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(857, 90);
            this.panel3.TabIndex = 6;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label14.Location = new System.Drawing.Point(3, 13);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(169, 65);
            this.label14.TabIndex = 32;
            this.label14.Text = "Search";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(84, 643);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 33);
            this.button1.TabIndex = 8;
            this.button1.Text = "Logout";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1132, 715);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Search";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee Database Management System";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Search_FormClosing);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.search_grid)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button emp_btn;
        private System.Windows.Forms.Button dept_btn;
        private System.Windows.Forms.Button comp_btn;
        private System.Windows.Forms.Button search_btn;
        private System.Windows.Forms.Button proj_btn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridView search_grid;
        private System.Windows.Forms.Button search_button;
        private System.Windows.Forms.TextBox searchbar;
        private System.Windows.Forms.Button button1;
    }
}