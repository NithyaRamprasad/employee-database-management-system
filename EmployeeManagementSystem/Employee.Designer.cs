
namespace EmployeeManagementSystem
{
    partial class Employee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Employee));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.proj_btn = new System.Windows.Forms.Button();
            this.emp_btn = new System.Windows.Forms.Button();
            this.dept_btn = new System.Windows.Forms.Button();
            this.comp_btn = new System.Windows.Forms.Button();
            this.search_btn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.total_sal_txt = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.annual_txt = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.bonus_txt = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.salary_id_txt = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.proj_id_txt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.emp_mobile_txt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.gender_txt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.emp_addr_txt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.emp_doj_txt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.emp_dob_txt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.emp_name_txt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dept_id_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.emp_id_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.mod_emp_btn = new System.Windows.Forms.Button();
            this.del_emp_btn = new System.Windows.Forms.Button();
            this.emp_grid = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.add_emp_btn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.emp_grid)).BeginInit();
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
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(245, 691);
            this.panel1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 4);
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
            this.panel3.Controls.Add(this.total_sal_txt);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.annual_txt);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.bonus_txt);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.salary_id_txt);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.proj_id_txt);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.emp_mobile_txt);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.gender_txt);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.emp_addr_txt);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.emp_doj_txt);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.emp_dob_txt);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.emp_name_txt);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.dept_id_txt);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.emp_id_txt);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.mod_emp_btn);
            this.panel3.Controls.Add(this.del_emp_btn);
            this.panel3.Controls.Add(this.emp_grid);
            this.panel3.Location = new System.Drawing.Point(263, 108);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(857, 594);
            this.panel3.TabIndex = 9;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // total_sal_txt
            // 
            this.total_sal_txt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.total_sal_txt.Location = new System.Drawing.Point(659, 462);
            this.total_sal_txt.Name = "total_sal_txt";
            this.total_sal_txt.ReadOnly = true;
            this.total_sal_txt.Size = new System.Drawing.Size(182, 29);
            this.total_sal_txt.TabIndex = 45;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(509, 465);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(96, 21);
            this.label10.TabIndex = 44;
            this.label10.Text = "Total Salary :";
            // 
            // annual_txt
            // 
            this.annual_txt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.annual_txt.Location = new System.Drawing.Point(659, 427);
            this.annual_txt.Name = "annual_txt";
            this.annual_txt.Size = new System.Drawing.Size(182, 29);
            this.annual_txt.TabIndex = 43;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(509, 430);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(113, 21);
            this.label11.TabIndex = 42;
            this.label11.Text = "Annual Salary :";
            // 
            // bonus_txt
            // 
            this.bonus_txt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bonus_txt.Location = new System.Drawing.Point(659, 392);
            this.bonus_txt.Name = "bonus_txt";
            this.bonus_txt.Size = new System.Drawing.Size(182, 29);
            this.bonus_txt.TabIndex = 41;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(509, 395);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(64, 21);
            this.label12.TabIndex = 40;
            this.label12.Text = " Bonus :";
            // 
            // salary_id_txt
            // 
            this.salary_id_txt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.salary_id_txt.Location = new System.Drawing.Point(659, 357);
            this.salary_id_txt.Name = "salary_id_txt";
            this.salary_id_txt.Size = new System.Drawing.Size(182, 29);
            this.salary_id_txt.TabIndex = 39;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(509, 360);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(77, 21);
            this.label13.TabIndex = 38;
            this.label13.Text = "Salary Id :";
            // 
            // proj_id_txt
            // 
            this.proj_id_txt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.proj_id_txt.Location = new System.Drawing.Point(659, 322);
            this.proj_id_txt.Name = "proj_id_txt";
            this.proj_id_txt.Size = new System.Drawing.Size(182, 29);
            this.proj_id_txt.TabIndex = 37;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(509, 325);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 21);
            this.label9.TabIndex = 36;
            this.label9.Text = "Project Id :";
            // 
            // emp_mobile_txt
            // 
            this.emp_mobile_txt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.emp_mobile_txt.Location = new System.Drawing.Point(659, 287);
            this.emp_mobile_txt.Name = "emp_mobile_txt";
            this.emp_mobile_txt.Size = new System.Drawing.Size(182, 29);
            this.emp_mobile_txt.TabIndex = 35;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(509, 290);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 21);
            this.label5.TabIndex = 34;
            this.label5.Text = "Employee Mobile :";
            // 
            // gender_txt
            // 
            this.gender_txt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gender_txt.Location = new System.Drawing.Point(659, 252);
            this.gender_txt.Name = "gender_txt";
            this.gender_txt.Size = new System.Drawing.Size(182, 29);
            this.gender_txt.TabIndex = 33;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(509, 255);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 21);
            this.label6.TabIndex = 32;
            this.label6.Text = " Gender :";
            // 
            // emp_addr_txt
            // 
            this.emp_addr_txt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.emp_addr_txt.Location = new System.Drawing.Point(659, 217);
            this.emp_addr_txt.Name = "emp_addr_txt";
            this.emp_addr_txt.Size = new System.Drawing.Size(182, 29);
            this.emp_addr_txt.TabIndex = 31;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(509, 220);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(145, 21);
            this.label7.TabIndex = 30;
            this.label7.Text = "Employee Address :";
            // 
            // emp_doj_txt
            // 
            this.emp_doj_txt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.emp_doj_txt.Location = new System.Drawing.Point(659, 182);
            this.emp_doj_txt.MaxLength = 10;
            this.emp_doj_txt.Name = "emp_doj_txt";
            this.emp_doj_txt.ReadOnly = true;
            this.emp_doj_txt.Size = new System.Drawing.Size(182, 29);
            this.emp_doj_txt.TabIndex = 29;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(509, 185);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(118, 21);
            this.label8.TabIndex = 28;
            this.label8.Text = "Employee DOJ :";
            // 
            // emp_dob_txt
            // 
            this.emp_dob_txt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.emp_dob_txt.Location = new System.Drawing.Point(659, 147);
            this.emp_dob_txt.MaxLength = 10;
            this.emp_dob_txt.Name = "emp_dob_txt";
            this.emp_dob_txt.ReadOnly = true;
            this.emp_dob_txt.Size = new System.Drawing.Size(182, 29);
            this.emp_dob_txt.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(509, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 21);
            this.label4.TabIndex = 26;
            this.label4.Text = "Employee DOB :";
            // 
            // emp_name_txt
            // 
            this.emp_name_txt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.emp_name_txt.Location = new System.Drawing.Point(659, 111);
            this.emp_name_txt.Name = "emp_name_txt";
            this.emp_name_txt.Size = new System.Drawing.Size(182, 29);
            this.emp_name_txt.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(509, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 21);
            this.label3.TabIndex = 24;
            this.label3.Text = "Employee Name :";
            // 
            // dept_id_txt
            // 
            this.dept_id_txt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dept_id_txt.Location = new System.Drawing.Point(659, 76);
            this.dept_id_txt.Name = "dept_id_txt";
            this.dept_id_txt.Size = new System.Drawing.Size(182, 29);
            this.dept_id_txt.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(509, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 21);
            this.label2.TabIndex = 22;
            this.label2.Text = "Department Id :";
            // 
            // emp_id_txt
            // 
            this.emp_id_txt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.emp_id_txt.Location = new System.Drawing.Point(659, 41);
            this.emp_id_txt.Name = "emp_id_txt";
            this.emp_id_txt.Size = new System.Drawing.Size(182, 29);
            this.emp_id_txt.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(509, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 21);
            this.label1.TabIndex = 20;
            this.label1.Text = "Employee Id :";
            // 
            // mod_emp_btn
            // 
            this.mod_emp_btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.mod_emp_btn.Location = new System.Drawing.Point(560, 537);
            this.mod_emp_btn.Name = "mod_emp_btn";
            this.mod_emp_btn.Size = new System.Drawing.Size(95, 34);
            this.mod_emp_btn.TabIndex = 12;
            this.mod_emp_btn.Text = "Modify";
            this.mod_emp_btn.UseVisualStyleBackColor = true;
            this.mod_emp_btn.Click += new System.EventHandler(this.mod_emp_btn_Click);
            // 
            // del_emp_btn
            // 
            this.del_emp_btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.del_emp_btn.Location = new System.Drawing.Point(706, 537);
            this.del_emp_btn.Name = "del_emp_btn";
            this.del_emp_btn.Size = new System.Drawing.Size(95, 34);
            this.del_emp_btn.TabIndex = 11;
            this.del_emp_btn.Text = "Delete";
            this.del_emp_btn.UseVisualStyleBackColor = true;
            this.del_emp_btn.Click += new System.EventHandler(this.del_emp_btn_Click);
            // 
            // emp_grid
            // 
            this.emp_grid.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.emp_grid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.emp_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.emp_grid.Location = new System.Drawing.Point(32, 25);
            this.emp_grid.Name = "emp_grid";
            this.emp_grid.RowTemplate.Height = 25;
            this.emp_grid.Size = new System.Drawing.Size(467, 546);
            this.emp_grid.TabIndex = 10;
            this.emp_grid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.emp_grid_CellClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.add_emp_btn);
            this.panel2.Location = new System.Drawing.Point(263, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(857, 90);
            this.panel2.TabIndex = 8;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label14.Location = new System.Drawing.Point(3, 4);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(390, 65);
            this.label14.TabIndex = 31;
            this.label14.Text = "Employee Details";
            // 
            // add_emp_btn
            // 
            this.add_emp_btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.add_emp_btn.Location = new System.Drawing.Point(746, 21);
            this.add_emp_btn.Name = "add_emp_btn";
            this.add_emp_btn.Size = new System.Drawing.Size(95, 34);
            this.add_emp_btn.TabIndex = 7;
            this.add_emp_btn.Text = "Add";
            this.add_emp_btn.UseVisualStyleBackColor = true;
            this.add_emp_btn.Click += new System.EventHandler(this.add_emp_btn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(79, 636);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 33);
            this.button1.TabIndex = 8;
            this.button1.Text = "Logout";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Employee
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
            this.Name = "Employee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee Database Management System";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Employee_FormClosing);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.emp_grid)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button emp_btn;
        private System.Windows.Forms.Button dept_btn;
        private System.Windows.Forms.Button comp_btn;
        private System.Windows.Forms.Button search_btn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView emp_grid;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button add_emp_btn;
        private System.Windows.Forms.Button proj_btn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button mod_emp_btn;
        private System.Windows.Forms.Button del_emp_btn;
        private System.Windows.Forms.TextBox proj_id_txt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox emp_mobile_txt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox gender_txt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox emp_addr_txt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox emp_doj_txt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox emp_dob_txt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox emp_name_txt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox dept_id_txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox emp_id_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox total_sal_txt;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox annual_txt;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox bonus_txt;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox salary_id_txt;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button button1;
    }
}