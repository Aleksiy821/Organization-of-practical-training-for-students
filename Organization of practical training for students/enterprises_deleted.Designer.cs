namespace Organization_of_practical_training_for_students
{
    partial class enterprises_deleted
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
            this.enterprises_adress = new System.Windows.Forms.TextBox();
            this.enterprises_name = new System.Windows.Forms.TextBox();
            this.enterprises_name_list = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.enterprises_adress);
            this.panel1.Controls.Add(this.enterprises_name);
            this.panel1.Controls.Add(this.enterprises_name_list);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(514, 359);
            this.panel1.TabIndex = 3;
            // 
            // enterprises_adress
            // 
            this.enterprises_adress.Location = new System.Drawing.Point(159, 173);
            this.enterprises_adress.Name = "enterprises_adress";
            this.enterprises_adress.Size = new System.Drawing.Size(218, 22);
            this.enterprises_adress.TabIndex = 5;
            // 
            // enterprises_name
            // 
            this.enterprises_name.Location = new System.Drawing.Point(159, 108);
            this.enterprises_name.Name = "enterprises_name";
            this.enterprises_name.Size = new System.Drawing.Size(216, 22);
            this.enterprises_name.TabIndex = 4;
            // 
            // enterprises_name_list
            // 
            this.enterprises_name_list.FormattingEnabled = true;
            this.enterprises_name_list.Location = new System.Drawing.Point(159, 38);
            this.enterprises_name_list.Name = "enterprises_name_list";
            this.enterprises_name_list.Size = new System.Drawing.Size(218, 24);
            this.enterprises_name_list.TabIndex = 3;
            this.enterprises_name_list.SelectedIndexChanged += new System.EventHandler(this.enterprises_name_list_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(159, 236);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(218, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Удалить предприятия";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(111, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(333, 20);
            this.label5.TabIndex = 23;
            this.label5.Text = "Выбор организации для удаления:";
            // 
            // enterprises_deleted
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 359);
            this.Controls.Add(this.panel1);
            this.Name = "enterprises_deleted";
            this.Text = "enterprises_deleted";
            this.Load += new System.EventHandler(this.enterprises_deleted_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox enterprises_adress;
        private System.Windows.Forms.TextBox enterprises_name;
        private System.Windows.Forms.ComboBox enterprises_name_list;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
    }
}