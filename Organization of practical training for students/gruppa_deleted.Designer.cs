namespace Organization_of_practical_training_for_students
{
    partial class gruppa_deleted
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
            this.gruppa_academic_year = new System.Windows.Forms.TextBox();
            this.grupp_name_list = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.gruppa_name = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.gruppa_academic_year);
            this.panel1.Controls.Add(this.grupp_name_list);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.gruppa_name);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(525, 348);
            this.panel1.TabIndex = 4;
            // 
            // gruppa_academic_year
            // 
            this.gruppa_academic_year.Location = new System.Drawing.Point(157, 151);
            this.gruppa_academic_year.Name = "gruppa_academic_year";
            this.gruppa_academic_year.Size = new System.Drawing.Size(218, 22);
            this.gruppa_academic_year.TabIndex = 4;
            // 
            // grupp_name_list
            // 
            this.grupp_name_list.FormattingEnabled = true;
            this.grupp_name_list.Location = new System.Drawing.Point(157, 33);
            this.grupp_name_list.Name = "grupp_name_list";
            this.grupp_name_list.Size = new System.Drawing.Size(218, 24);
            this.grupp_name_list.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(157, 201);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(218, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Удаление группы";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // gruppa_name
            // 
            this.gruppa_name.Location = new System.Drawing.Point(159, 88);
            this.gruppa_name.Name = "gruppa_name";
            this.gruppa_name.Size = new System.Drawing.Size(216, 22);
            this.gruppa_name.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(127, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(279, 20);
            this.label5.TabIndex = 23;
            this.label5.Text = "Выбор группы для удаления:";
            // 
            // gruppa_deleted
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 348);
            this.Controls.Add(this.panel1);
            this.Name = "gruppa_deleted";
            this.Text = "gruppa_deleted";
            this.Load += new System.EventHandler(this.gruppa_deleted_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox gruppa_academic_year;
        private System.Windows.Forms.ComboBox grupp_name_list;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox gruppa_name;
        private System.Windows.Forms.Label label5;
    }
}