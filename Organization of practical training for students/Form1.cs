using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using Word = Microsoft.Office.Interop.Word;
using System.Windows.Forms.VisualStyles;

namespace Organization_of_practical_training_for_students
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void создатьСпециальностьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            specialiti newForm = new specialiti();
            newForm.Show();
        }

        private void обновитьСуществующуюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            specialiti_update newForm = new specialiti_update();
            newForm.Show();
        }

        private void удалитьСпециальностьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            specialiti_deleted newForm = new specialiti_deleted();
            newForm.Show();
        }

        private void добавлениеНовойГруппыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gruppa_createdcs newForm = new gruppa_createdcs();
            newForm.Show();
        }

        private void удалениеГруппыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gruppa_deleted newForm = new gruppa_deleted();
            newForm.Show();
        }

        private void обновлениеГруппыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gruppa_update newForm = new gruppa_update();
            newForm.Show();
        }

        private void добавлениеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            students_created newForm = new students_created();
            newForm.Show();
        }

        private void обновлениеУчащегосяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            students_update newForm = new students_update();
            newForm.Show();
        }

        private void удалениеУчащегосяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            students_deleted newForm = new students_deleted();
            newForm.Show();
        }

        private void добавлениеПредприятияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            enterprises_created newForm = new enterprises_created();
            newForm.Show();
        }


        private void обновлениеПредприятияToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            enterprises_update newForm = new enterprises_update();
            newForm.Show();
        }

        private void удалениеПредприятияToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            enterprises_deleted newForm = new enterprises_deleted();
            newForm.Show();
        }

        private void добавитьОтделToolStripMenuItem_Click(object sender, EventArgs e)
        {
            department_created newForm = new department_created();
            newForm.Show();
        }

        private void обновитьОтделToolStripMenuItem_Click(object sender, EventArgs e)
        {
            department_update newForm = new department_update();
            newForm.Show();
        }

        private void удалитьОтделToolStripMenuItem_Click(object sender, EventArgs e)
        {
            department_deleted newForm = new department_deleted();
            newForm.Show();
        }

        private void добавитьРаботникаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            employees_created newForm = new employees_created();
            newForm.Show();
        }

        private void обновитьРаботникаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            employees_update newForm = new employees_update();
            newForm.Show();
        }

        private void удалитьРаботникаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            employees_deleted newForm = new employees_deleted();
            newForm.Show();
        }

        private void добавитьПрактикуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            typs_of_practice_created newForm = new typs_of_practice_created();
            newForm.Show();
        }

        private void обновитьПрактикуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            typs_of_practice_update newForm = new typs_of_practice_update();
            newForm.Show();
        }

        private void удалитьПрактикуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            typs_of_practice_deleted newForm = new typs_of_practice_deleted(); 
            newForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            referral_to_industrial_practice newForm = new referral_to_industrial_practice();
            newForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var wordApp = new Word.Application();
            var doc = wordApp.Documents.Add();
            doc.Content.Text = "Общество с ограниченной\r\nответственностью «Свиль»\r\n(ООО «Свиль»)\r\n\r\nПРИКАЗ\r\n\r\nДата  № Номер\r\n\r\nУкажите город\r\n\r\nО прохождении <Вид практики>\r\n\r\nНа основании договора об организации практики студентов, заключенного между <Название организации> и Учреждением образования «Навазние полностью» от дата № номер/номер,\r\n\r\nПРИКАЗЫВАЮ:\r\n1. <ФИО в род. Падеже>, студента н-го курса, факультет «название», зачислить в <Название отдела> отдел для прохождения практики на период с дата начала по дата окончания по специальности «название специальности».\r\n2. <…>\r\n\r\n\r\nДиректор организации\tПодпись\tРасшифровка\r\n\r\n\r\nС приказом ознакомлены\tПодпись\tРасшифровка\r\nДата\r\n\r\n<…>\r\n\r\n"; // Замените эту строку на ваш текст
            doc.SaveAs2(@"d:\Users\asus\Downloads\document.docx"); 
            doc.Close();
            wordApp.Quit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string sourcePath = @"d:\project\БД и СУБД\Курсовой проект\Organization of practical training for students\Organization of practical training for students\arhif\document.rar";
            string fileName = "document.rar";
            string sourceFile = Path.Combine(sourcePath, fileName);
            string targetPath = @"d:\Users\asus\Downloads\document.rar";
            string destFile = Path.Combine(targetPath, fileName);

            if (!Directory.Exists(targetPath))
            {
                Directory.CreateDirectory(targetPath);
            }

            File.Copy(sourceFile, destFile, true);

            Process.Start("explorer.exe", targetPath);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string connStr = "server=localhost;user=root;database=cursovayabdinsubd;port=3306;password=";
            MySqlConnection conn = new MySqlConnection(connStr);

            string userDate = data_excel.Text;
            string userSurname = surnameTextBox.Text;
            string userGroupName = groupNameTextBox.Text;

            string sql = "SELECT students.students_surname, employees.employees_surname, types_of_practice.typs_of_practice_name, " +
                         "referral_to_industrial_practice.practice_mark, referral_to_industrial_practice.practice_date, gruppa.gruppa_name " +
                         "FROM `referral_to_industrial_practice` " +
                         "inner JOIN `employees` ON referral_to_industrial_practice.employees_id = employees.employees_id " +
                         "inner JOIN `students` ON referral_to_industrial_practice.students_id = students.students_id " +
                         "inner JOIN `types_of_practice`  ON referral_to_industrial_practice.types_id = types_of_practice.types_id " +
                         "inner JOIN `gruppa` ON students.gruppa_id = gruppa.gruppa_id";

            List<string> conditions = new List<string>();

            if (!string.IsNullOrEmpty(userDate))
            {
                conditions.Add("STR_TO_DATE(referral_to_industrial_practice.practice_date, '%Y-%m-%d') = STR_TO_DATE('" + userDate + "', '%Y-%m-%d')");
            }
            if (!string.IsNullOrEmpty(userSurname))
            {
                conditions.Add("students.students_surname = '" + userSurname + "'");
            }
            if (!string.IsNullOrEmpty(userGroupName))
            {
                conditions.Add("gruppa.gruppa_name = '" + userGroupName + "'");
            }

            if (conditions.Count > 0)
            {
                sql += " WHERE " + string.Join(" AND ", conditions);
            }

            try
            {
                conn.Open();
                MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
                System.Data.DataTable dt = new System.Data.DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                conn.Close();
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application xla = new Microsoft.Office.Interop.Excel.Application();
            xla.Visible = true;
            Microsoft.Office.Interop.Excel.Workbook wb = xla.Workbooks.Add(Microsoft.Office.Interop.Excel.XlSheetType.xlWorksheet);
            Microsoft.Office.Interop.Excel.Worksheet ws = (Microsoft.Office.Interop.Excel.Worksheet)xla.ActiveSheet;

            int i = 1;
            int j = 1;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    ws.Cells[i, j] = cell.Value;
                    j++;
                }
                j = 1;
                i++;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application xla = new Microsoft.Office.Interop.Excel.Application();
            xla.Visible = true;
            Microsoft.Office.Interop.Excel.Workbook wb = xla.Workbooks.Add(Microsoft.Office.Interop.Excel.XlSheetType.xlWorksheet);

            Microsoft.Office.Interop.Excel.Worksheet ws1 = (Microsoft.Office.Interop.Excel.Worksheet)xla.ActiveSheet;
            ws1.Name = "С местом прохождения практики";

            int i = 1;
            int j = 1;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["employees_surname"].Value != null && row.Cells["employees_surname"].Value.ToString() != "Нету место прохождения практики")
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        ws1.Cells[i, j] = cell.Value;
                        j++;
                    }
                    j = 1;
                    i++;
                }
            }

            Microsoft.Office.Interop.Excel.Worksheet ws2 = (Microsoft.Office.Interop.Excel.Worksheet)wb.Worksheets.Add();
            ws2.Name = "Без места прохождения практики";

            i = 1;
            j = 1;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["employees_surname"].Value == null || row.Cells["employees_surname"].Value.ToString() == "Нету место прохождения практики")
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        ws2.Cells[i, j] = cell.Value;
                        j++;
                    }
                    j = 1;
                    i++;
                }
            }
        }

        private void вывестиСпискиУчащихсяСГруппамиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string connStr = "server=localhost;user=root;database=cursovayabdinsubd;port=3306;password=";
            MySqlConnection conn = new MySqlConnection(connStr);
            string query = @"
        SELECT students.students_surname, students.students_name, students.students_otchestvo, students.students_number_phone, gruppa.gruppa_name 
        FROM students
        JOIN gruppa ON students.gruppa_id = gruppa.gruppa_id
        WHERE 1";

            using (conn)
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        var dt = new System.Data.DataTable();
                        dt.Load(reader);

                        var excelApp = new Microsoft.Office.Interop.Excel.Application();
                        excelApp.Workbooks.Add();
                        Microsoft.Office.Interop.Excel._Worksheet workSheet = excelApp.ActiveSheet;

                        for (var i = 0; i < dt.Columns.Count; i++)
                        {
                            workSheet.Cells[1, i + 1] = dt.Columns[i].ColumnName;
                        }

                        for (var i = 0; i < dt.Rows.Count; i++)
                        {
                            for (var j = 0; j < dt.Columns.Count; j++)
                            {
                                workSheet.Cells[i + 2, j + 1] = dt.Rows[i][j];
                            }
                        }

                        workSheet.SaveAs(@"d:\Users\asus\Downloads\document.xlsx");
                        excelApp.Quit();
                    }
                }
            }
        }
    }
}
