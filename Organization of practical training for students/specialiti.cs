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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Organization_of_practical_training_for_students
{
    public partial class specialiti : Form
    {
        public specialiti()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            db db = new db();
            MySqlCommand command = new MySqlCommand("INSERT INTO `speciality` (`speciality_name`, `speciality_specialization`) VALUES (@speciality_name, @speciality_specialization);", db.getConnection());
            command.Parameters.Add("@speciality_name", MySqlDbType.VarChar).Value = speciality_name.Text;
            command.Parameters.Add("@speciality_specialization", MySqlDbType.VarChar).Value = speciality_specialization.Text;

            db.OpenConnection();

            if (command.ExecuteNonQuery() == 1)

                MessageBox.Show("Специальность была добавлена");

            else

                MessageBox.Show("Специальность не удалось добавить");

            db.ClosedConnection();
        }

        
    }
}
