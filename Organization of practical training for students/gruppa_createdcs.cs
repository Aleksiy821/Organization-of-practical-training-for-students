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

    public partial class gruppa_createdcs : Form
    {
        public gruppa_createdcs()
        {
            InitializeComponent();
        }

        private int selectedSpecialityId = -1;

        private void gruppa_createdcs_Load(object sender, EventArgs e)
        {
            PopulateSpecialityComboBox();
        }

        private void PopulateSpecialityComboBox()
        {
            try
            {
                specialityComboBox.Items.Clear();

                db db = new db();
                MySqlCommand fetchCommand = new MySqlCommand("SELECT `speciality_name` FROM `speciality`;", db.getConnection());

                db.OpenConnection();

                using (MySqlDataReader reader = fetchCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        specialityComboBox.Items.Add(reader["speciality_name"].ToString());
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
                MySqlCommand command = new MySqlCommand("SELECT `speciality_id` FROM `speciality` WHERE `speciality_name` = @speciality_name;", db.getConnection());
                command.Parameters.Add("@speciality_name", MySqlDbType.VarChar).Value = specialityName;

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

        private void specialityComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedSpecialityId = GetSpecialityId(specialityComboBox.SelectedItem?.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedSpecialityId == -1)
                {
                    MessageBox.Show("Выберите специальность");
                    return;
                }

                db db = new db();

                if (DateTime.TryParse(gruppa_academic_year.Text, out DateTime academicYear))
                {
                    MySqlCommand command = new MySqlCommand("INSERT INTO `gruppa`(`gruppa_name`, `gruppa_academic_year`, `speciality_id`) VALUES (@gruppa_name, @gruppa_academic_year, @speciality_id);", db.getConnection());
                    command.Parameters.Add("@gruppa_name", MySqlDbType.VarChar).Value = gruppa_name.Text; 
                    command.Parameters.Add("@gruppa_academic_year", MySqlDbType.Date).Value = academicYear.ToString("yyyy-MM-dd");
                    command.Parameters.Add("@speciality_id", MySqlDbType.Int32).Value = selectedSpecialityId;

                    db.OpenConnection();

                    if (command.ExecuteNonQuery() == 1)
                        MessageBox.Show("Группа была успешно добавлена");
                    else
                        MessageBox.Show("Не удалось добавить группу");

                    db.ClosedConnection();
                }
                else
                {
                    MessageBox.Show("Некорректный формат даты. Введите дату в формате 'YYYY-MM-DD'.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
        
    }
}
