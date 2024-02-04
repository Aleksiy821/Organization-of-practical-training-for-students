namespace Organization_of_practical_training_for_students
{
    partial class students_update
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
            this.students_number_phone = new System.Windows.Forms.TextBox();
            this.students_surname = new System.Windows.Forms.TextBox();
            this.students_otchestvo = new System.Windows.Forms.TextBox();
            this.students_surname_list = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.students_name = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.students_number_phone);
            this.panel1.Controls.Add(this.students_surname);
            this.panel1.Controls.Add(this.students_otchestvo);
            this.panel1.Controls.Add(this.students_surname_list);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.students_name);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(526, 379);
            this.panel1.TabIndex = 5;
            // 
            // students_number_phone
            // 
            this.students_number_phone.Location = new System.Drawing.Point(152, 238);
            this.students_number_phone.Name = "students_number_phone";
            this.students_number_phone.Size = new System.Drawing.Size(218, 22);
            this.students_number_phone.TabIndex = 6;
            // 
            // students_surname
            // 
            this.students_surname.Location = new System.Drawing.Point(154, 86);
            this.students_surname.Name = "students_surname";
            this.students_surname.Size = new System.Drawing.Size(216, 22);
            this.students_surname.TabIndex = 5;
            // 
            // students_otchestvo
            // 
            this.students_otchestvo.Location = new System.Drawing.Point(152, 187);
            this.students_otchestvo.Name = "students_otchestvo";
            this.students_otchestvo.Size = new System.Drawing.Size(218, 22);
            this.students_otchestvo.TabIndex = 4;
            // 
            // students_surname_list
            // 
            this.students_surname_list.FormattingEnabled = true;
            this.students_surname_list.Location = new System.Drawing.Point(154, 33);
            this.students_surname_list.Name = "students_surname_list";
            this.students_surname_list.Size = new System.Drawing.Size(218, 24);
            this.students_surname_list.TabIndex = 3;
            this.students_surname_list.SelectedIndexChanged += new System.EventHandler(this.students_id_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(152, 282);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(218, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Обновить студента";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // students_name
            // 
            this.students_name.Location = new System.Drawing.Point(154, 136);
            this.students_name.Name = "students_name";
            this.students_name.Size = new System.Drawing.Size(216, 22);
            this.students_name.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(150, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(178, 20);
            this.label5.TabIndex = 18;
            this.label5.Text = "Ввывоб студента:";
            // 
            // students_update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 379);
            this.Controls.Add(this.panel1);
            this.Name = "students_update";
            this.Text = "students_update";
            this.Load += new System.EventHandler(this.students_update_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox students_number_phone;
        private System.Windows.Forms.TextBox students_surname;
        private System.Windows.Forms.TextBox students_otchestvo;
        private System.Windows.Forms.ComboBox students_surname_list;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox students_name;
        private System.Windows.Forms.Label label5;
    }
}