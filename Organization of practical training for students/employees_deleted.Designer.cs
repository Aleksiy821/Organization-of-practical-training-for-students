namespace Organization_of_practical_training_for_students
{
    partial class employees_deleted
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
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.employees_number_phone = new System.Windows.Forms.TextBox();
            this.employees_surname = new System.Windows.Forms.TextBox();
            this.employees_otchestvo = new System.Windows.Forms.TextBox();
            this.employees_name_list = new System.Windows.Forms.ComboBox();
            this.employees_name = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(152, 282);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(218, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Удалить сотрудника";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.employees_number_phone);
            this.panel1.Controls.Add(this.employees_surname);
            this.panel1.Controls.Add(this.employees_otchestvo);
            this.panel1.Controls.Add(this.employees_name_list);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.employees_name);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(507, 389);
            this.panel1.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(115, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(323, 20);
            this.label5.TabIndex = 23;
            this.label5.Text = "Выбор сотрудника для удаления:";
            // 
            // employees_number_phone
            // 
            this.employees_number_phone.Location = new System.Drawing.Point(152, 238);
            this.employees_number_phone.Name = "employees_number_phone";
            this.employees_number_phone.Size = new System.Drawing.Size(218, 22);
            this.employees_number_phone.TabIndex = 6;
            // 
            // employees_surname
            // 
            this.employees_surname.Location = new System.Drawing.Point(154, 86);
            this.employees_surname.Name = "employees_surname";
            this.employees_surname.Size = new System.Drawing.Size(216, 22);
            this.employees_surname.TabIndex = 5;
            // 
            // employees_otchestvo
            // 
            this.employees_otchestvo.Location = new System.Drawing.Point(152, 187);
            this.employees_otchestvo.Name = "employees_otchestvo";
            this.employees_otchestvo.Size = new System.Drawing.Size(218, 22);
            this.employees_otchestvo.TabIndex = 4;
            // 
            // employees_name_list
            // 
            this.employees_name_list.FormattingEnabled = true;
            this.employees_name_list.Location = new System.Drawing.Point(154, 33);
            this.employees_name_list.Name = "employees_name_list";
            this.employees_name_list.Size = new System.Drawing.Size(218, 24);
            this.employees_name_list.TabIndex = 3;
            this.employees_name_list.SelectedIndexChanged += new System.EventHandler(this.employees_name_list_SelectedIndexChanged);
            // 
            // employees_name
            // 
            this.employees_name.Location = new System.Drawing.Point(154, 136);
            this.employees_name.Name = "employees_name";
            this.employees_name.Size = new System.Drawing.Size(216, 22);
            this.employees_name.TabIndex = 0;
            // 
            // employees_deleted
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 389);
            this.Controls.Add(this.panel1);
            this.Name = "employees_deleted";
            this.Text = "employees_deleted";
            this.Load += new System.EventHandler(this.employees_deleted_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox employees_number_phone;
        private System.Windows.Forms.TextBox employees_surname;
        private System.Windows.Forms.TextBox employees_otchestvo;
        private System.Windows.Forms.ComboBox employees_name_list;
        private System.Windows.Forms.TextBox employees_name;
        private System.Windows.Forms.Label label5;
    }
}