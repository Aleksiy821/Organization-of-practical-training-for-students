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
    public partial class gruppa_deleted : Form
    {
        public gruppa_deleted()
        {
            InitializeComponent();
        }

        private void gruppa_deleted_Load(object sender, EventArgs e)
        {
            PopulateGruppComboBox();
            grupp_name_list.SelectedIndexChanged += grupp_name_list_SelectedIndexChanged;
        }

        private void PopulateGruppComboBox()
        {
            try
            {
                grupp_name_list.Items.Clear();

                db db = new db();
                MySqlCommand fetchCommand = new MySqlCommand("SELECT `gruppa_name` FROM `gruppa`;", db.getConnection());

                db.OpenConnection();

                using (MySqlDataReader reader = fetchCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        grupp_name_list.Items.Add(reader["gruppa_name"].ToString());
                    }
                }

                db.ClosedConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void grupp_name_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedGrupp = grupp_name_list.SelectedItem?.ToString();

            if (!string.IsNullOrEmpty(selectedGrupp))
            {
                db db = new db();
                MySqlCommand command = new MySqlCommand("SELECT `gruppa_name`, `gruppa_academic_year`, `speciality_id` FROM `gruppa` WHERE `gruppa_name` = @gruppa_name;", db.getConnection());
                command.Parameters.Add("@gruppa_name", MySqlDbType.VarChar).Value = selectedGrupp;

                db.OpenConnection();

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        gruppa_name.Text = reader["gruppa_name"].ToString();
                        gruppa_academic_year.Text = reader["gruppa_academic_year"].ToString();
                        grupp_name_list.Text = reader["speciality_id"].ToString();
                    }
                }

                db.ClosedConnection();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string selectedGrupp = grupp_name_list.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(selectedGrupp))
            {
                MessageBox.Show("Выберите группу для удаления");
            }
            else
            {
                db db = new db();
                MySqlCommand deleteCommand = new MySqlCommand("DELETE FROM `gruppa` WHERE `gruppa_name` = @gruppa_name;", db.getConnection());
                deleteCommand.Parameters.Add("@gruppa_name", MySqlDbType.VarChar).Value = selectedGrupp;

                db.OpenConnection();

                if (deleteCommand.ExecuteNonQuery() == 1)
                    MessageBox.Show("Группа была успешно удалена");
                else
                    MessageBox.Show("Не удалось удалить группу");

                db.ClosedConnection();
            }
        }
     }
}
