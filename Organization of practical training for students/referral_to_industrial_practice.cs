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
    public partial class referral_to_industrial_practice : Form
    {
        private string idStud;
        private string idEmplo;
        private string idType;
        public referral_to_industrial_practice()
        {
            InitializeComponent();
        }

        private void referral_to_industrial_practice_Load(object sender, EventArgs e)
        {
            PopulateStudentComboBox();
            PopulateEmployeesComboBox();
            PopulateTypesComboBox();
            student_name_list.SelectedIndexChanged += student_name_list_SelectedIndexChanged;
            employees_name_list.SelectedIndexChanged += employees_name_list_SelectedIndexChanged;
            types_of_practice_name_list.SelectedIndexChanged += types_of_practice_name_list_SelectedIndexChanged;
        }

        private void PopulateStudentComboBox()
        {
            try
            {
                student_name_list.Items.Clear();

                db db = new db();
                MySqlCommand fetchCommand = new MySqlCommand("SELECT `students_surname` FROM `students` " +
                    "where students_id not in (select students_id from referral_to_industrial_practice)", db.getConnection());

                db.OpenConnection();

                using (MySqlDataReader reader = fetchCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        student_name_list.Items.Add(reader["students_surname"].ToString());
                    }
                }

                db.ClosedConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"PopulateStudentComboBox Error: {ex.Message}");
            }
        }

        private void PopulateEmployeesComboBox()
        {
            try
            {
                employees_name_list.Items.Clear();

                db db = new db();
                MySqlCommand fetchCommand = new MySqlCommand("SELECT `employees_surname` FROM `employees`;", db.getConnection());

                db.OpenConnection();

                using (MySqlDataReader reader = fetchCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        employees_name_list.Items.Add(reader["employees_surname"].ToString());

                    }
                }

                db.ClosedConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"PopulateEmployeesComboBox Error: {ex.Message}");
            }
        }

        private void PopulateTypesComboBox()
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
                MessageBox.Show($"PopulateTypesComboBox Error: {ex.Message}");
            }
        }


        private void student_name_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (student_name_list.SelectedItem is KeyValuePair<string, string> selectedStudent)
                {
                    db db = new db();
                    MySqlCommand command = new MySqlCommand("SELECT * FROM `students` WHERE `students_id` = @students_id;", db.getConnection());
                    command.Parameters.Add("@students_id", MySqlDbType.Int32).Value = selectedStudent.Key;

                    db.OpenConnection();

                    db.ClosedConnection();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"student_name_list_SelectedIndexChanged Error: {ex.Message}");
            }
            
        }

        private void employees_name_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (employees_name_list.SelectedItem is KeyValuePair<string, string> selectedEmployees)
            {
                db db = new db();
                MySqlCommand command = new MySqlCommand("SELECT * FROM `employees` WHERE `employees_id` = @employees_id;", db.getConnection());
                command.Parameters.Add("@employees_id", MySqlDbType.Int32).Value = selectedEmployees.Key;

                db.OpenConnection();
                db.ClosedConnection();
            }
        }

        private void types_of_practice_name_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedPractice = types_of_practice_name_list.SelectedItem?.ToString();

            if (!string.IsNullOrEmpty(selectedPractice))
            {
                db db = new db();
                MySqlCommand command = new MySqlCommand("SELECT * FROM `referral_to_industrial_practice` WHERE `types_id` = @types_id;", db.getConnection());
                command.Parameters.Add("@typs_of_practice_name", MySqlDbType.VarChar).Value = selectedPractice;

                db.OpenConnection();
                db.ClosedConnection();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (student_name_list.SelectedItem == null || employees_name_list.SelectedItem == null || types_of_practice_name_list.SelectedItem == null)
                {
                    MessageBox.Show("Выберите значения для всех комбобоксов");
                    return;
                }

                string practiceMark = practice_mark.Text;
                string practiceDate = practice_date.Text;

                db db = new db();
                MySqlCommand commandQueryOne = new MySqlCommand($"SELECT students_id FROM `students` WHERE `students_surname` = '{student_name_list.SelectedItem}';", db.getConnection());
                MySqlCommand commandQueryTwo = new MySqlCommand($"SELECT employees_id FROM `employees` WHERE `employees_surname` = '{employees_name_list.SelectedItem}';", db.getConnection());
                MySqlCommand commandQueryThree = new MySqlCommand($"SELECT types_id FROM `types_of_practice` WHERE `typs_of_practice_name` = '{types_of_practice_name_list.SelectedItem}';", db.getConnection());
                db.OpenConnection();

                using (MySqlDataReader reader = commandQueryOne.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        idStud = reader["students_id"].ToString();
                    }
                }

                using (MySqlDataReader reader = commandQueryTwo.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        idEmplo = reader["employees_id"].ToString();
                    }
                }

                using (MySqlDataReader reader = commandQueryThree.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        idType = reader["types_id"].ToString();
                    }
                }

                db.ClosedConnection();


                MySqlCommand command = new MySqlCommand("INSERT INTO `referral_to_industrial_practice`(`students_id`, `employees_id`, `types_id`, `practice_mark`, `practice_date`) VALUES (@studentId, @employeeId, @typeId, @practiceMark, @practiceDate);", db.getConnection());
                command.Parameters.Add("@studentId", MySqlDbType.Int32).Value = idStud;
                command.Parameters.Add("@employeeId", MySqlDbType.Int32).Value = idEmplo;
                command.Parameters.Add("@typeId", MySqlDbType.Int32).Value = idType;
                command.Parameters.Add("@practiceMark", MySqlDbType.VarChar).Value = practiceMark;
                command.Parameters.Add("@practiceDate", MySqlDbType.VarChar).Value = practiceDate;

                db.OpenConnection();
                command.ExecuteNonQuery();
                db.ClosedConnection();

                MessageBox.Show("Данные успешно добавлены.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("button1_Click Ошибка при выполнении запроса: " + ex.ToString());
            }
        }
    }
}
