using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Organization_of_practical_training_for_students
{
    public partial class department_update : Form
    {
        public department_update()
        {
            InitializeComponent();
        }

        string idDepartment;

        private void department_update_Load(object sender, EventArgs e)
        {
            PopulateGruppComboBox();
            department_name_list.SelectedIndexChanged += department_name_list_SelectedIndexChanged;
        }

        private void PopulateGruppComboBox()
        {
            try
            {
                department_name_list.Items.Clear();

                db db = new db();
                MySqlCommand fetchCommand = new MySqlCommand("SELECT * FROM `department`;", db.getConnection());

                db.OpenConnection();

                using (MySqlDataReader reader = fetchCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        department_name_list.Items.Add(reader["department_name"].ToString());
                        idDepartment = reader["department_id"].ToString();
                    }
                }

                db.ClosedConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void department_name_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedDepartment = department_name_list.SelectedItem?.ToString();

            if (!string.IsNullOrEmpty(selectedDepartment))
            {
                db db = new db();
                MySqlCommand command = new MySqlCommand("SELECT `department_name`, `department_number_phone` FROM `department` WHERE `department_name` = @department_name;", db.getConnection());
                command.Parameters.Add("@department_name", MySqlDbType.VarChar).Value = selectedDepartment;

                db.OpenConnection();

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        department_name.Text = reader["department_name"].ToString();
                        department_number_phone.Text = reader["department_number_phone"].ToString();
                    }
                }

                db.ClosedConnection();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string selectedDepartment = department_name_list.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(selectedDepartment))
            {
                MessageBox.Show("Выберите отдел для обновления");
            }
            else
            {
                db db = new db();
                MySqlCommand updateCommand = new MySqlCommand($"UPDATE `department` SET `department_name` = @department_name, `department_number_phone` = @department_number_phone WHERE `department_id` = '{idDepartment}';", db.getConnection());
        
                updateCommand.Parameters.Add("@department_name", MySqlDbType.VarChar).Value = department_name.Text;
                updateCommand.Parameters.Add("@department_number_phone", MySqlDbType.VarChar).Value = department_number_phone.Text;

                db.OpenConnection();

                if (updateCommand.ExecuteNonQuery() == 1)
                    MessageBox.Show("Отдел был успешно обновлен");
                else
                    MessageBox.Show("Не удалось обновить отдел");

                db.ClosedConnection();
            }
        }
    }
}
