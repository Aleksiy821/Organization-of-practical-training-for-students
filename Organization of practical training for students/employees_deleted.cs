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
    public partial class employees_deleted : Form
    {
        public employees_deleted()
        {
            InitializeComponent();
        }

        private void employees_deleted_Load(object sender, EventArgs e)
        {
            PopulateStudentsComboBox();
            employees_name_list.SelectedIndexChanged += employees_name_list_SelectedIndexChanged;
        }

        private void PopulateStudentsComboBox()
        {
            try
            {
                employees_name_list.Items.Clear();

                db db = new db();
                MySqlCommand fetchCommand = new MySqlCommand("SELECT `employees_surname` FROM `employees`;", db.getConnection());

                db.OpenConnection();

                using (MySqlDataReader reader = fetchCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        employees_name_list.Items.Add(reader["employees_surname"].ToString());
                    }
                }

                db.ClosedConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void employees_name_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedEmployees = employees_name_list.SelectedItem?.ToString();

            if (!string.IsNullOrEmpty(selectedEmployees))
            {
                db db = new db();
                MySqlCommand command = new MySqlCommand("SELECT `employees_surname`, `employees_name`, `employees_otchestvo`, `employees_number_phone`, `department_id` FROM `employees` WHERE `employees_surname` = @employees_surname;", db.getConnection());
                command.Parameters.Add("@employees_surname", MySqlDbType.VarChar).Value = selectedEmployees;

                db.OpenConnection();

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        employees_surname.Text = reader["employees_surname"].ToString();
                        employees_name.Text = reader["employees_name"].ToString();
                        employees_otchestvo.Text = reader["employees_otchestvo"].ToString();
                        employees_number_phone.Text = reader["employees_number_phone"].ToString();
                    }
                }

                db.ClosedConnection();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string selectedEmployees = employees_name_list.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(selectedEmployees))
            {
                MessageBox.Show("Выберите работника для удаления");
            }
            else
            {
                db db = new db();
                MySqlCommand deleteCommand = new MySqlCommand("DELETE FROM `employees` WHERE `employees_id` = @employees_id;", db.getConnection());
                deleteCommand.Parameters.Add("@employees_id", MySqlDbType.VarChar).Value = selectedEmployees;

                db.OpenConnection();

                if (deleteCommand.ExecuteNonQuery() == 1)
                    MessageBox.Show("Работник был успешно удален");
                else
                    MessageBox.Show("Не удалось удалить работника");

                db.ClosedConnection();
            }
        }
    }
}
