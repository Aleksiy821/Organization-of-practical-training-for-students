namespace Organization_of_practical_training_for_students
{
    partial class students_created
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
            this.gruppa_id = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.students_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.students_number_phone);
            this.panel1.Controls.Add(this.students_surname);
            this.panel1.Controls.Add(this.students_otchestvo);
            this.panel1.Controls.Add(this.gruppa_id);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.students_name);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(555, 366);
            this.panel1.TabIndex = 4;
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
            // gruppa_id
            // 
            this.gruppa_id.FormattingEnabled = true;
            this.gruppa_id.Location = new System.Drawing.Point(154, 33);
            this.gruppa_id.Name = "gruppa_id";
            this.gruppa_id.Size = new System.Drawing.Size(218, 24);
            this.gruppa_id.TabIndex = 3;
            this.gruppa_id.SelectedIndexChanged += new System.EventHandler(this.gruppa_id_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(152, 282);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(218, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Добавить студента";
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(150, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(227, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Выбор специальности: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(150, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Фамилия студента: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(150, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Имя студента: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(150, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(204, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Отчество студента: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(150, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(274, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Номер телефона студента: ";
            // 
            // students_created
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 366);
            this.Controls.Add(this.panel1);
            this.Name = "students_created";
            this.Text = "students_created";
            this.Load += new System.EventHandler(this.students_created_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox students_otchestvo;
        private System.Windows.Forms.ComboBox gruppa_id;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox students_name;
        private System.Windows.Forms.TextBox students_number_phone;
        private System.Windows.Forms.TextBox students_surname;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}