using GMap.NET;
using GMap.NET.MapProviders;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diplomnaya
{
    public partial class UserForm : Form
    {
        public UserForm()
        {
            InitializeComponent();
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "diplommDataSet.Проекты_домов". При необходимости она может быть перемещена или удалена.
            this.проекты_домовTableAdapter.Fill(this.diplommDataSet.Проекты_домов);

        }

        private void gMapControl1_Load(object sender, EventArgs e)
        {
            gMapControl1.MapProvider = GMapProviders.GoogleMap;
            gMapControl1.Position = new PointLatLng(51.612279, 39.463540);

            gMapControl1.MinZoom = 5;
            gMapControl1.MaxZoom = 50;
            gMapControl1.Zoom = 15;

            gMapControl1.DragButton = MouseButtons.Left;
        }
    }
}
