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
    public partial class enterprises_deleted : Form
    {
        public enterprises_deleted()
        {
            InitializeComponent();
        }

        private void enterprises_deleted_Load(object sender, EventArgs e)
        {
            PopulateSpecialityComboBox();
            enterprises_name_list.SelectedIndexChanged += enterprises_name_list_SelectedIndexChanged;
        }

        private void PopulateSpecialityComboBox()
        {
            try
            {
                enterprises_name_list.Items.Clear();

                db db = new db();
                MySqlCommand fetchCommand = new MySqlCommand("SELECT `enterprises_name` FROM `enterprises`;", db.getConnection());

                db.OpenConnection();

                using (MySqlDataReader reader = fetchCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        enterprises_name_list.Items.Add(reader["enterprises_name"].ToString());
                    }
                }

                db.ClosedConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void enterprises_name_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedEnterprises = enterprises_name_list.SelectedItem?.ToString();

            if (!string.IsNullOrEmpty(selectedEnterprises))
            {
                db db = new db();
                MySqlCommand command = new MySqlCommand("SELECT `enterprises_name`, `enterprises_adress` FROM `enterprises` WHERE `enterprises_name` = @enterprises_name;", db.getConnection());
                command.Parameters.Add("@enterprises_name", MySqlDbType.VarChar).Value = selectedEnterprises;

                db.OpenConnection();

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        enterprises_name.Text = reader["enterprises_name"].ToString();
                        enterprises_adress.Text = reader["enterprises_adress"].ToString();
                    }
                }

                db.ClosedConnection();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string selectedEnterprises_name = enterprises_name_list.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(selectedEnterprises_name))
            {
                MessageBox.Show("Выберите Производство для обновления");
            }
            else
            {
                db db = new db();
             
                MySqlCommand deleteCommand = new MySqlCommand("DELETE FROM `enterprises` WHERE `enterprises_name` = @enterprises_name;", db.getConnection());
                deleteCommand.Parameters.Add("@enterprises_name", MySqlDbType.VarChar).Value = selectedEnterprises_name;

                db.OpenConnection();

                if (deleteCommand.ExecuteNonQuery() == 1)
                    MessageBox.Show("Производство была успешно удалена");
                else
                    MessageBox.Show("Не удалось удалить Производство");

                db.ClosedConnection();
            }
        }
    }
}
