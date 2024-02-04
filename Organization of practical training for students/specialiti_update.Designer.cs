namespace Organization_of_practical_training_for_students
{
    partial class specialiti_update
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
            this.speciality_name_list = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.speciality_specialization = new System.Windows.Forms.TextBox();
            this.speciality_name = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.speciality_name_list);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.speciality_specialization);
            this.panel1.Controls.Add(this.speciality_name);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(530, 308);
            this.panel1.TabIndex = 1;
            // 
            // speciality_name_list
            // 
            this.speciality_name_list.FormattingEnabled = true;
            this.speciality_name_list.Location = new System.Drawing.Point(159, 38);
            this.speciality_name_list.Name = "speciality_name_list";
            this.speciality_name_list.Size = new System.Drawing.Size(218, 24);
            this.speciality_name_list.TabIndex = 3;
            this.speciality_name_list.SelectedIndexChanged += new System.EventHandler(this.speciality_name_list_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(159, 221);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(218, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Обновить спецальность";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // speciality_specialization
            // 
            this.speciality_specialization.Location = new System.Drawing.Point(159, 167);
            this.speciality_specialization.Name = "speciality_specialization";
            this.speciality_specialization.Size = new System.Drawing.Size(218, 22);
            this.speciality_specialization.TabIndex = 1;
            // 
            // speciality_name
            // 
            this.speciality_name.Location = new System.Drawing.Point(159, 107);
            this.speciality_name.Name = "speciality_name";
            this.speciality_name.Size = new System.Drawing.Size(218, 22);
            this.speciality_name.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(155, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(232, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "Ввывоб специальности:";
            // 
            // specialiti_update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 308);
            this.Controls.Add(this.panel1);
            this.Name = "specialiti_update";
            this.Text = "specialiti_update";
            this.Load += new System.EventHandler(this.specialiti_update_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox speciality_specialization;
        private System.Windows.Forms.TextBox speciality_name;
        private System.Windows.Forms.ComboBox speciality_name_list;
        private System.Windows.Forms.Label label5;
    }
}