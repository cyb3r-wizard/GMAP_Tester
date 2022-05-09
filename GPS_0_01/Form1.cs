using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GMap.NET;

namespace GPS_0_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCargarMapa_Click(object sender, EventArgs e)
        {
            double lat=0;
            double lng=0;


            if (lat != 0 || lng != 0)
            {


            if (txbLatitud.Text.Contains(".") || txbLongitud.Text.Contains("."))
            {
                lat = double.Parse(txbLatitud.Text.Replace(".", ","));
                lng = double.Parse(txbLongitud.Text.Replace(".", ","));
                txbLongitud.Text = lng.ToString();
                txbLatitud.Text =  lat.ToString();

            }
            else
            {
                lat = double.Parse(txbLatitud.Text);
                lng = double.Parse(txbLongitud.Text);
            }
            }
            gmpVisor.DragButton = MouseButtons.Left;
            gmpVisor.CanDragMap = true;
            gmpVisor.ShowCenter = false;
            gmpVisor.MapProvider = GMap.NET.MapProviders.GoogleSatelliteMapProvider.Instance;
            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerOnly;
            gmpVisor.Position = new PointLatLng(lat, lng);
            gmpVisor.Zoom = 18;

        }
    }
}
