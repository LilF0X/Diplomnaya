using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diplomnaya
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "diplommDataSet.Пользователь". При необходимости она может быть перемещена или удалена.
            this.пользовательTableAdapter.Fill(this.diplommDataSet.Пользователь);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = ClassConnection.GetConnection();

            string adduserstring = $"INSERT INTO Пользователь(Логин, Пароль, Доступ) VALUES ('{textBox1.Text}', '{textBox2.Text}', '{textBox3.Text}')";

            SqlCommand cmd = new SqlCommand(adduserstring, sqlConnection);

            cmd.ExecuteNonQuery();

            this.пользовательTableAdapter.Fill(this.diplommDataSet.Пользователь);

            MessageBox.Show("Пользователь добавлен успешно!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = ClassConnection.GetConnection();

            string deleteuserstring = $"DELETE FROM Пользователь WHERE id='{textBox4.Text}'";

            SqlCommand cmd = new SqlCommand(deleteuserstring, sqlConnection);

            cmd.ExecuteNonQuery();

            this.пользовательTableAdapter.Fill(this.diplommDataSet.Пользователь);

            MessageBox.Show("Пользователь удалён успешно!");
        }
    }
}
