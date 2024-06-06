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
    public partial class WorkerForm : Form
    {
        public WorkerForm()
        {
            InitializeComponent();
        }

        private void WorkerForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "diplommDataSet.Участок". При необходимости она может быть перемещена или удалена.
            this.участокTableAdapter.Fill(this.diplommDataSet.Участок);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "diplommDataSet.Стоимость_постройки_дома". При необходимости она может быть перемещена или удалена.
            this.стоимость_постройки_домаTableAdapter.Fill(this.diplommDataSet.Стоимость_постройки_дома);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "diplommDataSet.Проекты_домов". При необходимости она может быть перемещена или удалена.
            this.проекты_домовTableAdapter.Fill(this.diplommDataSet.Проекты_домов);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "diplommDataSet.Населённый_пункт". При необходимости она может быть перемещена или удалена.
            this.населённый_пунктTableAdapter.Fill(this.diplommDataSet.Населённый_пункт);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "diplommDataSet.Дом". При необходимости она может быть перемещена или удалена.
            this.домTableAdapter.Fill(this.diplommDataSet.Дом);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = ClassConnection.GetConnection();

            string addstring = $"INSERT INTO Дом (Проект дома, Площадь дома, Количество этажей, Адрес дома) VALUES ('{textBox1.Text}', '{textBox2.Text}', '{textBox3.Text}',  '{textBox4.Text}')";

            SqlCommand cmd = new SqlCommand(addstring, sqlConnection);

            cmd.ExecuteNonQuery();

            this.домTableAdapter.Fill(this.diplommDataSet.Дом);

            MessageBox.Show("Добавлено успешно!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = ClassConnection.GetConnection();

            string deletestring = $"DELETE FROM Дом WHERE id='{textBox5.Text}'";

            SqlCommand cmd = new SqlCommand(deletestring, sqlConnection);

            cmd.ExecuteNonQuery();

            this.домTableAdapter.Fill(this.diplommDataSet.Дом);

            MessageBox.Show("Удалено успешно!");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = ClassConnection.GetConnection();

            string addstring = $"INSERT INTO [Населённый пункт] (Название населенного пункта, Комуникации в населенном пункте, Количество  выкупленнных участков, Количество участков в продаже, Количество строющихся домов) VALUES ('{textBox6.Text}', '{textBox7.Text}', '{textBox8.Text}',  '{textBox9.Text}', '{textBox10.Text}')";

            SqlCommand cmd = new SqlCommand(addstring, sqlConnection);

            cmd.ExecuteNonQuery();

            this.населённый_пунктTableAdapter.Fill(this.diplommDataSet.Населённый_пункт);

            MessageBox.Show("Добавлено успешно!");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = ClassConnection.GetConnection();

            string deletestring = $"DELETE FROM [Населённый пункт] WHERE id='{textBox11.Text}'";

            SqlCommand cmd = new SqlCommand(deletestring, sqlConnection);

            cmd.ExecuteNonQuery();

            this.населённый_пунктTableAdapter.Fill(this.diplommDataSet.Населённый_пункт);

            MessageBox.Show("Удалено успешно!");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = ClassConnection.GetConnection();

            string addstring = $"INSERT INTO [Стоимость постройки дома] (Номер проекта дома, Общая стоимость дома, Срок постройки дома, Стоимость земельного участка) VALUES ('{textBox12.Text}', '{textBox13.Text}', '{textBox14.Text}',  '{textBox15.Text}')";

            SqlCommand cmd = new SqlCommand(addstring, sqlConnection);

            cmd.ExecuteNonQuery();

            this.стоимость_постройки_домаTableAdapter.Fill(this.diplommDataSet.Стоимость_постройки_дома);

            MessageBox.Show("Добавлено успешно!");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = ClassConnection.GetConnection();

            string deletestring = $"DELETE FROM [Стоимость постройки дома] WHERE id='{textBox16.Text}'";

            SqlCommand cmd = new SqlCommand(deletestring, sqlConnection);

            cmd.ExecuteNonQuery();

            this.стоимость_постройки_домаTableAdapter.Fill(this.diplommDataSet.Стоимость_постройки_дома);

            MessageBox.Show("Удалено успешно!");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            проекты_домовTableAdapter.Update(diplommDataSet.Проекты_домов);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            участокTableAdapter.Update(diplommDataSet.Участок);
        }
    }
}
