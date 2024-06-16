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
    public partial class FormReg : Form
    {
        public FormReg()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = ClassConnection.GetConnection();

            string addstring = $"INSERT INTO Пользователь(Логин, Пароль, Доступ) VALUES ('{textBox1.Text}', '{textBox2.Text}', 2)";

            SqlCommand cmd = new SqlCommand(addstring, conn);

            cmd.ExecuteNonQuery();

            MessageBox.Show("Успешно! Вернитесь, чтобы авторизоваться");
        }
    }
}
