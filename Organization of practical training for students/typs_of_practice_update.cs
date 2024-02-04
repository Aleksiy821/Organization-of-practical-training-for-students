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
    public partial class typs_of_practice_update : Form
    {
        public typs_of_practice_update()
        {
            InitializeComponent();
        }

        private void typs_of_practice_update_Load(object sender, EventArgs e)
        {
            PopulateSpecialityComboBox();
            types_of_practice_name_list.SelectedIndexChanged += types_of_practice_name_list_SelectedIndexChanged;
        }

        private void PopulateSpecialityComboBox()
        {
            try
            {
                types_of_practice_name_list.Items.Clear();

                db db = new db();
                MySqlCommand fetchCommand = new MySqlCommand("SELECT `typs_of_practice_name` FROM `types_of_practice`;", db.getConnection());

                db.OpenConnection();

                using (MySqlDataReader reader = fetchCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        types_of_practice_name_list.Items.Add(reader["typs_of_practice_name"].ToString());
                    }
                }

                db.ClosedConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void types_of_practice_name_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedPractice = types_of_practice_name_list.SelectedItem?.ToString();

            if (!string.IsNullOrEmpty(selectedPractice))
            {
                db db = new db();
                MySqlCommand command = new MySqlCommand("SELECT `typs_of_practice_name`, `typs_of_practice_date`, `types_of_practice_internship_period`, `types_of_practice_start_date`, `types_of_practice_end_date`, `types_of_practice_number`, `types_of_practice_supervisor` FROM `types_of_practice` WHERE `typs_of_practice_name` = @typs_of_practice_name;", db.getConnection());
                command.Parameters.Add("@typs_of_practice_name", MySqlDbType.VarChar).Value = selectedPractice;

                db.OpenConnection();

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        typs_of_practice_name.Text = reader["typs_of_practice_name"].ToString();
                        typs_of_practice_date.Text = reader["typs_of_practice_date"].ToString();
                        types_of_practice_internship_period.Text = reader["types_of_practice_internship_period"].ToString();
                        types_of_practice_start_date.Text = reader["types_of_practice_start_date"].ToString();
                        types_of_practice_end_date.Text = reader["types_of_practice_end_date"].ToString();
                        types_of_practice_number.Text = reader["types_of_practice_number"].ToString();
                        types_of_practice_supervisor.Text = reader["types_of_practice_supervisor"].ToString();
                    }
                }

                db.ClosedConnection();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string selectedPractice = types_of_practice_name_list.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(selectedPractice))
            {
                MessageBox.Show("Выберите предприятие для обновления");
            }
            else
            {
                db db = new db();
                MySqlCommand updateCommand = new MySqlCommand("UPDATE `types_of_practice` SET `typs_of_practice_name` = @new_typs_of_practice_name,`typs_of_practice_date` = @typs_of_practice_date,`types_of_practice_internship_period` = @types_of_practice_internship_period,`types_of_practice_start_date` = @types_of_practice_start_date,`types_of_practice_end_date` = @types_of_practice_end_date, `types_of_practice_number` = @types_of_practice_number, `types_of_practice_supervisor` = @types_of_practice_supervisor WHERE `typs_of_practice_name` = @typs_of_practice_name;", db.getConnection());
                updateCommand.Parameters.Add("@typs_of_practice_name", MySqlDbType.VarChar).Value = selectedPractice;
                updateCommand.Parameters.Add("@new_typs_of_practice_name", MySqlDbType.VarChar).Value = types_of_practice_supervisor.Text;
                updateCommand.Parameters.Add("@typs_of_practice_date", MySqlDbType.VarChar).Value = typs_of_practice_date.Text;
                updateCommand.Parameters.Add("@types_of_practice_internship_period", MySqlDbType.VarChar).Value = types_of_practice_internship_period.Text;
                updateCommand.Parameters.Add("@types_of_practice_start_date", MySqlDbType.VarChar).Value = types_of_practice_start_date.Text;
                updateCommand.Parameters.Add("@types_of_practice_end_date", MySqlDbType.VarChar).Value = types_of_practice_end_date.Text;
                updateCommand.Parameters.Add("@types_of_practice_number", MySqlDbType.VarChar).Value = types_of_practice_number.Text;
                updateCommand.Parameters.Add("@types_of_practice_supervisor", MySqlDbType.VarChar).Value = types_of_practice_supervisor.Text;

                db.OpenConnection();

                if (updateCommand.ExecuteNonQuery() == 1)
                    MessageBox.Show("Предприятие было успешно обновлено");
                else
                    MessageBox.Show("Не удалось обновить предприятие");

                db.ClosedConnection();
            }
        }
    }
}
