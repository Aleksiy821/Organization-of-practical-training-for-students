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
    public partial class typs_of_practice_deleted : Form
    {
        public typs_of_practice_deleted()
        {
            InitializeComponent();
        }

        private void typs_of_practice_deleted_Load(object sender, EventArgs e)
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
                MessageBox.Show("Выберите специальность для удаления");
            }
            else
            {
                db db = new db();
                MySqlCommand deleteCommand = new MySqlCommand("DELETE FROM `types_of_practice` WHERE `typs_of_practice_name` = @typs_of_practice_name;", db.getConnection());
                deleteCommand.Parameters.Add("@typs_of_practice_name", MySqlDbType.VarChar).Value = selectedPractice;

                db.OpenConnection();

                if (deleteCommand.ExecuteNonQuery() == 1)
                    MessageBox.Show("Практика была успешно удалена");
                else
                    MessageBox.Show("Не удалось удалить практику");

                db.ClosedConnection();
            }
        }

        private void typs_of_practice_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void typs_of_practice_date_TextChanged(object sender, EventArgs e)
        {

        }

        private void types_of_practice_internship_period_TextChanged(object sender, EventArgs e)
        {

        }

        private void types_of_practice_supervisor_TextChanged(object sender, EventArgs e)
        {

        }

        private void types_of_practice_start_date_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void types_of_practice_number_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
