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
    public partial class students_created : Form
    {
        public students_created()
        {
            InitializeComponent();
        }

        private int selectedGruppaId = -1;

        private void students_created_Load(object sender, EventArgs e)
        {
            PopulateGruppaComboBox();
        }

        private void PopulateGruppaComboBox()
        {
            try
            {
                gruppa_id.Items.Clear();

                db db = new db();
                MySqlCommand fetchCommand = new MySqlCommand("SELECT `gruppa_name` FROM `gruppa`;", db.getConnection());

                db.OpenConnection();

                using (MySqlDataReader reader = fetchCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        gruppa_id.Items.Add(reader["gruppa_name"].ToString());
                    }
                }

                db.ClosedConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private int GetSpecialityId(string specialityName)
        {
            try
            {
                db db = new db();
                MySqlCommand command = new MySqlCommand("SELECT `gruppa_id` FROM `gruppa` WHERE `gruppa_name` = @gruppa_name;", db.getConnection());
                command.Parameters.Add("@gruppa_name", MySqlDbType.VarChar).Value = specialityName;

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

        private void gruppa_id_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedGruppaId = GetSpecialityId(gruppa_id.SelectedItem?.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                if (selectedGruppaId == -1)
                {
                    MessageBox.Show("Выберите группу");
                    return;
                }

                db db = new db();

                MySqlCommand command = new MySqlCommand("INSERT INTO `students`(`students_surname`, `students_name`, `students_otchestvo`, `students_number_phone`, `gruppa_id`) VALUES (@students_surname, @students_name, @students_otchestvo, @students_number_phone, @gruppa_id);", db.getConnection());
                command.Parameters.Add("@students_surname", MySqlDbType.VarChar).Value = students_surname.Text;
                command.Parameters.Add("@students_name", MySqlDbType.VarChar).Value = students_name.Text;
                command.Parameters.Add("@students_otchestvo", MySqlDbType.VarChar).Value = students_otchestvo.Text;
                command.Parameters.Add("@students_number_phone", MySqlDbType.VarChar).Value = students_number_phone.Text;
                command.Parameters.Add("@gruppa_id", MySqlDbType.Int32).Value = selectedGruppaId;

                db.OpenConnection();

                if (command.ExecuteNonQuery() == 1)
                    MessageBox.Show("Студент был успешно добавлен");
                else
                    MessageBox.Show("Не удалось добавить студента");

                db.ClosedConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }

        }

    }
}
