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
    public partial class specialiti_update : Form
    {
        public specialiti_update()
        {
            InitializeComponent();
        }

        private void specialiti_update_Load(object sender, EventArgs e)
        {
            PopulateSpecialityComboBox();
            speciality_name_list.SelectedIndexChanged += speciality_name_list_SelectedIndexChanged;

        }

        private void PopulateSpecialityComboBox()
        {
            try
            {
                speciality_name_list.Items.Clear(); 

                db db = new db();
                MySqlCommand fetchCommand = new MySqlCommand("SELECT `speciality_name` FROM `speciality`;", db.getConnection());

                db.OpenConnection();

                using (MySqlDataReader reader = fetchCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        speciality_name_list.Items.Add(reader["speciality_name"].ToString());
                    }
                }

                db.ClosedConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void speciality_name_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedSpeciality = speciality_name_list.SelectedItem?.ToString();

            if (!string.IsNullOrEmpty(selectedSpeciality))
            {
                db db = new db();
                MySqlCommand command = new MySqlCommand("SELECT `speciality_name`, `speciality_specialization` FROM `speciality` WHERE `speciality_name` = @speciality_name;", db.getConnection());
                command.Parameters.Add("@speciality_name", MySqlDbType.VarChar).Value = selectedSpeciality;

                db.OpenConnection();

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        speciality_name.Text = reader["speciality_name"].ToString();
                        speciality_specialization.Text = reader["speciality_specialization"].ToString();
                    }
                }

                db.ClosedConnection();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string selectedSpeciality = speciality_name_list.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(selectedSpeciality))
            {
                MessageBox.Show("Выберите специальность для обновления");
            }
            else
            {
                db db = new db();
                MySqlCommand updateCommand = new MySqlCommand("UPDATE `speciality` SET `speciality_specialization` = @speciality_specialization, `speciality_name` = @new_speciality_name WHERE `speciality_name` = @speciality_name;", db.getConnection());
                updateCommand.Parameters.Add("@speciality_name", MySqlDbType.VarChar).Value = selectedSpeciality;
                updateCommand.Parameters.Add("@new_speciality_name", MySqlDbType.VarChar).Value = speciality_name.Text;
                updateCommand.Parameters.Add("@speciality_specialization", MySqlDbType.VarChar).Value = speciality_specialization.Text;

                db.OpenConnection();

                if (updateCommand.ExecuteNonQuery() == 1)
                    MessageBox.Show("Специальность была успешно обновлена");
                else
                    MessageBox.Show("Не удалось обновить специальность");

                db.ClosedConnection();
            }
        }

    }
}
