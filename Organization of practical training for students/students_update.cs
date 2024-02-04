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
    public partial class students_update : Form
    {
        public students_update()
        {
            InitializeComponent();
        }

        private void students_update_Load(object sender, EventArgs e)
        {
            PopulateStudentsComboBox();
            students_surname_list.SelectedIndexChanged += students_id_SelectedIndexChanged;
        }

        private void PopulateStudentsComboBox()
        {
            try
            {
                students_surname_list.Items.Clear();

                db db = new db();
                MySqlCommand fetchCommand = new MySqlCommand("SELECT `students_id`, `students_surname` FROM `students`;", db.getConnection());

                db.OpenConnection();

                using (MySqlDataReader reader = fetchCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        students_surname_list.Items.Add(new KeyValuePair<string, string>(reader["students_id"].ToString(), reader["students_surname"].ToString()));
                    }
                }

                db.ClosedConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void students_id_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (students_surname_list.SelectedItem is KeyValuePair<string, string> selectedStudent)
            {
                db db = new db();
                MySqlCommand command = new MySqlCommand("SELECT * FROM `students` WHERE `students_id` = @students_id;", db.getConnection());
                command.Parameters.Add("@students_id", MySqlDbType.Int32).Value = selectedStudent.Key;

                db.OpenConnection();

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        students_surname.Text = reader["students_surname"].ToString();
                        students_name.Text = reader["students_name"].ToString();
                        students_otchestvo.Text = reader["students_otchestvo"].ToString();
                        students_number_phone.Text = reader["students_number_phone"].ToString();
                    }
                }

                db.ClosedConnection();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (students_surname_list.SelectedItem is KeyValuePair<string, string> selectedStudent)
                {
                    db db = new db();
                    MySqlCommand updateCommand = new MySqlCommand("UPDATE `students` SET " +
                                                                  "`students_surname` = @students_surname, " +
                                                                  "`students_name` = @students_name, " +
                                                                  "`students_otchestvo` = @students_otchestvo, " +
                                                                  "`students_number_phone` = @students_number_phone " +
                                                                  "WHERE `students_id` = @students_id;", db.getConnection());

                    updateCommand.Parameters.Add("@students_surname", MySqlDbType.VarChar).Value = students_surname.Text;
                    updateCommand.Parameters.Add("@students_name", MySqlDbType.VarChar).Value = students_name.Text;
                    updateCommand.Parameters.Add("@students_otchestvo", MySqlDbType.VarChar).Value = students_otchestvo.Text;
                    updateCommand.Parameters.Add("@students_number_phone", MySqlDbType.VarChar).Value = students_number_phone.Text;
                    updateCommand.Parameters.Add("@students_id", MySqlDbType.Int32).Value = selectedStudent.Key;

                    db.OpenConnection();

                    if (updateCommand.ExecuteNonQuery() == 1)
                        MessageBox.Show("Данные студента успешно обновлены");
                    else
                        MessageBox.Show("Не удалось обновить данные студента");

                    db.ClosedConnection();
                }
                else
                {
                    MessageBox.Show("Выберите студента для обновления данных");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
    }
}
