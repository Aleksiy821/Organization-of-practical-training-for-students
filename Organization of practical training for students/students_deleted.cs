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
    public partial class students_deleted : Form
    {
        public students_deleted()
        {
            InitializeComponent();
        }

        private void students_deleted_Load(object sender, EventArgs e)
        {
            PopulateStudentsComboBox();
            students_surname_list.SelectedIndexChanged += students_surname_list_SelectedIndexChanged;
        }

        private void PopulateStudentsComboBox()
        {
            try
            {
                students_surname_list.Items.Clear();

                db db = new db();
                MySqlCommand fetchCommand = new MySqlCommand("SELECT `students_surname` FROM `students`;", db.getConnection());

                db.OpenConnection();

                using (MySqlDataReader reader = fetchCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        students_surname_list.Items.Add(reader["students_surname"].ToString());
                    }
                }

                db.ClosedConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void students_surname_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedStudent = students_surname_list.SelectedItem?.ToString();

            if (!string.IsNullOrEmpty(selectedStudent))
            {
                db db = new db();
                MySqlCommand command = new MySqlCommand("SELECT `students_surname`, `students_name`, `students_otchestvo`, `students_number_phone`, `gruppa_id` FROM `students` WHERE `students_surname` = @students_surname;", db.getConnection());
                command.Parameters.Add("@students_surname", MySqlDbType.VarChar).Value = selectedStudent;

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
            string selectedStudent = students_surname_list.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(selectedStudent))
            {
                MessageBox.Show("Выберите студента для удаления");
            }
            else
            {
                db db = new db();
                MySqlCommand deleteCommand = new MySqlCommand("DELETE FROM `students` WHERE `students_id` = @students_id;", db.getConnection());
                deleteCommand.Parameters.Add("@students_id", MySqlDbType.VarChar).Value = selectedStudent;

                db.OpenConnection();

                if (deleteCommand.ExecuteNonQuery() == 1)
                    MessageBox.Show("Студент был успешно удален");
                else
                    MessageBox.Show("Не удалось удалить студента");

                db.ClosedConnection();
            }
        }

    }
}
