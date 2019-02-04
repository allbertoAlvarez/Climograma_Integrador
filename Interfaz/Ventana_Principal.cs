using System;
using System.Windows.Forms;
using Modelo;
using GMap.NET;
using System.Collections;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;

namespace Interfaz
{
    public partial class Ventana_Principal : Form
    {

        private Estudio estudio = new Estudio();
        public Estudio Estudio { get => estudio; set => estudio = value; }

        public Ventana_Principal()
        {
            InitializeComponent();
            informacionTabla.VP = this;
        }

        private void Ventana_Principal_Load(object sender, EventArgs e)
        {
            Mapa_rios.MapProvider = GMap.NET.MapProviders.GoogleMapProvider.Instance;
            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerOnly;
            Mapa_rios.Position = new PointLatLng(3.42158,-76.5205);
            Mapa_rios.DragButton = MouseButtons.Left;

        }


        public void marcadores(double lat, double lon) {

            GMapOverlay markersOverlay = new GMapOverlay("markers");
            GMarkerGoogle marker = new GMarkerGoogle(new PointLatLng (lat, lon),
            GMarkerGoogleType.red);
            Mapa_rios.Overlays.Clear();
            markersOverlay.Markers.Add(marker);
            Mapa_rios.Overlays.Add(markersOverlay);

        }

		private void informacionTabla_Load(object sender, EventArgs e)
		{

		}
	}
}
