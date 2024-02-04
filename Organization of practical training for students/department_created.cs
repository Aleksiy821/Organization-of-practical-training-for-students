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
    public partial class department_created : Form
    {
        public department_created()
        {
            InitializeComponent();
        }

        private int selectedEnterprisesId = -1;

        private void department_created_Load(object sender, EventArgs e)
        {
            PopulateSpecialityComboBox();
        }

        private void PopulateSpecialityComboBox()
        {
            try
            {
                department_name_list.Items.Clear();

                db db = new db();
                MySqlCommand fetchCommand = new MySqlCommand("SELECT `enterprises_name` FROM `enterprises`;", db.getConnection());

                db.OpenConnection();

                using (MySqlDataReader reader = fetchCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        department_name_list.Items.Add(reader["enterprises_name"].ToString());
                    }
                }

                db.ClosedConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private int GetEnterpriseId(string specialityName)
        {
            try
            {
                db db = new db();
                MySqlCommand command = new MySqlCommand("SELECT `enterprises_id` FROM `enterprises` WHERE `enterprises_name` = @enterprises_name;", db.getConnection());
                command.Parameters.Add("@enterprises_name", MySqlDbType.VarChar).Value = specialityName;

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

        private void department_name_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedEnterprisesId = GetEnterpriseId(department_name_list.SelectedItem?.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedEnterprisesId == -1)
                {
                    MessageBox.Show("Выберите производства");
                    return;
                }

                db db = new db();

                    MySqlCommand command = new MySqlCommand("INSERT INTO `department`(`department_name`, `department_number_phone`, `enterprises_id`) VALUES (@department_name, @department_number_phone, @enterprises_id);", db.getConnection());
                    command.Parameters.Add("@department_name", MySqlDbType.VarChar).Value = department_name.Text;
                    command.Parameters.Add("@department_number_phone", MySqlDbType.VarChar).Value = department_number_phone.Text;
                    command.Parameters.Add("@enterprises_id", MySqlDbType.Int32).Value = selectedEnterprisesId;

                    db.OpenConnection();

                    if (command.ExecuteNonQuery() == 1)
                        MessageBox.Show("Отдел был успешно добавлен");
                    else
                        MessageBox.Show("Не удалось добавить отдел");

                    db.ClosedConnection();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
    }
}
