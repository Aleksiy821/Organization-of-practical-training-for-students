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
    public partial class employees_update : Form
    {
        public employees_update()
        {
            InitializeComponent();
        }

        private void employees_update_Load(object sender, EventArgs e)
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
                MySqlCommand fetchCommand = new MySqlCommand("SELECT `employees_id`, `employees_surname` FROM `employees`;", db.getConnection());

                db.OpenConnection();

                using (MySqlDataReader reader = fetchCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        employees_name_list.Items.Add(new KeyValuePair<string, string>(reader["employees_id"].ToString(), reader["employees_surname"].ToString()));
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
            if (employees_name_list.SelectedItem is KeyValuePair<string, string> selectedEmployees)
            {
                db db = new db();
                MySqlCommand command = new MySqlCommand("SELECT * FROM `employees` WHERE `employees_id` = @employees_id;", db.getConnection());
                command.Parameters.Add("@employees_id", MySqlDbType.Int32).Value = selectedEmployees.Key;

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
            try
            {
                if (employees_name_list.SelectedItem is KeyValuePair<string, string> selectedEmployees)
                {
                    db db = new db();
                    MySqlCommand updateCommand = new MySqlCommand("UPDATE `employees` SET " +
                                                                  "`employees_surname` = @employees_surname, " +
                                                                  "`employees_name` = @employees_name, " +
                                                                  "`employees_otchestvo` = @employees_otchestvo, " +
                                                                  "`employees_number_phone` = @employees_number_phone " +
                                                                  "WHERE `employees_id` = @employees_id;", db.getConnection());

                    updateCommand.Parameters.Add("@employees_surname", MySqlDbType.VarChar).Value = employees_surname.Text;
                    updateCommand.Parameters.Add("@employees_name", MySqlDbType.VarChar).Value = employees_name.Text;
                    updateCommand.Parameters.Add("@employees_otchestvo", MySqlDbType.VarChar).Value = employees_otchestvo.Text;
                    updateCommand.Parameters.Add("@employees_number_phone", MySqlDbType.VarChar).Value = employees_number_phone.Text;
                    updateCommand.Parameters.Add("@employees_id", MySqlDbType.Int32).Value = selectedEmployees.Key;

                    db.OpenConnection();

                    if (updateCommand.ExecuteNonQuery() == 1)
                        MessageBox.Show("Данные работника успешно обновлены");
                    else
                        MessageBox.Show("Не удалось обновить данные работника");

                    db.ClosedConnection();
                }
                else
                {
                    MessageBox.Show("Выберите работника для обновления данных");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
    }
}
