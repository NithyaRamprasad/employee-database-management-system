
namespace EmployeeManagementSystem
{
    partial class Department
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Department));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.proj_btn = new System.Windows.Forms.Button();
            this.emp_btn = new System.Windows.Forms.Button();
            this.dept_btn = new System.Windows.Forms.Button();
            this.comp_btn = new System.Windows.Forms.Button();
            this.search_btn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dept_name_txt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comp_id_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dept_id_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dept_grid = new System.Windows.Forms.DataGridView();
            this.mod_dept_btn = new System.Windows.Forms.Button();
            this.del_dept_btn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.add_dept_btn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dept_grid)).BeginInit();
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
            this.panel1.TabIndex = 6;
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
            this.panel3.Controls.Add(this.dept_name_txt);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.comp_id_txt);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.dept_id_txt);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.dept_grid);
            this.panel3.Controls.Add(this.mod_dept_btn);
            this.panel3.Controls.Add(this.del_dept_btn);
            this.panel3.Location = new System.Drawing.Point(263, 108);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(857, 594);
            this.panel3.TabIndex = 9;
            // 
            // dept_name_txt
            // 
            this.dept_name_txt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dept_name_txt.Location = new System.Drawing.Point(659, 193);
            this.dept_name_txt.Name = "dept_name_txt";
            this.dept_name_txt.Size = new System.Drawing.Size(182, 29);
            this.dept_name_txt.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(509, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 21);
            this.label3.TabIndex = 22;
            this.label3.Text = "Department Name :";
            // 
            // comp_id_txt
            // 
            this.comp_id_txt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comp_id_txt.Location = new System.Drawing.Point(659, 143);
            this.comp_id_txt.Name = "comp_id_txt";
            this.comp_id_txt.Size = new System.Drawing.Size(182, 29);
            this.comp_id_txt.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(509, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 21);
            this.label2.TabIndex = 20;
            this.label2.Text = "Company Id :";
            // 
            // dept_id_txt
            // 
            this.dept_id_txt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dept_id_txt.Location = new System.Drawing.Point(659, 94);
            this.dept_id_txt.Name = "dept_id_txt";
            this.dept_id_txt.Size = new System.Drawing.Size(182, 29);
            this.dept_id_txt.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(509, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 21);
            this.label1.TabIndex = 18;
            this.label1.Text = "Department Id :";
            // 
            // dept_grid
            // 
            this.dept_grid.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dept_grid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dept_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dept_grid.Location = new System.Drawing.Point(36, 81);
            this.dept_grid.Name = "dept_grid";
            this.dept_grid.RowTemplate.Height = 25;
            this.dept_grid.Size = new System.Drawing.Size(467, 546);
            this.dept_grid.TabIndex = 10;
            this.dept_grid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dept_grid_CellClick);
            // 
            // mod_dept_btn
            // 
            this.mod_dept_btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.mod_dept_btn.Location = new System.Drawing.Point(559, 266);
            this.mod_dept_btn.Name = "mod_dept_btn";
            this.mod_dept_btn.Size = new System.Drawing.Size(95, 34);
            this.mod_dept_btn.TabIndex = 9;
            this.mod_dept_btn.Text = "Modify";
            this.mod_dept_btn.UseVisualStyleBackColor = true;
            this.mod_dept_btn.Click += new System.EventHandler(this.mod_dept_btn_Click);
            // 
            // del_dept_btn
            // 
            this.del_dept_btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.del_dept_btn.Location = new System.Drawing.Point(705, 266);
            this.del_dept_btn.Name = "del_dept_btn";
            this.del_dept_btn.Size = new System.Drawing.Size(95, 34);
            this.del_dept_btn.TabIndex = 8;
            this.del_dept_btn.Text = "Delete";
            this.del_dept_btn.UseVisualStyleBackColor = true;
            this.del_dept_btn.Click += new System.EventHandler(this.del_dept_btn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.add_dept_btn);
            this.panel2.Location = new System.Drawing.Point(263, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(857, 90);
            this.panel2.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(3, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(437, 65);
            this.label4.TabIndex = 8;
            this.label4.Text = "Department Details";
            // 
            // add_dept_btn
            // 
            this.add_dept_btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.add_dept_btn.Location = new System.Drawing.Point(746, 21);
            this.add_dept_btn.Name = "add_dept_btn";
            this.add_dept_btn.Size = new System.Drawing.Size(95, 34);
            this.add_dept_btn.TabIndex = 7;
            this.add_dept_btn.Text = "Add";
            this.add_dept_btn.UseVisualStyleBackColor = true;
            this.add_dept_btn.Click += new System.EventHandler(this.add_dept_btn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(76, 644);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 33);
            this.button1.TabIndex = 8;
            this.button1.Text = "Logout";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Department
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
            this.Name = "Department";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee Database Manangement System";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Department_FormClosing);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dept_grid)).EndInit();
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
        private System.Windows.Forms.DataGridView dept_grid;
        private System.Windows.Forms.Button mod_dept_btn;
        private System.Windows.Forms.Button del_dept_btn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button add_dept_btn;
        private System.Windows.Forms.Button proj_btn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox dept_name_txt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox comp_id_txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox dept_id_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
    }
}