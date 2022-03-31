
namespace EmployeeManagementSystem
{
    partial class Add_Project
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
            this.clear = new System.Windows.Forms.Button();
            this.save_comp_btn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.cancel_comp_btn = new System.Windows.Forms.Button();
            this.duration_txt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.proj_name_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.proj_id_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // clear
            // 
            this.clear.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.clear.Location = new System.Drawing.Point(425, 346);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(95, 34);
            this.clear.TabIndex = 47;
            this.clear.Text = "Clear";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // save_comp_btn
            // 
            this.save_comp_btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.save_comp_btn.Location = new System.Drawing.Point(276, 346);
            this.save_comp_btn.Name = "save_comp_btn";
            this.save_comp_btn.Size = new System.Drawing.Size(95, 34);
            this.save_comp_btn.TabIndex = 46;
            this.save_comp_btn.Text = "Save";
            this.save_comp_btn.UseVisualStyleBackColor = true;
            this.save_comp_btn.Click += new System.EventHandler(this.save_comp_btn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.cancel_comp_btn);
            this.panel2.Location = new System.Drawing.Point(11, 14);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(760, 90);
            this.panel2.TabIndex = 39;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(3, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(331, 65);
            this.label4.TabIndex = 9;
            this.label4.Text = "Project Details";
            // 
            // cancel_comp_btn
            // 
            this.cancel_comp_btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cancel_comp_btn.Location = new System.Drawing.Point(640, 30);
            this.cancel_comp_btn.Name = "cancel_comp_btn";
            this.cancel_comp_btn.Size = new System.Drawing.Size(95, 34);
            this.cancel_comp_btn.TabIndex = 36;
            this.cancel_comp_btn.Text = "Back";
            this.cancel_comp_btn.UseVisualStyleBackColor = true;
            this.cancel_comp_btn.Click += new System.EventHandler(this.cancel_comp_btn_Click);
            // 
            // duration_txt
            // 
            this.duration_txt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.duration_txt.Location = new System.Drawing.Point(392, 276);
            this.duration_txt.Name = "duration_txt";
            this.duration_txt.Size = new System.Drawing.Size(182, 29);
            this.duration_txt.TabIndex = 53;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(242, 279);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 21);
            this.label3.TabIndex = 52;
            this.label3.Text = "Duration :";
            // 
            // proj_name_txt
            // 
            this.proj_name_txt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.proj_name_txt.Location = new System.Drawing.Point(392, 226);
            this.proj_name_txt.Name = "proj_name_txt";
            this.proj_name_txt.Size = new System.Drawing.Size(182, 29);
            this.proj_name_txt.TabIndex = 51;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(242, 229);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 21);
            this.label2.TabIndex = 50;
            this.label2.Text = "Project Name :";
            // 
            // proj_id_txt
            // 
            this.proj_id_txt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.proj_id_txt.Location = new System.Drawing.Point(392, 177);
            this.proj_id_txt.Name = "proj_id_txt";
            this.proj_id_txt.Size = new System.Drawing.Size(182, 29);
            this.proj_id_txt.TabIndex = 49;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(242, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 21);
            this.label1.TabIndex = 48;
            this.label1.Text = "Project Id :";
            // 
            // Add_Project
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.duration_txt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.proj_name_txt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.proj_id_txt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.save_comp_btn);
            this.Controls.Add(this.panel2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Add_Project";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee Database Management System";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Add_Project_FormClosing);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button save_comp_btn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button cancel_comp_btn;
        private System.Windows.Forms.TextBox duration_txt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox proj_name_txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox proj_id_txt;
        private System.Windows.Forms.Label label1;
    }
}