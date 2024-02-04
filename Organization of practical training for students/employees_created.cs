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
    public partial class employees_created : Form
    {
        public employees_created()
        {
            InitializeComponent();
        }

        private int selectedEmployeesId = -1;

        private void employees_created_Load(object sender, EventArgs e)
        {
            PopulateGruppaComboBox();
        }

        private void PopulateGruppaComboBox()
        {
            try
            {
                employees_name_list.Items.Clear();

                db db = new db();
                MySqlCommand fetchCommand = new MySqlCommand("SELECT `department_name` FROM `department`;", db.getConnection());

                db.OpenConnection();

                using (MySqlDataReader reader = fetchCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        employees_name_list.Items.Add(reader["department_name"].ToString());
                    }
                }

                db.ClosedConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private int GetEmployeesId(string specialityName)
        {
            try
            {
                db db = new db();
                MySqlCommand command = new MySqlCommand("SELECT `department_id` FROM `department` WHERE `department_name` = @department_name;", db.getConnection());
                command.Parameters.Add("@department_name", MySqlDbType.VarChar).Value = specialityName;

                db.OpenConnection();

                object result = command.ExecuteScalar();

                db.ClosedConnection();

                if (result != null && result != DBNull.Value)
                {
                    return Convert.ToInt32(result);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }

            return -1;
        }

        private void employees_name_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedEmployeesId = GetEmployeesId(employees_name_list.SelectedItem?.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedEmployeesId == -1)
                {
                    MessageBox.Show("Выберите отдел");
                    return;
                }

                db db = new db();

                MySqlCommand command = new MySqlCommand("INSERT INTO `employees`(`employees_surname`, `employees_name`, `employees_otchestvo`, `employees_number_phone`, `department_id`) VALUES (@employees_surname, @employees_name, @employees_otchestvo, @employees_number_phone, @department_id);", db.getConnection());
                command.Parameters.Add("@employees_surname", MySqlDbType.VarChar).Value = employees_surname.Text;
                command.Parameters.Add("@employees_name", MySqlDbType.VarChar).Value = employees_name.Text;
                command.Parameters.Add("@employees_otchestvo", MySqlDbType.VarChar).Value = employees_otchestvo.Text;
                command.Parameters.Add("@employees_number_phone", MySqlDbType.VarChar).Value = employees_number_phone.Text;
                command.Parameters.Add("@department_id", MySqlDbType.Int32).Value = selectedEmployeesId;

                db.OpenConnection();

                if (command.ExecuteNonQuery() == 1)
                    MessageBox.Show("Работник был успешно добавлен");
                else
                    MessageBox.Show("Не удалось добавить работника");

                db.ClosedConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
    }
}
