﻿
namespace EmployeeManagementSystem
{
    partial class Project
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Project));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.proj_btn = new System.Windows.Forms.Button();
            this.emp_btn = new System.Windows.Forms.Button();
            this.dept_btn = new System.Windows.Forms.Button();
            this.comp_btn = new System.Windows.Forms.Button();
            this.search_btn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.duration_txt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.proj_name_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.proj_id_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.proj_grid = new System.Windows.Forms.DataGridView();
            this.mod_proj_btn = new System.Windows.Forms.Button();
            this.del_proj_btn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.add_proj_btn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.proj_grid)).BeginInit();
            this.panel2.SuspendLayout();
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
            this.panel1.Location = new System.Drawing.Point(11, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(245, 691);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(13, 4);
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
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel3.Controls.Add(this.duration_txt);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.proj_name_txt);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.proj_id_txt);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.proj_grid);
            this.panel3.Controls.Add(this.mod_proj_btn);
            this.panel3.Controls.Add(this.del_proj_btn);
            this.panel3.Location = new System.Drawing.Point(263, 108);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(857, 594);
            this.panel3.TabIndex = 14;
            // 
            // duration_txt
            // 
            this.duration_txt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.duration_txt.Location = new System.Drawing.Point(668, 201);
            this.duration_txt.Name = "duration_txt";
            this.duration_txt.Size = new System.Drawing.Size(182, 29);
            this.duration_txt.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(518, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 21);
            this.label3.TabIndex = 24;
            this.label3.Text = "Duration :";
            // 
            // proj_name_txt
            // 
            this.proj_name_txt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.proj_name_txt.Location = new System.Drawing.Point(668, 151);
            this.proj_name_txt.Name = "proj_name_txt";
            this.proj_name_txt.Size = new System.Drawing.Size(182, 29);
            this.proj_name_txt.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(518, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 21);
            this.label2.TabIndex = 22;
            this.label2.Text = "Project Name :";
            // 
            // proj_id_txt
            // 
            this.proj_id_txt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.proj_id_txt.Location = new System.Drawing.Point(668, 102);
            this.proj_id_txt.Name = "proj_id_txt";
            this.proj_id_txt.Size = new System.Drawing.Size(182, 29);
            this.proj_id_txt.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(518, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 21);
            this.label1.TabIndex = 20;
            this.label1.Text = "Project Id :";
            // 
            // proj_grid
            // 
            this.proj_grid.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.proj_grid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.proj_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.proj_grid.Location = new System.Drawing.Point(35, 41);
            this.proj_grid.Name = "proj_grid";
            this.proj_grid.RowTemplate.Height = 25;
            this.proj_grid.Size = new System.Drawing.Size(467, 546);
            this.proj_grid.TabIndex = 10;
            this.proj_grid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.proj_grid_CellClick);
            this.proj_grid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.proj_grid_CellContentClick);
            // 
            // mod_proj_btn
            // 
            this.mod_proj_btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.mod_proj_btn.Location = new System.Drawing.Point(552, 266);
            this.mod_proj_btn.Name = "mod_proj_btn";
            this.mod_proj_btn.Size = new System.Drawing.Size(95, 34);
            this.mod_proj_btn.TabIndex = 9;
            this.mod_proj_btn.Text = "Modify";
            this.mod_proj_btn.UseVisualStyleBackColor = true;
            this.mod_proj_btn.Click += new System.EventHandler(this.mod_proj_btn_Click);
            // 
            // del_proj_btn
            // 
            this.del_proj_btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.del_proj_btn.Location = new System.Drawing.Point(698, 266);
            this.del_proj_btn.Name = "del_proj_btn";
            this.del_proj_btn.Size = new System.Drawing.Size(95, 34);
            this.del_proj_btn.TabIndex = 8;
            this.del_proj_btn.Text = "Delete";
            this.del_proj_btn.UseVisualStyleBackColor = true;
            this.del_proj_btn.Click += new System.EventHandler(this.del_proj_btn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.add_proj_btn);
            this.panel2.Location = new System.Drawing.Point(263, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(857, 90);
            this.panel2.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(3, 4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(331, 65);
            this.label5.TabIndex = 32;
            this.label5.Text = "Project Details";
            // 
            // add_proj_btn
            // 
            this.add_proj_btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.add_proj_btn.Location = new System.Drawing.Point(746, 21);
            this.add_proj_btn.Name = "add_proj_btn";
            this.add_proj_btn.Size = new System.Drawing.Size(95, 34);
            this.add_proj_btn.TabIndex = 7;
            this.add_proj_btn.Text = "Add";
            this.add_proj_btn.UseVisualStyleBackColor = true;
            this.add_proj_btn.Click += new System.EventHandler(this.add_proj_btn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(82, 650);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 33);
            this.button1.TabIndex = 8;
            this.button1.Text = "Logout";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Project
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
            this.Name = "Project";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee Database Management System";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Project_FormClosing);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.proj_grid)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button dept_btn;
        private System.Windows.Forms.Button comp_btn;
        private System.Windows.Forms.Button search_btn;
        private System.Windows.Forms.Button emp_btn;
        private System.Windows.Forms.Button proj_btn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView proj_grid;
        private System.Windows.Forms.Button mod_proj_btn;
        private System.Windows.Forms.Button del_proj_btn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button add_proj_btn;
        private System.Windows.Forms.TextBox duration_txt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox proj_name_txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox proj_id_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
    }
}

