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
    public partial class enterprises_created : Form
    {
        public enterprises_created()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            db db = new db();
            MySqlCommand command = new MySqlCommand("INSERT INTO `enterprises`(`enterprises_name`, `enterprises_adress`) VALUES (@enterprises_name, @enterprises_address);", db.getConnection());
            command.Parameters.Add("@enterprises_name", MySqlDbType.VarChar).Value = enterprises_name.Text;
            command.Parameters.Add("@enterprises_address", MySqlDbType.VarChar).Value = enterprises_adress.Text;

            db.OpenConnection();

            if (command.ExecuteNonQuery() == 1)

                MessageBox.Show("Предприятие была добавлена");

            else

                MessageBox.Show("Предприятие не удалось добавить");

            db.ClosedConnection();
        }
    }
}
