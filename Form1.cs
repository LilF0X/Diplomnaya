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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string querystring = $"SELECT Доступ FROM Пользователь WHERE Логин='{textBox1.Text}' AND Пароль='{textBox2.Text}'";

            SqlConnection sqlConnection = ClassConnection.GetConnection();

            SqlCommand cmd = new SqlCommand(querystring, sqlConnection);

            object Role = cmd.ExecuteScalar();

            if (Role != null)
            {

                switch (Role)
                {
                    case 1:
                        this.Hide();
                        AdminForm admin = new AdminForm();
                        admin.Show();
                        break;

                    case 2:
                        this.Hide();
                        UserForm user = new UserForm();
                        user.Show();
                        break;
                    case 3:
                        this.Hide();
                        WorkerForm worker = new WorkerForm();
                        worker.Show();
                        break;
                }
            }
            else
            {
                MessageBox.Show("Проверьте введённые данные! Такого аккаунта не существует");
            }
        }
    }
}
