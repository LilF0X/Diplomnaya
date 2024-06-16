using GMap.NET;
using GMap.NET.WindowsForms.Markers;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.ToolTips;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GMap.NET.WindowsPresentation;
using System.Data.SqlClient;
using System.Security.Policy;

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
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;

            if (comboBox1.SelectedIndex == 0)
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = true;

                label1.Text = "ПРОЕКТ ДОМА \"ИЗУМРУД\"\r\n\r\nПараметры проекта:\r\nПлощадь 60м2\r\nГабариты 5х11\r\nКоличество этажей 1\r\nКоличество жилых комнат 4\r\n\r\n Стоимость проекта: 2 520 000 руб.";

            }

            if (comboBox1.SelectedIndex == 1)
            {
                pictureBox1.Visible = false;
                pictureBox3.Visible = true;

                label1.Text = "ПРОЕКТ ДОМА \"НОВАЯ УСМАНЬ\"\r\n\r\nПараметры проекта:\r\nПлощадь 114м2\r\nГабариты 8.2х7.9\r\nКоличество этажей 2\r\nКоличество жилых комнат 3\r\n\r\n Стоимость проекта:3 975 000 руб.";

            }
        }

        private void gMapControl1_Load(object sender, EventArgs e)
        {
            gMapControl1.MapProvider = GMapProviders.GoogleMap;
            gMapControl1.Position = new PointLatLng(51.612279, 39.463540);

            gMapControl1.ShowCenter = false;
            gMapControl1.ShowTileGridLines = false;
            gMapControl1.MarkersEnabled = true;

            gMapControl1.MinZoom = 15;
            gMapControl1.MaxZoom = 20;
            gMapControl1.Zoom = 15;

            gMapControl1.DragButton = MouseButtons.Left;

            gMapControl1.Overlays.Add(GetOverlayMarkers(" GroupsMarkers", GMarkerGoogleType.green));

            gMapControl1.Update();

        }

        private GMarkerGoogle GetMarker(GMarkerGoogleType gMarkerGoogleType = GMarkerGoogleType.green)
        {
            GMarkerGoogle Pj1 = new GMarkerGoogle(new GMap.NET.PointLatLng(51.612283, 39.455626), gMarkerGoogleType);
            Pj1.ToolTip = new GMapRoundedToolTip(Pj1);
            Pj1.ToolTipText = "Проект Изумруд";
            Pj1.ToolTipMode = MarkerTooltipMode.OnMouseOver;
            return Pj1;
        }

            private GMarkerGoogle GetMarker2(GMarkerGoogleType gMarkerGoogleType = GMarkerGoogleType.green)
            {
                GMarkerGoogle Pj2 = new GMarkerGoogle(new GMap.NET.PointLatLng(51.612168, 39.455801), gMarkerGoogleType);
            Pj2.ToolTip = new GMapRoundedToolTip(Pj2);
            Pj2.ToolTipText = "Проект Усмань";
            Pj2.ToolTipMode = MarkerTooltipMode.OnMouseOver;
            return Pj2;
        }


        private GMapOverlay GetOverlayMarkers(string name, GMarkerGoogleType gMarkerGoogleType = GMarkerGoogleType.green)
        {
            GMapOverlay gMapMarkers = new GMapOverlay(name);// создание именованного слоя 
                gMapMarkers.Markers.Add(GetMarker(gMarkerGoogleType));// добавление маркеров на слой
                gMapMarkers.Markers.Add(GetMarker2(gMarkerGoogleType));
            return gMapMarkers;
        }
    }
}
