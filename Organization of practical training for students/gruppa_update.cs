using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Organization_of_practical_training_for_students
{
    public partial class gruppa_update : Form
    {
        public gruppa_update()
        {
            InitializeComponent();
        }
        string idGrupp;
        private void gruppa_update_Load(object sender, EventArgs e)
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
                MySqlCommand fetchCommand = new MySqlCommand("SELECT * FROM `gruppa`;", db.getConnection());

                db.OpenConnection();

                using (MySqlDataReader reader = fetchCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        grupp_name_list.Items.Add(reader["gruppa_name"].ToString());
                        idGrupp = reader["gruppa_id"].ToString();
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
                MySqlCommand command = new MySqlCommand("SELECT `gruppa_name`, `gruppa_academic_year` FROM `gruppa` WHERE `gruppa_name` = @gruppa_name;", db.getConnection());
                command.Parameters.Add("@gruppa_name", MySqlDbType.VarChar).Value = selectedGrupp;

                db.OpenConnection();

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        gruppa_name.Text = reader["gruppa_name"].ToString();
                        gruppa_academic_year.Text = reader["gruppa_academic_year"].ToString();
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
                MessageBox.Show("Выберите группу для обновления");
            }
            else
            {
                db db = new db();
                MySqlCommand updateCommand = new MySqlCommand($"UPDATE `gruppa` SET `gruppa_academic_year` = @gruppa_academic_year, `gruppa_name` = @gruppa_name WHERE `gruppa_id` = '{idGrupp}';", db.getConnection());

                    updateCommand.Parameters.Add("@gruppa_academic_year", MySqlDbType.Date).Value = gruppa_academic_year.Text;
                    updateCommand.Parameters.Add("@gruppa_name", MySqlDbType.VarChar).Value = gruppa_name.Text;

                    db.OpenConnection();

                    if (updateCommand.ExecuteNonQuery() == 1)
                        MessageBox.Show("Группа была успешно обновлена");
                    else
                        MessageBox.Show("Не удалось обновить группу");

                    db.ClosedConnection();
            }
        }
    }
}
