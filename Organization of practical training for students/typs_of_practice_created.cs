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
    public partial class typs_of_practice_created : Form
    {
        public typs_of_practice_created()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            db db = new db();
            MySqlCommand command = new MySqlCommand("INSERT INTO `types_of_practice` (`typs_of_practice_name`, `typs_of_practice_date`, `types_of_practice_internship_period`, `types_of_practice_start_date`, `types_of_practice_end_date`, `types_of_practice_number`, `types_of_practice_supervisor`) VALUES (@typs_of_practice_name, @typs_of_practice_date, @types_of_practice_internship_period, @types_of_practice_start_date, @types_of_practice_end_date, @types_of_practice_number, @types_of_practice_supervisor);", db.getConnection());
            command.Parameters.Add("@typs_of_practice_name", MySqlDbType.VarChar).Value = typs_of_practice_name.Text;
            command.Parameters.Add("@typs_of_practice_date", MySqlDbType.VarChar).Value = typs_of_practice_date.Text;
            command.Parameters.Add("@types_of_practice_internship_period", MySqlDbType.VarChar).Value = types_of_practice_internship_period.Text;
            command.Parameters.Add("@types_of_practice_start_date", MySqlDbType.VarChar).Value = types_of_practice_start_date.Text;
            command.Parameters.Add("@types_of_practice_end_date", MySqlDbType.VarChar).Value = types_of_practice_end_date.Text;
            command.Parameters.Add("@types_of_practice_number", MySqlDbType.VarChar).Value = types_of_practice_number.Text;
            command.Parameters.Add("@types_of_practice_supervisor", MySqlDbType.VarChar).Value = types_of_practice_supervisor.Text;

            db.OpenConnection();

            if (command.ExecuteNonQuery() == 1)

                MessageBox.Show("Практикиа была добавлена");

            else

                MessageBox.Show("Практику не удалось добавить");

            db.ClosedConnection();
        }
    }
}
