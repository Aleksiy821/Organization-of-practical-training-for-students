﻿namespace Organization_of_practical_training_for_students
{
    partial class department_deleted
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.department_number_phone = new System.Windows.Forms.TextBox();
            this.department_name_list = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.department_name = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.department_number_phone);
            this.panel1.Controls.Add(this.department_name_list);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.department_name);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(547, 333);
            this.panel1.TabIndex = 6;
            // 
            // department_number_phone
            // 
            this.department_number_phone.Location = new System.Drawing.Point(157, 151);
            this.department_number_phone.Name = "department_number_phone";
            this.department_number_phone.Size = new System.Drawing.Size(218, 22);
            this.department_number_phone.TabIndex = 4;
            // 
            // department_name_list
            // 
            this.department_name_list.FormattingEnabled = true;
            this.department_name_list.Location = new System.Drawing.Point(157, 33);
            this.department_name_list.Name = "department_name_list";
            this.department_name_list.Size = new System.Drawing.Size(218, 24);
            this.department_name_list.TabIndex = 3;
            this.department_name_list.SelectedIndexChanged += new System.EventHandler(this.department_name_list_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(157, 201);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(218, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Удалить отдел";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // department_name
            // 
            this.department_name.Location = new System.Drawing.Point(159, 88);
            this.department_name.Name = "department_name";
            this.department_name.Size = new System.Drawing.Size(216, 22);
            this.department_name.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(136, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(283, 20);
            this.label5.TabIndex = 22;
            this.label5.Text = "Выбор отдела для удаления:";
            // 
            // department_deleted
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 333);
            this.Controls.Add(this.panel1);
            this.Name = "department_deleted";
            this.Text = "department_deleted";
            this.Load += new System.EventHandler(this.department_deleted_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox department_number_phone;
        private System.Windows.Forms.ComboBox department_name_list;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox department_name;
        private System.Windows.Forms.Label label5;
    }
}